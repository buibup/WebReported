using Dapper;
using InterSystems.Data.CacheClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebReported.Models;

namespace WebReported.Data
{
    public class DataProvider : IDataProvider
    {
        private CacheConnection cache;
        public DataProvider()
        {
            cache = new CacheConnection(GlobalConfig.CnnString("Cache"));
        }
        public IEnumerable<VsAdmission> GetAdmission(int epiRowId)
        {
            using(var db = cache)
            {
                var data = db.Query<VsAdmission>(DbCacheQuery.GetVsAdmission(), new { PAADM_RowID = epiRowId });
                return data;
            }
        }
    }
}