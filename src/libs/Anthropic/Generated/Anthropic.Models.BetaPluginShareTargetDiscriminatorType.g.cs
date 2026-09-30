
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginShareTargetDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        OrganizationMember,
        /// <summary>
        ///
        /// </summary>
        RbacGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginShareTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginShareTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaPluginShareTargetDiscriminatorType.Organization => "organization",
                BetaPluginShareTargetDiscriminatorType.OrganizationMember => "organization_member",
                BetaPluginShareTargetDiscriminatorType.RbacGroup => "rbac_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginShareTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaPluginShareTargetDiscriminatorType.Organization,
                "organization_member" => BetaPluginShareTargetDiscriminatorType.OrganizationMember,
                "rbac_group" => BetaPluginShareTargetDiscriminatorType.RbacGroup,
                _ => null,
            };
        }
    }
}