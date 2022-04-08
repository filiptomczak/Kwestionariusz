using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class BirthdateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var survey = (Survey)validationContext.ObjectInstance;
            var pesel = survey.Pesel;
            var birthdate = survey.BirthDate;

            if (pesel != null && birthdate != null)
            {
                var year = birthdate.Year;
                var month = birthdate.Month;
                var day = birthdate.Day;


                var peselYear = int.Parse(pesel.Substring(0, 2));
                var peselMonth = int.Parse(pesel.Substring(2, 2));
                var peselDay = int.Parse(pesel.Substring(4, 2));

                if (peselYear <= 21) peselYear += 2000;
                else peselYear += 1900;

                if (peselYear == year && peselMonth == month && peselDay == day)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Pesel niezgodny z data");
            }
            else
            {
                return new ValidationResult("Brak pesel lub daty urodzenia");
            }
        }
    }
}