
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum SystemInputMessageContentBlockDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SystemInputMessageContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SystemInputMessageContentBlockDiscriminatorType value)
        {
            return value switch
            {
                SystemInputMessageContentBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SystemInputMessageContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "text" => SystemInputMessageContentBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}