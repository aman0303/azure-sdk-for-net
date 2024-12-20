// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.IndustryPlatform.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableIndustryPlatformSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _industryServicesResourceIndustryServicesClientDiagnostics;
        private IndustryServicesRestOperations _industryServicesResourceIndustryServicesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableIndustryPlatformSubscriptionResource"/> class for mocking. </summary>
        protected MockableIndustryPlatformSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableIndustryPlatformSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableIndustryPlatformSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics IndustryServicesResourceIndustryServicesClientDiagnostics => _industryServicesResourceIndustryServicesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.IndustryPlatform", IndustryServicesResource.ResourceType.Namespace, Diagnostics);
        private IndustryServicesRestOperations IndustryServicesResourceIndustryServicesRestClient => _industryServicesResourceIndustryServicesRestClient ??= new IndustryServicesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(IndustryServicesResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
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
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IndustryServicesResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IndustryServicesResource> GetIndustryServicesResourcesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IndustryServicesResourceIndustryServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IndustryServicesResourceIndustryServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IndustryServicesResource(Client, IndustryServicesResourceData.DeserializeIndustryServicesResourceData(e)), IndustryServicesResourceIndustryServicesClientDiagnostics, Pipeline, "MockableIndustryPlatformSubscriptionResource.GetIndustryServicesResources", "value", "nextLink", cancellationToken);
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
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IndustryServicesResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IndustryServicesResource> GetIndustryServicesResources(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => IndustryServicesResourceIndustryServicesRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => IndustryServicesResourceIndustryServicesRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IndustryServicesResource(Client, IndustryServicesResourceData.DeserializeIndustryServicesResourceData(e)), IndustryServicesResourceIndustryServicesClientDiagnostics, Pipeline, "MockableIndustryPlatformSubscriptionResource.GetIndustryServicesResources", "value", "nextLink", cancellationToken);
        }
    }
}
