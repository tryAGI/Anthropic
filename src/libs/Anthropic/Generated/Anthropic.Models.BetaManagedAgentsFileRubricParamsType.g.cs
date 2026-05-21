
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsFileRubricParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsFileRubricParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsFileRubricParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsFileRubricParamsType.File => "file",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsFileRubricParamsType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsFileRubricParamsType.File,
                _ => null,
            };
        }
    }
}