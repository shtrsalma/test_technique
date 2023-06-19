using Microsoft.EntityFrameworkCore;
using Project_TestTechnique.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_TestTechnique.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Candidat> Candidats { get; set; }

    }
}
