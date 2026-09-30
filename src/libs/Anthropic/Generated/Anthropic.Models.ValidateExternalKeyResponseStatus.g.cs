
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `success` — encrypt/decrypt roundtrip succeeded. `failure` — the roundtrip failed or timed out; see `error`.
    /// </summary>
    public enum ValidateExternalKeyResponseStatus
    {
        /// <summary>
        ///
        /// </summary>
        Failure,
        /// <summary>
        ///
        /// </summary>
        Success,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValidateExternalKeyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValidateExternalKeyResponseStatus value)
        {
            return value switch
            {
                ValidateExternalKeyResponseStatus.Failure => "failure",
                ValidateExternalKeyResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValidateExternalKeyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => ValidateExternalKeyResponseStatus.Failure,
                "success" => ValidateExternalKeyResponseStatus.Success,
                _ => null,
            };
        }
    }
}