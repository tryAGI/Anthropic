#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The stored copy of one call.
    /// </summary>
    public readonly partial struct BetaComplianceReviewMessageContent : global::System.IEquatable<BetaComplianceReviewMessageContent>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewMessageContentDiscriminatorType? Type { get; }

        /// <summary>
        /// A request to create a message, and its response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewCreateMessageContent? CreateMessage { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewCreateMessageContent? CreateMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CreateMessage))]
#endif
        public bool IsCreateMessage => CreateMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCreateMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComplianceReviewCreateMessageContent? value)
        {
            value = CreateMessage;
            return IsCreateMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewCreateMessageContent PickCreateMessage() => CreateMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'CreateMessage' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewMessageContent(global::Anthropic.BetaComplianceReviewCreateMessageContent value) => new BetaComplianceReviewMessageContent((global::Anthropic.BetaComplianceReviewCreateMessageContent?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewCreateMessageContent?(BetaComplianceReviewMessageContent @this) => @this.CreateMessage;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewMessageContent(global::Anthropic.BetaComplianceReviewCreateMessageContent? value)
        {
            CreateMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewMessageContent FromCreateMessage(global::Anthropic.BetaComplianceReviewCreateMessageContent? value) => new BetaComplianceReviewMessageContent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewMessageContent(
            global::Anthropic.BetaComplianceReviewMessageContentDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewCreateMessageContent? createMessage
            )
        {
            Type = type;

            CreateMessage = createMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            CreateMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            CreateMessage?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCreateMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewCreateMessageContent, TResult>? createMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateMessage is { } __value0 && createMessage != null)
            {
                return createMessage(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewCreateMessageContent>? createMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateMessage is { } __value0)
            {
                createMessage?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewCreateMessageContent>? createMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (CreateMessage is { } __value0)
            {
                createMessage?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CreateMessage,
                typeof(global::Anthropic.BetaComplianceReviewCreateMessageContent),
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
        public bool Equals(BetaComplianceReviewMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewCreateMessageContent?>.Default.Equals(CreateMessage, other.CreateMessage)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewMessageContent obj1, BetaComplianceReviewMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewMessageContent obj1, BetaComplianceReviewMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewMessageContent o && Equals(o);
        }
    }
}
