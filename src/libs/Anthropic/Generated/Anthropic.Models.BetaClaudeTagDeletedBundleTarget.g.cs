
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirms that a Bundle was detached.
    /// </summary>
    public sealed partial class BetaClaudeTagDeletedBundleTarget
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"bundle_target_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "bundle_target_deleted";

        /// <summary>
        /// The identifier the Bundle Target had.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagDeletedBundleTarget" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier the Bundle Target had.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaClaudeTagDeletedBundleTarget(
            string id,
            string type = "bundle_target_deleted")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaClaudeTagDeletedBundleTarget" /> class.
        /// </summary>
        public BetaClaudeTagDeletedBundleTarget()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaClaudeTagDeletedBundleTarget"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaClaudeTagDeletedBundleTarget FromId(string id)
        {
            return new BetaClaudeTagDeletedBundleTarget
            {
                Id = id,
            };
        }

    }
}