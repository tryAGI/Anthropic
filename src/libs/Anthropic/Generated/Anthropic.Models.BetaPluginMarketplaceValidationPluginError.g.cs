
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaPluginMarketplaceValidationPluginError
    {
        /// <summary>
        /// Why the plugin would be skipped by a synchronization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// A stable identifier for the reason — the value to branch on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorCode { get; set; }

        /// <summary>
        /// The plugin's name, as its entry in marketplace.json declares it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginError" /> class.
        /// </summary>
        /// <param name="error">
        /// Why the plugin would be skipped by a synchronization.
        /// </param>
        /// <param name="errorCode">
        /// A stable identifier for the reason — the value to branch on.
        /// </param>
        /// <param name="name">
        /// The plugin's name, as its entry in marketplace.json declares it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaPluginMarketplaceValidationPluginError(
            string error,
            string errorCode,
            string name)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.ErrorCode = errorCode ?? throw new global::System.ArgumentNullException(nameof(errorCode));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaPluginMarketplaceValidationPluginError" /> class.
        /// </summary>
        public BetaPluginMarketplaceValidationPluginError()
        {
        }

    }
}