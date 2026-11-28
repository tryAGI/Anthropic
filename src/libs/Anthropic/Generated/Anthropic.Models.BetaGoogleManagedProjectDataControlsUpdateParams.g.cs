
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaGoogleManagedProjectDataControlsUpdateParams
    {
        /// <summary>
        /// The customer-managed encryption key control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Cmek2JsonConverter))]
        public global::Anthropic.Cmek2? Cmek { get; set; }

        /// <summary>
        /// The customer-owned storage control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Storage2JsonConverter))]
        public global::Anthropic.Storage2? Storage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedProjectDataControlsUpdateParams" /> class.
        /// </summary>
        /// <param name="cmek">
        /// The customer-managed encryption key control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </param>
        /// <param name="storage">
        /// The customer-owned storage control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaGoogleManagedProjectDataControlsUpdateParams(
            global::Anthropic.Cmek2? cmek,
            global::Anthropic.Storage2? storage)
        {
            this.Cmek = cmek;
            this.Storage = storage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGoogleManagedProjectDataControlsUpdateParams" /> class.
        /// </summary>
        public BetaGoogleManagedProjectDataControlsUpdateParams()
        {
        }

    }
}