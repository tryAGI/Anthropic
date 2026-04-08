
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsModelOverloadedErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        ModelOverloadedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsModelOverloadedErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsModelOverloadedErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsModelOverloadedErrorType.ModelOverloadedError => "model_overloaded_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsModelOverloadedErrorType? ToEnum(string value)
        {
            return value switch
            {
                "model_overloaded_error" => BetaManagedAgentsModelOverloadedErrorType.ModelOverloadedError,
                _ => null,
            };
        }
    }
}