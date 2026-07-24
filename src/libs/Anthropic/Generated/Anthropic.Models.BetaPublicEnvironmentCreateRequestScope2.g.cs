
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaPublicEnvironmentCreateRequestScope2
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
    public static class BetaPublicEnvironmentCreateRequestScope2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPublicEnvironmentCreateRequestScope2 value)
        {
            return value switch
            {
                BetaPublicEnvironmentCreateRequestScope2.Account => "account",
                BetaPublicEnvironmentCreateRequestScope2.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPublicEnvironmentCreateRequestScope2? ToEnum(string value)
        {
            return value switch
            {
                "account" => BetaPublicEnvironmentCreateRequestScope2.Account,
                "organization" => BetaPublicEnvironmentCreateRequestScope2.Organization,
                _ => null,
            };
        }
    }
}