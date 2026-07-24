
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType.VaultNotFoundError => "vault_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType? ToEnum(string value)
        {
            return value switch
            {
                "vault_not_found_error" => BetaManagedAgentsVaultNotFoundDeploymentPausedReasonErrorType.VaultNotFoundError,
                _ => null,
            };
        }
    }
}