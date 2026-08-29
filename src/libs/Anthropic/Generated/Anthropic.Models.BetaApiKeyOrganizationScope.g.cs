
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaApiKeyOrganizationScope
    {
        /// <summary>
        /// Scope type. Always `"organization"`: the API key has no Workspace. Only a principal-bound API key can have this scope.<br/>
        /// Default Value: organization
        /// </summary>
        /// <default>"organization"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "organization";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyOrganizationScope" /> class.
        /// </summary>
        /// <param name="type">
        /// Scope type. Always `"organization"`: the API key has no Workspace. Only a principal-bound API key can have this scope.<br/>
        /// Default Value: organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaApiKeyOrganizationScope(
            string type = "organization")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaApiKeyOrganizationScope" /> class.
        /// </summary>
        public BetaApiKeyOrganizationScope()
        {
        }

    }
}