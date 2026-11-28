
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaStorageFailedCheckRole
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
    public static class BetaStorageFailedCheckRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStorageFailedCheckRole value)
        {
            return value switch
            {
                BetaStorageFailedCheckRole.Ingest => "ingest",
                BetaStorageFailedCheckRole.Maintenance => "maintenance",
                BetaStorageFailedCheckRole.MediaErasure => "media_erasure",
                BetaStorageFailedCheckRole.Read => "read",
                BetaStorageFailedCheckRole.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStorageFailedCheckRole? ToEnum(string value)
        {
            return value switch
            {
                "ingest" => BetaStorageFailedCheckRole.Ingest,
                "maintenance" => BetaStorageFailedCheckRole.Maintenance,
                "media_erasure" => BetaStorageFailedCheckRole.MediaErasure,
                "read" => BetaStorageFailedCheckRole.Read,
                "verify" => BetaStorageFailedCheckRole.Verify,
                _ => null,
            };
        }
    }
}