
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsFileResourceConfigType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsFileResourceConfigTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsFileResourceConfigType value)
        {
            return value switch
            {
                BetaManagedAgentsFileResourceConfigType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsFileResourceConfigType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsFileResourceConfigType.File,
                _ => null,
            };
        }
    }
}