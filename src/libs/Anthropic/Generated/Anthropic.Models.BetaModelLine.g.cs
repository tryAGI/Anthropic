
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Claude model line, such as `opus` or `sonnet`. More lines may be added as new values.
    /// </summary>
    public enum BetaModelLine
    {
        /// <summary>
        ///
        /// </summary>
        Fable,
        /// <summary>
        ///
        /// </summary>
        Haiku,
        /// <summary>
        ///
        /// </summary>
        Mythos,
        /// <summary>
        ///
        /// </summary>
        Opus,
        /// <summary>
        ///
        /// </summary>
        Sonnet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelLineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelLine value)
        {
            return value switch
            {
                BetaModelLine.Fable => "fable",
                BetaModelLine.Haiku => "haiku",
                BetaModelLine.Mythos => "mythos",
                BetaModelLine.Opus => "opus",
                BetaModelLine.Sonnet => "sonnet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelLine? ToEnum(string value)
        {
            return value switch
            {
                "fable" => BetaModelLine.Fable,
                "haiku" => BetaModelLine.Haiku,
                "mythos" => BetaModelLine.Mythos,
                "opus" => BetaModelLine.Opus,
                "sonnet" => BetaModelLine.Sonnet,
                _ => null,
            };
        }
    }
}