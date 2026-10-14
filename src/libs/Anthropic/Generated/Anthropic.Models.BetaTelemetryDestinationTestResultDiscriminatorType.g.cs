
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationTestResultDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTelemetryDestinationTestResultDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationTestResultDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationTestResultDiscriminatorType.Failure => "failure",
                BetaTelemetryDestinationTestResultDiscriminatorType.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationTestResultDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "failure" => BetaTelemetryDestinationTestResultDiscriminatorType.Failure,
                "success" => BetaTelemetryDestinationTestResultDiscriminatorType.Success,
                _ => null,
            };
        }
    }
}