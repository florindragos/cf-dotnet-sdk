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

using CloudFoundry.CloudController.V2.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public class ListAllServicesForOrganizationResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label
        {
            get;
            set;
        }

        [JsonProperty("provider", NullValueHandling = NullValueHandling.Ignore)]
        public string Provider
        {
            get;
            set;
        }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url
        {
            get;
            set;
        }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description
        {
            get;
            set;
        }

        [JsonProperty("long_description", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic LongDescription
        {
            get;
            set;
        }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version
        {
            get;
            set;
        }

        [JsonProperty("info_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic InfoUrl
        {
            get;
            set;
        }

        [JsonProperty("active", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active
        {
            get;
            set;
        }

        [JsonProperty("bindable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bindable
        {
            get;
            set;
        }

        [JsonProperty("unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UniqueId
        {
            get;
            set;
        }

        [JsonProperty("extra", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Extra
        {
            get;
            set;
        }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Tags
        {
            get;
            set;
        }

        [JsonProperty("requires", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] Requires
        {
            get;
            set;
        }

        [JsonProperty("documentation_url", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic DocumentationUrl
        {
            get;
            set;
        }

        [JsonProperty("service_broker_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceBrokerGuid
        {
            get;
            set;
        }

        [JsonProperty("plan_updateable", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic PlanUpdateable
        {
            get;
            set;
        }

        [JsonProperty("service_plans_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServicePlansUrl
        {
            get;
            set;
        }
    }
}