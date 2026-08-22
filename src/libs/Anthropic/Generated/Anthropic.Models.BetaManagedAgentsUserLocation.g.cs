
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Approximate user location for search result localization.
    /// </summary>
    public sealed partial class BetaManagedAgentsUserLocation
    {
        /// <summary>
        /// Location precision. Only "approximate" is supported.
        /// </summary>
        /// <default>"approximate"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "approximate";

        /// <summary>
        /// City name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// Region or state name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 country code, uppercase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// IANA timezone identifier, e.g. "America/Los_Angeles".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserLocation" /> class.
        /// </summary>
        /// <param name="city">
        /// City name.
        /// </param>
        /// <param name="region">
        /// Region or state name.
        /// </param>
        /// <param name="country">
        /// Two-letter ISO 3166-1 country code, uppercase.
        /// </param>
        /// <param name="timezone">
        /// IANA timezone identifier, e.g. "America/Los_Angeles".
        /// </param>
        /// <param name="type">
        /// Location precision. Only "approximate" is supported.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaManagedAgentsUserLocation(
            string? city,
            string? region,
            string? country,
            string? timezone,
            string type = "approximate")
        {
            this.Type = type;
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaManagedAgentsUserLocation" /> class.
        /// </summary>
        public BetaManagedAgentsUserLocation()
        {
        }

    }
}