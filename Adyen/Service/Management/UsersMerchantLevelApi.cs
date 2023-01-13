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
    public class UsersMerchantLevelApi : AbstractService
    {
        public UsersMerchantLevelApi(Client client) : base(client) {}
    
        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>ListMerchantUsersResponse</returns>
        public ListMerchantUsersResponse GetMerchantsMerchantIdUsers(string merchantId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdUsersAsync(merchantId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get a list of users
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="requestOptions">Additional request options. Query parameters:
        /// <list type="table">
        ///     <listheader>
        ///         <term>parameter</term>
        ///         <description>description</description>
        ///     </listheader>
        ///     <item>
        ///         <term>pageNumber</term>
        ///         <description>The number of the page to fetch.</description>
        ///     </item>
        ///     <item>
        ///         <term>pageSize</term>
        ///         <description>The number of items to have on a page. Maximum value is **100**. The default is **10** items on a page.</description>
        ///     </item>
        /// </list></param>
        /// <returns>Task of ListMerchantUsersResponse</returns>
        public async Task<ListMerchantUsersResponse> GetMerchantsMerchantIdUsersAsync(string merchantId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/users" + ToQueryString(requestOptions?.QueryParameters);
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<ListMerchantUsersResponse>(jsonResult);
        }

        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>User</returns>
        public User GetMerchantsMerchantIdUsersUserId(string merchantId, string userId, RequestOptions requestOptions = null)
        {
            return GetMerchantsMerchantIdUsersUserIdAsync(merchantId, userId, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get user details
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of User</returns>
        public async Task<User> GetMerchantsMerchantIdUsersUserIdAsync(string merchantId, string userId, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/users/{userId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(null, null, new HttpMethod("GET"));
            return JsonConvert.DeserializeObject<User>(jsonResult);
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <param name="updateMerchantUserRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>User</returns>
        public User PatchMerchantsMerchantIdUsersUserId(string merchantId, string userId, UpdateMerchantUserRequest updateMerchantUserRequest, RequestOptions requestOptions = null)
        {
            return PatchMerchantsMerchantIdUsersUserIdAsync(merchantId, userId, updateMerchantUserRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update a user
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="userId">Unique identifier of the user.</param>
        /// <param name="updateMerchantUserRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of User</returns>
        public async Task<User> PatchMerchantsMerchantIdUsersUserIdAsync(string merchantId, string userId, UpdateMerchantUserRequest updateMerchantUserRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/users/{userId}";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(updateMerchantUserRequest.ToJson(), null, new HttpMethod("PATCH"));
            return JsonConvert.DeserializeObject<User>(jsonResult);
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="createMerchantUserRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>CreateUserResponse</returns>
        public CreateUserResponse PostMerchantsMerchantIdUsers(string merchantId, CreateMerchantUserRequest createMerchantUserRequest, RequestOptions requestOptions = null)
        {
            return PostMerchantsMerchantIdUsersAsync(merchantId, createMerchantUserRequest, requestOptions).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create a new user
        /// </summary>
        /// <param name="merchantId">Unique identifier of the merchant.</param>
        /// <param name="createMerchantUserRequest"></param>
        /// <param name="requestOptions">Additional request options.</param>
        /// <returns>Task of CreateUserResponse</returns>
        public async Task<CreateUserResponse> PostMerchantsMerchantIdUsersAsync(string merchantId, CreateMerchantUserRequest createMerchantUserRequest, RequestOptions requestOptions = null)
        {
            var endpoint = $"/merchants/{merchantId}/users";
            var resource = new ManagementResource(this, endpoint);
            var jsonResult = await resource.RequestAsync(createMerchantUserRequest.ToJson(), null, new HttpMethod("POST"));
            return JsonConvert.DeserializeObject<CreateUserResponse>(jsonResult);
        }

    }
}