using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebReported.Models;

namespace WebReported.Data
{
    public class DataServices : IDataServices
    {
        IDataProvider dataProvider;
        public DataServices()
        {
            dataProvider = new DataProvider();
        }
        public DataTable GetVsAdmissionDT(int epiRowId)
        {
            var vsAdmission = dataProvider.GetAdmission(epiRowId);

            return vsAdmission.CreateDataTable();
        }
    }
}