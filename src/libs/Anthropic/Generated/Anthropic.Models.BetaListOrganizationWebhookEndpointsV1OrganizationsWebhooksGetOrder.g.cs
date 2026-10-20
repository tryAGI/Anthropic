
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder value)
        {
            return value switch
            {
                BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder.Asc => "asc",
                BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder.Asc,
                "desc" => BetaListOrganizationWebhookEndpointsV1OrganizationsWebhooksGetOrder.Desc,
                _ => null,
            };
        }
    }
}