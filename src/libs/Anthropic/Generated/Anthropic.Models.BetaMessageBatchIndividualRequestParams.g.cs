
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaMessageBatchIndividualRequestParams
    {
        /// <summary>
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string CustomId { get; set; } = default!;

        /// <summary>
        /// Messages API creation parameters for the individual request.<br/>
        /// See the [Messages API reference](https://docs.claude.com/en/api/messages) for full documentation on available parameters.<br/>
        /// Example: {"max_tokens":1024,"messages":[{"content":"Hello, world","role":"user"}],"model":"claude-opus-4-6"}
        /// </summary>
        /// <example>{"max_tokens":1024,"messages":[{"content":"Hello, world","role":"user"}],"model":"claude-opus-4-6"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Anthropic.BetaCreateMessageParams Params { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        /// <param name="customId">
        /// Developer-provided ID created for each request in a Message Batch. Useful for matching results to requests, as results may be given out of request order.<br/>
        /// Must be unique for each request within the Message Batch.
        /// </param>
        /// <param name="params">
        /// Messages API creation parameters for the individual request.<br/>
        /// See the [Messages API reference](https://docs.claude.com/en/api/messages) for full documentation on available parameters.<br/>
        /// Example: {"max_tokens":1024,"messages":[{"content":"Hello, world","role":"user"}],"model":"claude-opus-4-6"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaMessageBatchIndividualRequestParams(
            string customId,
            global::Anthropic.BetaCreateMessageParams @params)
        {
            this.CustomId = customId ?? throw new global::System.ArgumentNullException(nameof(customId));
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaMessageBatchIndividualRequestParams" /> class.
        /// </summary>
        public BetaMessageBatchIndividualRequestParams()
        {
        }
    }
}