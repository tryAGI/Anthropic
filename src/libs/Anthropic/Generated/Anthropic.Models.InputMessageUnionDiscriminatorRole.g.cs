
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum InputMessageUnionDiscriminatorRole
    {
        /// <summary>
        ///
        /// </summary>
        Assistant,
        /// <summary>
        ///
        /// </summary>
        System,
        /// <summary>
        ///
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InputMessageUnionDiscriminatorRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputMessageUnionDiscriminatorRole value)
        {
            return value switch
            {
                InputMessageUnionDiscriminatorRole.Assistant => "assistant",
                InputMessageUnionDiscriminatorRole.System => "system",
                InputMessageUnionDiscriminatorRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputMessageUnionDiscriminatorRole? ToEnum(string value)
        {
            return value switch
            {
                "assistant" => InputMessageUnionDiscriminatorRole.Assistant,
                "system" => InputMessageUnionDiscriminatorRole.System,
                "user" => InputMessageUnionDiscriminatorRole.User,
                _ => null,
            };
        }
    }
}