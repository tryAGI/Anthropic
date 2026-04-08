
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAddSessionResourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAddSessionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAddSessionResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAddSessionResourceDiscriminatorType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAddSessionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsAddSessionResourceDiscriminatorType.File,
                _ => null,
            };
        }
    }
}