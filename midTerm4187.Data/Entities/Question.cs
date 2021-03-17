using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace midTerm.Data.Entities
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public string Description { get; set; }
        [Required]
        public virtual ICollection<Option> Options { get; set; }
    }
}