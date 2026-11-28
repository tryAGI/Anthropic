
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// At least one Workspace has the storage attached.
    /// </summary>
    public sealed partial class BetaActiveExternalStorageStatus
    {
        /// <summary>
        /// Whether the bucket passed its latest recorded check. It can stay `true` after the bucket stops working, so don't use it for monitoring.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Healthy { get; set; }

        /// <summary>
        /// When the bucket's latest recorded check ran, in RFC 3339.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_checked_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime LastCheckedAt { get; set; }

        /// <summary>
        /// Default Value: active
        /// </summary>
        /// <default>"active"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "active";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaActiveExternalStorageStatus" /> class.
        /// </summary>
        /// <param name="healthy">
        /// Whether the bucket passed its latest recorded check. It can stay `true` after the bucket stops working, so don't use it for monitoring.
        /// </param>
        /// <param name="lastCheckedAt">
        /// When the bucket's latest recorded check ran, in RFC 3339.
        /// </param>
        /// <param name="type">
        /// Default Value: active
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaActiveExternalStorageStatus(
            bool healthy,
            global::System.DateTime lastCheckedAt,
            string type = "active")
        {
            this.Healthy = healthy;
            this.LastCheckedAt = lastCheckedAt;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaActiveExternalStorageStatus" /> class.
        /// </summary>
        public BetaActiveExternalStorageStatus()
        {
        }

    }
}