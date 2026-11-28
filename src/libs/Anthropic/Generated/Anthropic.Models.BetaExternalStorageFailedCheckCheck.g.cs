
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Name of the check that failed, such as `versioning`, for code to branch on. New names may be added; `other` is a check this API does not name. The value is a name with no data of its own.
    /// </summary>
    public enum BetaExternalStorageFailedCheckCheck
    {
        /// <summary>
        ///
        /// </summary>
        AlreadyRegistered,
        /// <summary>
        ///
        /// </summary>
        AssumeRole,
        /// <summary>
        ///
        /// </summary>
        BucketEmpty,
        /// <summary>
        ///
        /// </summary>
        BucketNotConfirmed,
        /// <summary>
        ///
        /// </summary>
        BucketPolicy,
        /// <summary>
        ///
        /// </summary>
        BucketSettings,
        /// <summary>
        ///
        /// </summary>
        DefaultEncryption,
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
        KeyUsable,
        /// <summary>
        ///
        /// </summary>
        KmsKeyRefused,
        /// <summary>
        ///
        /// </summary>
        LifecycleNoArchive,
        /// <summary>
        ///
        /// </summary>
        LifecycleRules,
        /// <summary>
        ///
        /// </summary>
        LifecycleTemplate,
        /// <summary>
        ///
        /// </summary>
        LocationMismatch,
        /// <summary>
        ///
        /// </summary>
        ObjectLock,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        OwnershipEnforced,
        /// <summary>
        ///
        /// </summary>
        ProbeFailed,
        /// <summary>
        ///
        /// </summary>
        ProbeObject,
        /// <summary>
        ///
        /// </summary>
        ProbeStorageClass,
        /// <summary>
        ///
        /// </summary>
        PublicAccessBlock,
        /// <summary>
        ///
        /// </summary>
        Region,
        /// <summary>
        ///
        /// </summary>
        Replication,
        /// <summary>
        ///
        /// </summary>
        RequestMetrics,
        /// <summary>
        ///
        /// </summary>
        RequestPayment,
        /// <summary>
        ///
        /// </summary>
        TranscriptsSupport,
        /// <summary>
        ///
        /// </summary>
        TrustIngestRole,
        /// <summary>
        ///
        /// </summary>
        TrustMaintenanceRole,
        /// <summary>
        ///
        /// </summary>
        TrustMediaErasureRole,
        /// <summary>
        ///
        /// </summary>
        TrustReadRole,
        /// <summary>
        ///
        /// </summary>
        TrustTranscriptsRole,
        /// <summary>
        ///
        /// </summary>
        TrustTranscriptsVerifyRole,
        /// <summary>
        ///
        /// </summary>
        TrustVerifyRole,
        /// <summary>
        ///
        /// </summary>
        Versioning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExternalStorageFailedCheckCheckExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalStorageFailedCheckCheck value)
        {
            return value switch
            {
                BetaExternalStorageFailedCheckCheck.AlreadyRegistered => "already_registered",
                BetaExternalStorageFailedCheckCheck.AssumeRole => "assume_role",
                BetaExternalStorageFailedCheckCheck.BucketEmpty => "bucket_empty",
                BetaExternalStorageFailedCheckCheck.BucketNotConfirmed => "bucket_not_confirmed",
                BetaExternalStorageFailedCheckCheck.BucketPolicy => "bucket_policy",
                BetaExternalStorageFailedCheckCheck.BucketSettings => "bucket_settings",
                BetaExternalStorageFailedCheckCheck.DefaultEncryption => "default_encryption",
                BetaExternalStorageFailedCheckCheck.DeletionPolicy => "deletion_policy",
                BetaExternalStorageFailedCheckCheck.Encryption => "encryption",
                BetaExternalStorageFailedCheckCheck.GrantMismatch => "grant_mismatch",
                BetaExternalStorageFailedCheckCheck.KeyUsable => "key_usable",
                BetaExternalStorageFailedCheckCheck.KmsKeyRefused => "kms_key_refused",
                BetaExternalStorageFailedCheckCheck.LifecycleNoArchive => "lifecycle_no_archive",
                BetaExternalStorageFailedCheckCheck.LifecycleRules => "lifecycle_rules",
                BetaExternalStorageFailedCheckCheck.LifecycleTemplate => "lifecycle_template",
                BetaExternalStorageFailedCheckCheck.LocationMismatch => "location_mismatch",
                BetaExternalStorageFailedCheckCheck.ObjectLock => "object_lock",
                BetaExternalStorageFailedCheckCheck.Other => "other",
                BetaExternalStorageFailedCheckCheck.OwnershipEnforced => "ownership_enforced",
                BetaExternalStorageFailedCheckCheck.ProbeFailed => "probe_failed",
                BetaExternalStorageFailedCheckCheck.ProbeObject => "probe_object",
                BetaExternalStorageFailedCheckCheck.ProbeStorageClass => "probe_storage_class",
                BetaExternalStorageFailedCheckCheck.PublicAccessBlock => "public_access_block",
                BetaExternalStorageFailedCheckCheck.Region => "region",
                BetaExternalStorageFailedCheckCheck.Replication => "replication",
                BetaExternalStorageFailedCheckCheck.RequestMetrics => "request_metrics",
                BetaExternalStorageFailedCheckCheck.RequestPayment => "request_payment",
                BetaExternalStorageFailedCheckCheck.TranscriptsSupport => "transcripts_support",
                BetaExternalStorageFailedCheckCheck.TrustIngestRole => "trust_ingest_role",
                BetaExternalStorageFailedCheckCheck.TrustMaintenanceRole => "trust_maintenance_role",
                BetaExternalStorageFailedCheckCheck.TrustMediaErasureRole => "trust_media_erasure_role",
                BetaExternalStorageFailedCheckCheck.TrustReadRole => "trust_read_role",
                BetaExternalStorageFailedCheckCheck.TrustTranscriptsRole => "trust_transcripts_role",
                BetaExternalStorageFailedCheckCheck.TrustTranscriptsVerifyRole => "trust_transcripts_verify_role",
                BetaExternalStorageFailedCheckCheck.TrustVerifyRole => "trust_verify_role",
                BetaExternalStorageFailedCheckCheck.Versioning => "versioning",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalStorageFailedCheckCheck? ToEnum(string value)
        {
            return value switch
            {
                "already_registered" => BetaExternalStorageFailedCheckCheck.AlreadyRegistered,
                "assume_role" => BetaExternalStorageFailedCheckCheck.AssumeRole,
                "bucket_empty" => BetaExternalStorageFailedCheckCheck.BucketEmpty,
                "bucket_not_confirmed" => BetaExternalStorageFailedCheckCheck.BucketNotConfirmed,
                "bucket_policy" => BetaExternalStorageFailedCheckCheck.BucketPolicy,
                "bucket_settings" => BetaExternalStorageFailedCheckCheck.BucketSettings,
                "default_encryption" => BetaExternalStorageFailedCheckCheck.DefaultEncryption,
                "deletion_policy" => BetaExternalStorageFailedCheckCheck.DeletionPolicy,
                "encryption" => BetaExternalStorageFailedCheckCheck.Encryption,
                "grant_mismatch" => BetaExternalStorageFailedCheckCheck.GrantMismatch,
                "key_usable" => BetaExternalStorageFailedCheckCheck.KeyUsable,
                "kms_key_refused" => BetaExternalStorageFailedCheckCheck.KmsKeyRefused,
                "lifecycle_no_archive" => BetaExternalStorageFailedCheckCheck.LifecycleNoArchive,
                "lifecycle_rules" => BetaExternalStorageFailedCheckCheck.LifecycleRules,
                "lifecycle_template" => BetaExternalStorageFailedCheckCheck.LifecycleTemplate,
                "location_mismatch" => BetaExternalStorageFailedCheckCheck.LocationMismatch,
                "object_lock" => BetaExternalStorageFailedCheckCheck.ObjectLock,
                "other" => BetaExternalStorageFailedCheckCheck.Other,
                "ownership_enforced" => BetaExternalStorageFailedCheckCheck.OwnershipEnforced,
                "probe_failed" => BetaExternalStorageFailedCheckCheck.ProbeFailed,
                "probe_object" => BetaExternalStorageFailedCheckCheck.ProbeObject,
                "probe_storage_class" => BetaExternalStorageFailedCheckCheck.ProbeStorageClass,
                "public_access_block" => BetaExternalStorageFailedCheckCheck.PublicAccessBlock,
                "region" => BetaExternalStorageFailedCheckCheck.Region,
                "replication" => BetaExternalStorageFailedCheckCheck.Replication,
                "request_metrics" => BetaExternalStorageFailedCheckCheck.RequestMetrics,
                "request_payment" => BetaExternalStorageFailedCheckCheck.RequestPayment,
                "transcripts_support" => BetaExternalStorageFailedCheckCheck.TranscriptsSupport,
                "trust_ingest_role" => BetaExternalStorageFailedCheckCheck.TrustIngestRole,
                "trust_maintenance_role" => BetaExternalStorageFailedCheckCheck.TrustMaintenanceRole,
                "trust_media_erasure_role" => BetaExternalStorageFailedCheckCheck.TrustMediaErasureRole,
                "trust_read_role" => BetaExternalStorageFailedCheckCheck.TrustReadRole,
                "trust_transcripts_role" => BetaExternalStorageFailedCheckCheck.TrustTranscriptsRole,
                "trust_transcripts_verify_role" => BetaExternalStorageFailedCheckCheck.TrustTranscriptsVerifyRole,
                "trust_verify_role" => BetaExternalStorageFailedCheckCheck.TrustVerifyRole,
                "versioning" => BetaExternalStorageFailedCheckCheck.Versioning,
                _ => null,
            };
        }
    }
}