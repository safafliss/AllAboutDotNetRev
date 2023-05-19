using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Web.Controllers
{
    public class PrestataireController : Controller
    {
        IServicePrestataire sprestataire;
        IServicePrestation sprestation;
        public PrestataireController(IServicePrestataire sprestataire, IServicePrestation sprestation)
        {
            this.sprestataire = sprestataire;
            this.sprestation = sprestation;
        }


        // GET: PrestataireController
        public ActionResult Index()
        {
            return View(sprestataire.GetAll().OrderBy(p=> p.PrestataireNom));
        }

        // GET: PrestataireController
        public ActionResult GetPrestationsAction(int id)
        {

            return View(sprestation.GetMany(p => p.Prestataire.PrestataireId == id));
        }

        // GET: PrestataireController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PrestataireController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PrestataireController/Create
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

        // GET: PrestataireController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PrestataireController/Edit/5
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

        // GET: PrestataireController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PrestataireController/Delete/5
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
