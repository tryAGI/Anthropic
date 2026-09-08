
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder
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
    public static class BetaGetUsersV1OrganizationsAnalyticsUsersGetOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder value)
        {
            return value switch
            {
                BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder.Asc => "asc",
                BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder.Asc,
                "desc" => BetaGetUsersV1OrganizationsAnalyticsUsersGetOrder.Desc,
                _ => null,
            };
        }
    }
}