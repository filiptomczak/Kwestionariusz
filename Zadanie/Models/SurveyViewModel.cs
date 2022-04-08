using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zadanie.Models
{
    public class SurveyViewModel
    {
        public Survey Survey { get; set; }

        public int SelectedUni { get; set; }
        public int SelectedFaculty { get; set; }
        public List<SelectListItem> Gender { get; set; }
        public List<SelectListItem> Universities { get; set; }
        public List<SelectListItem> Faculties { get; set; }
        public SurveyViewModel()
        {
            this.Gender = new List<SelectListItem>();
            this.Universities = new List<SelectListItem>();
            this.Faculties = new List<SelectListItem>();
        }
    }
}