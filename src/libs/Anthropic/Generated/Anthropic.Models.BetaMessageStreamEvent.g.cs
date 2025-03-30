#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaMessageStreamEvent : global::System.IEquatable<BetaMessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaMessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMessageStartEvent? MessageStart { get; init; }
#else
        public global::Anthropic.BetaMessageStartEvent? MessageStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStart))]
#endif
        public bool IsMessageStart => MessageStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaMessageStartEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMessageStartEvent?(BetaMessageStreamEvent @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaMessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMessageDeltaEvent? MessageDelta { get; init; }
#else
        public global::Anthropic.BetaMessageDeltaEvent? MessageDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageDelta))]
#endif
        public bool IsMessageDelta => MessageDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaMessageDeltaEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMessageDeltaEvent?(BetaMessageStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaMessageDeltaEvent? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMessageStopEvent? MessageStop { get; init; }
#else
        public global::Anthropic.BetaMessageStopEvent? MessageStop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessageStop))]
#endif
        public bool IsMessageStop => MessageStop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaMessageStopEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMessageStopEvent?(BetaMessageStreamEvent @this) => @this.MessageStop;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaMessageStopEvent? value)
        {
            MessageStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaContentBlockStartEvent? ContentBlockStart { get; init; }
#else
        public global::Anthropic.BetaContentBlockStartEvent? ContentBlockStart { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStart))]
#endif
        public bool IsContentBlockStart => ContentBlockStart != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaContentBlockStartEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaContentBlockStartEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaContentBlockStartEvent? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaContentBlockDeltaEvent? ContentBlockDelta { get; init; }
#else
        public global::Anthropic.BetaContentBlockDeltaEvent? ContentBlockDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockDelta))]
#endif
        public bool IsContentBlockDelta => ContentBlockDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaContentBlockDeltaEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaContentBlockDeltaEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaContentBlockDeltaEvent? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaContentBlockStopEvent? ContentBlockStop { get; init; }
#else
        public global::Anthropic.BetaContentBlockStopEvent? ContentBlockStop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContentBlockStop))]
#endif
        public bool IsContentBlockStop => ContentBlockStop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMessageStreamEvent(global::Anthropic.BetaContentBlockStopEvent value) => new BetaMessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaContentBlockStopEvent?(BetaMessageStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(global::Anthropic.BetaContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaMessageStreamEvent(
            global::Anthropic.BetaMessageStreamEventDiscriminatorType? type,
            global::Anthropic.BetaMessageStartEvent? messageStart,
            global::Anthropic.BetaMessageDeltaEvent? messageDelta,
            global::Anthropic.BetaMessageStopEvent? messageStop,
            global::Anthropic.BetaContentBlockStartEvent? contentBlockStart,
            global::Anthropic.BetaContentBlockDeltaEvent? contentBlockDelta,
            global::Anthropic.BetaContentBlockStopEvent? contentBlockStop
            )
        {
            Type = type;

            MessageStart = messageStart;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            MessageStop as object ??
            MessageDelta as object ??
            MessageStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            MessageStart?.ToString() ??
            MessageDelta?.ToString() ??
            MessageStop?.ToString() ??
            ContentBlockStart?.ToString() ??
            ContentBlockDelta?.ToString() ??
            ContentBlockStop?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaMessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::Anthropic.BetaMessageDeltaEvent?, TResult>? messageDelta = null,
            global::System.Func<global::Anthropic.BetaMessageStopEvent?, TResult>? messageStop = null,
            global::System.Func<global::Anthropic.BetaContentBlockStartEvent?, TResult>? contentBlockStart = null,
            global::System.Func<global::Anthropic.BetaContentBlockDeltaEvent?, TResult>? contentBlockDelta = null,
            global::System.Func<global::Anthropic.BetaContentBlockStopEvent?, TResult>? contentBlockStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart && messageStart != null)
            {
                return messageStart(MessageStart!);
            }
            else if (IsMessageDelta && messageDelta != null)
            {
                return messageDelta(MessageDelta!);
            }
            else if (IsMessageStop && messageStop != null)
            {
                return messageStop(MessageStop!);
            }
            else if (IsContentBlockStart && contentBlockStart != null)
            {
                return contentBlockStart(ContentBlockStart!);
            }
            else if (IsContentBlockDelta && contentBlockDelta != null)
            {
                return contentBlockDelta(ContentBlockDelta!);
            }
            else if (IsContentBlockStop && contentBlockStop != null)
            {
                return contentBlockStop(ContentBlockStop!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaMessageStartEvent?>? messageStart = null,
            global::System.Action<global::Anthropic.BetaMessageDeltaEvent?>? messageDelta = null,
            global::System.Action<global::Anthropic.BetaMessageStopEvent?>? messageStop = null,
            global::System.Action<global::Anthropic.BetaContentBlockStartEvent?>? contentBlockStart = null,
            global::System.Action<global::Anthropic.BetaContentBlockDeltaEvent?>? contentBlockDelta = null,
            global::System.Action<global::Anthropic.BetaContentBlockStopEvent?>? contentBlockStop = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMessageStart)
            {
                messageStart?.Invoke(MessageStart!);
            }
            else if (IsMessageDelta)
            {
                messageDelta?.Invoke(MessageDelta!);
            }
            else if (IsMessageStop)
            {
                messageStop?.Invoke(MessageStop!);
            }
            else if (IsContentBlockStart)
            {
                contentBlockStart?.Invoke(ContentBlockStart!);
            }
            else if (IsContentBlockDelta)
            {
                contentBlockDelta?.Invoke(ContentBlockDelta!);
            }
            else if (IsContentBlockStop)
            {
                contentBlockStop?.Invoke(ContentBlockStop!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                MessageStart,
                typeof(global::Anthropic.BetaMessageStartEvent),
                MessageDelta,
                typeof(global::Anthropic.BetaMessageDeltaEvent),
                MessageStop,
                typeof(global::Anthropic.BetaMessageStopEvent),
                ContentBlockStart,
                typeof(global::Anthropic.BetaContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::Anthropic.BetaContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::Anthropic.BetaContentBlockStopEvent),
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
        public bool Equals(BetaMessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMessageDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMessageStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaMessageStreamEvent obj1, BetaMessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaMessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaMessageStreamEvent obj1, BetaMessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaMessageStreamEvent o && Equals(o);
        }
    }
}
