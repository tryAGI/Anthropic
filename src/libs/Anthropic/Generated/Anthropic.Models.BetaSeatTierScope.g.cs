
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BetaSeatTierScope
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seat_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SeatTier { get; set; }

        /// <summary>
        /// Default Value: seat_tier
        /// </summary>
        /// <default>"seat_tier"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "seat_tier";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSeatTierScope" /> class.
        /// </summary>
        /// <param name="seatTier"></param>
        /// <param name="type">
        /// Default Value: seat_tier
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaSeatTierScope(
            string seatTier,
            string type = "seat_tier")
        {
            this.SeatTier = seatTier ?? throw new global::System.ArgumentNullException(nameof(seatTier));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaSeatTierScope" /> class.
        /// </summary>
        public BetaSeatTierScope()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaSeatTierScope"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaSeatTierScope FromSeatTier(string seatTier)
        {
            return new BetaSeatTierScope
            {
                SeatTier = seatTier,
            };
        }

    }
}