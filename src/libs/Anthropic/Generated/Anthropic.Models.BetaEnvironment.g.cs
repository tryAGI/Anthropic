
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Unified Environment resource for both cloud and BYOC environments.<br/>
    /// Example: {"type":"environment","id":"env_011CZkZ9X2dpNyB7HsEFoRfW","name":"python-data-analysis","description":"Python environment with data-analysis packages.","config":{"type":"cloud","networking":{"type":"limited","allowed_hosts":["api.example.com"],"allow_package_managers":true,"allow_mcp_servers":false},"packages":{"type":"packages","pip":["pandas","numpy"],"npm":[],"apt":[],"cargo":[],"gem":[],"go":[]}},"metadata":{},"archived_at":null,"created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
    /// </summary>
    public sealed partial class BetaEnvironment
    {
        /// <summary>
        /// RFC 3339 timestamp when environment was archived, or null if not archived
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public string? ArchivedAt { get; set; }

        /// <summary>
        /// Environment configuration (either Anthropic Cloud or BYOC)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaCloudConfig Config { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when environment was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CreatedAt { get; set; }

        /// <summary>
        /// User-provided description for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Environment identifier (e.g., 'env_...')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// User-provided metadata key-value pairs
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Human-readable name for the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The type of object (always 'environment')<br/>
        /// Default Value: environment
        /// </summary>
        /// <default>"environment"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "environment";

        /// <summary>
        /// RFC 3339 timestamp when environment was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironment" /> class.
        /// </summary>
        /// <param name="config">
        /// Environment configuration (either Anthropic Cloud or BYOC)
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 timestamp when environment was created
        /// </param>
        /// <param name="description">
        /// User-provided description for the environment
        /// </param>
        /// <param name="id">
        /// Environment identifier (e.g., 'env_...')
        /// </param>
        /// <param name="metadata">
        /// User-provided metadata key-value pairs
        /// </param>
        /// <param name="name">
        /// Human-readable name for the environment
        /// </param>
        /// <param name="updatedAt">
        /// RFC 3339 timestamp when environment was last updated
        /// </param>
        /// <param name="archivedAt">
        /// RFC 3339 timestamp when environment was archived, or null if not archived
        /// </param>
        /// <param name="type">
        /// The type of object (always 'environment')<br/>
        /// Default Value: environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnvironment(
            global::Anthropic.BetaCloudConfig config,
            string createdAt,
            string description,
            string id,
            global::System.Collections.Generic.Dictionary<string, string> metadata,
            string name,
            string updatedAt,
            string? archivedAt,
            string type = "environment")
        {
            this.ArchivedAt = archivedAt;
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type;
            this.UpdatedAt = updatedAt ?? throw new global::System.ArgumentNullException(nameof(updatedAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironment" /> class.
        /// </summary>
        public BetaEnvironment()
        {
        }
    }
}