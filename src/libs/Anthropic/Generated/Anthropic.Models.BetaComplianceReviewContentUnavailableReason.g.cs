#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why a message's content isn't returned.
    /// </summary>
    public readonly partial struct BetaComplianceReviewContentUnavailableReason : global::System.IEquatable<BetaComplianceReviewContentUnavailableReason>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentUnavailableReasonDiscriminatorType? Type { get; }

        /// <summary>
        /// No copy of the message was stored.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewContentNotCaptured? NotCaptured { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewContentNotCaptured? NotCaptured { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NotCaptured))]
#endif
        public bool IsNotCaptured => NotCaptured != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNotCaptured(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewContentNotCaptured? value)
        {
            value = NotCaptured;
            return IsNotCaptured;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewContentNotCaptured PickNotCaptured() => NotCaptured is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'NotCaptured' but the value was {ToString()}.");

        /// <summary>
        /// A copy of the message was stored and can't be returned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? StoredCopyUnavailable { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? StoredCopyUnavailable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StoredCopyUnavailable))]
#endif
        public bool IsStoredCopyUnavailable => StoredCopyUnavailable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStoredCopyUnavailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? value)
        {
            value = StoredCopyUnavailable;
            return IsStoredCopyUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewStoredCopyUnavailable PickStoredCopyUnavailable() => StoredCopyUnavailable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StoredCopyUnavailable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewContentUnavailableReason(global::Anthropic.BetaComplianceReviewContentNotCaptured value) => new BetaComplianceReviewContentUnavailableReason((global::Anthropic.BetaComplianceReviewContentNotCaptured?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewContentNotCaptured?(BetaComplianceReviewContentUnavailableReason @this) => @this.NotCaptured;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewContentUnavailableReason(global::Anthropic.BetaComplianceReviewContentNotCaptured? value)
        {
            NotCaptured = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewContentUnavailableReason FromNotCaptured(global::Anthropic.BetaComplianceReviewContentNotCaptured? value) => new BetaComplianceReviewContentUnavailableReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewContentUnavailableReason(global::Anthropic.BetaComplianceReviewStoredCopyUnavailable value) => new BetaComplianceReviewContentUnavailableReason((global::Anthropic.BetaComplianceReviewStoredCopyUnavailable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewStoredCopyUnavailable?(BetaComplianceReviewContentUnavailableReason @this) => @this.StoredCopyUnavailable;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewContentUnavailableReason(global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? value)
        {
            StoredCopyUnavailable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewContentUnavailableReason FromStoredCopyUnavailable(global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? value) => new BetaComplianceReviewContentUnavailableReason(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewContentUnavailableReason(
            global::Anthropic.BetaComplianceReviewContentUnavailableReasonDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewContentNotCaptured? notCaptured,
            global::Anthropic.BetaComplianceReviewStoredCopyUnavailable? storedCopyUnavailable
            )
        {
            Type = type;

            NotCaptured = notCaptured;
            StoredCopyUnavailable = storedCopyUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            StoredCopyUnavailable as object ??
            NotCaptured as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            NotCaptured?.ToString() ??
            StoredCopyUnavailable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsNotCaptured && !IsStoredCopyUnavailable || !IsNotCaptured && IsStoredCopyUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewContentNotCaptured, TResult>? notCaptured = null,
            global::System.Func<global::Anthropic.BetaComplianceReviewStoredCopyUnavailable, TResult>? storedCopyUnavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotCaptured is { } __value0 && notCaptured != null)
            {
                return notCaptured(__value0);
            }
            else if (StoredCopyUnavailable is { } __value1 && storedCopyUnavailable != null)
            {
                return storedCopyUnavailable(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewContentNotCaptured>? notCaptured = null,

            global::System.Action<global::Anthropic.BetaComplianceReviewStoredCopyUnavailable>? storedCopyUnavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotCaptured is { } __value0)
            {
                notCaptured?.Invoke(__value0);
            }
            else if (StoredCopyUnavailable is { } __value1)
            {
                storedCopyUnavailable?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewContentNotCaptured>? notCaptured = null,
            global::System.Action<global::Anthropic.BetaComplianceReviewStoredCopyUnavailable>? storedCopyUnavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (NotCaptured is { } __value0)
            {
                notCaptured?.Invoke(__value0);
            }
            else if (StoredCopyUnavailable is { } __value1)
            {
                storedCopyUnavailable?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                NotCaptured,
                typeof(global::Anthropic.BetaComplianceReviewContentNotCaptured),
                StoredCopyUnavailable,
                typeof(global::Anthropic.BetaComplianceReviewStoredCopyUnavailable),
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
        public bool Equals(BetaComplianceReviewContentUnavailableReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewContentNotCaptured?>.Default.Equals(NotCaptured, other.NotCaptured) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewStoredCopyUnavailable?>.Default.Equals(StoredCopyUnavailable, other.StoredCopyUnavailable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewContentUnavailableReason obj1, BetaComplianceReviewContentUnavailableReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewContentUnavailableReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewContentUnavailableReason obj1, BetaComplianceReviewContentUnavailableReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewContentUnavailableReason o && Equals(o);
        }
    }
}
