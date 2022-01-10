using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Test_Dependency_Injection_EF
{
    public class DependencyInjection
    {

        public DependencyInjection()
        {
            var serviceColletion = new ServiceCollection();
            var connectionString = "server=localhost;port=3306;database=dbEF-And-DI;uid=root;password=fx870";
            serviceColletion.AddDbContext<MyContext>(o =>
            {
                o.UseMySql()
            })
        }

    }
}
