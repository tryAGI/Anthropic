
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A named set of access that Claude can use in a Slack channel or a Slack workspace: connectors, repositories and credentials. Created and edited in claude.ai.
    /// </summary>
    public sealed partial class BetaClaudeTagBundle
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"bundle"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bundle";

        /// <summary>
        /// The Bundle's identifier. Starts with `capp_`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Bundle's name. Always set. Read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// What the Bundle is for. Null when it has none. Read-only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Time the Bundle was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time of the last change to the Bundle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagBundle" /> class.
        /// </summary>
        /// <param name="id">
        /// The Bundle's identifier. Starts with `capp_`.
        /// </param>
        /// <param name="displayName">
        /// The Bundle's name. Always set. Read-only.
        /// </param>
        /// <param name="createdAt">
        /// Time the Bundle was created.
        /// </param>
        /// <param name="updatedAt">
        /// Time of the last change to the Bundle.
        /// </param>
        /// <param name="description">
        /// What the Bundle is for. Null when it has none. Read-only.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagBundle(
            string id,
            string displayName,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string? description,
            string type = "bundle")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagBundle" /> class.
        /// </summary>
        public BetaClaudeTagBundle()
        {
        }

    }
}