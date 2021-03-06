// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Specification for using a virtual network
    /// </summary>
    public partial class VirtualNetworkProfile
    {
        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        public VirtualNetworkProfile() { }

        /// <summary>
        /// Initializes a new instance of the VirtualNetworkProfile class.
        /// </summary>
        public VirtualNetworkProfile(string id = default(string), string name = default(string), string type = default(string), string subnet = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Subnet = subnet;
        }

        /// <summary>
        /// Resource id of the virtual network
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the virtual network (read-only)
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Resource type of the virtual network (read-only)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Subnet within the virtual network
        /// </summary>
        [JsonProperty(PropertyName = "subnet")]
        public string Subnet { get; set; }

    }
}
