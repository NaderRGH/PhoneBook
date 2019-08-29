using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFrmEF_DBFirst.BusinessLayer
{
    class Common
    {
        public static DataTable ListToDataTable<T>(IList<T> data)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            int counterNotNullValue = 0;
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                if (!prop.Name.EndsWith("Tbls"))
                {
                    table.Columns.Add(prop.Name, prop.PropertyType);
                    counterNotNullValue++;
                }
            }
            object[] values = new object[counterNotNullValue];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    try
                    {
                        values[i] = props[i].GetValue(item);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Casting Error Occured: "+ e.Message);
                    }

                }
                table.Rows.Add(values);
            }
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds.ToString();
            //MessageBox.Show("Elapsed Time per Milliseconds = " + elapsedMs);
            return table;
        }
    }
}
