using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A event in a streaming conversation.
    /// </summary>
    public readonly struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MessageStartEvent? Start { get; init; }
#else
        public global::Anthropic.MessageStartEvent? Start { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Start))]
#endif
        public bool IsStart => Start != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageStartEvent?(MessageStreamEvent @this) => @this.Start;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageStartEvent? value)
        {
            Start = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MessageDeltaEvent? Delta { get; init; }
#else
        public global::Anthropic.MessageDeltaEvent? Delta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delta))]
#endif
        public bool IsDelta => Delta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageDeltaEvent?(MessageStreamEvent @this) => @this.Delta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageDeltaEvent? value)
        {
            Delta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MessageStopEvent? Stop { get; init; }
#else
        public global::Anthropic.MessageStopEvent? Stop { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Stop))]
#endif
        public bool IsStop => Stop != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageStopEvent?(MessageStreamEvent @this) => @this.Stop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageStopEvent? value)
        {
            Stop = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ContentBlockStartEvent? ContentBlockStart { get; init; }
#else
        public global::Anthropic.ContentBlockStartEvent? ContentBlockStart { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ContentBlockStartEvent?(MessageStreamEvent @this) => @this.ContentBlockStart;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.ContentBlockStartEvent? value)
        {
            ContentBlockStart = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ContentBlockDeltaEvent? ContentBlockDelta { get; init; }
#else
        public global::Anthropic.ContentBlockDeltaEvent? ContentBlockDelta { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ContentBlockDeltaEvent?(MessageStreamEvent @this) => @this.ContentBlockDelta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.ContentBlockDeltaEvent? value)
        {
            ContentBlockDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ContentBlockStopEvent? ContentBlockStop { get; init; }
#else
        public global::Anthropic.ContentBlockStopEvent? ContentBlockStop { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ContentBlockStopEvent?(MessageStreamEvent @this) => @this.ContentBlockStop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.ContentBlockStopEvent? value)
        {
            ContentBlockStop = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.PingEvent? Ping { get; init; }
#else
        public global::Anthropic.PingEvent? Ping { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ping))]
#endif
        public bool IsPing => Ping != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::Anthropic.PingEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.PingEvent?(MessageStreamEvent @this) => @this.Ping;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.PingEvent? value)
        {
            Ping = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::Anthropic.MessageStartEvent? start,
            global::Anthropic.MessageDeltaEvent? delta,
            global::Anthropic.MessageStopEvent? stop,
            global::Anthropic.ContentBlockStartEvent? contentBlockStart,
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta,
            global::Anthropic.ContentBlockStopEvent? contentBlockStop,
            global::Anthropic.PingEvent? ping
            )
        {
            Start = start;
            Delta = delta;
            Stop = stop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            Ping = ping;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ping as object ??
            ContentBlockStop as object ??
            ContentBlockDelta as object ??
            ContentBlockStart as object ??
            Stop as object ??
            Delta as object ??
            Start as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Start,
                typeof(global::Anthropic.MessageStartEvent),
                Delta,
                typeof(global::Anthropic.MessageDeltaEvent),
                Stop,
                typeof(global::Anthropic.MessageStopEvent),
                ContentBlockStart,
                typeof(global::Anthropic.ContentBlockStartEvent),
                ContentBlockDelta,
                typeof(global::Anthropic.ContentBlockDeltaEvent),
                ContentBlockStop,
                typeof(global::Anthropic.ContentBlockStopEvent),
                Ping,
                typeof(global::Anthropic.PingEvent),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStartEvent?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageDeltaEvent?>.Default.Equals(Delta, other.Delta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStopEvent?>.Default.Equals(Stop, other.Stop) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PingEvent?>.Default.Equals(Ping, other.Ping) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessageStreamEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessageStreamEvent obj1, MessageStreamEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessageStreamEvent o && Equals(o);
        }
    }
}
