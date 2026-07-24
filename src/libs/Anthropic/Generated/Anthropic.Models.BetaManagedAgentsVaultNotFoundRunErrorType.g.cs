
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsVaultNotFoundRunErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        VaultNotFoundError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsVaultNotFoundRunErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsVaultNotFoundRunErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsVaultNotFoundRunErrorType.VaultNotFoundError => "vault_not_found_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsVaultNotFoundRunErrorType? ToEnum(string value)
        {
            return value switch
            {
                "vault_not_found_error" => BetaManagedAgentsVaultNotFoundRunErrorType.VaultNotFoundError,
                _ => null,
            };
        }
    }
}