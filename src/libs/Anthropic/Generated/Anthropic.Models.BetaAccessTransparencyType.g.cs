
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaAccessTransparencyType
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAccessTransparencyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAccessTransparencyType value)
        {
            return value switch
            {
                BetaAccessTransparencyType.Disabled => "disabled",
                BetaAccessTransparencyType.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAccessTransparencyType? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaAccessTransparencyType.Disabled,
                "enabled" => BetaAccessTransparencyType.Enabled,
                _ => null,
            };
        }
    }
}