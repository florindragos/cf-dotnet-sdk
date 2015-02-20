//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by cf-sdk-builder
// 

using CloudFoundry.CloudController.V2.Client.Data;
using CloudFoundry.CloudController.V2.Interfaces;
using CloudFoundry.CloudController.Common;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CloudFoundry.CloudController.V2.Client
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class PrivateDomainsEndpoint: BaseEndpoint
    {
        public PrivateDomainsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// Filtering Private Domains by name
        /// </summary>
    
        
        public async Task<PagedResponseCollection<FilterPrivateDomainsByNameResponse>> FilterPrivateDomainsByName()
        {
            return await FilterPrivateDomainsByName(new RequestOptions());
        }
        
    
    
        public async Task<PagedResponseCollection<FilterPrivateDomainsByNameResponse>> FilterPrivateDomainsByName(RequestOptions options)
    
        {
            string route = "/v2/private_domains";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializePage<FilterPrivateDomainsByNameResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// List all Private Domains
        /// </summary>
    
        
        public async Task<PagedResponseCollection<ListAllPrivateDomainsResponse>> ListAllPrivateDomains()
        {
            return await ListAllPrivateDomains(new RequestOptions());
        }
        
    
    
        public async Task<PagedResponseCollection<ListAllPrivateDomainsResponse>> ListAllPrivateDomains(RequestOptions options)
    
        {
            string route = "/v2/private_domains";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializePage<ListAllPrivateDomainsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Retrieve a Particular Private Domain
        /// </summary>
    
        
    
    
        public async Task<RetrievePrivateDomainResponse> RetrievePrivateDomain(Guid? guid)
    
        {
            string route = string.Format("/v2/private_domains/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializeJson<RetrievePrivateDomainResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Create a Private Domain owned by the given Organization
        /// </summary>
    
    
        public async Task<CreatePrivateDomainOwnedByGivenOrganizationResponse> CreatePrivateDomainOwnedByGivenOrganization(CreatePrivateDomainOwnedByGivenOrganizationRequest value)
    
        {
            string route = "/v2/private_domains";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializeJson<CreatePrivateDomainOwnedByGivenOrganizationResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Delete a Particular Private Domain
        /// </summary>
    
    
        public async Task DeletePrivateDomain(Guid? guid)
    
        {
            string route = string.Format("/v2/private_domains/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            var response = await this.SendAsync(client);
        
        }
    
    }
}