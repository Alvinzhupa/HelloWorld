using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
namespace OptionsBindSample
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        /// <summary>
        /// 1.在程度启动时,先会把配置文件读出,(只要命名为appsettings.json,就会默认读取)
        /// 2.配置文件会随着这个Startup启动而注入Configuration
        /// 3.然后在run的时候,利用Configuration.Bind(Class)再把配置文件的数据注入到对应的类中中
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<Class>(Configuration);

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();

            //app.Run(async (context) =>
            //{
            //    var newClass = new Class();
            //    Configuration.Bind(newClass);//这里是把属性注入到对象中,然后就可以使用对象了

            //    await context.Response.WriteAsync($"name is {newClass.name}");
            //    await context.Response.WriteAsync($"name is {newClass.age}");
            //    await context.Response.WriteAsync($"name is {newClass.students}");
            //});
        }
    }
}
