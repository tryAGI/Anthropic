
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsDeletedCredentialType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultCredentialDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsDeletedCredentialTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsDeletedCredentialType value)
        {
            return value switch
            {
                BetaManagedAgentsDeletedCredentialType.VaultCredentialDeleted => "vault_credential_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsDeletedCredentialType? ToEnum(string value)
        {
            return value switch
            {
                "vault_credential_deleted" => BetaManagedAgentsDeletedCredentialType.VaultCredentialDeleted,
                _ => null,
            };
        }
    }
}