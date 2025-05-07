
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserLocation
    {
        /// <summary>
        /// The city of the user.<br/>
        /// Example: New York
        /// </summary>
        /// <example>New York</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The two letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the user.<br/>
        /// Example: US
        /// </summary>
        /// <example>US</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The region of the user.<br/>
        /// Example: California
        /// </summary>
        /// <example>California</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The [IANA timezone](https://nodatime.org/TimeZones) of the user.<br/>
        /// Example: America/New_York
        /// </summary>
        /// <example>America/New_York</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Anthropic.JsonConverters.UserLocationTypeJsonConverter))]
        public global::Anthropic.UserLocationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocation" /> class.
        /// </summary>
        /// <param name="city">
        /// The city of the user.<br/>
        /// Example: New York
        /// </param>
        /// <param name="country">
        /// The two letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the user.<br/>
        /// Example: US
        /// </param>
        /// <param name="region">
        /// The region of the user.<br/>
        /// Example: California
        /// </param>
        /// <param name="timezone">
        /// The [IANA timezone](https://nodatime.org/TimeZones) of the user.<br/>
        /// Example: America/New_York
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserLocation(
            string? city,
            string? country,
            string? region,
            string? timezone,
            global::Anthropic.UserLocationType type)
        {
            this.City = city;
            this.Country = country;
            this.Region = region;
            this.Timezone = timezone;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocation" /> class.
        /// </summary>
        public UserLocation()
        {
        }
    }
}