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
    public class ServiceBindingsEndpoint: BaseEndpoint
    {
        public ServiceBindingsEndpoint(CloudFoundryClient client)
        {
            this.CloudTarget = client.CloudTarget;
            this.CancellationToken = client.CancellationToken;
            this.ServiceLocator = client.ServiceLocator;
            this.auth = client.auth;
        }
    
        /// <summary>
        /// List all Service Bindings
        /// </summary>
    
        
        public async Task<PagedResponseCollection<ListAllServiceBindingsResponse>> ListAllServiceBindings()
        {
            return await ListAllServiceBindings(new RequestOptions());
        }
        
    
    
        public async Task<PagedResponseCollection<ListAllServiceBindingsResponse>> ListAllServiceBindings(RequestOptions options)
    
        {
            string route = "/v2/service_bindings";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route + options.ToString();
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializePage<ListAllServiceBindingsResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Retrieve a Particular Service Binding
        /// </summary>
    
        
    
    
        public async Task<RetrieveServiceBindingResponse> RetrieveServiceBinding(Guid? guid)
    
        {
            string route = string.Format("/v2/service_bindings/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Get;
            client.Headers.Add(BuildAuthenticationHeader());
        
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializeJson<RetrieveServiceBindingResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
        /// <summary>
        /// Delete a Particular Service Binding
        /// </summary>
    
    
        public async Task DeleteServiceBinding(Guid? guid)
    
        {
            string route = string.Format("/v2/service_bindings/{0}", guid);
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Delete;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            var response = await this.SendAsync(client);
        
        }
    
        /// <summary>
        /// Create a Service Binding
        /// </summary>
    
    
        public async Task<CreateServiceBindingResponse> CreateServiceBinding(CreateServiceBindingRequest value)
    
        {
            string route = "/v2/service_bindings";
        
            
            string endpoint = this.CloudTarget.ToString().TrimEnd('/') + route;
            
            var client = this.GetHttpClient();
            client.Uri = new Uri(endpoint);

            client.Method = HttpMethod.Post;
            client.Headers.Add(BuildAuthenticationHeader());
        
            client.ContentType = "application/x-www-form-urlencoded";
        
        
            client.Content = JsonConvert.SerializeObject(value).ConvertToStream();
        
            var response = await this.SendAsync(client);
        
            
            return Utilities.DeserializeJson<CreateServiceBindingResponse>(await response.ReadContentAsStringAsync());
            
        
        }
    
    }
}