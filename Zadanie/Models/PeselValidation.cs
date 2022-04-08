using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class PeselValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var survey = (Survey)validationContext.ObjectInstance;
            if (survey.Pesel != null)
            {
                if (survey.Pesel.Length == 11 && isNumber(survey.Pesel))
                    return ValidationResult.Success;
                if (isNumber(survey.Pesel) == false)
                    return new ValidationResult("Pesel musi skladac sie z samych cyfr");
                if(survey.Pesel.Length != 11)
                    return new ValidationResult("Pesel musi zawierac dokladnie 11 cyfr");             
                return new ValidationResult("Pesel niewazny");
            }
            else
                return new ValidationResult("Pesel niewazny");
        }
        private bool isNumber(string s)
        {
            decimal number;
            bool isNumeric = decimal.TryParse(s, out number);
            return isNumeric;
        }
    }
}