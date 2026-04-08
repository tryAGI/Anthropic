
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Must be 'object' for tool input schemas.
    /// </summary>
    public enum BetaManagedAgentsCustomToolInputSchemaType
    {
        /// <summary>
        /// 
        /// </summary>
        Object,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCustomToolInputSchemaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCustomToolInputSchemaType value)
        {
            return value switch
            {
                BetaManagedAgentsCustomToolInputSchemaType.Object => "object",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCustomToolInputSchemaType? ToEnum(string value)
        {
            return value switch
            {
                "object" => BetaManagedAgentsCustomToolInputSchemaType.Object,
                _ => null,
            };
        }
    }
}