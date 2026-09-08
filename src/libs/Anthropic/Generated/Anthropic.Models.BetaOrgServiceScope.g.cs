
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaOrgServiceScope
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Service { get; set; }

        /// <summary>
        /// Default Value: organization_service
        /// </summary>
        /// <default>"organization_service"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "organization_service";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrgServiceScope" /> class.
        /// </summary>
        /// <param name="service"></param>
        /// <param name="type">
        /// Default Value: organization_service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrgServiceScope(
            string service,
            string type = "organization_service")
        {
            this.Service = service ?? throw new global::System.ArgumentNullException(nameof(service));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrgServiceScope" /> class.
        /// </summary>
        public BetaOrgServiceScope()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaOrgServiceScope"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaOrgServiceScope FromService(string service)
        {
            return new BetaOrgServiceScope
            {
                Service = service,
            };
        }

    }
}