
using System.ComponentModel.Design;
using System.Data;
using System.Reflection;

namespace POSLayer.Library;

public static class Extensions
{
      
    public static DataTable ToDataTable<T>(this List<T> items)
    {
        DataTable dataTable = new DataTable(typeof(T).Name);
        PropertyInfo[] props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

        // Define columns based on properties
        foreach (PropertyInfo prop in props)
        {
            Type propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
            dataTable.Columns.Add(prop.Name, propType);
        }

        // Add rows
        foreach (T item in items)
        {
            var values = new object[props.Length];
            for (int i = 0; i < props.Length; i++)
            {
                values[i] = props[i].GetValue(item, null) ?? DBNull.Value;
            }
            dataTable.Rows.Add(values);
        }
        return dataTable;
    }

    // Returns a List of the actual enum constants
    public static List<T> ToList<T>(bool NameOrderly = false) where T : Enum
    {
        if (NameOrderly)
            return Enum.GetValues(typeof(T)).Cast<T>().OrderBy(x => x.ToString()).ToList();
        else
            return Enum.GetValues(typeof(T)).Cast<T>().ToList();
    }

}
