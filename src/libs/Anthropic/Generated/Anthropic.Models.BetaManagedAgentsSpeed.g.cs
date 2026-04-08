
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Inference speed mode. `fast` provides significantly faster output token generation at premium pricing. Not all models support `fast`; invalid combinations are rejected at create time.
    /// </summary>
    public enum BetaManagedAgentsSpeed
    {
        /// <summary>
        /// 
        /// </summary>
        Fast,
        /// <summary>
        /// 
        /// </summary>
        Standard,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSpeedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSpeed value)
        {
            return value switch
            {
                BetaManagedAgentsSpeed.Fast => "fast",
                BetaManagedAgentsSpeed.Standard => "standard",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSpeed? ToEnum(string value)
        {
            return value switch
            {
                "fast" => BetaManagedAgentsSpeed.Fast,
                "standard" => BetaManagedAgentsSpeed.Standard,
                _ => null,
            };
        }
    }
}