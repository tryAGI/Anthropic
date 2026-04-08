
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaEnvironmentConfigDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Cloud,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaEnvironmentConfigDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEnvironmentConfigDiscriminatorType value)
        {
            return value switch
            {
                BetaEnvironmentConfigDiscriminatorType.Cloud => "cloud",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEnvironmentConfigDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "cloud" => BetaEnvironmentConfigDiscriminatorType.Cloud,
                _ => null,
            };
        }
    }
}