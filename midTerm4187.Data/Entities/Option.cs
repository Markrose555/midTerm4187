using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace midTerm.Data.Entities
{
    public class Option
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public int? Order { get; set; }
        [Required]
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public virtual Question Question { get; set; }
    }
}