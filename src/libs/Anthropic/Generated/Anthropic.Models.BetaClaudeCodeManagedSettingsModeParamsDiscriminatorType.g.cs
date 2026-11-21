
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        RbacGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeCodeManagedSettingsModeParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.Organization => "organization",
                BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.RbacGroups => "rbac_groups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.Organization,
                "rbac_groups" => BetaClaudeCodeManagedSettingsModeParamsDiscriminatorType.RbacGroups,
                _ => null,
            };
        }
    }
}