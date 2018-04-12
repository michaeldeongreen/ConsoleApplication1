using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace ConsoleApplication1.SqlBulkCopy
{
    public static class ListExtensions
    {
        public static T AddNew<T>(this IList<T> list, T newItem)
        {
            list.Add(newItem);
            return newItem;
        }

        public static T AddNew<T>(this ICollection<T> list, T newItem)
        {
            list.Add(newItem);
            return newItem;
        }

        public static DataTable AsDataTable<T>(this IList<T> items)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            int t = table.Columns.Count;
            foreach (T item in items)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
