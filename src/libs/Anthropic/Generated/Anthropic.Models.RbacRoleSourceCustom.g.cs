
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RbacRoleSourceCustom
    {
        /// <summary>
        /// The organization's administrators can change and delete the RBAC Role.<br/>
        /// Default Value: custom
        /// </summary>
        /// <default>"custom"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "custom";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacRoleSourceCustom" /> class.
        /// </summary>
        /// <param name="type">
        /// The organization's administrators can change and delete the RBAC Role.<br/>
        /// Default Value: custom
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RbacRoleSourceCustom(
            string type = "custom")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RbacRoleSourceCustom" /> class.
        /// </summary>
        public RbacRoleSourceCustom()
        {
        }

    }
}