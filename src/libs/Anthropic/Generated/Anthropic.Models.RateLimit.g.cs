
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RateLimit
    {
        /// <summary>
        /// The rate-limit group this entry's limits apply to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Group3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Group3 Group { get; set; }

        /// <summary>
        /// Identifier of this rate-limit entry. It is stable within the organization and differs between organizations; the group's own identifier is `group.id`. Pass it as `rate_limit_id` to set a workspace's overrides for this group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The limiter values that apply to this group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limits")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue> Limits { get; set; }

        /// <summary>
        /// Model names this entry's limits apply to, including aliases. `null` when `group.type` is not `"model_group"`. The list covers the models your organization has access to, so it can differ between organizations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<string>? Models { get; set; }

        /// <summary>
        /// Object type. Always `rate_limit` for organization rate-limit entries.<br/>
        /// Default Value: rate_limit
        /// </summary>
        /// <default>"rate_limit"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "rate_limit";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimit" /> class.
        /// </summary>
        /// <param name="group">
        /// The rate-limit group this entry's limits apply to.
        /// </param>
        /// <param name="id">
        /// Identifier of this rate-limit entry. It is stable within the organization and differs between organizations; the group's own identifier is `group.id`. Pass it as `rate_limit_id` to set a workspace's overrides for this group.
        /// </param>
        /// <param name="limits">
        /// The limiter values that apply to this group.
        /// </param>
        /// <param name="models">
        /// Model names this entry's limits apply to, including aliases. `null` when `group.type` is not `"model_group"`. The list covers the models your organization has access to, so it can differ between organizations.
        /// </param>
        /// <param name="type">
        /// Object type. Always `rate_limit` for organization rate-limit entries.<br/>
        /// Default Value: rate_limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimit(
            global::Anthropic.Group3 group,
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue> limits,
            global::System.Collections.Generic.IList<string>? models,
            string type = "rate_limit")
        {
            this.Group = group;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Limits = limits ?? throw new global::System.ArgumentNullException(nameof(limits));
            this.Models = models;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimit" /> class.
        /// </summary>
        public RateLimit()
        {
        }

    }
}