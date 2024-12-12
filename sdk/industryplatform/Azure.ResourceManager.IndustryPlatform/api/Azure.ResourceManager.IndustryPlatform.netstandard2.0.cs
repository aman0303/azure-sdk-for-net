namespace Azure.ResourceManager.IndustryPlatform
{
    public static partial class IndustryPlatformExtensions
    {
        public static Azure.ResourceManager.IndustryPlatform.IndustryServicesResource GetIndustryServicesResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResource(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> GetIndustryServicesResourceAsync(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource, string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceCollection GetIndustryServicesResources(this Azure.ResourceManager.Resources.ResourceGroupResource resourceGroupResource) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResources(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResourcesAsync(this Azure.ResourceManager.Resources.SubscriptionResource subscriptionResource, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IndustryServicesResource : Azure.ResourceManager.ArmResource, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected IndustryServicesResource() { }
        public virtual Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string industryServiceResourceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IndustryServicesResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>, System.Collections.IEnumerable
    {
        protected IndustryServicesResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string industryServiceResourceName, Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string industryServiceResourceName, Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> Get(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> GetAsync(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.NullableResponse<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIfExists(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.NullableResponse<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> GetIfExistsAsync(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class IndustryServicesResourceData : Azure.ResourceManager.Models.TrackedResourceData, System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>
    {
        public IndustryServicesResourceData(Azure.Core.AzureLocation location) { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties Properties { get { throw null; } set { } }
        public Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku Sku { get { throw null; } set { } }
        protected override void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
}
namespace Azure.ResourceManager.IndustryPlatform.Mocking
{
    public partial class MockableIndustryPlatformArmClient : Azure.ResourceManager.ArmResource
    {
        protected MockableIndustryPlatformArmClient() { }
        public virtual Azure.ResourceManager.IndustryPlatform.IndustryServicesResource GetIndustryServicesResource(Azure.Core.ResourceIdentifier id) { throw null; }
    }
    public partial class MockableIndustryPlatformResourceGroupResource : Azure.ResourceManager.ArmResource
    {
        protected MockableIndustryPlatformResourceGroupResource() { }
        public virtual Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResource(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource>> GetIndustryServicesResourceAsync(string industryServiceResourceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceCollection GetIndustryServicesResources() { throw null; }
    }
    public partial class MockableIndustryPlatformSubscriptionResource : Azure.ResourceManager.ArmResource
    {
        protected MockableIndustryPlatformSubscriptionResource() { }
        public virtual Azure.Pageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.IndustryPlatform.IndustryServicesResource> GetIndustryServicesResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.IndustryPlatform.Models
{
    public static partial class ArmIndustryPlatformModelFactory
    {
        public static Azure.ResourceManager.IndustryPlatform.IndustryServicesResourceData IndustryServicesResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, System.Collections.Generic.IDictionary<string, string> tags = null, Azure.Core.AzureLocation location = default(Azure.Core.AzureLocation), Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties properties = null, Azure.ResourceManager.Models.ManagedServiceIdentity identity = null, Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku sku = null) { throw null; }
        public static Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties IndustryServicesResourceProperties(Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState?), string version = null, string aadApplicationId = null, string serviceUri = null, Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration managedResourceGroupConfiguration = null) { throw null; }
        public static Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration(string name = null, string location = null) { throw null; }
    }
    public partial class IndustryPlatformSku : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>
    {
        public IndustryPlatformSku(string name) { }
        public int? Capacity { get { throw null; } set { } }
        public string Family { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Size { get { throw null; } set { } }
        public Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSkuTier? Tier { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public enum IndustryPlatformSkuTier
    {
        Free = 0,
        Basic = 1,
        Standard = 2,
        Premium = 3,
    }
    public partial class IndustryServicesResourcePatch : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>
    {
        public IndustryServicesResourcePatch() { }
        public Azure.ResourceManager.Models.ManagedServiceIdentity Identity { get { throw null; } set { } }
        public string IndustryServicesResourceUpdateVersion { get { throw null; } set { } }
        public Azure.ResourceManager.IndustryPlatform.Models.IndustryPlatformSku Sku { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Tags { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourcePatch>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class IndustryServicesResourceProperties : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>
    {
        public IndustryServicesResourceProperties(string aadApplicationId) { }
        public string AadApplicationId { get { throw null; } set { } }
        public Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get { throw null; } }
        public Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ServiceUri { get { throw null; } }
        public string Version { get { throw null; } set { } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.IndustryServicesResourceProperties>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    public partial class ManagedResourceGroupConfiguration : System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>, System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>
    {
        internal ManagedResourceGroupConfiguration() { }
        public string Location { get { throw null; } }
        public string Name { get { throw null; } }
        protected virtual void JsonModelWriteCore(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>.Create(ref System.Text.Json.Utf8JsonReader reader, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        void System.ClientModel.Primitives.IJsonModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>.Write(System.Text.Json.Utf8JsonWriter writer, System.ClientModel.Primitives.ModelReaderWriterOptions options) { }
        Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>.Create(System.BinaryData data, System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        string System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>.GetFormatFromOptions(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
        System.BinaryData System.ClientModel.Primitives.IPersistableModel<Azure.ResourceManager.IndustryPlatform.Models.ManagedResourceGroupConfiguration>.Write(System.ClientModel.Primitives.ModelReaderWriterOptions options) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Accepted { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Provisioning { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState left, Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState left, Azure.ResourceManager.IndustryPlatform.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
}
