

using Microsoft.VisualBasic;
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
        public int? CategoryId { get; set; }
        public Category? CategoryName { get; set; }

        public string Title { get; set; }

        //Limit the year between 1888 and 3000 (I doubt humans will still be around in a millenium, but if they are I'll let them fix this issue)
        [Range(1888, 3000, ErrorMessage = "Please enter a valid year between 1888 and the current year")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo {  get; set; }
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }

    }
}
