// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.IndustryPlatform.Tests
{
    public class IndustryServicesResourceCollectionTest : IndustryPlatformManagementTestBase
    {
        public IndustryServicesResourceCollectionTest(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        public IndustryServicesResourceCollectionTest(bool isAsync)
            : base(isAsync)
        {
        }

        [TestCase]
        [RecordedTest]
        public async Task CreateOrUpdate()
        {
            var subscription = await Client.GetDefaultSubscriptionAsync();
            var rg = await CreateResourceGroup(subscription, "testRg", AzureLocation.SwedenCentral);
            var resourceName = Recording.GenerateAssetName("resource");
            var resource = await rg.GetIndustryServicesResources().CreateOrUpdateAsync(WaitUntil.Completed, resourceName, new IndustryServicesResourceData()
            {
                Sku = new Models.IndustryPlatformSku()
                {
                    Name = "Standard_S1"
                },
                Location = AzureLocation.SwedenCentral,
                Properties = new Models.IndustryServicesResourceProperties()
                {
                    AadApplicationId = "551cc538-4221-47c5-be31-927e787ed898",
                    Version = "1.0.0"
                },
                Identity = new ResourceManager.Models.ManagedServiceIdentity(ResourceManager.Models.ManagedServiceIdentityType.None)
                {}
            });
        }
    }
}
