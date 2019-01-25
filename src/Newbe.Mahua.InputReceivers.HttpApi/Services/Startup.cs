using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Newbe.Mahua.InputReceivers.HttpApi.Services
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSingleton(typeof(IMahuaCenter),
                b => PluginInstanceManager.GetInstance());

            services.AddSwaggerGen(c =>
            {
                var dirs = new[]
                {
                    AppDomain.CurrentDomain.BaseDirectory,
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AgentInfo.Instance.Id),
                };
                var xmlFiles = new List<string>();
                foreach (var dir in dirs)
                {
                    if (Directory.Exists(dir))
                    {
                        xmlFiles.AddRange(Directory.GetFiles(dir, "Newbe.Mahua.InputReceivers*.xml"));
                    }
                }

                foreach (var commentXmlFile in xmlFiles)
                {
                    c.IncludeXmlComments(commentXmlFile);
                }

                c.SwaggerDoc("v1", new Info
                {
                    Title = "Newbe.Mahua.HttpApi", Version = "v1",
                    License = new License
                    {
                        Url = "https://raw.githubusercontent.com/newbe36524/Newbe.Mahua.Framework/master/LICENSE",
                        Name = "GLWT"
                    },
                    Contact = new Contact
                    {
                        Email = "472158246@qq.com",
                        Url = "https://github.com/newbe36524/Newbe.Mahua.Framework",
                        Name = "Newbe36524"
                    },
                    Description =
                        "this is http api document for Newbe.Mahua. You can get some help from http://www.newbe.pro"
                });
                c.CustomOperationIds(description => description.RelativePath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseMvc(builder => { builder.MapRoute("default", "api/v1/{controller}/{action}"); });
            app.UseReDoc(options =>
            {
                options.SpecUrl = "/swagger/v1/swagger.json";
                options.RoutePrefix = "apiDoc";
            });
        }
    }
}