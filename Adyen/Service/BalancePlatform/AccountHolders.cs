/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Adyen.Service.Resource;
using Adyen.Model.BalancePlatform;
using Adyen.HttpClient;

namespace Adyen.Service.BalancePlatform
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccountHolders : AbstractService
    {
        public AccountHolders(Client client) : base(client) {}

        /// <summary>
        /// Get an account holder Returns an account holder.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <returns>AccountHolder</returns>
        public AccountHolder GetAccountHoldersId(string id)
        {
            return GetAccountHoldersIdAsync(id).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get an account holder Returns an account holder.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <returns>Task of AccountHolder</returns>
        public async Task<AccountHolder> GetAccountHoldersIdAsync(string id)
        {
            var resource = new BalancePlatformResource(this, $"/accountHolders/{id}");
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<AccountHolder>(jsonResult);
        }

        /// <summary>
        /// Get all balance accounts of an account holder Returns a paginated list of the balance accounts associated with an account holder. To fetch multiple pages, use the query parameters.   For example, to limit the page to 5 balance accounts and skip the first 10, use `/accountHolders/{id}/balanceAccounts?limit=5&offset=10`.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <param name="offset">The number of items that you want to skip. (optional)</param>
        /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. (optional)</param>
        /// <returns>PaginatedBalanceAccountsResponse</returns>
        public PaginatedBalanceAccountsResponse GetAccountHoldersIdBalanceAccounts(string id, int? offset = default(int?), int? limit = default(int?))
        {
            return GetAccountHoldersIdBalanceAccountsAsync(id, offset, limit).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all balance accounts of an account holder Returns a paginated list of the balance accounts associated with an account holder. To fetch multiple pages, use the query parameters.   For example, to limit the page to 5 balance accounts and skip the first 10, use `/accountHolders/{id}/balanceAccounts?limit=5&offset=10`.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <param name="offset">The number of items that you want to skip. (optional)</param>
        /// <param name="limit">The number of items returned per page, maximum 100 items. By default, the response returns 10 items per page. (optional)</param>
        /// <returns>Task of PaginatedBalanceAccountsResponse</returns>
        public async Task<PaginatedBalanceAccountsResponse> GetAccountHoldersIdBalanceAccountsAsync(string id, int? offset = default(int?), int? limit = default(int?))
        {
            var resource = new BalancePlatformResource(this, $"/accountHolders/{id}/balanceAccounts");
            var jsonResult = await resource.RequestAsync(null, null, HttpMethod.Get);
            return JsonConvert.DeserializeObject<PaginatedBalanceAccountsResponse>(jsonResult);
        }

        /// <summary>
        /// Update an account holder Updates an account holder. When updating an account holder resource, if a parameter is not provided in the request, it is left unchanged.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <param name="accountHolder"> (optional)</param>
        /// <returns>AccountHolder</returns>
        public AccountHolder PatchAccountHoldersId(string id, AccountHolder accountHolder)
        {
            return PatchAccountHoldersIdAsync(id, accountHolder).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Update an account holder Updates an account holder. When updating an account holder resource, if a parameter is not provided in the request, it is left unchanged.
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="id">The unique identifier of the account holder.</param>
        /// <param name="accountHolder"> (optional)</param>
        /// <returns>Task of AccountHolder</returns>
        public async Task<AccountHolder> PatchAccountHoldersIdAsync(string id, AccountHolder accountHolder)
        {
            var httpMethod = new HttpMethod("PATCH");
            string jsonRequest = accountHolder.ToJson();
            var resource = new BalancePlatformResource(this, $"/accountHolders/{id}");
            var jsonResult = await resource.RequestAsync(jsonRequest, null, httpMethod);
            return JsonConvert.DeserializeObject<AccountHolder>(jsonResult);
        }

        /// <summary>
        /// Create an account holder Creates an account holder linked to a [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities).  
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="accountHolderInfo"> (optional)</param>
        /// <returns>AccountHolder</returns>
        public AccountHolder PostAccountHolders(AccountHolderInfo accountHolderInfo)
        {
            return PostAccountHoldersAsync(accountHolderInfo).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create an account holder Creates an account holder linked to a [legal entity](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities).  
        /// </summary>
        /// <exception cref="HttpClientException">Thrown when fails to make API call</exception>
        /// <param name="accountHolderInfo"> (optional)</param>
        /// <returns>Task of AccountHolder</returns>
        public async Task<AccountHolder> PostAccountHoldersAsync(AccountHolderInfo accountHolderInfo)
        {
            string jsonRequest = accountHolderInfo.ToJson();
            var resource = new BalancePlatformResource(this, $"/accountHolders");
            var jsonResult = await resource.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<AccountHolder>(jsonResult);
        }
    }
}