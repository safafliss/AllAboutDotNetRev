using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class PretLivreController : Controller
    {
        IServicePretLivre sp;
        IServiceAbonne sa;
        IServiceLivre sl;
        public PretLivreController(IServicePretLivre sp, IServiceAbonne sa, IServiceLivre sl)
        {
            this.sp = sp;
            this.sa = sa;
            this.sl = sl;
        }

        // GET: PretLivreController
        public ActionResult Index(DateTime? dateDebut, DateTime? dateFin)
        {
            if (dateDebut == null || dateFin == null)
                return View(sp.GetAll());
            else
                return View(sp.GetMany(p => p.DateDebut.Date.Equals(dateDebut) && p.DateFin.Date.Equals(dateFin)));
            
        }

        // GET: PretLivreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PretLivreController/Create
        public ActionResult Create()
        {
            ViewBag.AbonneFk = new SelectList(sa.GetAll(), "Id", "Nom");
            ViewBag.LivreFk = new SelectList(sl.GetAll(), "LivreId", "Titre");
            return View();
        }

        // POST: PretLivreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PretLivre collection)
        {
            try
            {
                sp.Add(collection);
                sp.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PretLivreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PretLivreController/Edit/5
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

        // GET: PretLivreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PretLivreController/Delete/5
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
