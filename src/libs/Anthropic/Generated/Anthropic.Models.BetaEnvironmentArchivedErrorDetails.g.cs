
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The environment is archived, so it cannot be updated.
    /// </summary>
    public sealed partial class BetaEnvironmentArchivedErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"environment_archived"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        public string ErrorCode { get; set; } = "environment_archived";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentArchivedErrorDetails" /> class.
        /// </summary>
        /// <param name="errorCode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaEnvironmentArchivedErrorDetails(
            string errorCode = "environment_archived")
        {
            this.ErrorCode = errorCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaEnvironmentArchivedErrorDetails" /> class.
        /// </summary>
        public BetaEnvironmentArchivedErrorDetails()
        {
        }

    }
}