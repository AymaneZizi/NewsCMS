﻿using System;
using System.Collections.Generic;
using System.Linq;
using CrawlerEngine;
using Rss;
using System.Xml;
using System.ServiceModel.Syndication;
using Mn.NewsCms.Common.Models;
using Mn.NewsCms.Common;
using Mn.NewsCms.Common.EventsLog;
using Mn.NewsCms.Common.Config;
using Mn.NewsCms.DomainClasses.Config;
using Mn.NewsCms.Robot.Repository;
using Mn.NewsCms.Robot.Helper;
using Mn.NewsCms.Robot.Parser;


namespace Mn.NewsCms.Robot.Updater
{
    public class FeedUpdater
    {
        private readonly IAppConfigBiz _appConfigBiz;
        private readonly IUpdaterDurationBusiness DurationBiz;
        private readonly IFeedBusiness FeedBiz;
        private readonly IFeedItemBusiness ItemBiz;

        #region Properties
        public bool StopUpdater { get; set; }
        private bool? IsPause;
        private int StartOfEndDate
        {
            get
            {
                return Config.GetConfig<int>("StartNightly");
            }
        }
        private int EndOfEndDate
        {
            get
            {
                return Config.GetConfig<int>("EndNightly");
            }
        }
        static Dictionary<UpdateDuration, int> DurationDic = new Dictionary<UpdateDuration, int>();
        private static IAppConfigBiz _config;
        public IAppConfigBiz Config
        {
            get
            {
                if (_config == null)
                    _config = _appConfigBiz;
                return _config;
            }
        }
        #endregion

        public FeedUpdater(IAppConfigBiz appConfigBiz, IFeedBusiness feedBusiness, IFeedItemBusiness feedItemBusiness, IUpdaterDurationBusiness updaterDurationBusiness)
        {
            _appConfigBiz = appConfigBiz;
            DurationBiz = updaterDurationBusiness;
            FeedBiz = feedBusiness;
            ItemBiz = feedItemBusiness;
        }

