using DrinkAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAPI.Utils
{
    internal class GetUtils
    {
        public static string GetString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }
        public string GetCategoryName(List<CategoryDTO> categories)
        {
            string categoryName = GetString("Please enter category name");
            bool isContainCategory = categories.Any(c => c.Name.Equals(categoryName));
            if (!isContainCategory)
            {
                Console.WriteLine("Category not found");
                categoryName = "";
            }
            return categoryName;
        }
    }
}
