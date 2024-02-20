

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Klepacz.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public string CategoryId { get; set; }
        public Category Category { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? Lent {  get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
