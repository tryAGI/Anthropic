
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaNewOrganizationWebhookEndpointEnabledEvent
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
    public static class BetaNewOrganizationWebhookEndpointEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaNewOrganizationWebhookEndpointEnabledEvent value)
        {
            return value switch
            {
                BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened => "user_profile.enforcement_action_opened",
                BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved => "user_profile.enforcement_action_resolved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaNewOrganizationWebhookEndpointEnabledEvent? ToEnum(string value)
        {
            return value switch
            {
                "user_profile.enforcement_action_opened" => BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened,
                "user_profile.enforcement_action_resolved" => BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved,
                _ => null,
            };
        }
    }
}