
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsVaultArchivedRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsVaultArchivedRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsVaultArchivedRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsVaultArchivedRunErrorType.VaultArchivedError => "vault_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsVaultArchivedRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "vault_archived_error" => BetaManagedAgentsVaultArchivedRunErrorType.VaultArchivedError,
                _ => null,
            };
        }
    }
}