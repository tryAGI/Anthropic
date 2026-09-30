
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginInstallationSettingDeletedTargetDiscriminatorType
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
    public static class BetaPluginInstallationSettingDeletedTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginInstallationSettingDeletedTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaPluginInstallationSettingDeletedTargetDiscriminatorType.Organization => "organization",
                BetaPluginInstallationSettingDeletedTargetDiscriminatorType.OrganizationMember => "organization_member",
                BetaPluginInstallationSettingDeletedTargetDiscriminatorType.RbacGroup => "rbac_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginInstallationSettingDeletedTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaPluginInstallationSettingDeletedTargetDiscriminatorType.Organization,
                "organization_member" => BetaPluginInstallationSettingDeletedTargetDiscriminatorType.OrganizationMember,
                "rbac_group" => BetaPluginInstallationSettingDeletedTargetDiscriminatorType.RbacGroup,
                _ => null,
            };
        }
    }
}