// using Microsoft.EntityFrameworkCore;

namespace curzi.lorenzo._5h.PrimaWeb.Models
{
    public class PersoneContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Persona> Persone { get; set; }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder opzioni)
        {
            opzioni.UseSqlite("Data Source=dbPersone.db");
        }

    }
}