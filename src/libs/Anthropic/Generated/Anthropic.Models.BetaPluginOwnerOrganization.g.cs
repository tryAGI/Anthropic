
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginOwnerOrganization
    {
        /// <summary>
        /// The Plugin lives in a plugin marketplace the organization owns.<br/>
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
        /// Initializes a new instance of the <see cref="BetaPluginOwnerOrganization" /> class.
        /// </summary>
        /// <param name="type">
        /// The Plugin lives in a plugin marketplace the organization owns.<br/>
        /// Default Value: organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginOwnerOrganization(
            string type = "organization")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginOwnerOrganization" /> class.
        /// </summary>
        public BetaPluginOwnerOrganization()
        {
        }

    }
}