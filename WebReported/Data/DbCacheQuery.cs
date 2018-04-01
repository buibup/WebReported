using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReported.Data
{
    public static class DbCacheQuery
    {
        public static string GetVsAdmission()
        {
            const string query = @"
                SELECT PAPMI_RowId, PAPMI_No,
                    PAADM_RowID, PAADM_ADMNo,
                    PAADM_AdmDate, PAADM_AdmTime,
                    PAPMI_Name, PAPMI_Name2, PAPMI_Name3,
                    PAPMI_DOB, PAPER_AgeYr,
                    PAPER_AgeMth, PAPER_AgeDay
                FROM vs_admission
                WHERE PAADM_RowID = ?
            ";

            return query;
        }
    }
}