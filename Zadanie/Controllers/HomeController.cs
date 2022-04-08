using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zadanie.Models;
using System.Data.Entity;

namespace Zadanie.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            var viewModel = new SurveyViewModel();
            viewModel.Universities = _context.Universities.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            viewModel.Faculties = _context.Faculties.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            viewModel.Gender = _context.Gender.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            

            return View(viewModel);
        }
        public ActionResult GetFaculties(int id)
        {
            //var fieldList = _context.FOSs.ToList();

            if (id == 0) return Json("");
            var facultiesList = _context.Faculties.Where(x => x.UniversityId == id).Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
            return Json(facultiesList, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Submit(Survey survey)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new SurveyViewModel();
                viewModel.Universities = _context.Universities.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
                viewModel.Faculties = _context.Faculties.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();
                viewModel.Gender = _context.Gender.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Name }).ToList();

                return View("New", viewModel);
            }
            
            _context.Survey.Add(survey);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public ActionResult Results()
        {
            var surveys = _context.Survey
                .Include(s=>s.Gender)
                .Include(s=>s.GraduatedUni)
                .Include(s=>s.Faculty).ToList();

            return View(surveys);
        }

    }
}