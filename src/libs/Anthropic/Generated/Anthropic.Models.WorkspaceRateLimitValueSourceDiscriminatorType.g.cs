
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkspaceRateLimitValueSourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceRateLimitValueSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceRateLimitValueSourceDiscriminatorType value)
        {
            return value switch
            {
                WorkspaceRateLimitValueSourceDiscriminatorType.Organization => "organization",
                WorkspaceRateLimitValueSourceDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceRateLimitValueSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => WorkspaceRateLimitValueSourceDiscriminatorType.Organization,
                "workspace" => WorkspaceRateLimitValueSourceDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}