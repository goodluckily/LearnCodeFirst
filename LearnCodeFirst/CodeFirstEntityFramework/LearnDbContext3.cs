using CodeFirstModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFramework
{
    public class LearnDbContext3:DbContext
    {
        public LearnDbContext3(DbContextOptions<LearnDbContext3> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
    }
}
