#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct KeepVariant1 : global::System.IEquatable<KeepVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaClearThinking20251015KeepDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaThinkingTurns? ThinkingTurns { get; init; }
#else
        public global::Anthropic.BetaThinkingTurns? ThinkingTurns { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingTurns))]
#endif
        public bool IsThinkingTurns => ThinkingTurns != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeepVariant1(global::Anthropic.BetaThinkingTurns value) => new KeepVariant1((global::Anthropic.BetaThinkingTurns?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaThinkingTurns?(KeepVariant1 @this) => @this.ThinkingTurns;

        /// <summary>
        /// 
        /// </summary>
        public KeepVariant1(global::Anthropic.BetaThinkingTurns? value)
        {
            ThinkingTurns = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAllThinkingTurns? All { get; init; }
#else
        public global::Anthropic.BetaAllThinkingTurns? All { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(All))]
#endif
        public bool IsAll => All != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator KeepVariant1(global::Anthropic.BetaAllThinkingTurns value) => new KeepVariant1((global::Anthropic.BetaAllThinkingTurns?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAllThinkingTurns?(KeepVariant1 @this) => @this.All;

        /// <summary>
        /// 
        /// </summary>
        public KeepVariant1(global::Anthropic.BetaAllThinkingTurns? value)
        {
            All = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public KeepVariant1(
            global::Anthropic.BetaClearThinking20251015KeepDiscriminatorType? type,
            global::Anthropic.BetaThinkingTurns? thinkingTurns,
            global::Anthropic.BetaAllThinkingTurns? all
            )
        {
            Type = type;

            ThinkingTurns = thinkingTurns;
            All = all;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            All as object ??
            ThinkingTurns as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ThinkingTurns?.ToString() ??
            All?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsThinkingTurns && !IsAll || !IsThinkingTurns && IsAll;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaThinkingTurns?, TResult>? thinkingTurns = null,
            global::System.Func<global::Anthropic.BetaAllThinkingTurns?, TResult>? all = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingTurns && thinkingTurns != null)
            {
                return thinkingTurns(ThinkingTurns!);
            }
            else if (IsAll && all != null)
            {
                return all(All!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaThinkingTurns?>? thinkingTurns = null,
            global::System.Action<global::Anthropic.BetaAllThinkingTurns?>? all = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsThinkingTurns)
            {
                thinkingTurns?.Invoke(ThinkingTurns!);
            }
            else if (IsAll)
            {
                all?.Invoke(All!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ThinkingTurns,
                typeof(global::Anthropic.BetaThinkingTurns),
                All,
                typeof(global::Anthropic.BetaAllThinkingTurns),
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
        public bool Equals(KeepVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaThinkingTurns?>.Default.Equals(ThinkingTurns, other.ThinkingTurns) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAllThinkingTurns?>.Default.Equals(All, other.All) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(KeepVariant1 obj1, KeepVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<KeepVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(KeepVariant1 obj1, KeepVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is KeepVariant1 o && Equals(o);
        }
    }
}
