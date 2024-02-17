

using System.ComponentModel.DataAnnotations;

namespace Mission06_Klepacz.Models
{
    public class AddMovie
    {
        [Key]
        [Required]
        public int Movie_Id { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? Lent {  get; set; }
        public string? Notes { get; set; }

    }
}
