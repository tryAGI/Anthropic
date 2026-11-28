
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewViolatedPolicyCategory
    {
        /// <summary>
        ///
        /// </summary>
        AdultContent,
        /// <summary>
        ///
        /// </summary>
        Bio,
        /// <summary>
        ///
        /// </summary>
        Cgw,
        /// <summary>
        ///
        /// </summary>
        Chem,
        /// <summary>
        ///
        /// </summary>
        CompromisedKey,
        /// <summary>
        ///
        /// </summary>
        Cyber,
        /// <summary>
        ///
        /// </summary>
        Fraud,
        /// <summary>
        ///
        /// </summary>
        FrontierLlm,
        /// <summary>
        ///
        /// </summary>
        HumanExploitation,
        /// <summary>
        ///
        /// </summary>
        Io,
        /// <summary>
        ///
        /// </summary>
        Mgw,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Radnuc,
        /// <summary>
        ///
        /// </summary>
        ReasoningExtraction,
        /// <summary>
        ///
        /// </summary>
        SelfHarm,
        /// <summary>
        ///
        /// </summary>
        Surveillance,
        /// <summary>
        ///
        /// </summary>
        ViolentExtremism,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewViolatedPolicyCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewViolatedPolicyCategory value)
        {
            return value switch
            {
                BetaComplianceReviewViolatedPolicyCategory.AdultContent => "adult_content",
                BetaComplianceReviewViolatedPolicyCategory.Bio => "bio",
                BetaComplianceReviewViolatedPolicyCategory.Cgw => "cgw",
                BetaComplianceReviewViolatedPolicyCategory.Chem => "chem",
                BetaComplianceReviewViolatedPolicyCategory.CompromisedKey => "compromised_key",
                BetaComplianceReviewViolatedPolicyCategory.Cyber => "cyber",
                BetaComplianceReviewViolatedPolicyCategory.Fraud => "fraud",
                BetaComplianceReviewViolatedPolicyCategory.FrontierLlm => "frontier_llm",
                BetaComplianceReviewViolatedPolicyCategory.HumanExploitation => "human_exploitation",
                BetaComplianceReviewViolatedPolicyCategory.Io => "io",
                BetaComplianceReviewViolatedPolicyCategory.Mgw => "mgw",
                BetaComplianceReviewViolatedPolicyCategory.Other => "other",
                BetaComplianceReviewViolatedPolicyCategory.Radnuc => "radnuc",
                BetaComplianceReviewViolatedPolicyCategory.ReasoningExtraction => "reasoning_extraction",
                BetaComplianceReviewViolatedPolicyCategory.SelfHarm => "self_harm",
                BetaComplianceReviewViolatedPolicyCategory.Surveillance => "surveillance",
                BetaComplianceReviewViolatedPolicyCategory.ViolentExtremism => "violent_extremism",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewViolatedPolicyCategory? ToEnum(string value)
        {
            return value switch
            {
                "adult_content" => BetaComplianceReviewViolatedPolicyCategory.AdultContent,
                "bio" => BetaComplianceReviewViolatedPolicyCategory.Bio,
                "cgw" => BetaComplianceReviewViolatedPolicyCategory.Cgw,
                "chem" => BetaComplianceReviewViolatedPolicyCategory.Chem,
                "compromised_key" => BetaComplianceReviewViolatedPolicyCategory.CompromisedKey,
                "cyber" => BetaComplianceReviewViolatedPolicyCategory.Cyber,
                "fraud" => BetaComplianceReviewViolatedPolicyCategory.Fraud,
                "frontier_llm" => BetaComplianceReviewViolatedPolicyCategory.FrontierLlm,
                "human_exploitation" => BetaComplianceReviewViolatedPolicyCategory.HumanExploitation,
                "io" => BetaComplianceReviewViolatedPolicyCategory.Io,
                "mgw" => BetaComplianceReviewViolatedPolicyCategory.Mgw,
                "other" => BetaComplianceReviewViolatedPolicyCategory.Other,
                "radnuc" => BetaComplianceReviewViolatedPolicyCategory.Radnuc,
                "reasoning_extraction" => BetaComplianceReviewViolatedPolicyCategory.ReasoningExtraction,
                "self_harm" => BetaComplianceReviewViolatedPolicyCategory.SelfHarm,
                "surveillance" => BetaComplianceReviewViolatedPolicyCategory.Surveillance,
                "violent_extremism" => BetaComplianceReviewViolatedPolicyCategory.ViolentExtremism,
                _ => null,
            };
        }
    }
}