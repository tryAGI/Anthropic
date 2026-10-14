
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationDisabledReasonDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Caller,
        /// <summary>
        ///
        /// </summary>
        InvalidAddress,
        /// <summary>
        ///
        /// </summary>
        Redirect,
        /// <summary>
        ///
        /// </summary>
        SustainedFailure,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTelemetryDestinationDisabledReasonDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationDisabledReasonDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationDisabledReasonDiscriminatorType.Caller => "caller",
                BetaTelemetryDestinationDisabledReasonDiscriminatorType.InvalidAddress => "invalid_address",
                BetaTelemetryDestinationDisabledReasonDiscriminatorType.Redirect => "redirect",
                BetaTelemetryDestinationDisabledReasonDiscriminatorType.SustainedFailure => "sustained_failure",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationDisabledReasonDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "caller" => BetaTelemetryDestinationDisabledReasonDiscriminatorType.Caller,
                "invalid_address" => BetaTelemetryDestinationDisabledReasonDiscriminatorType.InvalidAddress,
                "redirect" => BetaTelemetryDestinationDisabledReasonDiscriminatorType.Redirect,
                "sustained_failure" => BetaTelemetryDestinationDisabledReasonDiscriminatorType.SustainedFailure,
                _ => null,
            };
        }
    }
}