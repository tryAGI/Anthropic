
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent
    {
        /// <summary>
        ///
        /// </summary>
        UserProfileEnforcementActionOpened,
        /// <summary>
        ///
        /// </summary>
        UserProfileEnforcementActionResolved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent value)
        {
            return value switch
            {
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionOpened => "user_profile.enforcement_action_opened",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionResolved => "user_profile.enforcement_action_resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent? ToEnum(string value)
        {
            return value switch
            {
                "user_profile.enforcement_action_opened" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionOpened,
                "user_profile.enforcement_action_resolved" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionResolved,
                _ => null,
            };
        }
    }
}