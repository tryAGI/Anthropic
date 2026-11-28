
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The field that a list of review cases is sorted by: `created_at` or `updated_at`.
    /// </summary>
    public enum BetaComplianceReviewCaseOrderBy
    {
        /// <summary>
        /// Sort by when Anthropic sent the case.
        /// </summary>
        CreatedAt,
        /// <summary>
        /// Sort by when the case last changed.
        /// </summary>
        UpdatedAt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaComplianceReviewCaseOrderByExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaComplianceReviewCaseOrderBy value)
        {
            return value switch
            {
                BetaComplianceReviewCaseOrderBy.CreatedAt => "created_at",
                BetaComplianceReviewCaseOrderBy.UpdatedAt => "updated_at",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaComplianceReviewCaseOrderBy? ToEnum(string value)
        {
            return value switch
            {
                "created_at" => BetaComplianceReviewCaseOrderBy.CreatedAt,
                "updated_at" => BetaComplianceReviewCaseOrderBy.UpdatedAt,
                _ => null,
            };
        }
    }
}