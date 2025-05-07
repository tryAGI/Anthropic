
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaSucceededResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaMessage Message { get; set; }

        /// <summary>
        /// Default Value: succeeded
        /// </summary>
        /// <default>global::Anthropic.BetaSucceededResultType.Succeeded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaSucceededResultTypeJsonConverter))]
        public global::Anthropic.BetaSucceededResultType Type { get; set; } = global::Anthropic.BetaSucceededResultType.Succeeded;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSucceededResult" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="type">
        /// Default Value: succeeded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSucceededResult(
            global::Anthropic.BetaMessage message,
            global::Anthropic.BetaSucceededResultType type = global::Anthropic.BetaSucceededResultType.Succeeded)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSucceededResult" /> class.
        /// </summary>
        public BetaSucceededResult()
        {
        }
    }
}