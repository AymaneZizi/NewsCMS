﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Tazeyab.Web.WebLogic
{
    public enum ThemeType
    {
        Dark = 1,
        Light = 2
    }

    public static class TazeyabConfig
    {
        public const string ThemeName = "Sekuzan";

        public static ThemeType ThemeType
        {
            get
            {
                return SelectedTheme == "DarkKnight" ? ThemeType.Dark : ThemeType.Light;
            }
        }

        public static string SelectedTheme
        {
            get
            {
                try
                {
                    return HttpContext.Current.Request.Cookies["SelectedTheme"].Value;
                }
                catch
                {
                    var cookie = new HttpCookie("SelectedTheme", "DarkKnight") { Expires = DateTime.Now.AddMonths(5) };
                    HttpContext.Current.Request.Cookies.Add(cookie);
                    return "DarkKnight";
                }
            }
        }

        public const int Cache1Min = 60;
        public const int Cache5Min = 300;//default cache time per second
        public const int Cache10Min = 600;
        public const int Cache30Min = 1800;
        public const int Cache1Hour = 3600;
        public const int Cache3Hour = 10800;
        public const int CacheHalfDay = 43200;

        public static int ItemsCacheTime
        {
            get
            {
                return 10;
            }
        }

        public static string SoundcloudApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["SoundcloudApiKey"].ToString();
            }
        }

        public static string TelegramGetMediaApiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["TelegramGetMediaApiKey"].ToString();
            }
        }
    }
}