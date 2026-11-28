
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalStorageFailedCheckRole
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
        Transcripts,
        /// <summary>
        ///
        /// </summary>
        TranscriptsVerify,
        /// <summary>
        ///
        /// </summary>
        Verify,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExternalStorageFailedCheckRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalStorageFailedCheckRole value)
        {
            return value switch
            {
                BetaExternalStorageFailedCheckRole.Ingest => "ingest",
                BetaExternalStorageFailedCheckRole.Maintenance => "maintenance",
                BetaExternalStorageFailedCheckRole.MediaErasure => "media_erasure",
                BetaExternalStorageFailedCheckRole.Read => "read",
                BetaExternalStorageFailedCheckRole.Transcripts => "transcripts",
                BetaExternalStorageFailedCheckRole.TranscriptsVerify => "transcripts_verify",
                BetaExternalStorageFailedCheckRole.Verify => "verify",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalStorageFailedCheckRole? ToEnum(string value)
        {
            return value switch
            {
                "ingest" => BetaExternalStorageFailedCheckRole.Ingest,
                "maintenance" => BetaExternalStorageFailedCheckRole.Maintenance,
                "media_erasure" => BetaExternalStorageFailedCheckRole.MediaErasure,
                "read" => BetaExternalStorageFailedCheckRole.Read,
                "transcripts" => BetaExternalStorageFailedCheckRole.Transcripts,
                "transcripts_verify" => BetaExternalStorageFailedCheckRole.TranscriptsVerify,
                "verify" => BetaExternalStorageFailedCheckRole.Verify,
                _ => null,
            };
        }
    }
}