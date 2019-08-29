using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFrmEF_DBFirst.DataAccessLayer;

namespace WinFrmEF_DBFirst.BusinessLayer
{
    class CategoryBusiness
    {
        public List<CategoryTbl> GetAllCategory()
        {
            var categories = new List<CategoryTbl>();
            using (var context = new PhoneBookEntities())
            {
                categories = context.CategoryTbls.Where(p => true).ToList<CategoryTbl>().ToList();
            }

            return categories;
        }
    }
}
