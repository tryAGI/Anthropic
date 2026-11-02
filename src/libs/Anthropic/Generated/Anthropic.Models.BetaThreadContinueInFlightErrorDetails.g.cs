
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Another request is still continuing from the same `previous_message_id`. Wait for it to complete and continue from its response `id`, or replay the full conversation with `thread: {"type": "create"}`.
    /// </summary>
    public sealed partial class BetaThreadContinueInFlightErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"thread_continue_in_flight"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "thread_continue_in_flight";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadContinueInFlightErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaThreadContinueInFlightErrorDetails(
            string errorCode = "thread_continue_in_flight")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaThreadContinueInFlightErrorDetails" /> class.
        /// </summary>
        public BetaThreadContinueInFlightErrorDetails()
        {
        }

    }
}