
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
    public static class BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent value)
        {
            return value switch
            {
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalKeyFailed => "external_key.failed",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalKeyRecovered => "external_key.recovered",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalStorageFailed => "external_storage.failed",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalStorageRecovered => "external_storage.recovered",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionOpened => "user_profile.enforcement_action_opened",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionResolved => "user_profile.enforcement_action_resolved",
                BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileProgramStatusUpdated => "user_profile.program_status_updated",
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
                "external_key.failed" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalKeyFailed,
                "external_key.recovered" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalKeyRecovered,
                "external_storage.failed" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalStorageFailed,
                "external_storage.recovered" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.ExternalStorageRecovered,
                "user_profile.enforcement_action_opened" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionOpened,
                "user_profile.enforcement_action_resolved" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileEnforcementActionResolved,
                "user_profile.program_status_updated" => BetaCreateOrganizationWebhookEndpointV1OrganizationsWebhooksPostRequestEnabledEvent.UserProfileProgramStatusUpdated,
                _ => null,
            };
        }
    }
}