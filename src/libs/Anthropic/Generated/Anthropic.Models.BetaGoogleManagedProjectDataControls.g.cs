
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Google Cloud project's encryption key and storage bucket settings for Claude on Google Cloud's Agent Platform. Your organization has one of these objects for each Google Cloud project that it has proved it owns. You can read and update it, but not create or delete it. Keys and buckets are set for each region. A request's region depends on the Google endpoint it is sent to: `us` is the US multi-region endpoint and the regional endpoint of every location whose name starts with `us-`, `eu` is the EU multi-region endpoint and the regional endpoint of every location whose name starts with `europe-`, `sg` is the `asia-southeast1` regional endpoint, and `global` is the global endpoint, wherever Google serves the request. Anthropic may add regions.
    /// </summary>
    public sealed partial class BetaGoogleManagedProjectDataControls
    {
        /// <summary>
        /// The customer-managed encryption key control: the key in your Google Cloud KMS that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no key of its own for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.CmekJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Cmek Cmek { get; set; }

        /// <summary>
        /// The number of the Google Cloud project that these controls belong to, in decimal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectNumber { get; set; }

        /// <summary>
        /// The customer-owned storage control: your Cloud Storage bucket that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no bucket of its own for the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.StorageJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Storage Storage { get; set; }

        /// <summary>
        /// Object type. Always `google_managed_project_data_controls`.<br/>
        /// Default Value: google_managed_project_data_controls
        /// </summary>
        /// <default>"google_managed_project_data_controls"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "google_managed_project_data_controls";

        /// <summary>
        /// When an update last changed a control, or a region's status last changed, in RFC 3339 format. A region that starts or stops reading `suspended`, a change to `last_checked_at` alone, and the removal of a retired entry do not count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedProjectDataControls" /> class.
        /// </summary>
        /// <param name="cmek">
        /// The customer-managed encryption key control: the key in your Google Cloud KMS that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no key of its own for the project.
        /// </param>
        /// <param name="projectNumber">
        /// The number of the Google Cloud project that these controls belong to, in decimal.
        /// </param>
        /// <param name="storage">
        /// The customer-owned storage control: your Cloud Storage bucket that is set for each region. It covers the project's requests that name no user profile, or a user profile that has no bucket of its own for the project.
        /// </param>
        /// <param name="updatedAt">
        /// When an update last changed a control, or a region's status last changed, in RFC 3339 format. A region that starts or stops reading `suspended`, a change to `last_checked_at` alone, and the removal of a retired entry do not count.
        /// </param>
        /// <param name="type">
        /// Object type. Always `google_managed_project_data_controls`.<br/>
        /// Default Value: google_managed_project_data_controls
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedProjectDataControls(
            global::Anthropic.Cmek cmek,
            string projectNumber,
            global::Anthropic.Storage storage,
            global::System.DateTime updatedAt,
            string type = "google_managed_project_data_controls")
        {
            this.Cmek = cmek;
            this.ProjectNumber = projectNumber ?? throw new global::System.ArgumentNullException(nameof(projectNumber));
            this.Storage = storage;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedProjectDataControls" /> class.
        /// </summary>
        public BetaGoogleManagedProjectDataControls()
        {
        }

    }
}