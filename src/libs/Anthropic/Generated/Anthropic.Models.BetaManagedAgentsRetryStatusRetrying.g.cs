
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The server is retrying automatically. Client should wait; the same error type may fire again as retrying, then once as exhausted when the retry budget runs out.
    /// </summary>
    public sealed partial class BetaManagedAgentsRetryStatusRetrying
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusRetryingTypeJsonConverter))]
        public global::Anthropic.BetaManagedAgentsRetryStatusRetryingType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRetryStatusRetrying" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRetryStatusRetrying(
            global::Anthropic.BetaManagedAgentsRetryStatusRetryingType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRetryStatusRetrying" /> class.
        /// </summary>
        public BetaManagedAgentsRetryStatusRetrying()
        {
        }
    }
}