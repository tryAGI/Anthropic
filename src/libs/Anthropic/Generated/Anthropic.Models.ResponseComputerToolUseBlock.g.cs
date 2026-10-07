#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseComputerToolUseBlock : global::System.IEquatable<ResponseComputerToolUseBlock>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Union { get; init; }
#else
        public global::Anthropic.ResponseComputerToolUseBlockUnion? Union { get; }
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
            out global::Anthropic.ResponseComputerToolUseBlockUnion? value)
        {
            value = Union;
            return IsUnion;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlockUnion PickUnion() => Union is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Union' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseComputerToolUseBlock(global::Anthropic.ResponseComputerToolUseBlockUnion value) => new ResponseComputerToolUseBlock((global::Anthropic.ResponseComputerToolUseBlockUnion?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerToolUseBlockUnion?(ResponseComputerToolUseBlock @this) => @this.Union;

        /// <summary>
        ///
        /// </summary>
        public ResponseComputerToolUseBlock(global::Anthropic.ResponseComputerToolUseBlockUnion? value)
        {
            Union = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseComputerToolUseBlock FromUnion(global::Anthropic.ResponseComputerToolUseBlockUnion? value) => new ResponseComputerToolUseBlock(value);

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
            global::System.Func<global::Anthropic.ResponseComputerToolUseBlockUnion?, TResult>? union = null,
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
            global::System.Action<global::Anthropic.ResponseComputerToolUseBlockUnion?>? union = null,
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
            global::System.Action<global::Anthropic.ResponseComputerToolUseBlockUnion?>? union = null,
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
                typeof(global::Anthropic.ResponseComputerToolUseBlockUnion),
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
        public bool Equals(ResponseComputerToolUseBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerToolUseBlockUnion?>.Default.Equals(Union, other.Union)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseComputerToolUseBlock obj1, ResponseComputerToolUseBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseComputerToolUseBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseComputerToolUseBlock obj1, ResponseComputerToolUseBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseComputerToolUseBlock o && Equals(o);
        }
    }
}
