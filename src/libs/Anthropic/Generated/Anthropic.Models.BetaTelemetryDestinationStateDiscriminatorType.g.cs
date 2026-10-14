
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationStateDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTelemetryDestinationStateDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationStateDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationStateDiscriminatorType.Disabled => "disabled",
                BetaTelemetryDestinationStateDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationStateDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaTelemetryDestinationStateDiscriminatorType.Disabled,
                "enabled" => BetaTelemetryDestinationStateDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}