
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which check failed, such as `label_mismatch` or `grant_mismatch`. Anthropic may add values.
    /// </summary>
    public enum BetaGoogleManagedStorageFailedCheckCheck
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
    public static class BetaGoogleManagedStorageFailedCheckCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGoogleManagedStorageFailedCheckCheck value)
        {
            return value switch
            {
                BetaGoogleManagedStorageFailedCheckCheck.BucketSettings => "bucket_settings",
                BetaGoogleManagedStorageFailedCheckCheck.DeletionPolicy => "deletion_policy",
                BetaGoogleManagedStorageFailedCheckCheck.Encryption => "encryption",
                BetaGoogleManagedStorageFailedCheckCheck.GrantMismatch => "grant_mismatch",
                BetaGoogleManagedStorageFailedCheckCheck.KmsKeyRefused => "kms_key_refused",
                BetaGoogleManagedStorageFailedCheckCheck.LabelMismatch => "label_mismatch",
                BetaGoogleManagedStorageFailedCheckCheck.LifecycleRules => "lifecycle_rules",
                BetaGoogleManagedStorageFailedCheckCheck.LocationMismatch => "location_mismatch",
                BetaGoogleManagedStorageFailedCheckCheck.ProbeFailed => "probe_failed",
                BetaGoogleManagedStorageFailedCheckCheck.ProjectNotVerified => "project_not_verified",
                BetaGoogleManagedStorageFailedCheckCheck.Versioning => "versioning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGoogleManagedStorageFailedCheckCheck? ToEnum(string value)
        {
            return value switch
            {
                "bucket_settings" => BetaGoogleManagedStorageFailedCheckCheck.BucketSettings,
                "deletion_policy" => BetaGoogleManagedStorageFailedCheckCheck.DeletionPolicy,
                "encryption" => BetaGoogleManagedStorageFailedCheckCheck.Encryption,
                "grant_mismatch" => BetaGoogleManagedStorageFailedCheckCheck.GrantMismatch,
                "kms_key_refused" => BetaGoogleManagedStorageFailedCheckCheck.KmsKeyRefused,
                "label_mismatch" => BetaGoogleManagedStorageFailedCheckCheck.LabelMismatch,
                "lifecycle_rules" => BetaGoogleManagedStorageFailedCheckCheck.LifecycleRules,
                "location_mismatch" => BetaGoogleManagedStorageFailedCheckCheck.LocationMismatch,
                "probe_failed" => BetaGoogleManagedStorageFailedCheckCheck.ProbeFailed,
                "project_not_verified" => BetaGoogleManagedStorageFailedCheckCheck.ProjectNotVerified,
                "versioning" => BetaGoogleManagedStorageFailedCheckCheck.Versioning,
                _ => null,
            };
        }
    }
}