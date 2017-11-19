using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
namespace configCommonlind
{
    class Program
    {
        static void Main(string[] args)
        {
            var setting = new Dictionary<string, string>() {
                {"name","abc" },
                {"age","1555553"}
            };

            //这里创建配置,如果需要设置默认值,那么使用AddInMemoryCollection
            var builder = new ConfigurationBuilder()
                .AddInMemoryCollection(setting)
                .AddCommandLine(args);

            var configuration = builder.Build();

            Console.WriteLine($"name:{configuration["name"]}");
            Console.WriteLine($"age:{configuration["age"]}");

            Console.ReadLine();
        }
    }
}
