#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolChangesVariant1Item2 : global::System.IEquatable<ToolChangesVariant1Item2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// An entry of a `compaction` block's `tool_changes`: a tool the<br/>
        /// compacted range made available, as a reference to a `tools` entry or<br/>
        /// MCP toolset, or as the tool definition in effect at the end of the<br/>
        /// range, by value. Send it back unchanged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolAdditionBlock? ToolAddition { get; init; }
#else
        public global::Anthropic.BetaResponseToolAdditionBlock? ToolAddition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolAddition))]
#endif
        public bool IsToolAddition => ToolAddition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolAddition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaResponseToolAdditionBlock? value)
        {
            value = ToolAddition;
            return IsToolAddition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlock PickToolAddition() => IsToolAddition
            ? ToolAddition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolAddition' but the value was {ToString()}.");

        /// <summary>
        /// An entry of a `compaction` block's `tool_changes`: a tool of the<br/>
        /// request's `tools` (or an MCP tool or toolset) that the compacted range<br/>
        /// withdrew. Send it back unchanged.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolRemovalBlock? ToolRemoval { get; init; }
#else
        public global::Anthropic.BetaResponseToolRemovalBlock? ToolRemoval { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolRemoval))]
#endif
        public bool IsToolRemoval => ToolRemoval != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolRemoval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaResponseToolRemovalBlock? value)
        {
            value = ToolRemoval;
            return IsToolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlock PickToolRemoval() => IsToolRemoval
            ? ToolRemoval!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolRemoval' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChangesVariant1Item2(global::Anthropic.BetaResponseToolAdditionBlock value) => new ToolChangesVariant1Item2((global::Anthropic.BetaResponseToolAdditionBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolAdditionBlock?(ToolChangesVariant1Item2 @this) => @this.ToolAddition;

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item2(global::Anthropic.BetaResponseToolAdditionBlock? value)
        {
            ToolAddition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChangesVariant1Item2 FromToolAddition(global::Anthropic.BetaResponseToolAdditionBlock? value) => new ToolChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChangesVariant1Item2(global::Anthropic.BetaResponseToolRemovalBlock value) => new ToolChangesVariant1Item2((global::Anthropic.BetaResponseToolRemovalBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolRemovalBlock?(ToolChangesVariant1Item2 @this) => @this.ToolRemoval;

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item2(global::Anthropic.BetaResponseToolRemovalBlock? value)
        {
            ToolRemoval = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChangesVariant1Item2 FromToolRemoval(global::Anthropic.BetaResponseToolRemovalBlock? value) => new ToolChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item2(
            global::Anthropic.BetaResponseCompactionBlockToolChangesVariant1ItemDiscriminatorType? type,
            global::Anthropic.BetaResponseToolAdditionBlock? toolAddition,
            global::Anthropic.BetaResponseToolRemovalBlock? toolRemoval
            )
        {
            Type = type;

            ToolAddition = toolAddition;
            ToolRemoval = toolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ToolRemoval as object ??
            ToolAddition as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ToolAddition?.ToString() ??
            ToolRemoval?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsToolAddition && !IsToolRemoval || !IsToolAddition && IsToolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseToolAdditionBlock, TResult>? toolAddition = null,
            global::System.Func<global::Anthropic.BetaResponseToolRemovalBlock, TResult>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolAddition && toolAddition != null)
            {
                return toolAddition(ToolAddition!);
            }
            else if (IsToolRemoval && toolRemoval != null)
            {
                return toolRemoval(ToolRemoval!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseToolAdditionBlock>? toolAddition = null,

            global::System.Action<global::Anthropic.BetaResponseToolRemovalBlock>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaResponseToolAdditionBlock>? toolAddition = null,
            global::System.Action<global::Anthropic.BetaResponseToolRemovalBlock>? toolRemoval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolAddition)
            {
                toolAddition?.Invoke(ToolAddition!);
            }
            else if (IsToolRemoval)
            {
                toolRemoval?.Invoke(ToolRemoval!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolAddition,
                typeof(global::Anthropic.BetaResponseToolAdditionBlock),
                ToolRemoval,
                typeof(global::Anthropic.BetaResponseToolRemovalBlock),
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
        public bool Equals(ToolChangesVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolAdditionBlock?>.Default.Equals(ToolAddition, other.ToolAddition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolRemovalBlock?>.Default.Equals(ToolRemoval, other.ToolRemoval)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolChangesVariant1Item2 obj1, ToolChangesVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChangesVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolChangesVariant1Item2 obj1, ToolChangesVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChangesVariant1Item2 o && Equals(o);
        }
    }
}
