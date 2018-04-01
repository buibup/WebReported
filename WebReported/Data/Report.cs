using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReported.Data
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string RequestParameter { get; set; }
        public string ProcedureName { get; set; }
        public string ReportParameter { get; set; }
        public string Path { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateDte { get; set; }
        public DateTime UpdateDte { get; set; }
    }
}