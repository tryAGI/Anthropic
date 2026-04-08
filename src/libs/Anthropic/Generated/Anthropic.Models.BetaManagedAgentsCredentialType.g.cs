
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultCredential,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialType.VaultCredential => "vault_credential",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialType? ToEnum(string value)
        {
            return value switch
            {
                "vault_credential" => BetaManagedAgentsCredentialType.VaultCredential,
                _ => null,
            };
        }
    }
}