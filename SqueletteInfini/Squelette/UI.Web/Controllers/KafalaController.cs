using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class KafalaController : Controller
    {
        IServiceKafala sk;
        IServiceBeneficiary sb;
        IServiceDonator sd;
        public KafalaController(IServiceKafala sk, IServiceBeneficiary sb, IServiceDonator sd)
        {
            this.sk = sk;
            this.sb = sb;
            this.sd = sd;
        }

        // GET: KafalaController
        public ActionResult Index()
        {
            return  View();
        }

        // GET: KafalaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KafalaController/Create
        public ActionResult Create()
        {
            ViewBag.BeneficiaryFk = new SelectList(sb.GetAll(), "CIN", "Name");
            ViewBag.DonatorFk = new SelectList(sd.GetAll(), "Id", "Name");
            return View();
        }

        // POST: KafalaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Kafala collection)
        {
            try
            {
                sk.Add(collection);
                sk.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KafalaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KafalaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: KafalaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KafalaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
