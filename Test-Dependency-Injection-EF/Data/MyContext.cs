
using Microsoft.EntityFrameworkCore;
using Test_Dependency_Injection_EF.Models;

namespace Test_Dependency_Injection_EF
{
    public class MyContext : DbContext
    {

        public DbSet<PersonEntity> Person { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }


    }
}
