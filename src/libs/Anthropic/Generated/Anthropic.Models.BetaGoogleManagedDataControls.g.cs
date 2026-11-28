
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A user profile's encryption key and storage bucket settings for Claude on Google Cloud's Agent Platform. Every user profile has one of these objects. You can read and update it, but not create or delete it. Keys and buckets are set for each region. A request's region depends on the Google endpoint it is sent to: `us` is the US multi-region endpoint and the regional endpoint of every location whose name starts with `us-`, `eu` is the EU multi-region endpoint and the regional endpoint of every location whose name starts with `europe-`, `sg` is the `asia-southeast1` regional endpoint, and `global` is the global endpoint, wherever Google serves the request. Anthropic may add regions.<br/>
    /// Example: {"type":"google_managed_data_controls","user_profile_id":"uprof_011CZkZCu8hGbp5mYRQgUmz9","bucket_label_value":"2f6d8c3a-91b4-4e57-8a0c-d5e1f7b3a924","updated_at":"2026-08-30T09:14:03Z","cmek":{"type":"disabled","retired_keys":[{"external_key_id":"ekey_01SDCCSbTxrXDpWc1phhtcfK","region":"us","expires_at":"2026-09-29T09:14:03Z"}]},"storage":{"type":"disabled","retired_buckets":[]}}
    /// </summary>
    public sealed partial class BetaGoogleManagedDataControls
    {
        /// <summary>
        /// Object type. Always `google_managed_data_controls`.
        /// </summary>
        /// <default>"google_managed_data_controls"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "google_managed_data_controls";

        /// <summary>
        /// The ID of the user profile that these controls belong to (`uprof_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_profile_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserProfileId { get; set; }

        /// <summary>
        /// The customer-managed encryption key control: the key in the end customer's Google Cloud KMS that is set for each region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedCmekControlJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaGoogleManagedCmekControl Cmek { get; set; }

        /// <summary>
        /// When an update last changed a control, or a region's status last changed, in RFC 3339 format. A region that starts or stops reading `suspended`, a change to `last_checked_at` alone, and the removal of a retired entry do not count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// The customer-owned storage control: the end customer's Cloud Storage bucket that is set for each region.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedStorageControlJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaGoogleManagedStorageControl Storage { get; set; }

        /// <summary>
        /// The label value that every bucket set up for this profile must have. It never changes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_label_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BucketLabelValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedDataControls" /> class.
        /// </summary>
        /// <param name="userProfileId">
        /// The ID of the user profile that these controls belong to (`uprof_...`).
        /// </param>
        /// <param name="cmek">
        /// The customer-managed encryption key control: the key in the end customer's Google Cloud KMS that is set for each region.
        /// </param>
        /// <param name="updatedAt">
        /// When an update last changed a control, or a region's status last changed, in RFC 3339 format. A region that starts or stops reading `suspended`, a change to `last_checked_at` alone, and the removal of a retired entry do not count.
        /// </param>
        /// <param name="storage">
        /// The customer-owned storage control: the end customer's Cloud Storage bucket that is set for each region.
        /// </param>
        /// <param name="bucketLabelValue">
        /// The label value that every bucket set up for this profile must have. It never changes.
        /// </param>
        /// <param name="type">
        /// Object type. Always `google_managed_data_controls`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedDataControls(
            string userProfileId,
            global::Anthropic.BetaGoogleManagedCmekControl cmek,
            global::System.DateTime updatedAt,
            global::Anthropic.BetaGoogleManagedStorageControl storage,
            string bucketLabelValue,
            string type = "google_managed_data_controls")
        {
            this.Type = type;
            this.UserProfileId = userProfileId ?? throw new global::System.ArgumentNullException(nameof(userProfileId));
            this.Cmek = cmek;
            this.UpdatedAt = updatedAt;
            this.Storage = storage;
            this.BucketLabelValue = bucketLabelValue ?? throw new global::System.ArgumentNullException(nameof(bucketLabelValue));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedDataControls" /> class.
        /// </summary>
        public BetaGoogleManagedDataControls()
        {
        }

    }
}