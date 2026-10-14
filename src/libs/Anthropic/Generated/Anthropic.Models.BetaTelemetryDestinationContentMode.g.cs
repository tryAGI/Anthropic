
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What the spans that the API exports to a telemetry destination contain.<br/>
    /// See the [OpenTelemetry export guide](https://platform.claude.com/docs/en/manage-claude/opentelemetry#choose-a-content-mode) to learn what the spans contain in each content mode.
    /// </summary>
    public enum BetaTelemetryDestinationContentMode
    {
        /// <summary>
        /// The spans contain the same metadata as `metadata_only`, plus message and tool content.<br/>
        /// An organization with a data-handling restriction, such as under HIPAA, can't choose this mode. The API exports only metadata for such an organization, even to a destination that already has `content`.
        /// </summary>
        Content,
        /// <summary>
        /// The spans contain identifiers, timing, status, token counts, and similar metadata. They don't contain prompt text, completion text, or tool inputs and outputs.
        /// </summary>
        MetadataOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTelemetryDestinationContentModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationContentMode value)
        {
            return value switch
            {
                BetaTelemetryDestinationContentMode.Content => "content",
                BetaTelemetryDestinationContentMode.MetadataOnly => "metadata_only",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationContentMode? ToEnum(string value)
        {
            return value switch
            {
                "content" => BetaTelemetryDestinationContentMode.Content,
                "metadata_only" => BetaTelemetryDestinationContentMode.MetadataOnly,
                _ => null,
            };
        }
    }
}