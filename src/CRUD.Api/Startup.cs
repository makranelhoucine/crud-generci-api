namespace CRUD.Api
{
    using System;

    using Infrastructure.POCOs;
    using Infrastructure.Repositories;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public static Action<IServiceCollection> RegisterDbContext { get; set; } = DefaultRegisterDbContext;

        public IConfiguration Configuration { get; }

        public static void DefaultRegisterDbContext(IServiceCollection services)
        {
            services.AddScoped<IADWContext>(
                serviceProvider =>
                    {
                        var configuration = serviceProvider.GetRequiredService<IConfiguration>();
                        return new ADWContext(configuration.GetConnectionString("ADWContext"));
                    });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(o => o.ConfigureGenericApi())
                    .ConfigureApplicationPartManager(m => m.ConfigureGenericFeature())
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddTransient(typeof(IReader<>), typeof(Reader<>));
            services.AddTransient(typeof(IWriter<>), typeof(Writer<>));
            RegisterDbContext(services);
        }
    }
}