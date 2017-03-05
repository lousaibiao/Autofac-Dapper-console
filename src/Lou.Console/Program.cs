using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Lou.Data;
using System.Reflection;
using Lou.Lib;

namespace Lou.Cons
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName() { Name = "Lou.Data" })).Where(w=>w.Name.EndsWith("Repository")).AsImplementedInterfaces();
            builder.RegisterAssemblyTypes(Assembly.Load(new AssemblyName() { Name = "Lou.Lib" })).Where(w => w.Name.EndsWith("Service")).AsImplementedInterfaces();
            var container = builder.Build();
            var empService = container.Resolve<IEmployeeService>();
            var detail = empService.GetById(1);

            //Console.WriteLine("hello world");
        }
    }
}
