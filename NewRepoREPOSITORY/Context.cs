using Microsoft.EntityFrameworkCore;
using NewRepoMODEL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRepoREPOSITORY
{
    public class Context :DbContext
    {
        public Context(DbContextOptions options):base(options)
        {

        }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
