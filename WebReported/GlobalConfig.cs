using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebReported
{
    public static class GlobalConfig
    {
        public static Dictionary<string, string> KeyValues { get; set; }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppString(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}