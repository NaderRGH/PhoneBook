using System.Collections.Generic;
using System.Data;
using System.Linq;
using WinFrmEF_DBFirst.DataAccessLayer;

namespace WinFrmEF_DBFirst.BusinessLayer
{
    class PersonBusiness
    {
        public List<PersonTbl> GetAllPersons()
        {
            var persons = new List<PersonTbl>();
            using (var context = new PhoneBookEntities())
            {
                persons = context.PersonTbls.Where(p => true).ToList<PersonTbl>().ToList();
            }

            return persons;
        }
    }
}
