
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ApiKeyScopeDiscriminatorType
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
    public static class ApiKeyScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ApiKeyScopeDiscriminatorType value)
        {
            return value switch
            {
                ApiKeyScopeDiscriminatorType.Organization => "organization",
                ApiKeyScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ApiKeyScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => ApiKeyScopeDiscriminatorType.Organization,
                "workspace" => ApiKeyScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}