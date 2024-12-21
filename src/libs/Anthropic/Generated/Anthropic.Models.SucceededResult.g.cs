
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SucceededResult
    {
        /// <summary>
        /// Default Value: succeeded
        /// </summary>
        /// <default>global::Anthropic.SucceededResultType.Succeeded</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.SucceededResultTypeJsonConverter))]
        public global::Anthropic.SucceededResultType Type { get; set; } = global::Anthropic.SucceededResultType.Succeeded;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Message Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SucceededResult" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: succeeded
        /// </param>
        /// <param name="message"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public SucceededResult(
            global::Anthropic.Message message,
            global::Anthropic.SucceededResultType type = global::Anthropic.SucceededResultType.Succeeded)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SucceededResult" /> class.
        /// </summary>
        public SucceededResult()
        {
        }
    }
}