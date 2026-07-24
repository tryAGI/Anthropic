
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The policy category that triggered a refusal.
    /// </summary>
    public enum BetaRefusalCategory
    {
        /// <summary>
        /// The request could enable biological harm, such as dangerous lab methods. Beneficial life sciences work can also trigger this category.
        /// </summary>
        Bio,
        /// <summary>
        /// The request could enable cyber harm, such as malware or exploit development. Benign cybersecurity work can also trigger this category.
        /// </summary>
        Cyber,
        /// <summary>
        /// The request could assist the development of competing AI models, which is restricted under [Anthropic's commercial terms](https://www.anthropic.com/legal/commercial-terms). Benign machine learning work can also trigger this category.
        /// </summary>
        FrontierLlm,
        /// <summary>
        /// The request could be related to an area that was determined as harmful. Benign work might sometimes trigger this category.
        /// </summary>
        GeneralHarms,
        /// <summary>
        /// The request asks the model to reproduce its internal reasoning in the response text. To get reasoning in a structured form instead, use [adaptive thinking](https://platform.claude.com/docs/en/build-with-claude/adaptive-thinking).
        /// </summary>
        ReasoningExtraction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRefusalCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRefusalCategory value)
        {
            return value switch
            {
                BetaRefusalCategory.Bio => "bio",
                BetaRefusalCategory.Cyber => "cyber",
                BetaRefusalCategory.FrontierLlm => "frontier_llm",
                BetaRefusalCategory.GeneralHarms => "general_harms",
                BetaRefusalCategory.ReasoningExtraction => "reasoning_extraction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRefusalCategory? ToEnum(string value)
        {
            return value switch
            {
                "bio" => BetaRefusalCategory.Bio,
                "cyber" => BetaRefusalCategory.Cyber,
                "frontier_llm" => BetaRefusalCategory.FrontierLlm,
                "general_harms" => BetaRefusalCategory.GeneralHarms,
                "reasoning_extraction" => BetaRefusalCategory.ReasoningExtraction,
                _ => null,
            };
        }
    }
}