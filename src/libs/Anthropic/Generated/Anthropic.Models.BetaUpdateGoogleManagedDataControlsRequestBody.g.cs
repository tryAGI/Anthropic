
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Example: {"cmek":{"type":"enabled","external_key_ids":{"us":"ekey_01SDCCSbTxrXDpWc1phhtcfK"}}}
    /// </summary>
    public sealed partial class BetaUpdateGoogleManagedDataControlsRequestBody
    {
        /// <summary>
        /// The customer-managed encryption key control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cmek")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedCmekControlParamsJsonConverter))]
        public global::Anthropic.BetaGoogleManagedCmekControlParams? Cmek { get; set; }

        /// <summary>
        /// The customer-owned storage control. Leave it out to keep the control as it is. Send `cmek`, `storage`, or both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaGoogleManagedStorageControlParamsJsonConverter))]
        public global::Anthropic.BetaGoogleManagedStorageControlParams? Storage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateGoogleManagedDataControlsRequestBody" /> class.
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
        public BetaUpdateGoogleManagedDataControlsRequestBody(
            global::Anthropic.BetaGoogleManagedCmekControlParams? cmek,
            global::Anthropic.BetaGoogleManagedStorageControlParams? storage)
        {
            this.Cmek = cmek;
            this.Storage = storage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateGoogleManagedDataControlsRequestBody" /> class.
        /// </summary>
        public BetaUpdateGoogleManagedDataControlsRequestBody()
        {
        }

    }
}