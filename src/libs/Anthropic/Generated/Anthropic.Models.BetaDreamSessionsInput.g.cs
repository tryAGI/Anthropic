
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The sessions that a dream reads, given as an entry in `inputs`.
    /// </summary>
    public sealed partial class BetaDreamSessionsInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaDreamSessionsInputTypeJsonConverter))]
        public global::Anthropic.BetaDreamSessionsInputType Type { get; set; }

        /// <summary>
        /// The IDs of the sessions whose transcripts the dream reads (`sesn_...`).<br/>
        /// Give 1 to 100 IDs, with no duplicates. Each session must be in the same workspace as the dream. Responses list the IDs in sorted order.<br/>
        /// The [limits table in the Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#limits) lists all the limits on a dream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> SessionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamSessionsInput" /> class.
        /// </summary>
        /// <param name="sessionIds">
        /// The IDs of the sessions whose transcripts the dream reads (`sesn_...`).<br/>
        /// Give 1 to 100 IDs, with no duplicates. Each session must be in the same workspace as the dream. Responses list the IDs in sorted order.<br/>
        /// The [limits table in the Dreams guide](https://platform.claude.com/docs/en/managed-agents/dreams#limits) lists all the limits on a dream.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDreamSessionsInput(
            global::System.Collections.Generic.IList<string> sessionIds,
            global::Anthropic.BetaDreamSessionsInputType type)
        {
            this.Type = type;
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDreamSessionsInput" /> class.
        /// </summary>
        public BetaDreamSessionsInput()
        {
        }

    }
}