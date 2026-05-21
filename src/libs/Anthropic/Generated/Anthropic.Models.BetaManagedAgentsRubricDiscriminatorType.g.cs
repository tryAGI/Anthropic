
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsRubricDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsRubricDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsRubricDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsRubricDiscriminatorType.File => "file",
                BetaManagedAgentsRubricDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsRubricDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "file" => BetaManagedAgentsRubricDiscriminatorType.File,
                "text" => BetaManagedAgentsRubricDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}