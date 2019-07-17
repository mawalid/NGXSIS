using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class ForgotPasswordFormRepo
    {
        public static AddrBook GetByID(int ID)
        {
            AddrBook forgotpasswordform = new AddrBook();
            using (DataContext db = new DataContext())
            {
                forgotpasswordform = db.AddrBook.Where(d => d.id == ID).First();
                return forgotpasswordform;
            }
        }

        public static bool Editforgotpasswordform(AddrBook forgotpasswordform)
        {
            try
            {
                AddrBook dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.AddrBook.Where(d => d.id == forgotpasswordform.id).First();
                    dep.id = forgotpasswordform.id;
                    if (dep.fp_counter == null)
                    {
                        dep.fp_counter = 0;
                    }
                    dep.fp_counter += 1;
                    dep.modified_by = forgotpasswordform.modified_by;
                    dep.modified_on = DateTime.Now;
                    dep.abpwd = forgotpasswordform.abpwd;//password

                    //string password = forgotpasswordform.abpwd;//misal encrypt edit password md5 di backend

                    //byte[] encData_byte = new byte[password.Length];
                    //encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                    //string encodedData = Convert.ToBase64String(encData_byte);

                    //dep.abpwd = encodedData;

                    //db.X_forgotpasswordform.Add(dep);//misal create password
                    //db.SaveChanges();

                    db.Entry(dep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
    }
}
