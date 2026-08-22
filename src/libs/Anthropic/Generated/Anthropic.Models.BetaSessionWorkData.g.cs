
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Work data for session work items.<br/>
    /// This resource type is used when work represents a session that needs to be executed<br/>
    /// in a self-hosted environment.
    /// </summary>
    public sealed partial class BetaSessionWorkData
    {
        /// <summary>
        /// Session identifier (e.g., 'session_...')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Type of work data
        /// </summary>
        /// <default>"session"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "session";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSessionWorkData" /> class.
        /// </summary>
        /// <param name="id">
        /// Session identifier (e.g., 'session_...')
        /// </param>
        /// <param name="type">
        /// Type of work data
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSessionWorkData(
            string id,
            string type = "session")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSessionWorkData" /> class.
        /// </summary>
        public BetaSessionWorkData()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaSessionWorkData"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaSessionWorkData FromId(string id)
        {
            return new BetaSessionWorkData
            {
                Id = id,
            };
        }

    }
}