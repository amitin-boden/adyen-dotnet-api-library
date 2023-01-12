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
    public class PaymentMethodsMerchantLevelApi : AbstractService
    {
        public PaymentMethodsMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get all payment methods
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>storeId</term>
        ///         <description>The unique identifier of the store for which to return the payment methods.</description>
        ///     </item>
        ///     <item>
        ///         <term>businessLineId</term>
        ///         <description>The unique identifier of the Business Line for which to return the payment methods.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        /// </list></param>
        /// <returns>PaymentMethodResponse</returns>
        public PaymentMethodResponse GetMerchantsMerchantIdPaymentMethodSettings(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PaymentMethodResponse>(jsonResult);
        }

        /// <summary>
        /// Get all payment methods
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>storeId</term>
        ///         <description>The unique identifier of the store for which to return the payment methods.</description>
        ///     </item>
        ///     <item>
        ///         <term>businessLineId</term>
        ///         <description>The unique identifier of the Business Line for which to return the payment methods.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page, maximum 100. The default is 10 items on a page.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of PaymentMethodResponse</returns>
        public async Task<PaymentMethodResponse> GetMerchantsMerchantIdPaymentMethodSettingsAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PaymentMethodResponse>(jsonResult);
        }

        /// <summary>
        /// Get payment method details
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Get payment method details
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(string merchantId, string paymentMethodId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Get Apple Pay domains
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>ApplePayInfo</returns>
        public ApplePayInfo GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomains(string merchantId, string paymentMethodId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ApplePayInfo>(jsonResult);
        }

        /// <summary>
        /// Get Apple Pay domains
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of ApplePayInfo</returns>
        public async Task<ApplePayInfo> GetMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdGetApplePayDomainsAsync(string merchantId, string paymentMethodId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/getApplePayDomains";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ApplePayInfo>(jsonResult);
        }

        /// <summary>
        /// Update a payment method
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="updatePaymentMethodInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodId(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo updatePaymentMethodInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(updatePaymentMethodInfo.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Update a payment method
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="updatePaymentMethodInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> PatchMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAsync(string merchantId, string paymentMethodId, UpdatePaymentMethodInfo updatePaymentMethodInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updatePaymentMethodInfo.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Request a payment method
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodSetupInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>PaymentMethod</returns>
        public PaymentMethod PostMerchantsMerchantIdPaymentMethodSettings(string merchantId, PaymentMethodSetupInfo paymentMethodSetupInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(paymentMethodSetupInfo.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Request a payment method
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodSetupInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of PaymentMethod</returns>
        public async Task<PaymentMethod> PostMerchantsMerchantIdPaymentMethodSettingsAsync(string merchantId, PaymentMethodSetupInfo paymentMethodSetupInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(paymentMethodSetupInfo.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<PaymentMethod>(jsonResult);
        }

        /// <summary>
        /// Add an Apple Pay domain
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="applePayInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Object</returns>
        public Object PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomains(string merchantId, string paymentMethodId, ApplePayInfo applePayInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = resource.Request(applePayInfo.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Object>(jsonResult);
        }

        /// <summary>
        /// Add an Apple Pay domain
        /// </summary>
        /// <param name="merchantId">The unique identifier of the merchant account.</param>
        /// <param name="paymentMethodId">The unique identifier of the payment method.</param>
        /// <param name="applePayInfo"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of Object</returns>
        public async Task<Object> PostMerchantsMerchantIdPaymentMethodSettingsPaymentMethodIdAddApplePayDomainsAsync(string merchantId, string paymentMethodId, ApplePayInfo applePayInfo, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/paymentMethodSettings/{paymentMethodId}/addApplePayDomains";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(applePayInfo.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<Object>(jsonResult);
        }

    }
}
