
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The repository host refused access to the repository.<br/>
    /// Example: {"type":"repository_forbidden_error","message":"The repository host refused access to the repository.","retry_status":{"type":"retrying"},"repository_url":"https://github.com/example-org/example-repo"}
    /// </summary>
    public sealed partial class BetaManagedAgentsRepositoryForbiddenError
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"repository_forbidden_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "repository_forbidden_error";

        /// <summary>
        /// Human-readable error description.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// What the client should do next. Always `retrying`: the session keeps running without the repository.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.BetaManagedAgentsRetryStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.BetaManagedAgentsRetryStatus RetryStatus { get; set; }

        /// <summary>
        /// URL of the repository that could not be cloned. Null when it could not be identified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_url")]
        public string? RepositoryUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRepositoryForbiddenError" /> class.
        /// </summary>
        /// <param name="message">
        /// Human-readable error description.
        /// </param>
        /// <param name="retryStatus">
        /// What the client should do next. Always `retrying`: the session keeps running without the repository.
        /// </param>
        /// <param name="repositoryUrl">
        /// URL of the repository that could not be cloned. Null when it could not be identified.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsRepositoryForbiddenError(
            string message,
            global::Anthropic.BetaManagedAgentsRetryStatus retryStatus,
            string? repositoryUrl,
            string type = "repository_forbidden_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.RetryStatus = retryStatus;
            this.RepositoryUrl = repositoryUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsRepositoryForbiddenError" /> class.
        /// </summary>
        public BetaManagedAgentsRepositoryForbiddenError()
        {
        }

    }
}