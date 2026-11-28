
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
        ExternalKeyFailed,
        /// <summary>
        ///
        /// </summary>
        ExternalKeyRecovered,
        /// <summary>
        ///
        /// </summary>
        ExternalStorageFailed,
        /// <summary>
        ///
        /// </summary>
        ExternalStorageRecovered,
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
    public static class BetaNewOrganizationWebhookEndpointEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaNewOrganizationWebhookEndpointEnabledEvent value)
        {
            return value switch
            {
                BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalKeyFailed => "external_key.failed",
                BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalKeyRecovered => "external_key.recovered",
                BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalStorageFailed => "external_storage.failed",
                BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalStorageRecovered => "external_storage.recovered",
                BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened => "user_profile.enforcement_action_opened",
                BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved => "user_profile.enforcement_action_resolved",
                BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileProgramStatusUpdated => "user_profile.program_status_updated",
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
                "external_key.failed" => BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalKeyFailed,
                "external_key.recovered" => BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalKeyRecovered,
                "external_storage.failed" => BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalStorageFailed,
                "external_storage.recovered" => BetaNewOrganizationWebhookEndpointEnabledEvent.ExternalStorageRecovered,
                "user_profile.enforcement_action_opened" => BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionOpened,
                "user_profile.enforcement_action_resolved" => BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileEnforcementActionResolved,
                "user_profile.program_status_updated" => BetaNewOrganizationWebhookEndpointEnabledEvent.UserProfileProgramStatusUpdated,
                _ => null,
            };
        }
    }
}