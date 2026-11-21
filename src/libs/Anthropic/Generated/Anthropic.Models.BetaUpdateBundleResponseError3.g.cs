
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaUpdateBundleResponseError3
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"conflict_error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "conflict_error";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public global::Anthropic.BetaSlackChannelSetUpSettingsConflictErrorDetails? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateBundleResponseError3" /> class.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="details"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaUpdateBundleResponseError3(
            string message,
            global::Anthropic.BetaSlackChannelSetUpSettingsConflictErrorDetails? details,
            string type = "conflict_error")
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaUpdateBundleResponseError3" /> class.
        /// </summary>
        public BetaUpdateBundleResponseError3()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaUpdateBundleResponseError3"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaUpdateBundleResponseError3 FromMessage(string message)
        {
            return new BetaUpdateBundleResponseError3
            {
                Message = message,
            };
        }

    }
}