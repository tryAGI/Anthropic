
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A message sent to Claude.
    /// </summary>
    public sealed partial class BetaComplianceReviewMessageDetails
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"message"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "message";

        /// <summary>
        /// The model that the call named. Null when none was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The stored request and response. Null when `content_unavailable_reason` is set. New types can appear, so accept a type that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::Anthropic.BetaComplianceReviewMessageContent? Content { get; set; }

        /// <summary>
        /// Why `content` is null. Null when `content` is set. New types can appear, so accept a type that you don't know.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_unavailable_reason")]
        public global::Anthropic.BetaComplianceReviewContentUnavailableReason? ContentUnavailableReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewMessageDetails" /> class.
        /// </summary>
        /// <param name="model">
        /// The model that the call named. Null when none was recorded.
        /// </param>
        /// <param name="content">
        /// The stored request and response. Null when `content_unavailable_reason` is set. New types can appear, so accept a type that you don't know.
        /// </param>
        /// <param name="contentUnavailableReason">
        /// Why `content` is null. Null when `content` is set. New types can appear, so accept a type that you don't know.
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaComplianceReviewMessageDetails(
            string? model,
            global::Anthropic.BetaComplianceReviewMessageContent? content,
            global::Anthropic.BetaComplianceReviewContentUnavailableReason? contentUnavailableReason,
            string type = "message")
        {
            this.Type = type;
            this.Model = model;
            this.Content = content;
            this.ContentUnavailableReason = contentUnavailableReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaComplianceReviewMessageDetails" /> class.
        /// </summary>
        public BetaComplianceReviewMessageDetails()
        {
        }

    }
}