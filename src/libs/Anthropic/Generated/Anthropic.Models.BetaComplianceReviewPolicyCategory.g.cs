
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaComplianceReviewPolicyCategory
    {
        /// <summary>
        ///
        /// </summary>
        AdultContent,
        /// <summary>
        ///
        /// </summary>
        Benign,
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
        Undetermined,
        /// <summary>
        ///
        /// </summary>
        ViolentExtremism,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewPolicyCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewPolicyCategory value)
        {
            return value switch
            {
                BetaComplianceReviewPolicyCategory.AdultContent => "adult_content",
                BetaComplianceReviewPolicyCategory.Benign => "benign",
                BetaComplianceReviewPolicyCategory.Bio => "bio",
                BetaComplianceReviewPolicyCategory.Cgw => "cgw",
                BetaComplianceReviewPolicyCategory.Chem => "chem",
                BetaComplianceReviewPolicyCategory.CompromisedKey => "compromised_key",
                BetaComplianceReviewPolicyCategory.Cyber => "cyber",
                BetaComplianceReviewPolicyCategory.Fraud => "fraud",
                BetaComplianceReviewPolicyCategory.FrontierLlm => "frontier_llm",
                BetaComplianceReviewPolicyCategory.HumanExploitation => "human_exploitation",
                BetaComplianceReviewPolicyCategory.Io => "io",
                BetaComplianceReviewPolicyCategory.Mgw => "mgw",
                BetaComplianceReviewPolicyCategory.Other => "other",
                BetaComplianceReviewPolicyCategory.Radnuc => "radnuc",
                BetaComplianceReviewPolicyCategory.ReasoningExtraction => "reasoning_extraction",
                BetaComplianceReviewPolicyCategory.SelfHarm => "self_harm",
                BetaComplianceReviewPolicyCategory.Surveillance => "surveillance",
                BetaComplianceReviewPolicyCategory.Undetermined => "undetermined",
                BetaComplianceReviewPolicyCategory.ViolentExtremism => "violent_extremism",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewPolicyCategory? ToEnum(string value)
        {
            return value switch
            {
                "adult_content" => BetaComplianceReviewPolicyCategory.AdultContent,
                "benign" => BetaComplianceReviewPolicyCategory.Benign,
                "bio" => BetaComplianceReviewPolicyCategory.Bio,
                "cgw" => BetaComplianceReviewPolicyCategory.Cgw,
                "chem" => BetaComplianceReviewPolicyCategory.Chem,
                "compromised_key" => BetaComplianceReviewPolicyCategory.CompromisedKey,
                "cyber" => BetaComplianceReviewPolicyCategory.Cyber,
                "fraud" => BetaComplianceReviewPolicyCategory.Fraud,
                "frontier_llm" => BetaComplianceReviewPolicyCategory.FrontierLlm,
                "human_exploitation" => BetaComplianceReviewPolicyCategory.HumanExploitation,
                "io" => BetaComplianceReviewPolicyCategory.Io,
                "mgw" => BetaComplianceReviewPolicyCategory.Mgw,
                "other" => BetaComplianceReviewPolicyCategory.Other,
                "radnuc" => BetaComplianceReviewPolicyCategory.Radnuc,
                "reasoning_extraction" => BetaComplianceReviewPolicyCategory.ReasoningExtraction,
                "self_harm" => BetaComplianceReviewPolicyCategory.SelfHarm,
                "surveillance" => BetaComplianceReviewPolicyCategory.Surveillance,
                "undetermined" => BetaComplianceReviewPolicyCategory.Undetermined,
                "violent_extremism" => BetaComplianceReviewPolicyCategory.ViolentExtremism,
                _ => null,
            };
        }
    }
}