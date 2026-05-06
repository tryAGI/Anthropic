
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialValidationType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialValidation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialValidationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialValidationType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialValidationType.VaultCredentialValidation => "vault_credential_validation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialValidationType? ToEnum(string value)
        {
            return value switch
            {
                "vault_credential_validation" => BetaManagedAgentsCredentialValidationType.VaultCredentialValidation,
                _ => null,
            };
        }
    }
}