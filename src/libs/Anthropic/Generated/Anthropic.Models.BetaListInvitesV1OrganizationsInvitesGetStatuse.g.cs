
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListInvitesV1OrganizationsInvitesGetStatuse
    {
        /// <summary>
        ///
        /// </summary>
        Accepted,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListInvitesV1OrganizationsInvitesGetStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListInvitesV1OrganizationsInvitesGetStatuse value)
        {
            return value switch
            {
                BetaListInvitesV1OrganizationsInvitesGetStatuse.Accepted => "accepted",
                BetaListInvitesV1OrganizationsInvitesGetStatuse.Expired => "expired",
                BetaListInvitesV1OrganizationsInvitesGetStatuse.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListInvitesV1OrganizationsInvitesGetStatuse? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => BetaListInvitesV1OrganizationsInvitesGetStatuse.Accepted,
                "expired" => BetaListInvitesV1OrganizationsInvitesGetStatuse.Expired,
                "pending" => BetaListInvitesV1OrganizationsInvitesGetStatuse.Pending,
                _ => null,
            };
        }
    }
}