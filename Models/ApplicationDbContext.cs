using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebApplication1minor.Models
{
    public class ApplicationDbContext :DbContext
    {
    
            public ApplicationDbContext(DbContextOptions dbContextOptions) : base()
            { }
            public DbSet<Teacher> Teachers { get; set; }
            public DbSet<Student> Students { get; set; }




        }
    }

