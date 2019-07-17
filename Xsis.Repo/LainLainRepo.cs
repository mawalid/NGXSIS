using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class LainLainRepo
    {
        public static List<Pe_Referensi> GetAll(int idBiodata)
        {
            List<Pe_Referensi> result = new List<Pe_Referensi>();
            using (var db = new DataContext())
            {
                //result = db.Organisasi.ToList();
                result = (from t in db.Pe_Referensi
                          where t.is_delete == false && t.biodata_id == idBiodata
                          select t).OrderByDescending(x => x.id).ToList();
                return result;
            }
        }
    }
}
