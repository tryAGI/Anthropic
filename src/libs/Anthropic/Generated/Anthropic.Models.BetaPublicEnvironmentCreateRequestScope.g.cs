
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPublicEnvironmentCreateRequestScope
    {
        /// <summary>
        ///
        /// </summary>
        Account,
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPublicEnvironmentCreateRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentCreateRequestScope value)
        {
            return value switch
            {
                BetaPublicEnvironmentCreateRequestScope.Account => "account",
                BetaPublicEnvironmentCreateRequestScope.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentCreateRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "account" => BetaPublicEnvironmentCreateRequestScope.Account,
                "organization" => BetaPublicEnvironmentCreateRequestScope.Organization,
                _ => null,
            };
        }
    }
}