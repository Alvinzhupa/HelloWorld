using System;
using Microsoft.Extensions.Configuration;
namespace JsonConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("class.json");
           var configrantion= builder.Build();

            Console.WriteLine($"name:{configrantion["name"]}");
            Console.WriteLine($"age:{configrantion["age"]}");

            //以下是数组的读法
            Console.WriteLine($"name:{configrantion["student:0:name"]}");
            Console.WriteLine($"name:{configrantion["student:0:age"]}");

            Console.WriteLine($"name:{configrantion["student:1:name"]}");
            Console.WriteLine($"name:{configrantion["student:1:age"]}");

            Console.WriteLine($"name:{configrantion["student:2:name"]}");//如果没当前属性的,则输出空而不会报错
            Console.WriteLine($"name:{configrantion["student:2:age"]}");

            Console.Read();
        }
    }
}
