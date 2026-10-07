#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseComputerToolUseBlock : global::System.IEquatable<BetaResponseComputerToolUseBlock>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Union { get; init; }
#else
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion? Union { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Union))]
#endif
        public bool IsUnion => Union != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnion(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaResponseComputerToolUseBlockUnion? value)
        {
            value = Union;
            return IsUnion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlockUnion PickUnion() => Union is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Union' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseComputerToolUseBlock(global::Anthropic.BetaResponseComputerToolUseBlockUnion value) => new BetaResponseComputerToolUseBlock((global::Anthropic.BetaResponseComputerToolUseBlockUnion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerToolUseBlockUnion?(BetaResponseComputerToolUseBlock @this) => @this.Union;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseComputerToolUseBlock(global::Anthropic.BetaResponseComputerToolUseBlockUnion? value)
        {
            Union = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseComputerToolUseBlock FromUnion(global::Anthropic.BetaResponseComputerToolUseBlockUnion? value) => new BetaResponseComputerToolUseBlock(value);

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Union as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Union?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUnion;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseComputerToolUseBlockUnion?, TResult>? union = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Union is { } __value0 && union != null)
            {
                return union(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseComputerToolUseBlockUnion?>? union = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Union is { } __value0)
            {
                union?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaResponseComputerToolUseBlockUnion?>? union = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Union is { } __value0)
            {
                union?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Union,
                typeof(global::Anthropic.BetaResponseComputerToolUseBlockUnion),
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
        public bool Equals(BetaResponseComputerToolUseBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerToolUseBlockUnion?>.Default.Equals(Union, other.Union)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseComputerToolUseBlock obj1, BetaResponseComputerToolUseBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseComputerToolUseBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseComputerToolUseBlock obj1, BetaResponseComputerToolUseBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseComputerToolUseBlock o && Equals(o);
        }
    }
}
