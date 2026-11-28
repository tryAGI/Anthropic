#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The status of a review case.
    /// </summary>
    public readonly partial struct BetaComplianceReviewCaseStatus : global::System.IEquatable<BetaComplianceReviewCaseStatus>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// Anthropic is waiting for a response to the case.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewCaseOpen? Open { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewCaseOpen? Open { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Open))]
#endif
        public bool IsOpen => Open != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpen(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewCaseOpen? value)
        {
            value = Open;
            return IsOpen;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseOpen PickOpen() => Open is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Open' but the value was {ToString()}.");

        /// <summary>
        /// Anthropic has stopped waiting for a response. A closed case stays closed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewCaseClosed? Closed { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewCaseClosed? Closed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Closed))]
#endif
        public bool IsClosed => Closed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClosed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewCaseClosed? value)
        {
            value = Closed;
            return IsClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCaseClosed PickClosed() => Closed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Closed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewCaseStatus(global::Anthropic.BetaComplianceReviewCaseOpen value) => new BetaComplianceReviewCaseStatus((global::Anthropic.BetaComplianceReviewCaseOpen?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewCaseOpen?(BetaComplianceReviewCaseStatus @this) => @this.Open;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewCaseStatus(global::Anthropic.BetaComplianceReviewCaseOpen? value)
        {
            Open = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewCaseStatus FromOpen(global::Anthropic.BetaComplianceReviewCaseOpen? value) => new BetaComplianceReviewCaseStatus(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewCaseStatus(global::Anthropic.BetaComplianceReviewCaseClosed value) => new BetaComplianceReviewCaseStatus((global::Anthropic.BetaComplianceReviewCaseClosed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewCaseClosed?(BetaComplianceReviewCaseStatus @this) => @this.Closed;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewCaseStatus(global::Anthropic.BetaComplianceReviewCaseClosed? value)
        {
            Closed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewCaseStatus FromClosed(global::Anthropic.BetaComplianceReviewCaseClosed? value) => new BetaComplianceReviewCaseStatus(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewCaseStatus(
            global::Anthropic.BetaComplianceReviewCaseStatusDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewCaseOpen? open,
            global::Anthropic.BetaComplianceReviewCaseClosed? closed
            )
        {
            Type = type;

            Open = open;
            Closed = closed;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Closed as object ??
            Open as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Open?.ToString() ??
            Closed?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpen && !IsClosed || !IsOpen && IsClosed;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewCaseOpen, TResult>? open = null,
            global::System.Func<global::Anthropic.BetaComplianceReviewCaseClosed, TResult>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0 && open != null)
            {
                return open(__value0);
            }
            else if (Closed is { } __value1 && closed != null)
            {
                return closed(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewCaseOpen>? open = null,

            global::System.Action<global::Anthropic.BetaComplianceReviewCaseClosed>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0)
            {
                open?.Invoke(__value0);
            }
            else if (Closed is { } __value1)
            {
                closed?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewCaseOpen>? open = null,
            global::System.Action<global::Anthropic.BetaComplianceReviewCaseClosed>? closed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Open is { } __value0)
            {
                open?.Invoke(__value0);
            }
            else if (Closed is { } __value1)
            {
                closed?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Open,
                typeof(global::Anthropic.BetaComplianceReviewCaseOpen),
                Closed,
                typeof(global::Anthropic.BetaComplianceReviewCaseClosed),
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
        public bool Equals(BetaComplianceReviewCaseStatus other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewCaseOpen?>.Default.Equals(Open, other.Open) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewCaseClosed?>.Default.Equals(Closed, other.Closed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewCaseStatus obj1, BetaComplianceReviewCaseStatus obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewCaseStatus>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewCaseStatus obj1, BetaComplianceReviewCaseStatus obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewCaseStatus o && Equals(o);
        }
    }
}
