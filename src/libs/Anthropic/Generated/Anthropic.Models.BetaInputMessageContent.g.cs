#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaInputMessageContent : global::System.IEquatable<BetaInputMessageContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaInputMessageContentVariant1 { get; init; }
#else
        public string? BetaInputMessageContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaInputMessageContentVariant1))]
#endif
        public bool IsBetaInputMessageContentVariant1 => BetaInputMessageContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaInputMessageContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaInputMessageContentVariant1;
            return IsBetaInputMessageContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaInputMessageContentVariant1() => BetaInputMessageContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaInputMessageContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Example: [{"text":"What is a quaternion?","type":"text"}]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? BetaInputMessageContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? BetaInputMessageContentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaInputMessageContentVariant2))]
#endif
        public bool IsBetaInputMessageContentVariant2 => BetaInputMessageContentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaInputMessageContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? value)
        {
            value = BetaInputMessageContentVariant2;
            return IsBetaInputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock> PickBetaInputMessageContentVariant2() => BetaInputMessageContentVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaInputMessageContentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaInputMessageContent(string value) => new BetaInputMessageContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaInputMessageContent @this) => @this.BetaInputMessageContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageContent(string? value)
        {
            BetaInputMessageContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaInputMessageContent FromBetaInputMessageContentVariant1(string? value) => new BetaInputMessageContent(value);

        /// <summary>
        ///
        /// </summary>
        public BetaInputMessageContent(
            string? betaInputMessageContentVariant1,
            global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>? betaInputMessageContentVariant2
            )
        {
            BetaInputMessageContentVariant1 = betaInputMessageContentVariant1;
            BetaInputMessageContentVariant2 = betaInputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaInputMessageContentVariant2 as object ??
            BetaInputMessageContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaInputMessageContentVariant1?.ToString() ??
            BetaInputMessageContentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaInputMessageContentVariant1 || IsBetaInputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaInputMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>, TResult>? betaInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaInputMessageContentVariant1 is { } __value0 && betaInputMessageContentVariant1 != null)
            {
                return betaInputMessageContentVariant1(__value0);
            }
            else if (BetaInputMessageContentVariant2 is { } __value1 && betaInputMessageContentVariant2 != null)
            {
                return betaInputMessageContentVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaInputMessageContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>? betaInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaInputMessageContentVariant1 is { } __value0)
            {
                betaInputMessageContentVariant1?.Invoke(__value0);
            }
            else if (BetaInputMessageContentVariant2 is { } __value1)
            {
                betaInputMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaInputMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>>? betaInputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaInputMessageContentVariant1 is { } __value0)
            {
                betaInputMessageContentVariant1?.Invoke(__value0);
            }
            else if (BetaInputMessageContentVariant2 is { } __value1)
            {
                betaInputMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaInputMessageContentVariant1,
                typeof(string),
                BetaInputMessageContentVariant2,
                typeof(global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>),
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
        public bool Equals(BetaInputMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaInputMessageContentVariant1, other.BetaInputMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Anthropic.BetaInputContentBlock>?>.Default.Equals(BetaInputMessageContentVariant2, other.BetaInputMessageContentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaInputMessageContent obj1, BetaInputMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaInputMessageContent obj1, BetaInputMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputMessageContent o && Equals(o);
        }
    }
}
