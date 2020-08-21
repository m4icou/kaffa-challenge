using Microsoft.EntityFrameworkCore;
using Exercicio5.Models;

namespace Exercicio5.Data
{
    public class Exercicio5Context : DbContext
    {
        //Here the context of the localDb, using Entity Framework 
        public Exercicio5Context (DbContextOptions<Exercicio5Context> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; }
    }
}
