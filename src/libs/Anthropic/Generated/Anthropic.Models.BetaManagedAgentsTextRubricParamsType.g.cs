
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsTextRubricParamsType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsTextRubricParamsTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsTextRubricParamsType value)
        {
            return value switch
            {
                BetaManagedAgentsTextRubricParamsType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsTextRubricParamsType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaManagedAgentsTextRubricParamsType.Text,
                _ => null,
            };
        }
    }
}