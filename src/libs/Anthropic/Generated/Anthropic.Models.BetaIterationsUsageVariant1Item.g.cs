#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaIterationsUsageVariant1Item : global::System.IEquatable<BetaIterationsUsageVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? Type { get; }

        /// <summary>
        /// Token usage for a sampling iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMessageIterationUsage? Message { get; init; }
#else
        public global::Anthropic.BetaMessageIterationUsage? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// Token usage for a compaction iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCompactionIterationUsage? Compaction { get; init; }
#else
        public global::Anthropic.BetaCompactionIterationUsage? Compaction { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Compaction))]
#endif
        public bool IsCompaction => Compaction != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaIterationsUsageVariant1Item(global::Anthropic.BetaMessageIterationUsage value) => new BetaIterationsUsageVariant1Item((global::Anthropic.BetaMessageIterationUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMessageIterationUsage?(BetaIterationsUsageVariant1Item @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(global::Anthropic.BetaMessageIterationUsage? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaIterationsUsageVariant1Item(global::Anthropic.BetaCompactionIterationUsage value) => new BetaIterationsUsageVariant1Item((global::Anthropic.BetaCompactionIterationUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCompactionIterationUsage?(BetaIterationsUsageVariant1Item @this) => @this.Compaction;

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(global::Anthropic.BetaCompactionIterationUsage? value)
        {
            Compaction = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(
            global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? type,
            global::Anthropic.BetaMessageIterationUsage? message,
            global::Anthropic.BetaCompactionIterationUsage? compaction
            )
        {
            Type = type;

            Message = message;
            Compaction = compaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Compaction as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Compaction?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsCompaction || !IsMessage && IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaMessageIterationUsage?, TResult>? message = null,
            global::System.Func<global::Anthropic.BetaCompactionIterationUsage?, TResult>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsCompaction && compaction != null)
            {
                return compaction(Compaction!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaMessageIterationUsage?>? message = null,
            global::System.Action<global::Anthropic.BetaCompactionIterationUsage?>? compaction = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsCompaction)
            {
                compaction?.Invoke(Compaction!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::Anthropic.BetaMessageIterationUsage),
                Compaction,
                typeof(global::Anthropic.BetaCompactionIterationUsage),
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
        public bool Equals(BetaIterationsUsageVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMessageIterationUsage?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCompactionIterationUsage?>.Default.Equals(Compaction, other.Compaction) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaIterationsUsageVariant1Item obj1, BetaIterationsUsageVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaIterationsUsageVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaIterationsUsageVariant1Item obj1, BetaIterationsUsageVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaIterationsUsageVariant1Item o && Equals(o);
        }
    }
}
