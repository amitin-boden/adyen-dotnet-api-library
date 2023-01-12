/*
* Management API
*
*
* The version of the OpenAPI document: 1
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Net.Http;
using System.Threading.Tasks;
using Adyen.Model;
using Adyen.Service.Resource;
using Adyen.Model.Management;
using Newtonsoft.Json;

namespace Adyen.Service.Management
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class APIKeyMerchantLevelApi : AbstractService
    {
        public APIKeyMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Generate new API key
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>GenerateApiKeyResponse</returns>
        public GenerateApiKeyResponse PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKey(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(null, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<GenerateApiKeyResponse>(jsonResult);
        }

        /// <summary>
        /// Generate new API key
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="apiCredentialId">Unique identifier of the API credential.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of GenerateApiKeyResponse</returns>
        public async Task<GenerateApiKeyResponse> PostMerchantsMerchantIdApiCredentialsApiCredentialIdGenerateApiKeyAsync(string merchantId, string apiCredentialId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/apiCredentials/{apiCredentialId}/generateApiKey";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<GenerateApiKeyResponse>(jsonResult);
        }

    }
}
