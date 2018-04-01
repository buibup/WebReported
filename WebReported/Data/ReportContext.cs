using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebReported.Data
{
    public class ReportContext:DbContext
    {
        public ReportContext():base("DefaultConnection")
        {

        }

        public DbSet<Report> Reports { get; set; }
    }
}