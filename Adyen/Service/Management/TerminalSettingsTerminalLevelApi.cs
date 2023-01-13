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
    public class TerminalSettingsTerminalLevelApi : AbstractService
    {
        public TerminalSettingsTerminalLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Logo</returns>
        public Logo GetTerminalsTerminalIdTerminalLogos(string terminalId, RequestOptions requestOptions = null)
        {
            return GetTerminalsTerminalIdTerminalLogosAsync(terminalId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get the terminal logo
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Logo</returns>
        public async Task<Logo> GetTerminalsTerminalIdTerminalLogosAsync(string terminalId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/terminals/{terminalId}/terminalLogos";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalSettings</returns>
        public TerminalSettings GetTerminalsTerminalIdTerminalSettings(string terminalId, RequestOptions requestOptions = null)
        {
            return GetTerminalsTerminalIdTerminalSettingsAsync(terminalId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get terminal settings
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalSettings</returns>
        public async Task<TerminalSettings> GetTerminalsTerminalIdTerminalSettingsAsync(string terminalId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/terminals/{terminalId}/terminalSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

        /// <summary>
        /// Update the logo
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Logo</returns>
        public Logo PatchTerminalsTerminalIdTerminalLogos(string terminalId, Logo logo, RequestOptions requestOptions = null)
        {
            return PatchTerminalsTerminalIdTerminalLogosAsync(terminalId, logo, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update the logo
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="logo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Logo</returns>
        public async Task<Logo> PatchTerminalsTerminalIdTerminalLogosAsync(string terminalId, Logo logo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/terminals/{terminalId}/terminalLogos";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(logo.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<Logo>(jsonResult);
        }

        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="terminalSettings"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>TerminalSettings</returns>
        public TerminalSettings PatchTerminalsTerminalIdTerminalSettings(string terminalId, TerminalSettings terminalSettings, RequestOptions requestOptions = null)
        {
            return PatchTerminalsTerminalIdTerminalSettingsAsync(terminalId, terminalSettings, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update terminal settings
        /// </summary>
        /// <param name="terminalId">The unique identifier of the payment terminal.</param>
        /// <param name="terminalSettings"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of TerminalSettings</returns>
        public async Task<TerminalSettings> PatchTerminalsTerminalIdTerminalSettingsAsync(string terminalId, TerminalSettings terminalSettings, RequestOptions requestOptions = null)
        {
            var endpoint = $"/terminals/{terminalId}/terminalSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(terminalSettings.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<TerminalSettings>(jsonResult);
        }

    }
}