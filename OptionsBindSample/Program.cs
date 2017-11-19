using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace OptionsBindSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(config => //这里是因为查看过源码,源码里面使用了这个方法对引入的appsettings.json进行了设置,
            {
                config.AddJsonFile("appsettings.json", true, false);//这里config参数是形参,是一个委托,来使用ConfigrationBuilder设置配置文件的
            })
                .UseStartup<Startup>()
                .Build();
    }
}
