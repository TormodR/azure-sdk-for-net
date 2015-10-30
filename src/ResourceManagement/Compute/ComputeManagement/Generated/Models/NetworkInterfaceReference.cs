// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.13.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Describes a network interface reference.
    /// </summary>
    public partial class NetworkInterfaceReference : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReference class.
        /// </summary>
        public NetworkInterfaceReference() { }

        /// <summary>
        /// Initializes a new instance of the NetworkInterfaceReference class.
        /// </summary>
        public NetworkInterfaceReference(bool? primary = default(bool?))
        {
            Primary = primary;
        }

        /// <summary>
        /// Gets or sets whether this is a primary NIC on a virtual machine
        /// </summary>
        [JsonProperty(PropertyName = "properties.primary")]
        public bool? Primary { get; set; }

    }
}
