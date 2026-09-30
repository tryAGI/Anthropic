
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType
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
    public static class BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType value)
        {
            return value switch
            {
                BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.Organization => "organization",
                BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.OrganizationMember => "organization_member",
                BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.RbacGroup => "rbac_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.Organization,
                "organization_member" => BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.OrganizationMember,
                "rbac_group" => BetaListPluginSharesV1OrganizationsPluginsPluginIdSharesGetTargetType.RbacGroup,
                _ => null,
            };
        }
    }
}