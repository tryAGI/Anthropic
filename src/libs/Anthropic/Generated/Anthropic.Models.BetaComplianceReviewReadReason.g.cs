#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why a review item is readable.
    /// </summary>
    public readonly partial struct BetaComplianceReviewReadReason : global::System.IEquatable<BetaComplianceReviewReadReason>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewReadReasonDiscriminatorType? Type { get; }

        /// <summary>
        /// Anthropic flagged the item for your organization to review.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewSafeguardsReason? SafeguardsReview { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewSafeguardsReason? SafeguardsReview { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SafeguardsReview))]
#endif
        public bool IsSafeguardsReview => SafeguardsReview != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSafeguardsReview(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewSafeguardsReason? value)
        {
            value = SafeguardsReview;
            return IsSafeguardsReview;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewSafeguardsReason PickSafeguardsReview() => SafeguardsReview is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SafeguardsReview' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewReadReason(global::Anthropic.BetaComplianceReviewSafeguardsReason value) => new BetaComplianceReviewReadReason((global::Anthropic.BetaComplianceReviewSafeguardsReason?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewSafeguardsReason?(BetaComplianceReviewReadReason @this) => @this.SafeguardsReview;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewReadReason(global::Anthropic.BetaComplianceReviewSafeguardsReason? value)
        {
            SafeguardsReview = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewReadReason FromSafeguardsReview(global::Anthropic.BetaComplianceReviewSafeguardsReason? value) => new BetaComplianceReviewReadReason(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewReadReason(
            global::Anthropic.BetaComplianceReviewReadReasonDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewSafeguardsReason? safeguardsReview
            )
        {
            Type = type;

            SafeguardsReview = safeguardsReview;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SafeguardsReview as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SafeguardsReview?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSafeguardsReview;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewSafeguardsReason, TResult>? safeguardsReview = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SafeguardsReview is { } __value0 && safeguardsReview != null)
            {
                return safeguardsReview(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewSafeguardsReason>? safeguardsReview = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SafeguardsReview is { } __value0)
            {
                safeguardsReview?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewSafeguardsReason>? safeguardsReview = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SafeguardsReview is { } __value0)
            {
                safeguardsReview?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SafeguardsReview,
                typeof(global::Anthropic.BetaComplianceReviewSafeguardsReason),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(BetaComplianceReviewReadReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewSafeguardsReason?>.Default.Equals(SafeguardsReview, other.SafeguardsReview)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewReadReason obj1, BetaComplianceReviewReadReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewReadReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewReadReason obj1, BetaComplianceReviewReadReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewReadReason o && Equals(o);
        }
    }
}
