
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRequestMCPServerURLDefinition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_token")]
        public string? AuthorizationToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configuration")]
        public global::Anthropic.BetaRequestMCPServerToolConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaRequestMCPServerURLDefinitionTypeJsonConverter))]
        public global::Anthropic.BetaRequestMCPServerURLDefinitionType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPServerURLDefinition" /> class.
        /// </summary>
        /// <param name="authorizationToken"></param>
        /// <param name="name"></param>
        /// <param name="toolConfiguration"></param>
        /// <param name="type"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRequestMCPServerURLDefinition(
            string name,
            string url,
            string? authorizationToken,
            global::Anthropic.BetaRequestMCPServerToolConfiguration? toolConfiguration,
            global::Anthropic.BetaRequestMCPServerURLDefinitionType type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AuthorizationToken = authorizationToken;
            this.ToolConfiguration = toolConfiguration;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRequestMCPServerURLDefinition" /> class.
        /// </summary>
        public BetaRequestMCPServerURLDefinition()
        {
        }
    }
}