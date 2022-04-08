using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class Survey
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [EmailAddress]
        [EmailValidation]
        [Display(Name = "Adres email")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Imie")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [PeselValidation]
        public string Pesel { get; set; }

        [Display(Name = "Plec")]
        [GenderValidation]
        public Gender Gender { get; set; }
        [Required]
        public byte GenderId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Data urodzenia: RRRR-MM-DD")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        [BirthdateValidation]
        public DateTime BirthDate { get; set; }
        
        public int Age { get; set; }
        
        [Display(Name = "Ukonczona uczelnia")]
        [ForeignKey("GraduatedUni_Id")]
        public University GraduatedUni { get; set; }
        [Required]
        public byte GraduatedUni_Id { get; set; }
        [Display(Name = "Ukonczony kierunek studiow")]
        [ForeignKey("Faculty_Id")]
        public Faculty Faculty { get; set; }
        [Required]
        public byte Faculty_Id { get; set; }
        [Display(Name = "Srednia")]
        [Range(1.0,6.0)]
        public double? Grade { get; set; }
    }
}