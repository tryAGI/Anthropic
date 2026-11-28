
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// No Workspace has the storage attached. A Workspace can attach it again, unless<br/>
    /// `removal_started` is true.
    /// </summary>
    public sealed partial class BetaDrainingExternalStorageStatus
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
        /// True once a delete has started removing this storage, which can't be undone. It then can't be attached, and another delete finishes the removal.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removal_started")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool RemovalStarted { get; set; }

        /// <summary>
        /// Default Value: draining
        /// </summary>
        /// <default>"draining"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "draining";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDrainingExternalStorageStatus" /> class.
        /// </summary>
        /// <param name="healthy">
        /// Whether the bucket passed its latest recorded check. It can stay `true` after the bucket stops working, so don't use it for monitoring.
        /// </param>
        /// <param name="lastCheckedAt">
        /// When the bucket's latest recorded check ran, in RFC 3339.
        /// </param>
        /// <param name="removalStarted">
        /// True once a delete has started removing this storage, which can't be undone. It then can't be attached, and another delete finishes the removal.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="type">
        /// Default Value: draining
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDrainingExternalStorageStatus(
            bool healthy,
            global::System.DateTime lastCheckedAt,
            bool removalStarted,
            string type = "draining")
        {
            this.Healthy = healthy;
            this.LastCheckedAt = lastCheckedAt;
            this.RemovalStarted = removalStarted;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDrainingExternalStorageStatus" /> class.
        /// </summary>
        public BetaDrainingExternalStorageStatus()
        {
        }

    }
}