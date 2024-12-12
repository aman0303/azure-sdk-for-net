// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.IndustryPlatform.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.IndustryPlatform
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.IndustryPlatform. </summary>
    public static partial class IndustryPlatformExtensions
    {
        private static MockableIndustryPlatformArmClient GetMockableIndustryPlatformArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableIndustryPlatformArmClient(client0));
        }

        private static MockableIndustryPlatformResourceGroupResource GetMockableIndustryPlatformResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIndustryPlatformResourceGroupResource(client, resource.Id));
        }

        private static MockableIndustryPlatformSubscriptionResource GetMockableIndustryPlatformSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableIndustryPlatformSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="IndustryServicesResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IndustryServicesResource.CreateResourceIdentifier" /> to create an <see cref="IndustryServicesResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformArmClient.GetIndustryServicesResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="IndustryServicesResource"/> object. </returns>
        public static IndustryServicesResource GetIndustryServicesResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableIndustryPlatformArmClient(client).GetIndustryServicesResource(id);
        }

        /// <summary>
        /// Gets a collection of IndustryServicesResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformResourceGroupResource.GetIndustryServicesResources()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of IndustryServicesResources and their operations over a IndustryServicesResource. </returns>
        public static IndustryServicesResourceCollection GetIndustryServicesResources(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableIndustryPlatformResourceGroupResource(resourceGroupResource).GetIndustryServicesResources();
        }

        /// <summary>
        /// Get a IndustryServicesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IndustryPlatform/industryServices/{industryServiceResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IndustryServicesResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IndustryServicesResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformResourceGroupResource.GetIndustryServicesResourceAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="industryServiceResourceName"> The name of the IndustryService Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="industryServiceResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="industryServiceResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<IndustryServicesResource>> GetIndustryServicesResourceAsync(this ResourceGroupResource resourceGroupResource, string industryServiceResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableIndustryPlatformResourceGroupResource(resourceGroupResource).GetIndustryServicesResourceAsync(industryServiceResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a IndustryServicesResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IndustryPlatform/industryServices/{industryServiceResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IndustryServicesResource_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IndustryServicesResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformResourceGroupResource.GetIndustryServicesResource(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="industryServiceResourceName"> The name of the IndustryService Resource Name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="industryServiceResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="industryServiceResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<IndustryServicesResource> GetIndustryServicesResource(this ResourceGroupResource resourceGroupResource, string industryServiceResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableIndustryPlatformResourceGroupResource(resourceGroupResource).GetIndustryServicesResource(industryServiceResourceName, cancellationToken);
        }

        /// <summary>
        /// List IndustryServicesResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IndustryPlatform/industryServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IndustryServicesResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IndustryServicesResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformSubscriptionResource.GetIndustryServicesResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="IndustryServicesResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<IndustryServicesResource> GetIndustryServicesResourcesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableIndustryPlatformSubscriptionResource(subscriptionResource).GetIndustryServicesResourcesAsync(cancellationToken);
        }

        /// <summary>
        /// List IndustryServicesResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.IndustryPlatform/industryServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IndustryServicesResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-10-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="IndustryServicesResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableIndustryPlatformSubscriptionResource.GetIndustryServicesResources(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="IndustryServicesResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<IndustryServicesResource> GetIndustryServicesResources(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableIndustryPlatformSubscriptionResource(subscriptionResource).GetIndustryServicesResources(cancellationToken);
        }
    }
}
