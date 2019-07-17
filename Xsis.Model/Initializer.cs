using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xsis.Model
{
    class Initializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<MenuTree> menutree = new List<MenuTree>();
            menutree.Add(new MenuTree { title = "Pelamar", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/Pelamar", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Proses Pelamar", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Penjadwalan", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Rencana", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 2, menu_parent = 3, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Undangan", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 2, menu_parent = 3, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Tes", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Bootcamp", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            menutree.Add(new MenuTree { title = "Laporan", menu_image_url = null, menu_icon = null, menu_order = 1, menu_level = 1, menu_parent = null, menu_url = "/#", menu_type = "SIDEBAR", created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false });
            base.Seed(context);
            foreach(var item in menutree)
            {
                context.MenuTree.Add(item);
            }

            List<Biodata> biodata = new List<Biodata>();
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "irfan maulana", nick_name = "irfan", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "irfanmaulanaa8888@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "harsan febrian", nick_name = "harsa", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "harsan123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "latifa sudar", nick_name = "tifa", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "latifa123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "mawalid", nick_name = "walid", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "mawalid93@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            biodata.Add(new Biodata { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, fullname = "putri hartono", nick_name = "putri", pob = "Jakarta", dob = DateTime.Now, gender = true, religion_id = 1, high = 170, weight = 68, nationality = "indonesia", ethnic = "Betawi", hobby = "esport", identity_type_id = 1, identity_no = "123", email = "putri123@gmail.com", phone_number1 = "0857", phone_number2 = null, parent_phone_number = "0857", child_sequence = null, how_many_brothers = null, marital_status_id = 1, addrbook_id = null, token = null, expired_token = null, mariage_year = null, company_id = 1 });
            base.Seed(context);
            foreach(var item in biodata)
            {
                context.Biodata.Add(item);
            }

            List<AddrBook> addrbook = new List<AddrBook>();
            addrbook.Add(new AddrBook { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, is_locked = false, attempt = 0, email = "mawalid93@gmail.com", abuid = "mawalid", abpwd = "2dcd7074fadb80595c6e71fc77de6066", fp_token = "asdf", fp_expired_date = DateTime.Now, fp_counter = 0 });
            addrbook.Add(new AddrBook { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, is_locked = false, attempt = 0, email = "irfanmaulanaa8888@gmail.com", abuid = "irfan", abpwd = "2dcd7074fadb80595c6e71fc77de6066", fp_token = "asdf", fp_expired_date = DateTime.Now, fp_counter = 0 });
            addrbook.Add(new AddrBook { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, is_locked = false, attempt = 0, email = "harsan123@gmail.com", abuid = "harsan", abpwd = "2dcd7074fadb80595c6e71fc77de6066", fp_token = "asdf", fp_expired_date = DateTime.Now, fp_counter = 0 });
            addrbook.Add(new AddrBook { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, is_locked = false, attempt = 0, email = "latifa123@gmail.com", abuid = "latifa", abpwd = "2dcd7074fadb80595c6e71fc77de6066", fp_token = "asdf", fp_expired_date = DateTime.Now, fp_counter = 0 });
            addrbook.Add(new AddrBook { created_by = 99, created_on = DateTime.Now, modified_by = null, modified_on = null, deleted_by = null, deleted_on = null, is_delete = false, is_locked = false, attempt = 0, email = "putri123@gmail.com", abuid = "putri", abpwd = "2dcd7074fadb80595c6e71fc77de6066", fp_token = "asdf", fp_expired_date = DateTime.Now, fp_counter = 0 });
            base.Seed(context);
            foreach(var item in addrbook)
            {
                context.AddrBook.Add(item);
            }
        }
    }
}
