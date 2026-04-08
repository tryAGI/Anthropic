
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsUserContentBlockDiscriminatorType
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
    public static class BetaManagedAgentsUserContentBlockDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsUserContentBlockDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsUserContentBlockDiscriminatorType.Document => "document",
                BetaManagedAgentsUserContentBlockDiscriminatorType.Image => "image",
                BetaManagedAgentsUserContentBlockDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsUserContentBlockDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "document" => BetaManagedAgentsUserContentBlockDiscriminatorType.Document,
                "image" => BetaManagedAgentsUserContentBlockDiscriminatorType.Image,
                "text" => BetaManagedAgentsUserContentBlockDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}