        public void AutoUpdater()
        {
            StopUpdater = false;
            if (Config.GetConfig<int>("DisableUpdater") == 1)
            {
                GeneralLogs.WriteLog("Updater is Disable", TypeOfLog.Info);
                return;
            }
            //------Starting after 10 min
            //System.Threading.Thread.Sleep(1000 * 60 * 10);           

            while (!StopUpdater)
            {
                DateTime startTime = Config.GetServerNow();
                if (startTime.Hour >= StartOfEndDate && startTime.Hour < EndOfEndDate)
                {
                    StopUpdater = true;
                    return;
                }

                UpdateIsParting();

                var delay = Config.GetServerNow().Subtract(startTime);
                if (((delay.Minutes == 0 && delay.Seconds > 0) || delay.Minutes > 0) && delay.Minutes < Config.GetTimeInterval())
                {
                    GeneralLogs.WriteLog("I'm Sleeping for " + (Config.GetTimeInterval() - delay.Minutes) + " minutes", TypeOfLog.End, typeof(FeedUpdater));
                    IsPause = true;
                    System.Threading.Thread.Sleep(1000 * 60 * (Config.GetTimeInterval() - delay.Minutes));//1 sec >> 1 min >> 10 min  
                    IsPause = false;
                }
            }
        }
        public void UpdateIsParting()
        {
            GeneralLogs.WriteLogInDB("Start updater...", TypeOfLog.Start, typeof(FeedUpdater));

            var periods = DurationBiz.GetList().Where(x => x.EnabledForUpdate && x.IsParting.Value == true).ToList();

            foreach (var duration in periods)
            {
                if (StopUpdater)
                    return;

                UpdateFeedsPerDuration(duration);

            }

            var _LuceneRepository = new LuceneSaverRepository();
            _LuceneRepository.Optimize();
            GeneralLogs.WriteLog("Lucene Optimize", TypeOfLog.Warning, typeof(FeedUpdater));

            GeneralLogs.WriteLogInDB("End Updater at " + Config.GetServerNow().ToString("hh:mm"), TypeOfLog.End, typeof(FeedUpdater));
        }
        public void UpdateFeedsPerDuration(UpdateDuration duration)
        {
            var delaytime = TimeSpan.Parse(duration.DelayTime);
            var Partnumber = delaytime.Hours * 60 / Config.GetTimeInterval();//20 min intervall
            var TopCount = (duration.FeedsCount / Partnumber) != 0 ? (duration.FeedsCount / Partnumber) : (duration.FeedsCount % Partnumber);

            var feeds = FeedBiz.GetList().Where(x => x.UpdateDurationId.Value == duration.Id
                        && ((int)x.Deleted < 1 || (int)x.Deleted > 10)).OrderBy(feed => feed.Id).Skip(duration.StartIndex).Take(TopCount).ToList();

            if (TopCount == 0)
                return;

            GeneralLogs.WriteLog("Start updating duration " + duration.Code + " Start at:" + duration.StartIndex, TypeOfLog.Start, typeof(FeedUpdater));

            foreach (var feed in feeds)
            {
                GeneralLogs.WriteLog("Feed updating. Id:" + feed.Id, TypeOfLog.Start, typeof(FeedUpdater));
                UpdatingFeed(feed);
            }

            duration.FeedsCount = FeedBiz.GetList().Where(x => x.UpdateDurationId.Value == duration.Id && ((int)x.Deleted < 1 || (int)x.Deleted > 10)).Count();
            duration.StartIndex = (duration.StartIndex + TopCount) >= duration.FeedsCount ? 0 : (duration.StartIndex + TopCount);
            var res = DurationBiz.Edit(duration);
            if (res.Status)
                GeneralLogs.WriteLog("Duration updated. Id:" + duration.Id + " Start Index: " + duration.StartIndex, TypeOfLog.OK, typeof(FeedUpdater));

        }
        public int UpdatingFeed(Feed dbfeed, bool saveItems = true)
        {
            int NumberOfNewItem = 0;
            var items = new List<FeedItem>();
            var log = new FeedLog() { FeedId = dbfeed.Id };
            try
            {
                if (dbfeed.FeedType == 0 || !dbfeed.FeedType.HasValue)
                {
                    #region Feed
                    RssFeed feed = RssFeed.Read(dbfeed.Link);
                    //-----------shart check kardane inke feed aslan update shode dar site marja ya kheir------------
                    if (feed == null)
                    {
                        dbfeed.Deleted = Common.Share.DeleteStatus.NotWork;
                    }
                    else if (feed.Channels.Count > 0)
                    {
                        //--------Feed has new items-----------
                        if (feed.Channels.Count > 0)
                        {
                            RssChannel channel = (RssChannel)feed.Channels[0];

                            if (channel.Items.LatestPubDate() != channel.Items[0].PubDate)
                            {
                                items = new FeedItemsOperation(_appConfigBiz).RssItemsToFeedItems(channel.ItemsSorted, dbfeed);
                            }
                            else
                                items = new FeedItemsOperation(_appConfigBiz).RssItemsToFeedItems(channel.Items, dbfeed);


                            //----------Visual Items---------                             
                            //NumberOfNewItem = listReturnBack.Count;
                            //if (NumberOfNewItem > 0)
                            //{
                            //    if (dbfeed.InIndex == 1)
                            //    {
                            //        if (dbfeed.Site.HasSocialTag.HasValue && dbfeed.Site.HasSocialTag.Value)
                            //            Updater.FeedItemImage.setFeedItemsImage(dbfeed, listReturnBack, 5);
                            //        //else
                            //        //    FeedItemsOperation.insertFeedItemsIndex(dbfeed, listReturnBack, 5);
                            //    }
                            //    entiti.SaveChanges();
                            //}
                        }

                    }
                    #endregion
                }
                else if (dbfeed.FeedType.HasValue && dbfeed.FeedType.Value == Common.Share.FeedType.Atom)
                {
                    #region Atom
                    XmlReader reader = XmlReader.Create(dbfeed.Link);
                    SyndicationFeed atomfeed = SyndicationFeed.Load(reader);
                    int i = 0;
                    if (atomfeed == null)
                    {
                        dbfeed.Deleted = Common.Share.DeleteStatus.NotWork;
                    }
                    else if (atomfeed.Items.Any())
                    {
                        foreach (SyndicationItem item in atomfeed.Items)
                        {
                            i++;
                            break;
                        }
                        if (i > 0)
                        {
                            items = new FeedItemsOperation(_appConfigBiz).AtomItemsToFeedItems(atomfeed.Items, dbfeed);
                        }

                    }
                    #endregion
                }

                if (items.Any())
                {
                    if (dbfeed.Site.HasImage != HasImage.NotSupport)
                        new FeedItemImage(_appConfigBiz).SetItemsImage(items, dbfeed);
                    if (saveItems)
                    {
                        NumberOfNewItem = ItemBiz.AddItems(items);
                        if (NumberOfNewItem > 0)
                            dbfeed.LastUpdatedItemUrl = items.Last().Link.SubstringM(0, 400);
                    }

                    GeneralLogs.WriteLog("Updating feed " + dbfeed.Id + "  Items:" + NumberOfNewItem + "  New:" + NumberOfNewItem + " " + dbfeed.Link.Replace("http://", ""), TypeOfLog.OK, typeof(FeedUpdater));
                }

            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("404") > 0)
                    dbfeed.Deleted = Common.Share.DeleteStatus.NotFound;
                else if (ex.Message.IndexOf("403") > 0)
                    dbfeed.Deleted = Common.Share.DeleteStatus.Forbidden;
                else if (ex.Message.IndexOfX("timed out") > 0)
                    dbfeed.Deleted = Common.Share.DeleteStatus.RequestTimeOut;
                else
                    dbfeed.Deleted = Common.Share.DeleteStatus.Temporary;

                log.HasError = true;
                log.Message = "Error:" + (ex.InnerException != null ? ex.InnerException.Message.SubstringM(0, 512) : ex.Message.SubstringM(0, 512));
                FeedBiz.CreateFeedLog(log);
                var msg = "FeedId " + dbfeed.Id + " " + dbfeed.Link.SubstringM(0, 40) + " Error:" + (ex.InnerException != null ? ex.InnerException.Message.SubstringM(0, 512) : ex.Message.SubstringM(0, 512));
                GeneralLogs.WriteLog(msg, TypeOfLog.Error, typeof(FeedUpdater));

                FeedBiz.Edit(dbfeed);
                return NumberOfNewItem;
            }

            dbfeed.LastUpdaterVisit = DateTime.Now;

            if (saveItems)
            {
                FeedBiz.CheckForChangeDuration(dbfeed, NumberOfNewItem > 0 ? true : false);
                if (NumberOfNewItem > 0)
                    dbfeed.LastUpdateDateTime = DateTime.Now;
            }

            var res = FeedBiz.Edit(dbfeed);
            if (saveItems && res.Status)
            {
                log.HasError = false;
                log.Message = "Successfull Updat Feed " + dbfeed.Title.SubstringM(0, 16) + " " + dbfeed.Link.Replace("http://", "").SubstringM(0, 24);
                log.ItemsCount = NumberOfNewItem;
                FeedBiz.CreateFeedLog(log);
            }

            return saveItems ? NumberOfNewItem : items.Count;
        }
    }
}
