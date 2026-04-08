
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDocumentSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        File,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDocumentSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDocumentSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsDocumentSourceDiscriminatorType.Base64 => "base64",
                BetaManagedAgentsDocumentSourceDiscriminatorType.File => "file",
                BetaManagedAgentsDocumentSourceDiscriminatorType.Text => "text",
                BetaManagedAgentsDocumentSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDocumentSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaManagedAgentsDocumentSourceDiscriminatorType.Base64,
                "file" => BetaManagedAgentsDocumentSourceDiscriminatorType.File,
                "text" => BetaManagedAgentsDocumentSourceDiscriminatorType.Text,
                "url" => BetaManagedAgentsDocumentSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}