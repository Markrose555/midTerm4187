using System;
using midTerm4187.Data.Enums;

namespace midTerm4187.Data.Entities
{
    public class SurveyUser
    {
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DoB { get; set; }
        public Gender Gender { get; set; }
        public string Country { get; set; }
    }
}
