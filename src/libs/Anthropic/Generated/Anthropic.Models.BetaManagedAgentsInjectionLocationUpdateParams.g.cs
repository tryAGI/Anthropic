
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Changes which parts of an outbound request the secret is substituted into. A location you leave out keeps its current setting.<br/>
    /// After the change, at least one location must be enabled.<br/>
    /// See [Authenticate with vaults](https://platform.claude.com/docs/en/managed-agents/vaults#add-a-credential) to learn more about injection locations.
    /// </summary>
    public sealed partial class BetaManagedAgentsInjectionLocationUpdateParams
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
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationUpdateParams" /> class.
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
        public BetaManagedAgentsInjectionLocationUpdateParams(
            bool? header,
            bool? body)
        {
            this.Header = header;
            this.Body = body;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsInjectionLocationUpdateParams" /> class.
        /// </summary>
        public BetaManagedAgentsInjectionLocationUpdateParams()
        {
        }

    }
}