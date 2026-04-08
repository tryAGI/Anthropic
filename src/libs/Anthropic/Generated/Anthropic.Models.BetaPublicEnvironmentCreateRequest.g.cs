
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Public API request to create a new environment (without org/account fields).<br/>
    /// Example: {"name":"python-data-analysis","description":"Python environment with data-analysis packages.","config":{"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true},"packages":{"pip":["pandas","numpy"]}}}
    /// </summary>
    public sealed partial class BetaPublicEnvironmentCreateRequest
    {
        /// <summary>
        /// Environment configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Anthropic.ConfigVariant1? Config { get; set; }

        /// <summary>
        /// Optional description of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User-provided metadata key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Human-readable name for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicEnvironmentCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Human-readable name for the environment
        /// </param>
        /// <param name="config">
        /// Environment configuration
        /// </param>
        /// <param name="description">
        /// Optional description of the environment
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata key-value pairs
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPublicEnvironmentCreateRequest(
            string name,
            global::Anthropic.ConfigVariant1? config,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Config = config;
            this.Description = description;
            this.Metadata = metadata;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicEnvironmentCreateRequest" /> class.
        /// </summary>
        public BetaPublicEnvironmentCreateRequest()
        {
        }
    }
}