using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Xsis.Model;
using Xsis.Repo;

namespace Xsis.Web.Controllers
{
    public class KirimTokenController : Controller
    {
        // GET: KirimToken
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil(int ID)
        {
            return Json(KirimTokenRepo.GetAll(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(KirimTokenRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit()
        {
            return PartialView("_Edit");
        }

        public ActionResult EditSimpan(Biodata biodatamdl)
        {
            biodatamdl.modified_by = Convert.ToInt32(Session["foo"]);
            if (KirimTokenRepo.Editkirimtoken(biodatamdl))
            {
                return Json(new { EditToken = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { EditToken = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        //public ActionResult TrySendMail(string email, string expiredToken)
        //{
        //    return Json(KirimTokenRepo.SendMail(email, expiredToken), JsonRequestBehavior.AllowGet);
        //}
    }
}