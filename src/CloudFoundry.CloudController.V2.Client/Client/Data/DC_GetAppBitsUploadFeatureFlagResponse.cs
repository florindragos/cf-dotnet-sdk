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
    public class GetAppBitsUploadFeatureFlagResponse : IResponse
    {
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        [JsonProperty("enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled
        {
            get;
            set;
        }

        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ErrorMessage
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
    }
}