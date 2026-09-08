
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPublicEnvironmentUpdateRequestScope
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
    public static class BetaPublicEnvironmentUpdateRequestScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentUpdateRequestScope value)
        {
            return value switch
            {
                BetaPublicEnvironmentUpdateRequestScope.Account => "account",
                BetaPublicEnvironmentUpdateRequestScope.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentUpdateRequestScope? ToEnum(string value)
        {
            return value switch
            {
                "account" => BetaPublicEnvironmentUpdateRequestScope.Account,
                "organization" => BetaPublicEnvironmentUpdateRequestScope.Organization,
                _ => null,
            };
        }
    }
}