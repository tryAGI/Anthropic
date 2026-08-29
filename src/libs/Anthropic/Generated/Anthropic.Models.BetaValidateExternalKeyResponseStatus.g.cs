
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// `success` — encrypt/decrypt roundtrip succeeded. `failure` — the roundtrip failed or timed out; see `error`.
    /// </summary>
    public enum BetaValidateExternalKeyResponseStatus
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
    public static class BetaValidateExternalKeyResponseStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaValidateExternalKeyResponseStatus value)
        {
            return value switch
            {
                BetaValidateExternalKeyResponseStatus.Failure => "failure",
                BetaValidateExternalKeyResponseStatus.Success => "success",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaValidateExternalKeyResponseStatus? ToEnum(string value)
        {
            return value switch
            {
                "failure" => BetaValidateExternalKeyResponseStatus.Failure,
                "success" => BetaValidateExternalKeyResponseStatus.Success,
                _ => null,
            };
        }
    }
}