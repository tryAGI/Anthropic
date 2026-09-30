
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginMarketplaceValidationPluginWarning
    {
        /// <summary>
        /// A stable identifier for the kind of warning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorCode { get; set; }

        /// <summary>
        /// What would be left out, and why.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginWarning" /> class.
        /// </summary>
        /// <param name="errorCode">
        /// A stable identifier for the kind of warning.
        /// </param>
        /// <param name="message">
        /// What would be left out, and why.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginMarketplaceValidationPluginWarning(
            string errorCode,
            string message)
        {
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginWarning" /> class.
        /// </summary>
        public BetaPluginMarketplaceValidationPluginWarning()
        {
        }

    }
}