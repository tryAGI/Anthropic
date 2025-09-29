#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct EditsItem : global::System.IEquatable<EditsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClearToolUses20250919? ClearToolUses20250919 { get; init; }
#else
        public global::Anthropic.BetaClearToolUses20250919? ClearToolUses20250919 { get; }
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
        public static implicit operator EditsItem(global::Anthropic.BetaClearToolUses20250919 value) => new EditsItem((global::Anthropic.BetaClearToolUses20250919?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaClearToolUses20250919?(EditsItem @this) => @this.ClearToolUses20250919;

        /// <summary>
        /// 
        /// </summary>
        public EditsItem(global::Anthropic.BetaClearToolUses20250919? value)
        {
            ClearToolUses20250919 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public EditsItem(
            global::Anthropic.BetaContextManagementConfigEditDiscriminatorType? type,
            global::Anthropic.BetaClearToolUses20250919? clearToolUses20250919
            )
        {
            Type = type;

            ClearToolUses20250919 = clearToolUses20250919;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClearToolUses20250919 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ClearToolUses20250919?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClearToolUses20250919;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClearToolUses20250919?, TResult>? clearToolUses20250919 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClearToolUses20250919?>? clearToolUses20250919 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ClearToolUses20250919,
                typeof(global::Anthropic.BetaClearToolUses20250919),
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
        public bool Equals(EditsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClearToolUses20250919?>.Default.Equals(ClearToolUses20250919, other.ClearToolUses20250919) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(EditsItem obj1, EditsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EditsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(EditsItem obj1, EditsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EditsItem o && Equals(o);
        }
    }
}
