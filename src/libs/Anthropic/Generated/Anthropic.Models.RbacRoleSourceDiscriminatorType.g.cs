
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum RbacRoleSourceDiscriminatorType
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
    public static class RbacRoleSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RbacRoleSourceDiscriminatorType value)
        {
            return value switch
            {
                RbacRoleSourceDiscriminatorType.BuiltIn => "built_in",
                RbacRoleSourceDiscriminatorType.Custom => "custom",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RbacRoleSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "built_in" => RbacRoleSourceDiscriminatorType.BuiltIn,
                "custom" => RbacRoleSourceDiscriminatorType.Custom,
                _ => null,
            };
        }
    }
}