
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionStopDetailsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionStopDetailsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionStopDetailsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSessionStopDetailsDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionStopDetailsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "refusal" => BetaManagedAgentsSessionStopDetailsDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}