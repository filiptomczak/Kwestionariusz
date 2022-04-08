using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Zadanie.Models
{
    public class Faculty
    {
        [Key]
        public byte Id { get; set; }
        public int UniversityId { get; set; }
        public string Name { get; set; }
    }
}