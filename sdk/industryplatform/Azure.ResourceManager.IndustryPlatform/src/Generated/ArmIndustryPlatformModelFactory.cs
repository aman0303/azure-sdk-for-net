// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IndustryPlatform.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmIndustryPlatformModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="IndustryPlatform.IndustryServicesResourceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The resource-specific properties for this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. </param>
        /// <param name="sku"> The SKU (Stock Keeping Unit) assigned to this resource. </param>
        /// <returns> A new <see cref="IndustryPlatform.IndustryServicesResourceData"/> instance for mocking. </returns>
        public static IndustryServicesResourceData IndustryServicesResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, IndustryServicesResourceProperties properties = null, ManagedServiceIdentity identity = null, IndustryPlatformSku sku = null)
        {
            tags ??= new Dictionary<string, string>();

            return new IndustryServicesResourceData(
                id,
                name,
                resourceType,
                systemData,
                tags,
                location,
                properties,
                identity,
                sku,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.IndustryServicesResourceProperties"/>. </summary>
        /// <param name="provisioningState"> The status of the last operation. </param>
        /// <param name="version"> IndustryService Resource Version. </param>
        /// <param name="aadApplicationId"> AAD Application Id. </param>
        /// <param name="serviceUri"> Service Url. </param>
        /// <param name="managedResourceGroupConfiguration"> Configuration of the managed resource group associated with the resource. </param>
        /// <returns> A new <see cref="Models.IndustryServicesResourceProperties"/> instance for mocking. </returns>
        public static IndustryServicesResourceProperties IndustryServicesResourceProperties(ProvisioningState? provisioningState = null, string version = null, string aadApplicationId = null, string serviceUri = null, ManagedResourceGroupConfiguration managedResourceGroupConfiguration = null)
        {
            return new IndustryServicesResourceProperties(
                provisioningState,
                version,
                aadApplicationId,
                serviceUri,
                managedResourceGroupConfiguration,
                serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.ManagedResourceGroupConfiguration"/>. </summary>
        /// <param name="name"> The resource group name. </param>
        /// <param name="location"> The resource group location. </param>
        /// <returns> A new <see cref="Models.ManagedResourceGroupConfiguration"/> instance for mocking. </returns>
        public static ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration(string name = null, string location = null)
        {
            return new ManagedResourceGroupConfiguration(name, location, serializedAdditionalRawData: null);
        }
    }
}
