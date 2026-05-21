
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Outcome of a refresh-token exchange attempted during credential validation.
    /// </summary>
    public enum BetaManagedAgentsCredentialRefreshStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ConnectError,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        NoRefreshToken,
        /// <summary>
        /// 
        /// </summary>
        Succeeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsCredentialRefreshStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsCredentialRefreshStatus value)
        {
            return value switch
            {
                BetaManagedAgentsCredentialRefreshStatus.ConnectError => "connect_error",
                BetaManagedAgentsCredentialRefreshStatus.Failed => "failed",
                BetaManagedAgentsCredentialRefreshStatus.NoRefreshToken => "no_refresh_token",
                BetaManagedAgentsCredentialRefreshStatus.Succeeded => "succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsCredentialRefreshStatus? ToEnum(string value)
        {
            return value switch
            {
                "connect_error" => BetaManagedAgentsCredentialRefreshStatus.ConnectError,
                "failed" => BetaManagedAgentsCredentialRefreshStatus.Failed,
                "no_refresh_token" => BetaManagedAgentsCredentialRefreshStatus.NoRefreshToken,
                "succeeded" => BetaManagedAgentsCredentialRefreshStatus.Succeeded,
                _ => null,
            };
        }
    }
}