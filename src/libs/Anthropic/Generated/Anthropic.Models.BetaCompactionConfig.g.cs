#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaCompactionConfig : global::System.IEquatable<BetaCompactionConfig>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCompactionConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// Compact the whole conversation and return a signed `compaction` block,<br/>
        /// alone, that a later request sends back first in `messages`, in place of<br/>
        /// the messages it summarizes. There is no trigger and no pause flag: sending<br/>
        /// the parameter compacts, and nothing is sampled after the block.<br/>
        /// The summarization prompt is the server's own unless `instructions` are<br/>
        /// given, which then replace it for this request; a value that is empty or<br/>
        /// only whitespace counts as absent.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaSummarizeCompaction? Summarize { get; init; }
#else
        public global::Anthropic.BetaSummarizeCompaction? Summarize { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Summarize))]
#endif
        public bool IsSummarize => Summarize != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSummarize(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaSummarizeCompaction? value)
        {
            value = Summarize;
            return IsSummarize;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaSummarizeCompaction PickSummarize() => IsSummarize
            ? Summarize!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Summarize' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaCompactionConfig(global::Anthropic.BetaSummarizeCompaction value) => new BetaCompactionConfig((global::Anthropic.BetaSummarizeCompaction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaSummarizeCompaction?(BetaCompactionConfig @this) => @this.Summarize;

        /// <summary>
        ///
        /// </summary>
        public BetaCompactionConfig(global::Anthropic.BetaSummarizeCompaction? value)
        {
            Summarize = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaCompactionConfig FromSummarize(global::Anthropic.BetaSummarizeCompaction? value) => new BetaCompactionConfig(value);

        /// <summary>
        ///
        /// </summary>
        public BetaCompactionConfig(
            global::Anthropic.BetaCompactionConfigDiscriminatorType? type,
            global::Anthropic.BetaSummarizeCompaction? summarize
            )
        {
            Type = type;

            Summarize = summarize;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Summarize as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Summarize?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSummarize;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaSummarizeCompaction, TResult>? summarize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummarize && summarize != null)
            {
                return summarize(Summarize!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaSummarizeCompaction>? summarize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummarize)
            {
                summarize?.Invoke(Summarize!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaSummarizeCompaction>? summarize = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSummarize)
            {
                summarize?.Invoke(Summarize!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Summarize,
                typeof(global::Anthropic.BetaSummarizeCompaction),
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
        public bool Equals(BetaCompactionConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaSummarizeCompaction?>.Default.Equals(Summarize, other.Summarize)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaCompactionConfig obj1, BetaCompactionConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaCompactionConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaCompactionConfig obj1, BetaCompactionConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaCompactionConfig o && Equals(o);
        }
    }
}
