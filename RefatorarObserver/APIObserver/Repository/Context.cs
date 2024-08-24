using Microsoft.EntityFrameworkCore;
using RefatorarObserver.Models;

namespace APIObserver.Repository
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options)
        { 
        
        }

        public DbSet<Produto> Produto { get; set; }

    }
}
