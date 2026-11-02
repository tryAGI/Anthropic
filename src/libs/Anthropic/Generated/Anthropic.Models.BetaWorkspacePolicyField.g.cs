
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspacePolicyField
    {
        /// <summary>
        ///
        /// </summary>
        ExternalKeyId,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWorkspacePolicyFieldExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspacePolicyField value)
        {
            return value switch
            {
                BetaWorkspacePolicyField.ExternalKeyId => "external_key_id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspacePolicyField? ToEnum(string value)
        {
            return value switch
            {
                "external_key_id" => BetaWorkspacePolicyField.ExternalKeyId,
                _ => null,
            };
        }
    }
}