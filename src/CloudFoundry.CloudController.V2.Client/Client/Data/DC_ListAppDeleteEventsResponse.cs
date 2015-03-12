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
    /// <summary>
    /// Data class used for deserializing the "CloudFoundry.CloudController.V2.Client.EventsEndpoint.ListAppDeleteEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/events/list_app_delete_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public partial class ListAppDeleteEventsResponse : CloudFoundry.CloudController.V2.Client.Data.Base.AbstractListAppDeleteEventsResponse
    {
    }
}

namespace CloudFoundry.CloudController.V2.Client.Data.Base
{
    /// <summary>
    /// Base abstract data class used for deserializing the "CloudFoundry.CloudController.V2.Client.EventsEndpoint.ListAppDeleteEvents()" Response
    /// <para>For usage information, see online documentation at "http://apidocs.cloudfoundry.org/195/events/list_app_delete_events.html"</para>
    /// </summary>
    [GeneratedCodeAttribute("cf-sdk-builder", "1.0.0.0")]
    public abstract class AbstractListAppDeleteEventsResponse : IResponse
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
        /// <para>The Type</para>
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor</para>
        /// </summary>
        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public string Actor
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor Type</para>
        /// </summary>
        [JsonProperty("actor_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActorType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actor Name</para>
        /// </summary>
        [JsonProperty("actor_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActorName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee</para>
        /// </summary>
        [JsonProperty("actee", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Actee
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee Type</para>
        /// </summary>
        [JsonProperty("actee_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ActeeType
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Actee Name</para>
        /// </summary>
        [JsonProperty("actee_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ActeeName
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Timestamp</para>
        /// </summary>
        [JsonProperty("timestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string Timestamp
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Metadata</para>
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, dynamic> Metadata
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Space Guid</para>
        /// </summary>
        [JsonProperty("space_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SpaceGuid
        {
            get;
            set;
        }

        /// <summary> 
        /// <para>The Organization Guid</para>
        /// </summary>
        [JsonProperty("organization_guid", NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrganizationGuid
        {
            get;
            set;
        }
    }
}