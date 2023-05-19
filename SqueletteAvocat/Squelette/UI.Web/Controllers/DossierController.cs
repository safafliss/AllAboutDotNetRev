using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class DossierController : Controller
    {
        IServiceDossier sd;
        IServiceAvocat sa;
        IServiceClient sc;
        public DossierController(IServiceDossier sd, IServiceAvocat sa, IServiceClient sc)
        {
            this.sd = sd;
            this.sa = sa;
            this.sc = sc;
        }

        // GET: DossierController
        public ActionResult Index(string? nomAvocat)
        {
            if (nomAvocat == null)
                return View(sd.GetAll());
            else
                return View(sd.GetMany(sd=>sd.Avocat.Nom == nomAvocat));
            
        }
        
        // GET: DossierController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DossierController/Create
        public ActionResult Create()
        {
            ViewBag.ClientFk = new SelectList(sc.GetAll(), "CIN", "Nom");
            ViewBag.AvocatFk = new SelectList(sa.GetAll(), "AvocatId", "AvocatId");
            return View();
        }

        // POST: DossierController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Dossier collection)
        {
            try
            {
                sd.Add(collection);
                sd.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DossierController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DossierController/Edit/5
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

        // GET: DossierController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DossierController/Delete/5
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
