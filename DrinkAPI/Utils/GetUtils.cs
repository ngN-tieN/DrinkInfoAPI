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
            bool isContainsCategory = categories.Any(c => c.Name.Equals(categoryName));
            if (!isContainsValidCharacter(categoryName))
            {
                Console.WriteLine("Invalid character!");
                categoryName = "";
            }
            if (!isContainsCategory)
            {
                Console.WriteLine("Category not found");
                categoryName = "";
            }
            return categoryName;
        }
        public bool isContainsValidCharacter(string str)
        {
            foreach(var c in str)
            {
                if (!c.Equals(" ") && !c.Equals("/") && !char.IsLetter(c)) return false;
            }
            return true;
        }
    }
}
