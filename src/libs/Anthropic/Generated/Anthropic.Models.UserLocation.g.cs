
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserLocation
    {
        /// <summary>
        /// The city of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The two letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// The region of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// The [IANA timezone](https://nodatime.org/TimeZones) of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"approximate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "approximate";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLocation" /> class.
        /// </summary>
        /// <param name="city">
        /// The city of the user.
        /// </param>
        /// <param name="country">
        /// The two letter [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) of the user.
        /// </param>
        /// <param name="region">
        /// The region of the user.
        /// </param>
        /// <param name="timezone">
        /// The [IANA timezone](https://nodatime.org/TimeZones) of the user.
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
            string type = "approximate")
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