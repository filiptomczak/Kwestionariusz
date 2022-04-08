using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class GenderValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var survey = (Survey)validationContext.ObjectInstance;
            if (survey.Pesel != null && survey.GenderId != 0)
            {
                var pesel = survey.Pesel.ToList();
                int x = int.Parse(pesel[9].ToString());
                var gender = survey.GenderId;

                if (x % 2 == 0 && gender == 1 || x % 2 != 0 && gender == 2)
                    return ValidationResult.Success;
                return new ValidationResult("Plec niezgodna z numerem pesel");
            }
            else
            {
                return new ValidationResult("Plec niezgodna z numerem pesel");
            }
        }
    }
}