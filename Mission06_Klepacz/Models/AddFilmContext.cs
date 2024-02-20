using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Klepacz.Models

{
    public class AddFilmContext : DbContext
    { 
        public AddFilmContext(DbContextOptions<AddFilmContext>options) : base(options) 
        { 
        }

        public DbSet<AddMovie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
