
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Where in the outbound request the secret value may be substituted.
    /// </summary>
    public sealed partial class BetaManagedAgentsInjectionLocationParams
    {
        /// <summary>
        /// Substitute when the placeholder appears in a request header value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header")]
        public bool? Header { get; set; }

        /// <summary>
        /// Substitute when the placeholder appears in the request body.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public bool? Body { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationParams" /> class.
        /// </summary>
        /// <param name="header">
        /// Substitute when the placeholder appears in a request header value.
        /// </param>
        /// <param name="body">
        /// Substitute when the placeholder appears in the request body.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsInjectionLocationParams(
            bool? header,
            bool? body)
        {
            this.Header = header;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationParams" /> class.
        /// </summary>
        public BetaManagedAgentsInjectionLocationParams()
        {
        }

    }
}