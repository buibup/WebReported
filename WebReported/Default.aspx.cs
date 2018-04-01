using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebReported.Data;
using WebReported.Models;

namespace WebReported
{
    public partial class Default : System.Web.UI.Page
    {
        IDataServices dataServices;
        public Default()
        {
            dataServices = new DataServices();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            var n = Request.QueryString;

            if (n.HasKeys())
            {
                // set value request query string to class
                n.SetRequestQueryString();

                if (RequestQueryString.IsQR)
                {
                    var dt = dataServices.GetVsAdmissionDT(RequestQueryString.PAADM_RowID);

                    try
                    {
                        using (ReportDocument rd = new ReportDocument())
                        {
                            rd.Load(Server.MapPath(@"~/Reports/test.rpt"));
                            rd.FileName = Server.MapPath(@"~/Reports/test.rpt");
                            rd.SetDataSource(dt);

                            Response.Buffer = false;
                            Response.ClearContent();
                            Response.ClearHeaders();
                            rd.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "test");
                            HttpContext.Current.ApplicationInstance.CompleteRequest();
                        }
                    }
                    catch (ThreadAbortException ex)
                    {
                        Thread.ResetAbort();
                    }
                }
                else
                {
                    try
                    {
                        using(ReportDocument rd = new ReportDocument())
                        {
                            rd.Load(Server.MapPath(@"~/Reports/test.rpt"));
                            rd.FileName = Server.MapPath(@"~/Reports/test.rpt");
                            rd.SetParameterValue("EpiRowId", RequestQueryString.PAADM_RowID);

                            Response.Buffer = false;
                            Response.ClearContent();
                            Response.ClearHeaders();
                            rd.ExportToHttpResponse(ExportFormatType.PortableDocFormat, Response, false, "test");
                            HttpContext.Current.ApplicationInstance.CompleteRequest();
                        }
                    }
                    catch (ThreadAbortException)
                    {
                        Thread.ResetAbort();
                    }
                }
            }
        }
    }
}