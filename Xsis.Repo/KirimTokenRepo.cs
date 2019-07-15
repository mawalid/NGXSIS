using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Xsis.Model;

namespace Xsis.Repo
{
    public class KirimTokenRepo
    {
        public static List<Biodata> GetAll(int ID)
        {
            List<Biodata> result = new List<Biodata>();
            using (var db = new DataContext())
            {
                //result = db.Biodata.ToList();
                result = (from t in db.Biodata
                          where t.is_delete == false && t.id == ID
                          select t).ToList();
                return result;
            }
        }

        public static Biodata GetByID(int ID)
        {
            Biodata biodata = new Biodata();
            using (DataContext db = new DataContext())
            {
                biodata = db.Biodata.Where(d => d.id == ID).First();
                return biodata;
            }
        }

        public static bool Editkirimtoken(Biodata biodatamdl)
        {
            var shortURL = RandomURL();
            try
            {

                Biodata dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Biodata.Where(d => d.id == biodatamdl.id).First();
                    dep.modified_by = biodatamdl.modified_by;
                    dep.modified_on = DateTime.Now;
                    dep.token = shortURL;
                    dep.expired_token = biodatamdl.expired_token;
                    db.Entry(dep).State = EntityState.Modified;//dep diperlakukan sebagai Entry di dalam database kirim token (System.Data.Entity.EntityState.Modified)
                    db.SaveChanges();
                }

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("luforysa.dilawam@gmail.com");
                mail.To.Add(biodatamdl.email);
                mail.Subject = "XSIS Token";
                mail.IsBodyHtml = true;
                string htmlStr = "This is the new Token: " + shortURL + " valid until: " + biodatamdl.expired_token;
                mail.Body = htmlStr;
                SmtpServer.Port = 587;

                SmtpServer.Credentials = new System.Net.NetworkCredential("luforysa.dilawam@gmail.com", "Fastabiqul3khoirot");
                SmtpServer.EnableSsl = true;
                //SmtpServer.Timeout = 12000;

                SmtpServer.Send(mail);

                //UpdateDB(email, shortURL);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static string RandomURL()
        {
            // List of characters and numbers to be used...  
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<char> characters = new List<char>()
                    {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n',
                        'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B',
                            'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P',
                                'Q', 'R', 'S',  'T', 'U', 'V', 'W', 'X', 'Y', 'Z', '-', '_'};

            string URL = "";
            Random rand = new Random();
            // run the loop till I get a string of 10 characters  
            for (int i = 0; i < 10; i++)
            {
                // Get random numbers, to get either a character or a number...  
                int random = rand.Next(0, 3);
                if (random == 1)
                {
                    // use a number  
                    random = rand.Next(0, numbers.Count);
                    URL += numbers[random].ToString();
                }
                else
                {
                    random = rand.Next(0, characters.Count);
                    URL += characters[random].ToString();
                }
            }
            return URL;
        }

        //public static string SendMail(string email, string expiredToken)
        //{
        //    var shortURL = RandomURL();
        //    try
        //    {
        //        MailMessage mail = new MailMessage();
        //        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

        //        mail.From = new MailAddress("luforysa.dilawam@gmail.com");
        //        mail.To.Add(email);
        //        mail.Subject = "XSIS Token";
        //        mail.IsBodyHtml = true;
        //        string htmlStr = "This is the new Token: " + shortURL + " valid until: " + expiredToken;
        //        mail.Body = htmlStr;
        //        SmtpServer.Port = 587;

        //        SmtpServer.Credentials = new System.Net.NetworkCredential("luforysa.dilawam@gmail.com", "Fastabiqul3khoirot");
        //        SmtpServer.EnableSsl = true;
        //        //SmtpServer.Timeout = 12000;

        //        SmtpServer.Send(mail);

        //        UpdateDB(email, shortURL);

        //        return shortURL;
        //    }
        //    catch (Exception)
        //    {
        //        //Console.WriteLine(e);
        //        var error="";
        //        return error;
        //    }
        //}

        //public static string UpdateDB(string email, string shortURL)
        //{
        //    var result = "";
        //    Biodata kt = new Biodata();
        //    using (DataContext db = new DataContext())
        //    {
        //        kt = db.Biodata.Where(d => d.email == email).First();
        //        kt.token = shortURL;
        //        db.Entry(kt).State = EntityState.Modified;
        //        db.SaveChanges();



        //    }
        //    return result;


        //}
    }
}
