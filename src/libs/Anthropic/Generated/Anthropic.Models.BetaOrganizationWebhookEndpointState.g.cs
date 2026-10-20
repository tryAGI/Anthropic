
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether deliveries are sent to an organization webhook endpoint.
    /// </summary>
    public enum BetaOrganizationWebhookEndpointState
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOrganizationWebhookEndpointStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOrganizationWebhookEndpointState value)
        {
            return value switch
            {
                BetaOrganizationWebhookEndpointState.Disabled => "disabled",
                BetaOrganizationWebhookEndpointState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOrganizationWebhookEndpointState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaOrganizationWebhookEndpointState.Disabled,
                "enabled" => BetaOrganizationWebhookEndpointState.Enabled,
                _ => null,
            };
        }
    }
}