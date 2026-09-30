
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ExternalKeyAttachmentDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Attached,
        /// <summary>
        ///
        /// </summary>
        Unattached,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExternalKeyAttachmentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExternalKeyAttachmentDiscriminatorType value)
        {
            return value switch
            {
                ExternalKeyAttachmentDiscriminatorType.Attached => "attached",
                ExternalKeyAttachmentDiscriminatorType.Unattached => "unattached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExternalKeyAttachmentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "attached" => ExternalKeyAttachmentDiscriminatorType.Attached,
                "unattached" => ExternalKeyAttachmentDiscriminatorType.Unattached,
                _ => null,
            };
        }
    }
}