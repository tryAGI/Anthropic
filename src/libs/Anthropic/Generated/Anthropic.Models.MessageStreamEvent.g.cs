#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStartEvent value) => new MessageStreamEvent((global::Anthropic.MessageStartEvent?)value);

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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageDeltaEvent value) => new MessageStreamEvent((global::Anthropic.MessageDeltaEvent?)value);

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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStopEvent value) => new MessageStreamEvent((global::Anthropic.MessageStopEvent?)value);

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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockStartEvent value) => new MessageStreamEvent((global::Anthropic.ContentBlockStartEvent?)value);

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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockDeltaEvent value) => new MessageStreamEvent((global::Anthropic.ContentBlockDeltaEvent?)value);

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
        public static implicit operator MessageStreamEvent(global::Anthropic.ContentBlockStopEvent value) => new MessageStreamEvent((global::Anthropic.ContentBlockStopEvent?)value);

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
        public global::Anthropic.Ping? Ping { get; init; }
#else
        public global::Anthropic.Ping? Ping { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.Ping value) => new MessageStreamEvent((global::Anthropic.Ping?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.Ping?(MessageStreamEvent @this) => @this.Ping;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.Ping? value)
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
            global::Anthropic.Ping? ping
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
        public override string? ToString() =>
            Start?.ToString() ??
            Delta?.ToString() ??
            Stop?.ToString() ??
            ContentBlockStart?.ToString() ??
            ContentBlockDelta?.ToString() ??
            ContentBlockStop?.ToString() ??
            Ping?.ToString() 
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
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.MessageStartEvent?, TResult>? start = null,
            global::System.Func<global::Anthropic.MessageDeltaEvent?, TResult>? delta = null,
            global::System.Func<global::Anthropic.MessageStopEvent?, TResult>? stop = null,
            global::System.Func<global::Anthropic.ContentBlockStartEvent?, TResult>? contentBlockStart = null,
            global::System.Func<global::Anthropic.ContentBlockDeltaEvent?, TResult>? contentBlockDelta = null,
            global::System.Func<global::Anthropic.ContentBlockStopEvent?, TResult>? contentBlockStop = null,
            global::System.Func<global::Anthropic.Ping?, TResult>? ping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart && start != null)
            {
                return start(Start!);
            }
            else if (IsDelta && delta != null)
            {
                return delta(Delta!);
            }
            else if (IsStop && stop != null)
            {
                return stop(Stop!);
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
            else if (IsPing && ping != null)
            {
                return ping(Ping!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.MessageStartEvent?>? start = null,
            global::System.Action<global::Anthropic.MessageDeltaEvent?>? delta = null,
            global::System.Action<global::Anthropic.MessageStopEvent?>? stop = null,
            global::System.Action<global::Anthropic.ContentBlockStartEvent?>? contentBlockStart = null,
            global::System.Action<global::Anthropic.ContentBlockDeltaEvent?>? contentBlockDelta = null,
            global::System.Action<global::Anthropic.ContentBlockStopEvent?>? contentBlockStop = null,
            global::System.Action<global::Anthropic.Ping?>? ping = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStart)
            {
                start?.Invoke(Start!);
            }
            else if (IsDelta)
            {
                delta?.Invoke(Delta!);
            }
            else if (IsStop)
            {
                stop?.Invoke(Stop!);
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
            else if (IsPing)
            {
                ping?.Invoke(Ping!);
            }
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
                typeof(global::Anthropic.Ping),
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
        public bool Equals(MessageStreamEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStartEvent?>.Default.Equals(Start, other.Start) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageDeltaEvent?>.Default.Equals(Delta, other.Delta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStopEvent?>.Default.Equals(Stop, other.Stop) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockStartEvent?>.Default.Equals(ContentBlockStart, other.ContentBlockStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockDeltaEvent?>.Default.Equals(ContentBlockDelta, other.ContentBlockDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ContentBlockStopEvent?>.Default.Equals(ContentBlockStop, other.ContentBlockStop) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Ping?>.Default.Equals(Ping, other.Ping) 
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
