
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Public API request to update an environment (without org/account fields).<br/>
    /// Example: {"description":"Python environment with data-analysis packages."}
    /// </summary>
    public sealed partial class BetaPublicEnvironmentUpdateRequest
    {
        /// <summary>
        /// Updated environment configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        public global::Anthropic.ConfigVariant12? Config { get; set; }

        /// <summary>
        /// Updated description of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// User-provided metadata key-value pairs. Set a value to null or empty string to delete the key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Updated name for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicEnvironmentUpdateRequest" /> class.
        /// </summary>
        /// <param name="config">
        /// Updated environment configuration
        /// </param>
        /// <param name="description">
        /// Updated description of the environment
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata key-value pairs. Set a value to null or empty string to delete the key.
        /// </param>
        /// <param name="name">
        /// Updated name for the environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPublicEnvironmentUpdateRequest(
            global::Anthropic.ConfigVariant12? config,
            string? description,
            object? metadata,
            string? name)
        {
            this.Config = config;
            this.Description = description;
            this.Metadata = metadata;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPublicEnvironmentUpdateRequest" /> class.
        /// </summary>
        public BetaPublicEnvironmentUpdateRequest()
        {
        }
    }
}