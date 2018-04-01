using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using WebReported.Data;
using WebReported.Models;

namespace WebReported
{
    public static class Helpers
    {
        public static void SetRequestQueryString(this NameValueCollection n)
        {
            foreach (var k in n.AllKeys)
            {
                var key = k.ToLower();
                if (key == nameof(RequestQueryStringEnum.EpiRowId).ToLower())
                {
                    int i = 0;
                    int.TryParse(n[key], out i);
                    RequestQueryString.PAADM_RowID = i;
                }
                if (key == nameof(RequestQueryStringEnum.ReportName).ToLower())
                {

                    RequestQueryString.ReportName = n[key];
                }
                if (key == nameof(RequestQueryStringEnum.IsQRCode).ToLower())
                {
                    bool flag = false;
                    RequestQueryString.IsQR = bool.TryParse(n[key], out flag);
                }
            }
        }

        public static DataTable CreateDataTable<T>(this IEnumerable<T> list)
        {
            Type type = typeof(T);
            var properties = type.GetProperties();

            DataTable dataTable = new DataTable();
            foreach (PropertyInfo info in properties)
            {
                dataTable.Columns.Add(new DataColumn(info.Name, Nullable.GetUnderlyingType(info.PropertyType) ?? info.PropertyType));
            }

            foreach (T entity in list)
            {
                object[] values = new object[properties.Length];
                for (int i = 0; i < properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(entity);
                }

                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}