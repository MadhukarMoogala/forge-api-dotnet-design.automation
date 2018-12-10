/* 
 * Forge Design Automation
 *
 * Generated by [Forge Swagger Codegen](https://git.autodesk.com/design-automation/forge-rsdk-codegen)
 */

using Autodesk.Forge.Core;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using Autodesk.Forge.DesignAutomation.Client;
using Autodesk.Forge.DesignAutomation.Model;

namespace Autodesk.Forge.DesignAutomation.Http
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISharesApiHttp
    {
        /// <summary>
        /// Gets all Shares (AppBundles and Activities) shared by this Forge app. Gets all Shares (AppBundles and Activities) shared by this Forge app (shared to other  Forge apps for them to use).                Sharing of AppBundles and Activities is controlled via the use of &#39;aliases&#39;.
        /// </summary>
        /// <exception cref="HttpRequestException">Thrown when fails to make API call</exception>
        /// <param name="page">Used to get subsequent &#39;pages&#39; of data. (optional)</param>
        /// <returns>Task of ApiResponse<PageShares></returns>
        
        System.Threading.Tasks.Task<ApiResponse<PageShares>> GetSharesAsync (string page = null);
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SharesApiHttp : ISharesApiHttp
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SharesApiHttp"/> class
        /// using ForgeService object
        /// </summary>
        /// <param name="service">An instance of ForgeService</param>
        /// <returns></returns>
        public SharesApiHttp(ForgeService service = null, IOptions<Configuration> configuration = null)
        {
            this.Service = service ?? ForgeService.CreateDefault();

            // set BaseAddress from configuration or default
            this.Service.Client.BaseAddress = configuration?.Value.BaseAddress ?? new Configuration().BaseAddress;
        }

         /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the ForgeService</value>
        public ForgeService Service {get; set;}

        /// <summary>
        /// Gets all Shares (AppBundles and Activities) shared by this Forge app. Gets all Shares (AppBundles and Activities) shared by this Forge app (shared to other  Forge apps for them to use).                Sharing of AppBundles and Activities is controlled via the use of &#39;aliases&#39;.
        /// </summary>
        /// <exception cref="HttpRequestException">Thrown when fails to make API call</exception>
        /// <param name="page">Used to get subsequent &#39;pages&#39; of data. (optional)</param>
        /// <returns>Task of ApiResponse<PageShares></returns>
        
        public async System.Threading.Tasks.Task<ApiResponse<PageShares>> GetSharesAsync (string page = null)
        {
            var localVarPath = "/v3/shares";

            using (var request = new HttpRequestMessage())
            {
                if (page != null) localVarPath = Marshalling.AddQuery(localVarPath, "page", page); // query parameter

                // Request URI is now ready
                request.RequestUri = new Uri(localVarPath);

                request.Headers.TryAddWithoutValidation("Accept", "application/json");
                



                // tell the underlying pipeline what scope we'd like to use
                request.Properties.Add(ForgeConfiguration.ScopeKey, "code:all");

                // make the HTTP request
                var localVarResponse = await this.Service.Client.SendAsync(request);

                localVarResponse.EnsureSuccessStatusCode();

                return new ApiResponse<PageShares>(localVarResponse, (PageShares)Marshalling.Deserialize(localVarResponse.Content, typeof(PageShares)));

            } // using
        }
    }
}