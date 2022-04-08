using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Zadanie.Models;
using System.Data.Entity;

namespace Zadanie.Models
{
    public class EmailValidation : ValidationAttribute
    {
        private ApplicationDbContext _context;
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            _context = new ApplicationDbContext();

            var survey = (Survey)validationContext.ObjectInstance;
            var email = survey.Email;
            var emailsInDb = _context.Survey.Any(e => e.Email == email);
            _context.Dispose();
            if (!emailsInDb)
                return ValidationResult.Success;
            else
                return new ValidationResult("Podany adres email juz istnieje");
        }
    }
}