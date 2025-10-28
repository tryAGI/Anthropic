#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct AppliedEditsItem : global::System.IEquatable<AppliedEditsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? ClearToolUses20250919 { get; init; }
#else
        public global::Anthropic.BetaResponseClearToolUses20250919Edit? ClearToolUses20250919 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClearToolUses20250919))]
#endif
        public bool IsClearToolUses20250919 => ClearToolUses20250919 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppliedEditsItem(global::Anthropic.BetaResponseClearToolUses20250919Edit value) => new AppliedEditsItem((global::Anthropic.BetaResponseClearToolUses20250919Edit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseClearToolUses20250919Edit?(AppliedEditsItem @this) => @this.ClearToolUses20250919;

        /// <summary>
        /// 
        /// </summary>
        public AppliedEditsItem(global::Anthropic.BetaResponseClearToolUses20250919Edit? value)
        {
            ClearToolUses20250919 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseClearThinking20251015Edit? ClearThinking20251015 { get; init; }
#else
        public global::Anthropic.BetaResponseClearThinking20251015Edit? ClearThinking20251015 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClearThinking20251015))]
#endif
        public bool IsClearThinking20251015 => ClearThinking20251015 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator AppliedEditsItem(global::Anthropic.BetaResponseClearThinking20251015Edit value) => new AppliedEditsItem((global::Anthropic.BetaResponseClearThinking20251015Edit?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseClearThinking20251015Edit?(AppliedEditsItem @this) => @this.ClearThinking20251015;

        /// <summary>
        /// 
        /// </summary>
        public AppliedEditsItem(global::Anthropic.BetaResponseClearThinking20251015Edit? value)
        {
            ClearThinking20251015 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public AppliedEditsItem(
            global::Anthropic.BetaResponseContextManagementAppliedEditDiscriminatorType? type,
            global::Anthropic.BetaResponseClearToolUses20250919Edit? clearToolUses20250919,
            global::Anthropic.BetaResponseClearThinking20251015Edit? clearThinking20251015
            )
        {
            Type = type;

            ClearToolUses20250919 = clearToolUses20250919;
            ClearThinking20251015 = clearThinking20251015;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClearThinking20251015 as object ??
            ClearToolUses20250919 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ClearToolUses20250919?.ToString() ??
            ClearThinking20251015?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClearToolUses20250919 && !IsClearThinking20251015 || !IsClearToolUses20250919 && IsClearThinking20251015;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaResponseClearToolUses20250919Edit?, TResult>? clearToolUses20250919 = null,
            global::System.Func<global::Anthropic.BetaResponseClearThinking20251015Edit?, TResult>? clearThinking20251015 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClearToolUses20250919 && clearToolUses20250919 != null)
            {
                return clearToolUses20250919(ClearToolUses20250919!);
            }
            else if (IsClearThinking20251015 && clearThinking20251015 != null)
            {
                return clearThinking20251015(ClearThinking20251015!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaResponseClearToolUses20250919Edit?>? clearToolUses20250919 = null,
            global::System.Action<global::Anthropic.BetaResponseClearThinking20251015Edit?>? clearThinking20251015 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClearToolUses20250919)
            {
                clearToolUses20250919?.Invoke(ClearToolUses20250919!);
            }
            else if (IsClearThinking20251015)
            {
                clearThinking20251015?.Invoke(ClearThinking20251015!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClearToolUses20250919,
                typeof(global::Anthropic.BetaResponseClearToolUses20250919Edit),
                ClearThinking20251015,
                typeof(global::Anthropic.BetaResponseClearThinking20251015Edit),
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
        public bool Equals(AppliedEditsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseClearToolUses20250919Edit?>.Default.Equals(ClearToolUses20250919, other.ClearToolUses20250919) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseClearThinking20251015Edit?>.Default.Equals(ClearThinking20251015, other.ClearThinking20251015) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(AppliedEditsItem obj1, AppliedEditsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AppliedEditsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(AppliedEditsItem obj1, AppliedEditsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AppliedEditsItem o && Equals(o);
        }
    }
}
