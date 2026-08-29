
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaApiKeyScopeDiscriminatorType
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
    public static class BetaApiKeyScopeDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaApiKeyScopeDiscriminatorType value)
        {
            return value switch
            {
                BetaApiKeyScopeDiscriminatorType.Organization => "organization",
                BetaApiKeyScopeDiscriminatorType.Workspace => "workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaApiKeyScopeDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "organization" => BetaApiKeyScopeDiscriminatorType.Organization,
                "workspace" => BetaApiKeyScopeDiscriminatorType.Workspace,
                _ => null,
            };
        }
    }
}