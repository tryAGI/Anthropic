using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A event in a streaming conversation.
    /// </summary>
    public readonly partial struct MessageStreamEvent : global::System.IEquatable<MessageStreamEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.MessageStreamEventDiscriminatorType? Type { get; }

        /// <summary>
        /// A start event in a streaming conversation.
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
        /// A delta event in a streaming conversation.
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
        /// A stop event in a streaming conversation.
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
        /// A start event in a streaming content block.
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
        /// A delta event in a streaming content block.
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
        /// A stop event in a streaming content block.
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
        /// A ping event in a streaming conversation.
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
        /// An error event in a streaming conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ErrorEvent? Error { get; init; }
#else
        public global::Anthropic.ErrorEvent? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessageStreamEvent(global::Anthropic.ErrorEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ErrorEvent?(MessageStreamEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.ErrorEvent? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(
            global::Anthropic.MessageStreamEventDiscriminatorType? type,
            global::Anthropic.MessageStartEvent? start,
            global::Anthropic.MessageDeltaEvent? delta,
            global::Anthropic.MessageStopEvent? stop,
            global::Anthropic.ContentBlockStartEvent? contentBlockStart,
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta,
            global::Anthropic.ContentBlockStopEvent? contentBlockStop,
            global::Anthropic.PingEvent? ping,
            global::Anthropic.ErrorEvent? error
            )
        {
            Type = type;

            Start = start;
            Delta = delta;
            Stop = stop;
            ContentBlockStart = contentBlockStart;
            ContentBlockDelta = contentBlockDelta;
            ContentBlockStop = contentBlockStop;
            Ping = ping;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
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
            return IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsStart && IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsStart && !IsDelta && IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsStart && !IsDelta && !IsStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing && !IsError || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing && !IsError || !IsStart && !IsDelta && !IsStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && IsError;
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
            global::System.Func<global::Anthropic.PingEvent?, TResult>? ping = null,
            global::System.Func<global::Anthropic.ErrorEvent?, TResult>? error = null,
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
            else if (IsError && error != null)
            {
                return error(Error!);
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
            global::System.Action<global::Anthropic.PingEvent?>? ping = null,
            global::System.Action<global::Anthropic.ErrorEvent?>? error = null,
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
            else if (IsError)
            {
                error?.Invoke(Error!);
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
                typeof(global::Anthropic.PingEvent),
                Error,
                typeof(global::Anthropic.ErrorEvent),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.PingEvent?>.Default.Equals(Ping, other.Ping) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ErrorEvent?>.Default.Equals(Error, other.Error) 
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Anthropic.MessageStreamEvent? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Anthropic.MessageStreamEvent),
                jsonSerializerContext) as global::Anthropic.MessageStreamEvent?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Anthropic.MessageStreamEvent? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.MessageStreamEvent>(
                json,
                jsonSerializerOptions);
        }

    }
}
