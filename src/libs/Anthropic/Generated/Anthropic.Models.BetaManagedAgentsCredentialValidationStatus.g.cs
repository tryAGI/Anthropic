
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Overall verdict of a credential validation probe.
    /// </summary>
    public enum BetaManagedAgentsCredentialValidationStatus
    {
        /// <summary>
        /// The probe reached the MCP server and was rejected, and a refresh (if attempted) did not recover it.
        /// </summary>
        Invalid,
        /// <summary>
        /// The probe could not determine validity — for example, a transport error or a successful refresh that was not re-probed.
        /// </summary>
        Unknown,
        /// <summary>
        /// The credential successfully authenticated against its MCP server.
        /// </summary>
        Valid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialValidationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialValidationStatus value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialValidationStatus.Invalid => "invalid",
                BetaManagedAgentsCredentialValidationStatus.Unknown => "unknown",
                BetaManagedAgentsCredentialValidationStatus.Valid => "valid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialValidationStatus? ToEnum(string value)
        {
            return value switch
            {
                "invalid" => BetaManagedAgentsCredentialValidationStatus.Invalid,
                "unknown" => BetaManagedAgentsCredentialValidationStatus.Unknown,
                "valid" => BetaManagedAgentsCredentialValidationStatus.Valid,
                _ => null,
            };
        }
    }
}