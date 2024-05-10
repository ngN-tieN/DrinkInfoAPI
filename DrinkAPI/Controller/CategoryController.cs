using DrinkAPI.Services;
using DrinkAPI.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAPI.Controller
{
    internal class CategoryController
    {
        private CategoriesListView view = null;
        private FetchCategoryAPI service = null;
        public CategoryController()
        {
            view = new CategoriesListView();
            service = new FetchCategoryAPI();
        }

    }
}
