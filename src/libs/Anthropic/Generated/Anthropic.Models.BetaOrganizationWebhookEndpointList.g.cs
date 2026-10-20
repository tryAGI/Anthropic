
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A page of organization webhook endpoints.
    /// </summary>
    public sealed partial class BetaOrganizationWebhookEndpointList
    {
        /// <summary>
        /// The organization webhook endpoints on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint> Data { get; set; }

        /// <summary>
        /// First ID in the `data` list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// Whether more endpoints follow this page in list order. With `before_id`, only endpoints before the cursor count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Last ID in the `data` list. Can be used as the `after_id` for the next page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationWebhookEndpointList" /> class.
        /// </summary>
        /// <param name="data">
        /// The organization webhook endpoints on this page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more endpoints follow this page in list order. With `before_id`, only endpoints before the cursor count.
        /// </param>
        /// <param name="firstId">
        /// First ID in the `data` list.
        /// </param>
        /// <param name="lastId">
        /// Last ID in the `data` list. Can be used as the `after_id` for the next page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaOrganizationWebhookEndpointList(
            global::System.Collections.Generic.IList<global::Anthropic.BetaOrganizationWebhookEndpoint> data,
            bool hasMore,
            string? firstId,
            string? lastId)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaOrganizationWebhookEndpointList" /> class.
        /// </summary>
        public BetaOrganizationWebhookEndpointList()
        {
        }

    }
}