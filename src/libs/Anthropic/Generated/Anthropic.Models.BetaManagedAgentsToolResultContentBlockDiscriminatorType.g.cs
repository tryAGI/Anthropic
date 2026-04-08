
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsToolResultContentBlockDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Document,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsToolResultContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsToolResultContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsToolResultContentBlockDiscriminatorType.Document => "document",
                BetaManagedAgentsToolResultContentBlockDiscriminatorType.Image => "image",
                BetaManagedAgentsToolResultContentBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsToolResultContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaManagedAgentsToolResultContentBlockDiscriminatorType.Document,
                "image" => BetaManagedAgentsToolResultContentBlockDiscriminatorType.Image,
                "text" => BetaManagedAgentsToolResultContentBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}