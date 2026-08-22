
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where in the outbound request the secret value is substituted.
    /// </summary>
    public sealed partial class BetaManagedAgentsInjectionLocationResponse
    {
        /// <summary>
        /// Whether the placeholder is substituted in request header values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Header { get; set; }

        /// <summary>
        /// Whether the placeholder is substituted in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationResponse" /> class.
        /// </summary>
        /// <param name="header">
        /// Whether the placeholder is substituted in request header values.
        /// </param>
        /// <param name="body">
        /// Whether the placeholder is substituted in the request body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsInjectionLocationResponse(
            bool header,
            bool body)
        {
            this.Header = header;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationResponse" /> class.
        /// </summary>
        public BetaManagedAgentsInjectionLocationResponse()
        {
        }

    }
}