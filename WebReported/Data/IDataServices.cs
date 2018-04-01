using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebReported.Models;

namespace WebReported.Data
{
    public interface IDataServices
    {
        DataTable GetVsAdmissionDT(int epiRowId);
    }
}
