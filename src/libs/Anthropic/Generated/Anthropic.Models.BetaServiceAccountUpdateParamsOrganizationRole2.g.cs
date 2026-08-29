
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaServiceAccountUpdateParamsOrganizationRole2
    {
        /// <summary>
        ///
        /// </summary>
        Admin,
        /// <summary>
        ///
        /// </summary>
        Developer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaServiceAccountUpdateParamsOrganizationRole2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaServiceAccountUpdateParamsOrganizationRole2 value)
        {
            return value switch
            {
                BetaServiceAccountUpdateParamsOrganizationRole2.Admin => "admin",
                BetaServiceAccountUpdateParamsOrganizationRole2.Developer => "developer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaServiceAccountUpdateParamsOrganizationRole2? ToEnum(string value)
        {
            return value switch
            {
                "admin" => BetaServiceAccountUpdateParamsOrganizationRole2.Admin,
                "developer" => BetaServiceAccountUpdateParamsOrganizationRole2.Developer,
                _ => null,
            };
        }
    }
}