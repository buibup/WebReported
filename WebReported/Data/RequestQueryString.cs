using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReported.Data
{
    public static class RequestQueryString
    {
        public static int PAADM_RowID { get; set; }
        public static string ReportName { get; set; }
        public static bool IsQR { get; set; }
    }
}