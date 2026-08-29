
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKeyUpdateParams
    {
        /// <summary>
        /// Name of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Status of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public global::Anthropic.BetaApiKeyUpdateParamsStatus2? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyUpdateParams" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the API key.
        /// </param>
        /// <param name="status">
        /// Status of the API key.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyUpdateParams(
            string? name,
            global::Anthropic.BetaApiKeyUpdateParamsStatus2? status)
        {
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyUpdateParams" /> class.
        /// </summary>
        public BetaApiKeyUpdateParams()
        {
        }

    }
}