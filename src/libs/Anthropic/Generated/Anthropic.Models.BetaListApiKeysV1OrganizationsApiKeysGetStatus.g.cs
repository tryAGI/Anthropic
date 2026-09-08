
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaListApiKeysV1OrganizationsApiKeysGetStatus
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
    public static class BetaListApiKeysV1OrganizationsApiKeysGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaListApiKeysV1OrganizationsApiKeysGetStatus value)
        {
            return value switch
            {
                BetaListApiKeysV1OrganizationsApiKeysGetStatus.Active => "active",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus.Archived => "archived",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus.Expired => "expired",
                BetaListApiKeysV1OrganizationsApiKeysGetStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaListApiKeysV1OrganizationsApiKeysGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaListApiKeysV1OrganizationsApiKeysGetStatus.Active,
                "archived" => BetaListApiKeysV1OrganizationsApiKeysGetStatus.Archived,
                "expired" => BetaListApiKeysV1OrganizationsApiKeysGetStatus.Expired,
                "inactive" => BetaListApiKeysV1OrganizationsApiKeysGetStatus.Inactive,
                _ => null,
            };
        }
    }
}