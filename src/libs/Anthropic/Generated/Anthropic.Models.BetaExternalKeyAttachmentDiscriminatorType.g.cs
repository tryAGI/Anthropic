
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalKeyAttachmentDiscriminatorType
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
    public static class BetaExternalKeyAttachmentDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalKeyAttachmentDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalKeyAttachmentDiscriminatorType.Attached => "attached",
                BetaExternalKeyAttachmentDiscriminatorType.Unattached => "unattached",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalKeyAttachmentDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "attached" => BetaExternalKeyAttachmentDiscriminatorType.Attached,
                "unattached" => BetaExternalKeyAttachmentDiscriminatorType.Unattached,
                _ => null,
            };
        }
    }
}