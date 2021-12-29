using CodeFirstModel;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    public class LearnDbContext1 : DbContext
    {

        public DbSet<Student> Student { get; set; }
        public DbSet<School> School { get; set; }


        public DbSet<Car> Car { get; set; }

        public DbSet<RecordOfSale> RecordOfSales { get; set; }


        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearnTest1;Uid=sa;Pwd=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //简单的 一对多
            modelBuilder.Entity<School>()
            .HasMany(p => p.Students)
            .WithOne(p => p.School)
            .HasForeignKey(p => p.SId);


            //组合外键
            modelBuilder.Entity<Car>().HasKey(x => new { x.State, x.LicensePlate }); //依据状态 车牌 组合
            modelBuilder.Entity<RecordOfSale>().HasOne(x => x.Car).WithMany(x => x.SaleHistory)
                .HasForeignKey(s => new { s.CarState, s.CarLicensePlate }); //绑定 依据状态 车牌 组合

            //1.也就是 主键索引 是聚集的
            //2.这种组合索引是非聚集的


            //1.指定字段为 外键字段 [ForeignKey("外键字段名称")]

            //2.影子外键
            modelBuilder.Entity<Blog>().Property<int>("BlogForeignKey");
            modelBuilder.Entity<Post>().HasOne(x => x.Blog).WithMany(x => x.Posts).HasForeignKey("BlogForeignKey");

        }
    }
}