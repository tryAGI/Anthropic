
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        RbacGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType value)
        {
            return value switch
            {
                BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType.Organization => "organization",
                BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType.RbacGroup => "rbac_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType.Organization,
                "rbac_group" => BetaListPluginInstallationSettingsV1OrganizationsPluginsPluginIdInstallationSettingsGetTargetType.RbacGroup,
                _ => null,
            };
        }
    }
}