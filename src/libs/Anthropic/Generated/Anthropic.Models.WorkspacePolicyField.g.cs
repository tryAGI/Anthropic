
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkspacePolicyField
    {
        /// <summary>
        ///
        /// </summary>
        ExternalKeyId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspacePolicyFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspacePolicyField value)
        {
            return value switch
            {
                WorkspacePolicyField.ExternalKeyId => "external_key_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspacePolicyField? ToEnum(string value)
        {
            return value switch
            {
                "external_key_id" => WorkspacePolicyField.ExternalKeyId,
                _ => null,
            };
        }
    }
}