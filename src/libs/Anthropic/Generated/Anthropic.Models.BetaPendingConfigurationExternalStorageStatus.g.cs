
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The storage isn't verified yet.
    /// </summary>
    public sealed partial class BetaPendingConfigurationExternalStorageStatus
    {
        /// <summary>
        /// Default Value: pending_configuration
        /// </summary>
        /// <default>"pending_configuration"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "pending_configuration";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPendingConfigurationExternalStorageStatus" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: pending_configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPendingConfigurationExternalStorageStatus(
            string type = "pending_configuration")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPendingConfigurationExternalStorageStatus" /> class.
        /// </summary>
        public BetaPendingConfigurationExternalStorageStatus()
        {
        }

    }
}