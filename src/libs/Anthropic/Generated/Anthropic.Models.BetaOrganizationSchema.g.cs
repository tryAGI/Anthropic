
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrganizationSchema
    {
        /// <summary>
        /// ID of the Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Name of the Organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Object type.<br/>
        /// For Organizations, this is always `"organization"`.<br/>
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
        /// Initializes a new instance of the <see cref="BetaOrganizationSchema" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the Organization.
        /// </param>
        /// <param name="name">
        /// Name of the Organization.
        /// </param>
        /// <param name="type">
        /// Object type.<br/>
        /// For Organizations, this is always `"organization"`.<br/>
        /// Default Value: organization
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationSchema(
            global::System.Guid id,
            string name,
            string type = "organization")
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationSchema" /> class.
        /// </summary>
        public BetaOrganizationSchema()
        {
        }

    }
}