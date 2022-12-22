#region License

// /*
//  *                       ######
//  *                       ######
//  * ############    ####( ######  #####. ######  ############   ############
//  * #############  #####( ######  #####. ######  #############  #############
//  *        ######  #####( ######  #####. ######  #####  ######  #####  ######
//  * ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  * ###### ######  #####( ######  #####. ######  #####          #####  ######
//  * #############  #############  #############  #############  #####  ######
//  *  ############   ############  #############   ############  #####  ######
//  *                                      ######
//  *                               #############
//  *                               ############
//  *
//  * Adyen Dotnet API Library
//  *
//  * Copyright (c) 2022 Adyen N.V.
//  * This file is open source and available under the MIT license.
//  * See the LICENSE file for more info.
//  */

#endregion

using Adyen.Constants;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Adyen.HttpClient.Interfaces;
using Adyen.Model;

namespace Adyen.HttpClient
{
    public class HttpClientWrapper : IClient
    {
        private readonly Config _config;

        private readonly Encoding _encoding = Encoding.UTF8;
        private readonly System.Net.Http.HttpClient _httpClient;

        public HttpClientWrapper(Config config, System.Net.Http.HttpClient httpClient)
        {
            
            _config = config;
            _httpClient = httpClient;
        }

        public string Request(string endpoint, string requestBody, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {
            return RequestAsync(endpoint, requestBody, isApiKeyRequired, requestOptions,  httpMethod).ConfigureAwait(false).GetAwaiter().GetResult();
        }

        public async Task<string> RequestAsync(string endpoint, string requestBody, bool isApiKeyRequired, RequestOptions requestOptions = null, HttpMethod httpMethod = null)
        {   
            // do we need the using() here in the first line?
            using (var request = GetHttpRequestMessage(endpoint, isApiKeyRequired, requestBody, requestOptions, httpMethod))
            using (var httpResponseMessage = await _httpClient.SendAsync(request))
            {
                var responseText = await httpResponseMessage.Content.ReadAsStringAsync();
                httpResponseMessage.EnsureSuccessStatusCode();
                return responseText;
            }
        }

        public string Post(string endpoint, Dictionary<string, string> postParameters)
        {
            var dictToString = QueryString(postParameters);

            var content = new StringContent(dictToString, _encoding, "application/x-www-form-urlencoded");
            using (var request = new HttpRequestMessage(HttpMethod.Post, endpoint) {Content = content})
            using (var response = _httpClient.SendAsync(request).GetAwaiter().GetResult())
            {
                response.EnsureSuccessStatusCode();
                return response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
        }

        private HttpRequestMessage GetHttpRequestMessage(string endpoint, bool isApiKeyRequired, string requestBody, RequestOptions requestOptions, HttpMethod httpMethod)
        {   
            if (httpMethod == null) {httpMethod = HttpMethod.Post;}
            
            var httpWebRequest = new HttpRequestMessage(httpMethod, endpoint);
            
            // custom patch method for dotnet <2.1
            var patchMethod = new HttpMethod("PATCH");
            
            if (httpMethod == HttpMethod.Post || httpMethod == patchMethod)
            {
                httpWebRequest.Content = new StringContent(requestBody, _encoding, "application/json");
            }

            httpWebRequest.Headers.Add("ContentType", "application/json");
            httpWebRequest.Headers.Add("Accept-Charset", "UTF-8");
            httpWebRequest.Headers.Add("Cache-Control", "no-cache");
            httpWebRequest.Headers.Add("UserAgent", $"{_config.ApplicationName} {ClientConfig.UserAgentSuffix}{ClientConfig.LibVersion}");
            if (!string.IsNullOrWhiteSpace(requestOptions?.IdempotencyKey))
            {
                httpWebRequest.Headers.Add("Idempotency-Key", requestOptions.IdempotencyKey);
            }

            //Use one of two authentication method.
            if (isApiKeyRequired || _config.HasApiKey)
            {
                httpWebRequest.Headers.Add("x-api-key", _config.XApiKey);
            }
            else if (_config.HasPassword)
            {
                var authString = _config.Username + ":" + _config.Password;
                var bytes = Encoding.UTF8.GetBytes(authString);
                var credentials = Convert.ToBase64String(bytes);
                httpWebRequest.Headers.Add("Authorization", "Basic " + credentials);
            }

            return httpWebRequest;
        }

        private static string QueryString(IDictionary<string, string> dict)
        {
            var stringBuilder = new StringBuilder();
            foreach (var item in dict)
            {
                stringBuilder.Append(item.Key);
                stringBuilder.Append('=');
                stringBuilder.Append(HttpUtility.UrlEncode(item.Value));
                stringBuilder.Append('&');
            }

            if (stringBuilder.Length > 0)
            {
                //remove trailing &amp
                stringBuilder.Remove(stringBuilder.Length - 2, 1);
            }

            return stringBuilder.ToString();
        }

        public void Dispose()
        {
            _httpClient?.Dispose();
        }
    }
}