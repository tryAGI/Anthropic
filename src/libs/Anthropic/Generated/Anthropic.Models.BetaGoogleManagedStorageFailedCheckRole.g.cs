
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGoogleManagedStorageFailedCheckRole
    {
        /// <summary>
        ///
        /// </summary>
        Ingest,
        /// <summary>
        ///
        /// </summary>
        Maintenance,
        /// <summary>
        ///
        /// </summary>
        MediaErasure,
        /// <summary>
        ///
        /// </summary>
        Read,
        /// <summary>
        ///
        /// </summary>
        Verify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaGoogleManagedStorageFailedCheckRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedStorageFailedCheckRole value)
        {
            return value switch
            {
                BetaGoogleManagedStorageFailedCheckRole.Ingest => "ingest",
                BetaGoogleManagedStorageFailedCheckRole.Maintenance => "maintenance",
                BetaGoogleManagedStorageFailedCheckRole.MediaErasure => "media_erasure",
                BetaGoogleManagedStorageFailedCheckRole.Read => "read",
                BetaGoogleManagedStorageFailedCheckRole.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedStorageFailedCheckRole? ToEnum(string value)
        {
            return value switch
            {
                "ingest" => BetaGoogleManagedStorageFailedCheckRole.Ingest,
                "maintenance" => BetaGoogleManagedStorageFailedCheckRole.Maintenance,
                "media_erasure" => BetaGoogleManagedStorageFailedCheckRole.MediaErasure,
                "read" => BetaGoogleManagedStorageFailedCheckRole.Read,
                "verify" => BetaGoogleManagedStorageFailedCheckRole.Verify,
                _ => null,
            };
        }
    }
}