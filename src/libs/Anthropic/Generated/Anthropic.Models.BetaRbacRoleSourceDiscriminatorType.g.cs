
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRbacRoleSourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        BuiltIn,
        /// <summary>
        ///
        /// </summary>
        Custom,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRbacRoleSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRbacRoleSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaRbacRoleSourceDiscriminatorType.BuiltIn => "built_in",
                BetaRbacRoleSourceDiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRbacRoleSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "built_in" => BetaRbacRoleSourceDiscriminatorType.BuiltIn,
                "custom" => BetaRbacRoleSourceDiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}