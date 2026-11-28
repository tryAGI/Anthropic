
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
    /// </summary>
    public enum BetaStorageFailedCheckCheck
    {
        /// <summary>
        ///
        /// </summary>
        BucketSettings,
        /// <summary>
        ///
        /// </summary>
        DeletionPolicy,
        /// <summary>
        ///
        /// </summary>
        Encryption,
        /// <summary>
        ///
        /// </summary>
        GrantMismatch,
        /// <summary>
        ///
        /// </summary>
        KmsKeyRefused,
        /// <summary>
        ///
        /// </summary>
        LabelMismatch,
        /// <summary>
        ///
        /// </summary>
        LifecycleRules,
        /// <summary>
        ///
        /// </summary>
        LocationMismatch,
        /// <summary>
        ///
        /// </summary>
        ProbeFailed,
        /// <summary>
        ///
        /// </summary>
        ProjectNotVerified,
        /// <summary>
        ///
        /// </summary>
        Versioning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaStorageFailedCheckCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaStorageFailedCheckCheck value)
        {
            return value switch
            {
                BetaStorageFailedCheckCheck.BucketSettings => "bucket_settings",
                BetaStorageFailedCheckCheck.DeletionPolicy => "deletion_policy",
                BetaStorageFailedCheckCheck.Encryption => "encryption",
                BetaStorageFailedCheckCheck.GrantMismatch => "grant_mismatch",
                BetaStorageFailedCheckCheck.KmsKeyRefused => "kms_key_refused",
                BetaStorageFailedCheckCheck.LabelMismatch => "label_mismatch",
                BetaStorageFailedCheckCheck.LifecycleRules => "lifecycle_rules",
                BetaStorageFailedCheckCheck.LocationMismatch => "location_mismatch",
                BetaStorageFailedCheckCheck.ProbeFailed => "probe_failed",
                BetaStorageFailedCheckCheck.ProjectNotVerified => "project_not_verified",
                BetaStorageFailedCheckCheck.Versioning => "versioning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaStorageFailedCheckCheck? ToEnum(string value)
        {
            return value switch
            {
                "bucket_settings" => BetaStorageFailedCheckCheck.BucketSettings,
                "deletion_policy" => BetaStorageFailedCheckCheck.DeletionPolicy,
                "encryption" => BetaStorageFailedCheckCheck.Encryption,
                "grant_mismatch" => BetaStorageFailedCheckCheck.GrantMismatch,
                "kms_key_refused" => BetaStorageFailedCheckCheck.KmsKeyRefused,
                "label_mismatch" => BetaStorageFailedCheckCheck.LabelMismatch,
                "lifecycle_rules" => BetaStorageFailedCheckCheck.LifecycleRules,
                "location_mismatch" => BetaStorageFailedCheckCheck.LocationMismatch,
                "probe_failed" => BetaStorageFailedCheckCheck.ProbeFailed,
                "project_not_verified" => BetaStorageFailedCheckCheck.ProjectNotVerified,
                "versioning" => BetaStorageFailedCheckCheck.Versioning,
                _ => null,
            };
        }
    }
}