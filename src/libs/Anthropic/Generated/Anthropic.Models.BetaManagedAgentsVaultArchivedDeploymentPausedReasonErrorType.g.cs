
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultArchivedError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType.VaultArchivedError => "vault_archived_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "vault_archived_error" => BetaManagedAgentsVaultArchivedDeploymentPausedReasonErrorType.VaultArchivedError,
                _ => null,
            };
        }
    }
}