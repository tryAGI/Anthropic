
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsSystemContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSystemContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSystemContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsSystemContentBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSystemContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaManagedAgentsSystemContentBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}