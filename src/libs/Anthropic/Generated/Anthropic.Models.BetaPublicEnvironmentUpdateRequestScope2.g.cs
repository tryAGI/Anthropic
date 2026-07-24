
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPublicEnvironmentUpdateRequestScope2
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
    public static class BetaPublicEnvironmentUpdateRequestScope2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentUpdateRequestScope2 value)
        {
            return value switch
            {
                BetaPublicEnvironmentUpdateRequestScope2.Account => "account",
                BetaPublicEnvironmentUpdateRequestScope2.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentUpdateRequestScope2? ToEnum(string value)
        {
            return value switch
            {
                "account" => BetaPublicEnvironmentUpdateRequestScope2.Account,
                "organization" => BetaPublicEnvironmentUpdateRequestScope2.Organization,
                _ => null,
            };
        }
    }
}