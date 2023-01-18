using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace Core3_1
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            //Kullanıcı ve Rol/Yetki yönetimi eklentisi.
            app.UseAuthentication();

            //Rota erişim yönetimi eklentisi.
            app.UseAuthorization();

            //endpoint: Tam adresten domaini ayırınca elimizde kalan kısımdır.
            //Tam adres: https://ilkerturan.com/contact
            //Domain = https://ilkerturan.com/
            //endpoint = /contact
            app.UseEndpoints(endpoints =>
            {
                //Sabit/Özel Rota: pattern client tarafından yollanır, eğer uygun rota yazılmışsa ve daha üstteki rotalara uymamışsa bu rotayı işletir.
                endpoints.MapControllerRoute(
                    name: "privacy_pattern",
                    pattern: "privacy",
                    defaults: new { controller = "Home", action = "Privacy" }
                    );

                //Yarı özel rota: Bu tip rotalar client tarafından daha önceden belirlenmiş parametreleri de bekler. Örn: querystring

                endpoints.MapControllerRoute(
                    name:"metin_pattern",
                    pattern:"metin/{name?}",
                    defaults: new { controller = "Home", action = "Metin" }
                    );

                //En genel rota default olarak adlandırırldı.
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
