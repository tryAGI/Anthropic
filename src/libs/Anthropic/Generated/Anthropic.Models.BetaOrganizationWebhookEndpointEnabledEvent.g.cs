
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaOrganizationWebhookEndpointEnabledEvent
    {
        /// <summary>
        ///
        /// </summary>
        UserProfileEnforcementActionOpened,
        /// <summary>
        ///
        /// </summary>
        UserProfileEnforcementActionResolved,
        /// <summary>
        ///
        /// </summary>
        UserProfileProgramStatusUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOrganizationWebhookEndpointEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOrganizationWebhookEndpointEnabledEvent value)
        {
            return value switch
            {
                BetaOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened => "user_profile.enforcement_action_opened",
                BetaOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved => "user_profile.enforcement_action_resolved",
                BetaOrganizationWebhookEndpointEnabledEvent.UserProfileProgramStatusUpdated => "user_profile.program_status_updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOrganizationWebhookEndpointEnabledEvent? ToEnum(string value)
        {
            return value switch
            {
                "user_profile.enforcement_action_opened" => BetaOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened,
                "user_profile.enforcement_action_resolved" => BetaOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved,
                "user_profile.program_status_updated" => BetaOrganizationWebhookEndpointEnabledEvent.UserProfileProgramStatusUpdated,
                _ => null,
            };
        }
    }
}