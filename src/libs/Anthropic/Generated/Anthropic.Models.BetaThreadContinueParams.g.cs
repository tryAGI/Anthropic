
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Resume from the response named by ``previous_message_id``.
    /// </summary>
    public sealed partial class BetaThreadContinueParams
    {
        /// <summary>
        /// The `id` of the previous response in this Thread.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_message_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousMessageId { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"continue"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "continue";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadContinueParams" /> class.
        /// </summary>
        /// <param name="previousMessageId">
        /// The `id` of the previous response in this Thread.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThreadContinueParams(
            string previousMessageId,
            string type = "continue")
        {
            this.PreviousMessageId = previousMessageId ?? throw new global::System.ArgumentNullException(nameof(previousMessageId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadContinueParams" /> class.
        /// </summary>
        public BetaThreadContinueParams()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaThreadContinueParams"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaThreadContinueParams FromPreviousMessageId(string previousMessageId)
        {
            return new BetaThreadContinueParams
            {
                PreviousMessageId = previousMessageId,
            };
        }

    }
}