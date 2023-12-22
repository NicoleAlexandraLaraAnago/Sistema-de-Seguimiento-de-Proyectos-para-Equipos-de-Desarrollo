using Microsoft.EntityFrameworkCore;
using proyecto.Model;

namespace proyecto.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) 
        {

        }
        public DbSet<Tarea> Tareas { get; set; }  
        
            
        }
    }

