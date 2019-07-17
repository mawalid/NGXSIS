using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class HomeRepo 
    {
        public static List<MenuTree> GetAll(int ID)
        {
            List<MenuTree> result = new List<MenuTree>();
            using (var db = new DataContext())
            {
                result = (from t in db.MenuTree
                          where t.is_delete == false && t.menu_level == 1
                          select t).ToList();
                return result;
            }
        }
    }
}
