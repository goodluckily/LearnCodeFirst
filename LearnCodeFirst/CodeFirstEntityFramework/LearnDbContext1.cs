using CodeFirstModel;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstEntityFramework
{
    public class LearnDbContext1 : DbContext
    {

        //public DbSet<Student> Student { get; set; }
        //public DbSet<School> School { get; set; }
        //public DbSet<Car> Car { get; set; }
        //public DbSet<RecordOfSale> RecordOfSales { get; set; }
        //public DbSet<Blog> Blogs { get; set; }
        //public DbSet<Post> Posts { get; set; }


        public DbSet<User> User { get; set; }

        public DbSet<Role> Role { get; set; }

        //public DbSet<UserAndRoleMap> UserAndRoleMap { get; set; }


        //public DbSet<Post> Posts { get; set; }
        //public DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearnTest1;Uid=sa;Pwd=123456");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ////简单的 一对多
            //modelBuilder.Entity<School>()
            //.HasMany(p => p.Students)
            //.WithOne(p => p.School)
            //.HasForeignKey(p => p.SId);


            ////组合外键
            //modelBuilder.Entity<Car>().HasKey(x => new { x.State, x.LicensePlate }); //依据状态 车牌 组合
            //modelBuilder.Entity<RecordOfSale>().HasOne(x => x.Car).WithMany(x => x.SaleHistory)
            //    .HasForeignKey(s => new { s.CarState, s.CarLicensePlate }); //绑定 依据状态 车牌 组合

            ////1.也就是 主键索引 是聚集的
            ////2.这种组合索引是非聚集的

            ////1.指定字段为 外键字段 [ForeignKey("外键字段名称")]

            ////2.影子外键
            //modelBuilder.Entity<Blog>().Property<int>("BlogForeignKey");


            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Role>().HasKey(x => x.Id);

            //modelBuilder.Entity<Post>().HasKey(x=>x.PostId);
            //modelBuilder.Entity<Tag>().HasKey(x => x.TagId);

            //第三方表的 多<==>多 间接多对多关系

            //第一种
            //modelBuilder.Entity<UserAndRoleMap>().HasKey(t => new { t.UserId, t.RoleId });
            //modelBuilder.Entity<UserAndRoleMap>()
            //    .HasOne(pt => pt.User)
            //    .WithMany(p => p.userAndRoleMaps)
            //    .HasForeignKey(pt => pt.UserId);
            //modelBuilder.Entity<UserAndRoleMap>()
            //    .HasOne(pt => pt.Role)
            //    .WithMany(t => t.userAndRoleMaps)
            //    .HasForeignKey(pt => pt.RoleId);

            // modelBuilder.Entity<Post>()
            //.HasMany(p => p.Tags)
            //.WithMany(p => p.Posts)
            //.UsingEntity<PostTag>(
            //    j => j
            //        .HasOne(pt => pt.Tag)
            //        .WithMany(t => t.PostTags)
            //        .HasForeignKey(pt => pt.TagId),
            //    j => j
            //        .HasOne(pt => pt.Post)
            //        .WithMany(p => p.PostTags)
            //        .HasForeignKey(pt => pt.PostId),
            //    j =>
            //    {
            //        //j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //        j.HasKey(t => new { t.PostId, t.TagId });
            //    });

            modelBuilder.Entity<User>().HasMany(x => x.roles).WithMany(x => x.users)
                .UsingEntity<UserAndRoleMap>(
                    j => j.HasOne(pt => pt.Role).WithMany(t => t.userAndRoles).HasForeignKey(pt => pt.RoleId),
                    j => j.HasOne(pt => pt.User).WithMany(a => a.userAndRoles).HasForeignKey(p => p.UserId),
                    j =>
                    {
                        j.HasKey(x => new { x.UserId, x.RoleId });
                    }
                );
        }
    }
}