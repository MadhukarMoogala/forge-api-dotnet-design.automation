/* 
 * Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/forge-ozone/forge-rsdk-codegen)
 */

using Autodesk.Forge.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Autodesk.Forge.DesignAutomation.Rsdk.Http;

namespace Autodesk.Forge.DesignAutomation.Rsdk
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Adds DesignAutomationClient and configures it with the given configuration.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IHttpClientBuilder AddDesignAutomation(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Configuration>(configuration.GetSection("Forge").GetSection("DesignAutomation"));
            services.AddForgeService(configuration);
            services.AddTransient<IActivitiesApi,ActivitiesApi>();
            services.AddTransient<IAppBundlesApi,AppBundlesApi>();
            services.AddTransient<IEnginesApi,EnginesApi>();
            services.AddTransient<IForgeAppsApi,ForgeAppsApi>();
            services.AddTransient<IHealthApi,HealthApi>();
            services.AddTransient<ISharesApi,SharesApi>();
            services.AddTransient<IWorkItemsApi,WorkItemsApi>();
            services.AddTransient<DesignAutomationClient>();
            return services.AddForgeService(configuration);
        }
    }
}