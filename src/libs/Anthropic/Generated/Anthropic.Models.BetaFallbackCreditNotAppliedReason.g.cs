
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why the reprice was not applied.<br/>
    /// A closed enum; additions to the redemption-check vocabulary arrive as<br/>
    /// deliberate schema updates.
    /// </summary>
    public enum BetaFallbackCreditNotAppliedReason
    {
        /// <summary>
        /// 
        /// </summary>
        BodyMismatch,
        /// <summary>
        /// 
        /// </summary>
        ContinuationExcluded,
        /// <summary>
        /// 
        /// </summary>
        ContinuationOnly,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        InvalidTargetModel,
        /// <summary>
        /// 
        /// </summary>
        NotEnabled,
        /// <summary>
        /// 
        /// </summary>
        RepriceUnavailable,
        /// <summary>
        /// 
        /// </summary>
        TemporarilyUnavailable,
        /// <summary>
        /// 
        /// </summary>
        VariantFieldsPresent,
        /// <summary>
        /// 
        /// </summary>
        WrongOrganization,
        /// <summary>
        /// 
        /// </summary>
        WrongPlatform,
        /// <summary>
        /// 
        /// </summary>
        WrongWorkspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFallbackCreditNotAppliedReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFallbackCreditNotAppliedReason value)
        {
            return value switch
            {
                BetaFallbackCreditNotAppliedReason.BodyMismatch => "body_mismatch",
                BetaFallbackCreditNotAppliedReason.ContinuationExcluded => "continuation_excluded",
                BetaFallbackCreditNotAppliedReason.ContinuationOnly => "continuation_only",
                BetaFallbackCreditNotAppliedReason.Expired => "expired",
                BetaFallbackCreditNotAppliedReason.InvalidTargetModel => "invalid_target_model",
                BetaFallbackCreditNotAppliedReason.NotEnabled => "not_enabled",
                BetaFallbackCreditNotAppliedReason.RepriceUnavailable => "reprice_unavailable",
                BetaFallbackCreditNotAppliedReason.TemporarilyUnavailable => "temporarily_unavailable",
                BetaFallbackCreditNotAppliedReason.VariantFieldsPresent => "variant_fields_present",
                BetaFallbackCreditNotAppliedReason.WrongOrganization => "wrong_organization",
                BetaFallbackCreditNotAppliedReason.WrongPlatform => "wrong_platform",
                BetaFallbackCreditNotAppliedReason.WrongWorkspace => "wrong_workspace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFallbackCreditNotAppliedReason? ToEnum(string value)
        {
            return value switch
            {
                "body_mismatch" => BetaFallbackCreditNotAppliedReason.BodyMismatch,
                "continuation_excluded" => BetaFallbackCreditNotAppliedReason.ContinuationExcluded,
                "continuation_only" => BetaFallbackCreditNotAppliedReason.ContinuationOnly,
                "expired" => BetaFallbackCreditNotAppliedReason.Expired,
                "invalid_target_model" => BetaFallbackCreditNotAppliedReason.InvalidTargetModel,
                "not_enabled" => BetaFallbackCreditNotAppliedReason.NotEnabled,
                "reprice_unavailable" => BetaFallbackCreditNotAppliedReason.RepriceUnavailable,
                "temporarily_unavailable" => BetaFallbackCreditNotAppliedReason.TemporarilyUnavailable,
                "variant_fields_present" => BetaFallbackCreditNotAppliedReason.VariantFieldsPresent,
                "wrong_organization" => BetaFallbackCreditNotAppliedReason.WrongOrganization,
                "wrong_platform" => BetaFallbackCreditNotAppliedReason.WrongPlatform,
                "wrong_workspace" => BetaFallbackCreditNotAppliedReason.WrongWorkspace,
                _ => null,
            };
        }
    }
}