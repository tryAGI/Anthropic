
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListApiKeysV1OrganizationsApiKeysGetStatus2
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Archived,
        /// <summary>
        ///
        /// </summary>
        Expired,
        /// <summary>
        ///
        /// </summary>
        Inactive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaListApiKeysV1OrganizationsApiKeysGetStatus2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListApiKeysV1OrganizationsApiKeysGetStatus2 value)
        {
            return value switch
            {
                BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Active => "active",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Archived => "archived",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Expired => "expired",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListApiKeysV1OrganizationsApiKeysGetStatus2? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Active,
                "archived" => BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Archived,
                "expired" => BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Expired,
                "inactive" => BetaListApiKeysV1OrganizationsApiKeysGetStatus2.Inactive,
                _ => null,
            };
        }
    }
}