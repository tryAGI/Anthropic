
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Status of automatic JWKS polling for a federation issuer.<br/>
    /// Anthropic periodically fetches the issuer's signing keys in the<br/>
    /// background. These fields summarize the most recent fetches so the<br/>
    /// health of the JWKS endpoint can be monitored.
    /// </summary>
    public sealed partial class BetaIssuerPollStatus
    {
        /// <summary>
        /// Consecutive fetch failures since the last success.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("consecutive_failures")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ConsecutiveFailures { get; set; }

        /// <summary>
        /// When the last successful fetch completed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_fetched_at")]
        public global::System.DateTime? LastFetchedAt { get; set; }

        /// <summary>
        /// When the next fetch is scheduled. Null if paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_poll_at")]
        public global::System.DateTime? NextPollAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaIssuerPollStatus" /> class.
        /// </summary>
        /// <param name="consecutiveFailures">
        /// Consecutive fetch failures since the last success.
        /// </param>
        /// <param name="lastFetchedAt">
        /// When the last successful fetch completed.
        /// </param>
        /// <param name="nextPollAt">
        /// When the next fetch is scheduled. Null if paused.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaIssuerPollStatus(
            int consecutiveFailures,
            global::System.DateTime? lastFetchedAt,
            global::System.DateTime? nextPollAt)
        {
            this.ConsecutiveFailures = consecutiveFailures;
            this.LastFetchedAt = lastFetchedAt;
            this.NextPollAt = nextPollAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaIssuerPollStatus" /> class.
        /// </summary>
        public BetaIssuerPollStatus()
        {
        }

    }
}