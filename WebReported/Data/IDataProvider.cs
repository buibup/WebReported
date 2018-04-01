using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebReported.Models;

namespace WebReported.Data
{
    public interface IDataProvider
    {
        IEnumerable<VsAdmission> GetAdmission(int epiRowId);
    }
}
