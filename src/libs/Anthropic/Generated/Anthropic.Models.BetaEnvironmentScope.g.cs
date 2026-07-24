
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The visibility scope for this environment. 'organization' means visible to all accounts. 'account' means visible only to the owning account.
    /// </summary>
    public enum BetaEnvironmentScope
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
    public static class BetaEnvironmentScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEnvironmentScope value)
        {
            return value switch
            {
                BetaEnvironmentScope.Account => "account",
                BetaEnvironmentScope.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEnvironmentScope? ToEnum(string value)
        {
            return value switch
            {
                "account" => BetaEnvironmentScope.Account,
                "organization" => BetaEnvironmentScope.Organization,
                _ => null,
            };
        }
    }
}