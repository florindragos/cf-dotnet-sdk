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

using CloudFoundry.CloudController.V2.Client.Interfaces;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

namespace CloudFoundry.CloudController.V2.Client.Data
{
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SecurityGroupRunningDefaultsEndpoint.ReturnSecurityGroupsUsedForRunningApps()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/224/security_group_running_defaults/return_the_security_groups_used_for_running_apps.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ReturnSecurityGroupsUsedForRunningAppsResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractReturnSecurityGroupsUsedForRunningAppsResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.SecurityGroupRunningDefaultsEndpoint.ReturnSecurityGroupsUsedForRunningApps()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/224/security_group_running_defaults/return_the_security_groups_used_for_running_apps.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractReturnSecurityGroupsUsedForRunningAppsResponse : IResponse
    {
        /// <summary>
        /// Contains the Metadata for this Entity
        /// </summary>
        public Metadata EntityMetadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Name</para>
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Rules</para>
        /// </summary>
        [JsonProperty("rules", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic>[] Rules
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Running Default</para>
        /// </summary>
        [JsonProperty("running_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? RunningDefault
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Staging Default</para>
        /// </summary>
        [JsonProperty("staging_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? StagingDefault
        {
            get;
            set;
        }
    }
}