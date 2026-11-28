
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeCodeManagedSettingsModeDiscriminatorType
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
    public static class BetaClaudeCodeManagedSettingsModeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeCodeManagedSettingsModeDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeCodeManagedSettingsModeDiscriminatorType.Organization => "organization",
                BetaClaudeCodeManagedSettingsModeDiscriminatorType.RbacGroups => "rbac_groups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeCodeManagedSettingsModeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaClaudeCodeManagedSettingsModeDiscriminatorType.Organization,
                "rbac_groups" => BetaClaudeCodeManagedSettingsModeDiscriminatorType.RbacGroups,
                _ => null,
            };
        }
    }
}