
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A Claude model line, such as `opus` or `sonnet`. More lines may be added as new values.
    /// </summary>
    public enum ModelLine
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
    public static class ModelLineExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelLine value)
        {
            return value switch
            {
                ModelLine.Fable => "fable",
                ModelLine.Haiku => "haiku",
                ModelLine.Mythos => "mythos",
                ModelLine.Opus => "opus",
                ModelLine.Sonnet => "sonnet",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelLine? ToEnum(string value)
        {
            return value switch
            {
                "fable" => ModelLine.Fable,
                "haiku" => ModelLine.Haiku,
                "mythos" => ModelLine.Mythos,
                "opus" => ModelLine.Opus,
                "sonnet" => ModelLine.Sonnet,
                _ => null,
            };
        }
    }
}