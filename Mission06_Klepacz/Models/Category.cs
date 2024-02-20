using System.ComponentModel.DataAnnotations;

namespace Mission06_Klepacz.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; }
    }
}
