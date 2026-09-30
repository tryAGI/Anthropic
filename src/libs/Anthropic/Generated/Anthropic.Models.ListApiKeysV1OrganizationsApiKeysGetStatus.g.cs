
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ListApiKeysV1OrganizationsApiKeysGetStatus
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
    public static class ListApiKeysV1OrganizationsApiKeysGetStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListApiKeysV1OrganizationsApiKeysGetStatus value)
        {
            return value switch
            {
                ListApiKeysV1OrganizationsApiKeysGetStatus.Active => "active",
                ListApiKeysV1OrganizationsApiKeysGetStatus.Archived => "archived",
                ListApiKeysV1OrganizationsApiKeysGetStatus.Expired => "expired",
                ListApiKeysV1OrganizationsApiKeysGetStatus.Inactive => "inactive",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListApiKeysV1OrganizationsApiKeysGetStatus? ToEnum(string value)
        {
            return value switch
            {
                "active" => ListApiKeysV1OrganizationsApiKeysGetStatus.Active,
                "archived" => ListApiKeysV1OrganizationsApiKeysGetStatus.Archived,
                "expired" => ListApiKeysV1OrganizationsApiKeysGetStatus.Expired,
                "inactive" => ListApiKeysV1OrganizationsApiKeysGetStatus.Inactive,
                _ => null,
            };
        }
    }
}