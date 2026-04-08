
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsFileResourceParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsFileResourceParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsFileResourceParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsFileResourceParamsType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsFileResourceParamsType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsFileResourceParamsType.File,
                _ => null,
            };
        }
    }
}