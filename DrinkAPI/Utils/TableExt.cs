using DrinkAPI.Model;
using DrinkAPI.Models;
using Spectre.Console;
using System.Reflection;
namespace DrinkAPI.Utils
{
    internal class TableExt
    {
        public static void PrintTable(string[] columns, List<string[]> rows, string title)

        {
            var table = new Table();
            table.ShowRowSeparators();
            table.Caption(title);
            table.AddColumns(columns);
            foreach (var row in rows) { table.AddRow(row); }
            AnsiConsole.Write(table);


        }
        public static void PrintTableNoColumn(List<string[]> rows, string caption)

        {
            var table = new Table();
            table.ShowRowSeparators();
            table.Caption(caption);
            foreach (var row in rows) { table.AddRow(row); }

        }
        public static void PrintDrinksInfoTable(List<DrinkDTO> drinksInfo)
        {
            string[] columns = ["ID", "Drink"];
            
            PrintTable(columns, GetRows(drinksInfo), "Drink Info");
        }
        public static void PrintCategoriesTable(List<CategoryDTO> categories)
        {
            string[] columns = ["Category"];
            PrintTable(columns, GetRows(categories), "Category");

        }
        public static List<string[]> GetRows<T>(List<T> list)
            where T : class 
        {
            List<string[]> rows = new();
            foreach (var item in list)
            {
                rows.Add(GetRow(item));
            }
            return rows;
        }
        public static string[] GetRow<T>(T TModel)
            where T : class
        {
            GenericPropertyFinder<T> finder = new GenericPropertyFinder<T>();
            return finder.GetStringTModelPropertiesValue(TModel);

        }
    }
    public class GenericPropertyFinder<TModel> where TModel : class
    {
        public string[] GetStringTModelPropertiesValue(TModel tmodelObj)
        {
            //Getting Type of Generic Class Model
            Type tModelType = tmodelObj.GetType();

            //We will be defining a PropertyInfo Object which contains details about the class property 
            PropertyInfo[] arrayPropertyInfos = tModelType.GetProperties();
            string[] propsValue = [];
            //Now we will loop in all properties one by one to get value
            foreach (PropertyInfo property in arrayPropertyInfos)
            {
                propsValue.Append(property.GetValue(tmodelObj).ToString());
            }
            return propsValue;
        }
    }
}   
