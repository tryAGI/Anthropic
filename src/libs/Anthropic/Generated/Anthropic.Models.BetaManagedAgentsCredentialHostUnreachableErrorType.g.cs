
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsCredentialHostUnreachableErrorType
    {
        /// <summary>
        /// 
        /// </summary>
        CredentialHostUnreachableError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialHostUnreachableErrorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialHostUnreachableErrorType value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialHostUnreachableErrorType.CredentialHostUnreachableError => "credential_host_unreachable_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialHostUnreachableErrorType? ToEnum(string value)
        {
            return value switch
            {
                "credential_host_unreachable_error" => BetaManagedAgentsCredentialHostUnreachableErrorType.CredentialHostUnreachableError,
                _ => null,
            };
        }
    }
}