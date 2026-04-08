
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Parameters for updating a static bearer token credential. The `mcp_server_url` is immutable.
    /// </summary>
    public sealed partial class BetaManagedAgentsStaticBearerUpdateParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsStaticBearerUpdateParamsTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParamsType Type { get; set; }

        /// <summary>
        /// Updated static bearer token value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerUpdateParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="token">
        /// Updated static bearer token value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsStaticBearerUpdateParams(
            global::Anthropic.BetaManagedAgentsStaticBearerUpdateParamsType type,
            string? token)
        {
            this.Type = type;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsStaticBearerUpdateParams" /> class.
        /// </summary>
        public BetaManagedAgentsStaticBearerUpdateParams()
        {
        }
    }
}