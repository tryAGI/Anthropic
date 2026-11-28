
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaRbacRoleSourceBuiltIn
    {
        /// <summary>
        /// Anthropic provisions the RBAC Role, and the organization's administrators cannot change or delete it.<br/>
        /// Default Value: built_in
        /// </summary>
        /// <default>"built_in"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "built_in";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacRoleSourceBuiltIn" /> class.
        /// </summary>
        /// <param name="type">
        /// Anthropic provisions the RBAC Role, and the organization's administrators cannot change or delete it.<br/>
        /// Default Value: built_in
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaRbacRoleSourceBuiltIn(
            string type = "built_in")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRbacRoleSourceBuiltIn" /> class.
        /// </summary>
        public BetaRbacRoleSourceBuiltIn()
        {
        }

    }
}