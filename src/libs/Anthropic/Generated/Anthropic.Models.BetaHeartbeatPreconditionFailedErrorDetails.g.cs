
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `expected_last_heartbeat` does not match the stored heartbeat, so another worker may hold the lease.
    /// </summary>
    public sealed partial class BetaHeartbeatPreconditionFailedErrorDetails
    {
        /// <summary>
        /// The lease as the server holds it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaWorkLeaseState CurrentState { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"heartbeat_precondition_failed"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "heartbeat_precondition_failed";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHeartbeatPreconditionFailedErrorDetails" /> class.
        /// </summary>
        /// <param name="currentState">
        /// The lease as the server holds it.
        /// </param>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaHeartbeatPreconditionFailedErrorDetails(
            global::Anthropic.BetaWorkLeaseState currentState,
            string errorCode = "heartbeat_precondition_failed")
        {
            this.CurrentState = currentState ?? throw new global::System.ArgumentNullException(nameof(currentState));
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaHeartbeatPreconditionFailedErrorDetails" /> class.
        /// </summary>
        public BetaHeartbeatPreconditionFailedErrorDetails()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaHeartbeatPreconditionFailedErrorDetails"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaHeartbeatPreconditionFailedErrorDetails FromCurrentState(global::Anthropic.BetaWorkLeaseState currentState)
        {
            return new BetaHeartbeatPreconditionFailedErrorDetails
            {
                CurrentState = currentState,
            };
        }

    }
}