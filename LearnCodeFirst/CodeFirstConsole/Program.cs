// See https://aka.ms/new-console-template for more information
using CodeFirstEntityFramework;
using CodeFirstModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


//第一种 使用无参构造函数，必须重写OnConfiguring()函数 LearnDbContext1
var context = new LearnDbContext1();


////第二种 构造函数注入 LearnDbContext2
//IServiceCollection services = new ServiceCollection();
//services.AddDbContext<LearnDbContext2>(x=>x.UseSqlServer("Service=.;Database=LearnTest1;Uid=sa;Pwd=123456;"));

//第三种 工厂方式 LearnDbContext3
//new LearnDbContextFactory();


#region 方法一

context.Set<School>().Add(new School() 
{
    SName ="中心小学",
    SAddress ="深圳",
    Students = new List<Student>()
    {
        new Student(){Name="张三",Address="家里" }
    }
});

var result = context.SaveChanges();


#endregion