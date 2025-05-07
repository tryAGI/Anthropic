
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaSignatureContentBlockDelta
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Default Value: signature_delta
        /// </summary>
        /// <default>global::Anthropic.BetaSignatureContentBlockDeltaType.SignatureDelta</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSignatureContentBlockDeltaTypeJsonConverter))]
        public global::Anthropic.BetaSignatureContentBlockDeltaType Type { get; set; } = global::Anthropic.BetaSignatureContentBlockDeltaType.SignatureDelta;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSignatureContentBlockDelta" /> class.
        /// </summary>
        /// <param name="signature"></param>
        /// <param name="type">
        /// Default Value: signature_delta
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSignatureContentBlockDelta(
            string signature,
            global::Anthropic.BetaSignatureContentBlockDeltaType type = global::Anthropic.BetaSignatureContentBlockDeltaType.SignatureDelta)
        {
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSignatureContentBlockDelta" /> class.
        /// </summary>
        public BetaSignatureContentBlockDelta()
        {
        }
    }
}