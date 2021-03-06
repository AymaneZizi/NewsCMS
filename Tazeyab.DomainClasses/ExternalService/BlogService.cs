﻿using System;
using System.Linq;
using System.Web;
using Mn.NewsCms.Common.BaseClass;
using Mn.NewsCms.Common.ExternalService;
using Mn.NewsCms.Common.Models;

namespace Mn.NewsCms.DomainClasses.ExternalService
{
    public class BlogService : BaseBusiness<RemoteRequestLog, long>, IBlogService
    {
        public BlogService(IUnitOfWork dbContext) : base(dbContext)
        {
        }

        public IQueryable<RemoteRequestLog> GetListRemoteRequest()
        {
            return base.GetList();
        }

        public OperationStatus Create(RemoteRequestLog log)
        {
            var res = base.Create(log);
            return res;
        }

        public OperationStatus InsertRemoteRequestLog(string Controller, string Content)
        {
            var reqref = HttpContext.Current.Request.UrlReferrer.ToString();
            var log = new RemoteRequestLog { RequestRefer = reqref, CreationDate = DateTime.Now, Controller = Controller, Content = Content };
            return this.Create(log);
        }        
    }
}
