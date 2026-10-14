
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Confirmation that a destination was deleted.
    /// </summary>
    public sealed partial class BetaDeletedTelemetryDestination
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"telemetry_destination_deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "telemetry_destination_deleted";

        /// <summary>
        /// ID of the deleted destination (`tdst_...`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedTelemetryDestination" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the deleted destination (`tdst_...`).
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaDeletedTelemetryDestination(
            string id,
            string type = "telemetry_destination_deleted")
        {
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaDeletedTelemetryDestination" /> class.
        /// </summary>
        public BetaDeletedTelemetryDestination()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaDeletedTelemetryDestination"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaDeletedTelemetryDestination FromId(string id)
        {
            return new BetaDeletedTelemetryDestination
            {
                Id = id,
            };
        }

    }
}