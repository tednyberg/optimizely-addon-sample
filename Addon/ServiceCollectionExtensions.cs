using EPiServer.Framework.Hosting;
using EPiServer.Framework.Web.Resources;
using EPiServer.Shell.Modules;
using EPiServer.Web.Hosting;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomAddon(this IServiceCollection services, IWebHostEnvironment webHostEnvironment)
        {
            const string ADDON_NAME = "Addon";

            // Register the add-on module
            services.Configure<ProtectedModuleOptions>(pm =>
            {
                pm.Items.Add(new ModuleDetails
                {
                    Name = ADDON_NAME
                });
            });

            // Load add-on module files directly from Addon project folder and enable UI debugging during development
            if (webHostEnvironment.IsDevelopment())
            {
                var uiSolutionFolder = Path.Combine(webHostEnvironment.ContentRootPath, @"..\");

                services.Configure<CompositeFileProviderOptions>(c =>
                {
                    c.BasePathFileProviders.Add(new MappingPhysicalFileProvider($"/EPiServer/{ADDON_NAME}", string.Empty, Path.Combine(uiSolutionFolder, ADDON_NAME)));
                });

                // Debug logging for CMS UI
                services.Configure<ClientResourceOptions>(x => x.Debug = true);
            }

            return services;
        }
    }
}
