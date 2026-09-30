
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ListInvitesV1OrganizationsInvitesGetStatuse
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
    public static class ListInvitesV1OrganizationsInvitesGetStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListInvitesV1OrganizationsInvitesGetStatuse value)
        {
            return value switch
            {
                ListInvitesV1OrganizationsInvitesGetStatuse.Accepted => "accepted",
                ListInvitesV1OrganizationsInvitesGetStatuse.Expired => "expired",
                ListInvitesV1OrganizationsInvitesGetStatuse.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListInvitesV1OrganizationsInvitesGetStatuse? ToEnum(string value)
        {
            return value switch
            {
                "accepted" => ListInvitesV1OrganizationsInvitesGetStatuse.Accepted,
                "expired" => ListInvitesV1OrganizationsInvitesGetStatuse.Expired,
                "pending" => ListInvitesV1OrganizationsInvitesGetStatuse.Pending,
                _ => null,
            };
        }
    }
}