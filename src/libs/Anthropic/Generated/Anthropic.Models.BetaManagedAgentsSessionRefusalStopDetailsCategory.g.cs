
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsSessionRefusalStopDetailsCategory
    {
        /// <summary>
        ///
        /// </summary>
        Bio,
        /// <summary>
        ///
        /// </summary>
        Cyber,
        /// <summary>
        ///
        /// </summary>
        FrontierLlm,
        /// <summary>
        ///
        /// </summary>
        GeneralHarms,
        /// <summary>
        ///
        /// </summary>
        ReasoningExtraction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsSessionRefusalStopDetailsCategoryExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsSessionRefusalStopDetailsCategory value)
        {
            return value switch
            {
                BetaManagedAgentsSessionRefusalStopDetailsCategory.Bio => "bio",
                BetaManagedAgentsSessionRefusalStopDetailsCategory.Cyber => "cyber",
                BetaManagedAgentsSessionRefusalStopDetailsCategory.FrontierLlm => "frontier_llm",
                BetaManagedAgentsSessionRefusalStopDetailsCategory.GeneralHarms => "general_harms",
                BetaManagedAgentsSessionRefusalStopDetailsCategory.ReasoningExtraction => "reasoning_extraction",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsSessionRefusalStopDetailsCategory? ToEnum(string value)
        {
            return value switch
            {
                "bio" => BetaManagedAgentsSessionRefusalStopDetailsCategory.Bio,
                "cyber" => BetaManagedAgentsSessionRefusalStopDetailsCategory.Cyber,
                "frontier_llm" => BetaManagedAgentsSessionRefusalStopDetailsCategory.FrontierLlm,
                "general_harms" => BetaManagedAgentsSessionRefusalStopDetailsCategory.GeneralHarms,
                "reasoning_extraction" => BetaManagedAgentsSessionRefusalStopDetailsCategory.ReasoningExtraction,
                _ => null,
            };
        }
    }
}