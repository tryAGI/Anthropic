
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the RBAC Group was created: `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
    /// </summary>
    public enum RbacGroupSourceType
    {
        /// <summary>
        /// `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
        /// </summary>
        Direct,
        /// <summary>
        /// `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
        /// </summary>
        Scim,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RbacGroupSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RbacGroupSourceType value)
        {
            return value switch
            {
                RbacGroupSourceType.Direct => "direct",
                RbacGroupSourceType.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RbacGroupSourceType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => RbacGroupSourceType.Direct,
                "scim" => RbacGroupSourceType.Scim,
                _ => null,
            };
        }
    }
}