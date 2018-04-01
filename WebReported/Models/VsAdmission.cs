using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReported.Models
{
    public class VsAdmission
    {
        public byte[] QRCode { get; set; }
        public int PAPMI_RowId { get; set; }
        public string PAPMI_No { get; set; }
        public int PAADM_RowID { get; set; }
        public string PAADM_ADMNo { get; set; }
        public DateTime PAADM_AdmDate { get; set; }
        public TimeSpan PAADM_AdmTime { get; set; }
        public string PAPMI_Name { get; set; }
        public string PAPMI_Name2 { get; set; }
        public string PAPMI_Name3 { get; set; }
        public string FullName {
            get
            {
                return string.IsNullOrEmpty(PAPMI_Name3)? $"{PAPMI_Name} {PAPMI_Name2}" :  $"{PAPMI_Name3}{PAPMI_Name} {PAPMI_Name2}";
            }
        }
        public DateTime PAPMI_DOB { get; set; }
        public int PAPER_AgeYr { get; set; }
        public int PAPER_AgeMth { get; set; }
        public int PAPER_AgeDay { get; set; }
    }
}