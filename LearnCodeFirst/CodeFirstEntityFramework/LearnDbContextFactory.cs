using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEntityFramework
{
    public class LearnDbContextFactory: IDesignTimeDbContextFactory<LearnDbContext3>
    {
        public LearnDbContext3 CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LearnDbContext3>();
            optionsBuilder.UseSqlServer("Server=.;Database=LearnTest3;Uid=sa;Pwd=123456");
            return new LearnDbContext3(optionsBuilder.Options);
        }
    }
}
