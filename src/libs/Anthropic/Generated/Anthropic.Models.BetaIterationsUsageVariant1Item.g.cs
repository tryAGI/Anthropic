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
        /// 
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaMessageIterationUsage? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaMessageIterationUsage PickMessage() => IsMessage
            ? Message!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

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
        public bool TryPickCompaction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCompactionIterationUsage? value)
        {
            value = Compaction;
            return IsCompaction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCompactionIterationUsage PickCompaction() => IsCompaction
            ? Compaction!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Compaction' but the value was {ToString()}.");

        /// <summary>
        /// Token usage for an advisor sub-inference iteration.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAdvisorMessageIterationUsage? AdvisorMessage { get; init; }
#else
        public global::Anthropic.BetaAdvisorMessageIterationUsage? AdvisorMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorMessage))]
#endif
        public bool IsAdvisorMessage => AdvisorMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAdvisorMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAdvisorMessageIterationUsage? value)
        {
            value = AdvisorMessage;
            return IsAdvisorMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaAdvisorMessageIterationUsage PickAdvisorMessage() => IsAdvisorMessage
            ? AdvisorMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorMessage' but the value was {ToString()}.");

        /// <summary>
        /// Token usage for the fallback-model attempt of a server-side fallback request.<br/>
        /// Produced in place of a `message` entry for whichever hop served the<br/>
        /// response. A declined hop produces the existing `message` entry. Whether<br/>
        /// a fallback model served the response is signalled by the presence of this<br/>
        /// entry in `usage.iterations`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaFallbackMessageIterationUsage? FallbackMessage { get; init; }
#else
        public global::Anthropic.BetaFallbackMessageIterationUsage? FallbackMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FallbackMessage))]
#endif
        public bool IsFallbackMessage => FallbackMessage != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFallbackMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaFallbackMessageIterationUsage? value)
        {
            value = FallbackMessage;
            return IsFallbackMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaFallbackMessageIterationUsage PickFallbackMessage() => IsFallbackMessage
            ? FallbackMessage!
            : throw new global::System.InvalidOperationException($"Expected union variant 'FallbackMessage' but the value was {ToString()}.");
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
        public static BetaIterationsUsageVariant1Item FromMessage(global::Anthropic.BetaMessageIterationUsage? value) => new BetaIterationsUsageVariant1Item(value);

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
        public static BetaIterationsUsageVariant1Item FromCompaction(global::Anthropic.BetaCompactionIterationUsage? value) => new BetaIterationsUsageVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaIterationsUsageVariant1Item(global::Anthropic.BetaAdvisorMessageIterationUsage value) => new BetaIterationsUsageVariant1Item((global::Anthropic.BetaAdvisorMessageIterationUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaAdvisorMessageIterationUsage?(BetaIterationsUsageVariant1Item @this) => @this.AdvisorMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(global::Anthropic.BetaAdvisorMessageIterationUsage? value)
        {
            AdvisorMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaIterationsUsageVariant1Item FromAdvisorMessage(global::Anthropic.BetaAdvisorMessageIterationUsage? value) => new BetaIterationsUsageVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaIterationsUsageVariant1Item(global::Anthropic.BetaFallbackMessageIterationUsage value) => new BetaIterationsUsageVariant1Item((global::Anthropic.BetaFallbackMessageIterationUsage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaFallbackMessageIterationUsage?(BetaIterationsUsageVariant1Item @this) => @this.FallbackMessage;

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(global::Anthropic.BetaFallbackMessageIterationUsage? value)
        {
            FallbackMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaIterationsUsageVariant1Item FromFallbackMessage(global::Anthropic.BetaFallbackMessageIterationUsage? value) => new BetaIterationsUsageVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaIterationsUsageVariant1Item(
            global::Anthropic.BetaIterationsUsageItemsDiscriminatorType? type,
            global::Anthropic.BetaMessageIterationUsage? message,
            global::Anthropic.BetaCompactionIterationUsage? compaction,
            global::Anthropic.BetaAdvisorMessageIterationUsage? advisorMessage,
            global::Anthropic.BetaFallbackMessageIterationUsage? fallbackMessage
            )
        {
            Type = type;

            Message = message;
            Compaction = compaction;
            AdvisorMessage = advisorMessage;
            FallbackMessage = fallbackMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            FallbackMessage as object ??
            AdvisorMessage as object ??
            Compaction as object ??
            Message as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            Compaction?.ToString() ??
            AdvisorMessage?.ToString() ??
            FallbackMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsCompaction && !IsAdvisorMessage && !IsFallbackMessage || !IsMessage && IsCompaction && !IsAdvisorMessage && !IsFallbackMessage || !IsMessage && !IsCompaction && IsAdvisorMessage && !IsFallbackMessage || !IsMessage && !IsCompaction && !IsAdvisorMessage && IsFallbackMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaMessageIterationUsage, TResult>? message = null,
            global::System.Func<global::Anthropic.BetaCompactionIterationUsage, TResult>? compaction = null,
            global::System.Func<global::Anthropic.BetaAdvisorMessageIterationUsage, TResult>? advisorMessage = null,
            global::System.Func<global::Anthropic.BetaFallbackMessageIterationUsage, TResult>? fallbackMessage = null,
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
            else if (IsAdvisorMessage && advisorMessage != null)
            {
                return advisorMessage(AdvisorMessage!);
            }
            else if (IsFallbackMessage && fallbackMessage != null)
            {
                return fallbackMessage(FallbackMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaMessageIterationUsage>? message = null,

            global::System.Action<global::Anthropic.BetaCompactionIterationUsage>? compaction = null,

            global::System.Action<global::Anthropic.BetaAdvisorMessageIterationUsage>? advisorMessage = null,

            global::System.Action<global::Anthropic.BetaFallbackMessageIterationUsage>? fallbackMessage = null,
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
            else if (IsAdvisorMessage)
            {
                advisorMessage?.Invoke(AdvisorMessage!);
            }
            else if (IsFallbackMessage)
            {
                fallbackMessage?.Invoke(FallbackMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaMessageIterationUsage>? message = null,
            global::System.Action<global::Anthropic.BetaCompactionIterationUsage>? compaction = null,
            global::System.Action<global::Anthropic.BetaAdvisorMessageIterationUsage>? advisorMessage = null,
            global::System.Action<global::Anthropic.BetaFallbackMessageIterationUsage>? fallbackMessage = null,
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
            else if (IsAdvisorMessage)
            {
                advisorMessage?.Invoke(AdvisorMessage!);
            }
            else if (IsFallbackMessage)
            {
                fallbackMessage?.Invoke(FallbackMessage!);
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
                AdvisorMessage,
                typeof(global::Anthropic.BetaAdvisorMessageIterationUsage),
                FallbackMessage,
                typeof(global::Anthropic.BetaFallbackMessageIterationUsage),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCompactionIterationUsage?>.Default.Equals(Compaction, other.Compaction) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAdvisorMessageIterationUsage?>.Default.Equals(AdvisorMessage, other.AdvisorMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaFallbackMessageIterationUsage?>.Default.Equals(FallbackMessage, other.FallbackMessage) 
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
