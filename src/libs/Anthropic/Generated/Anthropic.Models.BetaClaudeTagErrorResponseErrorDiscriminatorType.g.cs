
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaClaudeTagErrorResponseErrorDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        ConflictError,
        /// <summary>
        ///
        /// </summary>
        InvalidRequestError,
        /// <summary>
        ///
        /// </summary>
        NotFoundError,
        /// <summary>
        ///
        /// </summary>
        PermissionError,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaClaudeTagErrorResponseErrorDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaClaudeTagErrorResponseErrorDiscriminatorType value)
        {
            return value switch
            {
                BetaClaudeTagErrorResponseErrorDiscriminatorType.ConflictError => "conflict_error",
                BetaClaudeTagErrorResponseErrorDiscriminatorType.InvalidRequestError => "invalid_request_error",
                BetaClaudeTagErrorResponseErrorDiscriminatorType.NotFoundError => "not_found_error",
                BetaClaudeTagErrorResponseErrorDiscriminatorType.PermissionError => "permission_error",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaClaudeTagErrorResponseErrorDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "conflict_error" => BetaClaudeTagErrorResponseErrorDiscriminatorType.ConflictError,
                "invalid_request_error" => BetaClaudeTagErrorResponseErrorDiscriminatorType.InvalidRequestError,
                "not_found_error" => BetaClaudeTagErrorResponseErrorDiscriminatorType.NotFoundError,
                "permission_error" => BetaClaudeTagErrorResponseErrorDiscriminatorType.PermissionError,
                _ => null,
            };
        }
    }
}