
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationStateParamsDiscriminatorType
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
    public static class BetaTelemetryDestinationStateParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationStateParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationStateParamsDiscriminatorType.Disabled => "disabled",
                BetaTelemetryDestinationStateParamsDiscriminatorType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationStateParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaTelemetryDestinationStateParamsDiscriminatorType.Disabled,
                "enabled" => BetaTelemetryDestinationStateParamsDiscriminatorType.Enabled,
                _ => null,
            };
        }
    }
}