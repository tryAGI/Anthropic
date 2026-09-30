
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPluginInstallationSettingTargetDiscriminatorType
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
    public static class BetaPluginInstallationSettingTargetDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginInstallationSettingTargetDiscriminatorType value)
        {
            return value switch
            {
                BetaPluginInstallationSettingTargetDiscriminatorType.Organization => "organization",
                BetaPluginInstallationSettingTargetDiscriminatorType.OrganizationMember => "organization_member",
                BetaPluginInstallationSettingTargetDiscriminatorType.RbacGroup => "rbac_group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginInstallationSettingTargetDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaPluginInstallationSettingTargetDiscriminatorType.Organization,
                "organization_member" => BetaPluginInstallationSettingTargetDiscriminatorType.OrganizationMember,
                "rbac_group" => BetaPluginInstallationSettingTargetDiscriminatorType.RbacGroup,
                _ => null,
            };
        }
    }
}