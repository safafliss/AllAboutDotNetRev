using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace UI.Web.Controllers
{
    public class VaccinController : Controller
    {
        IServiceVaccin sv;
        IServiceCentreVaccination scen;
        public VaccinController(IServiceVaccin sv, IServiceCentreVaccination scen)
        {
            this.sv = sv;
            this.scen = scen;
        }


        // GET: VaccinController
        public ActionResult Index()
        {
            //return View(sv.GetAll().OrderByDescending(sv=>sv.DateValidite));
            var vaccins = sv.GetAll().OrderByDescending(sv => sv.DateValidite);
            foreach(var item in vaccins)
            {
                item.Validité = sv.CheckVaccin(item);
            }
            return View(vaccins);
        }

        // GET: VaccinController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: VaccinController/Create
        public ActionResult Create()
        {
            ViewBag.CentreVaccinationFk = new SelectList(scen.GetAll(), "CentreVaccinationId", "CentreVaccinationId");
            return View();
        }

        // POST: VaccinController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vaccin collection)
        {
            try
            {
                sv.Add(collection);
                sv.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: VaccinController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: VaccinController/Edit/5
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

        // GET: VaccinController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VaccinController/Delete/5
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
