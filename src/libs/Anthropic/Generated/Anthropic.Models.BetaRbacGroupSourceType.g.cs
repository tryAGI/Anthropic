
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the RBAC Group was created: `"direct"` for groups created directly (for example, in the organization's admin settings), `"scim"` for groups provisioned by the identity provider.
    /// </summary>
    public enum BetaRbacGroupSourceType
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
    public static class BetaRbacGroupSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRbacGroupSourceType value)
        {
            return value switch
            {
                BetaRbacGroupSourceType.Direct => "direct",
                BetaRbacGroupSourceType.Scim => "scim",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRbacGroupSourceType? ToEnum(string value)
        {
            return value switch
            {
                "direct" => BetaRbacGroupSourceType.Direct,
                "scim" => BetaRbacGroupSourceType.Scim,
                _ => null,
            };
        }
    }
}