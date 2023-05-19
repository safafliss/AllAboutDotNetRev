using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class DonatorController : Controller
    {
        IServiceDonator sd;
        IServiceKafala sk;
        public DonatorController(IServiceDonator sd, IServiceKafala sk)
        {
            this.sd = sd;
            this.sk = sk;
        }

        // GET: DonatorController
        public ActionResult Index()
        {
            return View(sd.GetAll());
        }

        // GET: DonatorController/Details/5
        public ActionResult Details(int id)
        {
            return View(sd.GetById(id));
        }
        // GET: KafalaController
        public ActionResult KafflaByDonator(int id)
        {

            return View(sk.GetMany(k => k.Donator.Id == id));
        }
        // GET: DonatorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonatorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DonatorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(sd.GetById(id));
        }

        // POST: DonatorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Donator collection)
        {
            try
            {
                sd.Update(collection);
                sd.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DonatorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(sd.GetById(id));
        }

        // POST: DonatorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Donator collection)
        {
            try
            {
                sd.Delete(sd.GetById(id));
                sd.Commit();    
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
