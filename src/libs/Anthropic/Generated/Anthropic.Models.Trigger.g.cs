#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Condition that triggers the context management strategy
    /// </summary>
    public readonly partial struct Trigger : global::System.IEquatable<Trigger>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaInputTokensTrigger? InputTokens { get; init; }
#else
        public global::Anthropic.BetaInputTokensTrigger? InputTokens { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputTokens))]
#endif
        public bool IsInputTokens => InputTokens != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Trigger(global::Anthropic.BetaInputTokensTrigger value) => new Trigger((global::Anthropic.BetaInputTokensTrigger?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaInputTokensTrigger?(Trigger @this) => @this.InputTokens;

        /// <summary>
        /// 
        /// </summary>
        public Trigger(global::Anthropic.BetaInputTokensTrigger? value)
        {
            InputTokens = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolUsesTrigger? ToolUses { get; init; }
#else
        public global::Anthropic.BetaToolUsesTrigger? ToolUses { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUses))]
#endif
        public bool IsToolUses => ToolUses != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Trigger(global::Anthropic.BetaToolUsesTrigger value) => new Trigger((global::Anthropic.BetaToolUsesTrigger?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolUsesTrigger?(Trigger @this) => @this.ToolUses;

        /// <summary>
        /// 
        /// </summary>
        public Trigger(global::Anthropic.BetaToolUsesTrigger? value)
        {
            ToolUses = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Trigger(
            global::Anthropic.BetaClearToolUses20250919TriggerDiscriminatorType? type,
            global::Anthropic.BetaInputTokensTrigger? inputTokens,
            global::Anthropic.BetaToolUsesTrigger? toolUses
            )
        {
            Type = type;

            InputTokens = inputTokens;
            ToolUses = toolUses;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolUses as object ??
            InputTokens as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputTokens?.ToString() ??
            ToolUses?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputTokens && !IsToolUses || !IsInputTokens && IsToolUses;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaInputTokensTrigger?, TResult>? inputTokens = null,
            global::System.Func<global::Anthropic.BetaToolUsesTrigger?, TResult>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTokens && inputTokens != null)
            {
                return inputTokens(InputTokens!);
            }
            else if (IsToolUses && toolUses != null)
            {
                return toolUses(ToolUses!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaInputTokensTrigger?>? inputTokens = null,
            global::System.Action<global::Anthropic.BetaToolUsesTrigger?>? toolUses = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputTokens)
            {
                inputTokens?.Invoke(InputTokens!);
            }
            else if (IsToolUses)
            {
                toolUses?.Invoke(ToolUses!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputTokens,
                typeof(global::Anthropic.BetaInputTokensTrigger),
                ToolUses,
                typeof(global::Anthropic.BetaToolUsesTrigger),
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
        public bool Equals(Trigger other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaInputTokensTrigger?>.Default.Equals(InputTokens, other.InputTokens) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolUsesTrigger?>.Default.Equals(ToolUses, other.ToolUses) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Trigger obj1, Trigger obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Trigger>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Trigger obj1, Trigger obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Trigger o && Equals(o);
        }
    }
}
