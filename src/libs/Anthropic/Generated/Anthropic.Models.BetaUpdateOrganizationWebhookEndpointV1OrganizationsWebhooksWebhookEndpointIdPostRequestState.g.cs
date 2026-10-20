
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `disabled` stops deliveries. `enabled` resumes them and clears `disabled_reason`. Events that happen while the endpoint is disabled are never delivered.
    /// </summary>
    public enum BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState
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
    public static class BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState value)
        {
            return value switch
            {
                BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState.Disabled => "disabled",
                BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState.Disabled,
                "enabled" => BetaUpdateOrganizationWebhookEndpointV1OrganizationsWebhooksWebhookEndpointIdPostRequestState.Enabled,
                _ => null,
            };
        }
    }
}