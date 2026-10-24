
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why Anthropic placed this enforcement action: `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
    /// </summary>
    public enum UserProfileEnforcementActionReason
    {
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        AccountCompromise,
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        FraudOrAbuse,
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        HighHarm,
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        Unspecified,
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        UnsupportedRegion,
        /// <summary>
        /// `unsupported_region`, `fraud_or_abuse`, `high_harm`, `usage_policy_violation`, `account_compromise` or `unspecified`. More values may be added; read a value you do not recognize as `unspecified`.
        /// </summary>
        UsagePolicyViolation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserProfileEnforcementActionReasonExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserProfileEnforcementActionReason value)
        {
            return value switch
            {
                UserProfileEnforcementActionReason.AccountCompromise => "account_compromise",
                UserProfileEnforcementActionReason.FraudOrAbuse => "fraud_or_abuse",
                UserProfileEnforcementActionReason.HighHarm => "high_harm",
                UserProfileEnforcementActionReason.Unspecified => "unspecified",
                UserProfileEnforcementActionReason.UnsupportedRegion => "unsupported_region",
                UserProfileEnforcementActionReason.UsagePolicyViolation => "usage_policy_violation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserProfileEnforcementActionReason? ToEnum(string value)
        {
            return value switch
            {
                "account_compromise" => UserProfileEnforcementActionReason.AccountCompromise,
                "fraud_or_abuse" => UserProfileEnforcementActionReason.FraudOrAbuse,
                "high_harm" => UserProfileEnforcementActionReason.HighHarm,
                "unspecified" => UserProfileEnforcementActionReason.Unspecified,
                "unsupported_region" => UserProfileEnforcementActionReason.UnsupportedRegion,
                "usage_policy_violation" => UserProfileEnforcementActionReason.UsagePolicyViolation,
                _ => null,
            };
        }
    }
}