#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ToolChangesVariant1Item : global::System.IEquatable<ToolChangesVariant1Item>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// Mid-conversation directive to make a tool available.<br/>
        /// ``tool`` is a reference to a tool (or MCP toolset) declared in the<br/>
        /// request's ``tools``. Under the ``inline-tools-2026-09-15`` beta it may<br/>
        /// instead be a reference to a tool defined earlier in ``messages``, or a<br/>
        /// ``tool_definition`` object that carries an inline tool definition in<br/>
        /// ``definition`` (the same object a ``tools`` entry holds). An ``mcp_toolset``<br/>
        /// definition also requires the ``mcp-client-2026-09-15`` beta. The tool is<br/>
        /// offered to the model from this point in the conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; init; }
#else
        public global::Anthropic.BetaRequestToolAdditionBlock? ToolAddition { get; }
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
            out global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            value = ToolAddition;
            return IsToolAddition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlock PickToolAddition() => IsToolAddition
            ? ToolAddition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolAddition' but the value was {ToString()}.");

        /// <summary>
        /// Mid-conversation directive to withdraw a tool.<br/>
        /// ``tool`` references a tool (or MCP toolset) by name: one declared in the<br/>
        /// request's ``tools`` or defined earlier in ``messages``. It is no longer<br/>
        /// offered to the model from this point in the conversation onward.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; init; }
#else
        public global::Anthropic.BetaRequestToolRemovalBlock? ToolRemoval { get; }
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
            out global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            value = ToolRemoval;
            return IsToolRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlock PickToolRemoval() => IsToolRemoval
            ? ToolRemoval!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolRemoval' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChangesVariant1Item(global::Anthropic.BetaRequestToolAdditionBlock value) => new ToolChangesVariant1Item((global::Anthropic.BetaRequestToolAdditionBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolAdditionBlock?(ToolChangesVariant1Item @this) => @this.ToolAddition;

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item(global::Anthropic.BetaRequestToolAdditionBlock? value)
        {
            ToolAddition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChangesVariant1Item FromToolAddition(global::Anthropic.BetaRequestToolAdditionBlock? value) => new ToolChangesVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ToolChangesVariant1Item(global::Anthropic.BetaRequestToolRemovalBlock value) => new ToolChangesVariant1Item((global::Anthropic.BetaRequestToolRemovalBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolRemovalBlock?(ToolChangesVariant1Item @this) => @this.ToolRemoval;

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item(global::Anthropic.BetaRequestToolRemovalBlock? value)
        {
            ToolRemoval = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ToolChangesVariant1Item FromToolRemoval(global::Anthropic.BetaRequestToolRemovalBlock? value) => new ToolChangesVariant1Item(value);

        /// <summary>
        ///
        /// </summary>
        public ToolChangesVariant1Item(
            global::Anthropic.BetaRequestCompactionBlockToolChangesVariant1ItemDiscriminatorType? type,
            global::Anthropic.BetaRequestToolAdditionBlock? toolAddition,
            global::Anthropic.BetaRequestToolRemovalBlock? toolRemoval
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
            global::System.Func<global::Anthropic.BetaRequestToolAdditionBlock, TResult>? toolAddition = null,
            global::System.Func<global::Anthropic.BetaRequestToolRemovalBlock, TResult>? toolRemoval = null,
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
            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,

            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,
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
            global::System.Action<global::Anthropic.BetaRequestToolAdditionBlock>? toolAddition = null,
            global::System.Action<global::Anthropic.BetaRequestToolRemovalBlock>? toolRemoval = null,
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
                typeof(global::Anthropic.BetaRequestToolAdditionBlock),
                ToolRemoval,
                typeof(global::Anthropic.BetaRequestToolRemovalBlock),
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
        public bool Equals(ToolChangesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolAdditionBlock?>.Default.Equals(ToolAddition, other.ToolAddition) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolRemovalBlock?>.Default.Equals(ToolRemoval, other.ToolRemoval)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ToolChangesVariant1Item obj1, ToolChangesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChangesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ToolChangesVariant1Item obj1, ToolChangesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChangesVariant1Item o && Equals(o);
        }
    }
}
