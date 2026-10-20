
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Overall verdict of a credential validation probe.
    /// </summary>
    public enum BetaManagedAgentsCredentialValidationStatus
    {
        /// <summary>
        /// The probe reached the MCP server and the server rejected the credential, or no access token is stored. A refresh, if one was tried, didn't recover it. Usually the end user needs to authorize again.
        /// </summary>
        Invalid,
        /// <summary>
        /// The probe couldn't tell whether the credential works, for example because of a network error or because a refresh succeeded but the new access token wasn't tested. Validate the credential again to find out.
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