
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsVaultType
    {
        /// <summary>
        /// 
        /// </summary>
        Vault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsVaultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsVaultType value)
        {
            return value switch
            {
                BetaManagedAgentsVaultType.Vault => "vault",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsVaultType? ToEnum(string value)
        {
            return value switch
            {
                "vault" => BetaManagedAgentsVaultType.Vault,
                _ => null,
            };
        }
    }
}