using System;
using System.ComponentModel.DataAnnotations;
using midTerm.Data.Enums;

namespace midTerm.Data.Entities
{
    public class SurveyUser
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        [Required]
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
