#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// What is particular to one kind of review item.
    /// </summary>
    public readonly partial struct BetaComplianceReviewItemDetails : global::System.IEquatable<BetaComplianceReviewItemDetails>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewItemDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// A message sent to Claude.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewMessageDetails? Message { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewMessageDetails? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewMessageDetails? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageDetails PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewItemDetails(global::Anthropic.BetaComplianceReviewMessageDetails value) => new BetaComplianceReviewItemDetails((global::Anthropic.BetaComplianceReviewMessageDetails?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewMessageDetails?(BetaComplianceReviewItemDetails @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewItemDetails(global::Anthropic.BetaComplianceReviewMessageDetails? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewItemDetails FromMessage(global::Anthropic.BetaComplianceReviewMessageDetails? value) => new BetaComplianceReviewItemDetails(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewItemDetails(
            global::Anthropic.BetaComplianceReviewItemDetailsDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewMessageDetails? message
            )
        {
            Type = type;

            Message = message;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewMessageDetails, TResult>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewMessageDetails>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewMessageDetails>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::Anthropic.BetaComplianceReviewMessageDetails),
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
        public bool Equals(BetaComplianceReviewItemDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewMessageDetails?>.Default.Equals(Message, other.Message)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewItemDetails obj1, BetaComplianceReviewItemDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewItemDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewItemDetails obj1, BetaComplianceReviewItemDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewItemDetails o && Equals(o);
        }
    }
}
