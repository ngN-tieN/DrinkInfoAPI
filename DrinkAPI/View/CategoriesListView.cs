using DrinkAPI.Model;
using DrinkAPI.Models;
using DrinkAPI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAPI.View
{
    internal class CategoriesListView
    {
        public void DisplayCategories(List<CategoryDTO> categories)
        {
            TableExt.PrintCategoriesTable(categories);
        }
    }
}
