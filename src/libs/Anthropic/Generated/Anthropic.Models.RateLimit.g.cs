
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RateLimit
    {
        /// <summary>
        /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.Group3JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.Group3 Group { get; set; }

        /// <summary>
        /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.RateLimitGroupTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Anthropic.RateLimitGroupType GroupType { get; set; }

        /// <summary>
        /// Identifier of this rate-limit entry. It is stable within the organization and differs between organizations; the group's own identifier is `group.id`.
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
        /// Model names this entry's limits apply to, including aliases. `null` when `group_type` is not `"model_group"`.
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
        /// The rate-limit group this entry's limits apply to. Its `type` equals `group_type`.
        /// </param>
        /// <param name="groupType">
        /// Deprecated: use `group.type` instead. The kind of rate-limit group this entry represents. `model_group` entries apply to a family of models (listed in `models`); other values apply to an API-surface category and have `models` set to `null`. Always equal to `group.type`.
        /// </param>
        /// <param name="id">
        /// Identifier of this rate-limit entry. It is stable within the organization and differs between organizations; the group's own identifier is `group.id`.
        /// </param>
        /// <param name="limits">
        /// The limiter values that apply to this group.
        /// </param>
        /// <param name="models">
        /// Model names this entry's limits apply to, including aliases. `null` when `group_type` is not `"model_group"`.
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
            global::Anthropic.RateLimitGroupType groupType,
            string id,
            global::System.Collections.Generic.IList<global::Anthropic.RateLimitValue> limits,
            global::System.Collections.Generic.IList<string>? models,
            string type = "rate_limit")
        {
            this.Group = group;
            this.GroupType = groupType;
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