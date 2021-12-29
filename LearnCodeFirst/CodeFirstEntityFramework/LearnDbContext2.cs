using CodeFirstModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFramework
{
    public class LearnDbContext2 : DbContext
    {
        public LearnDbContext2()
        {

        }
        public LearnDbContext2(DbContextOptions<LearnDbContext2> Options) : base(Options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearnTest2;Uid=sa;Pwd=123456");
        }
    }
}
