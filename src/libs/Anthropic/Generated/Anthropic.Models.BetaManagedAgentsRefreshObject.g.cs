
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Outcome of a refresh-token exchange attempted during credential validation.
    /// </summary>
    public sealed partial class BetaManagedAgentsRefreshObject
    {
        /// <summary>
        /// Outcome of the refresh attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsCredentialRefreshStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsCredentialRefreshStatus Status { get; set; }

        /// <summary>
        /// The captured HTTP error response from the token endpoint. Populated only when `status` is `failed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_response")]
        public global::Anthropic.BetaManagedAgentsRefreshHttpResponse? HttpResponse { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRefreshObject" /> class.
        /// </summary>
        /// <param name="status">
        /// Outcome of the refresh attempt.
        /// </param>
        /// <param name="httpResponse">
        /// The captured HTTP error response from the token endpoint. Populated only when `status` is `failed`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRefreshObject(
            global::Anthropic.BetaManagedAgentsCredentialRefreshStatus status,
            global::Anthropic.BetaManagedAgentsRefreshHttpResponse? httpResponse)
        {
            this.Status = status;
            this.HttpResponse = httpResponse;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRefreshObject" /> class.
        /// </summary>
        public BetaManagedAgentsRefreshObject()
        {
        }

    }
}