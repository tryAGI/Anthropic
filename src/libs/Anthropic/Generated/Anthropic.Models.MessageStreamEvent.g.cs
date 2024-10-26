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
        public global::Anthropic.MessageStartEvent? MessageStart { get; init; }
#else
        public global::Anthropic.MessageStartEvent? MessageStart { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStartEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageStartEvent?(MessageStreamEvent @this) => @this.MessageStart;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageStartEvent? value)
        {
            MessageStart = value;
        }

        /// <summary>
        /// A delta event in a streaming conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MessageDeltaEvent? MessageDelta { get; init; }
#else
        public global::Anthropic.MessageDeltaEvent? MessageDelta { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageDeltaEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageDeltaEvent?(MessageStreamEvent @this) => @this.MessageDelta;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageDeltaEvent? value)
        {
            MessageDelta = value;
        }

        /// <summary>
        /// A stop event in a streaming conversation.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MessageStopEvent? MessageStop { get; init; }
#else
        public global::Anthropic.MessageStopEvent? MessageStop { get; }
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
        public static implicit operator MessageStreamEvent(global::Anthropic.MessageStopEvent value) => new MessageStreamEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.MessageStopEvent?(MessageStreamEvent @this) => @this.MessageStop;

        /// <summary>
        /// 
        /// </summary>
        public MessageStreamEvent(global::Anthropic.MessageStopEvent? value)
        {
            MessageStop = value;
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
            global::Anthropic.MessageStartEvent? messageStart,
            global::Anthropic.MessageDeltaEvent? messageDelta,
            global::Anthropic.MessageStopEvent? messageStop,
            global::Anthropic.ContentBlockStartEvent? contentBlockStart,
            global::Anthropic.ContentBlockDeltaEvent? contentBlockDelta,
            global::Anthropic.ContentBlockStopEvent? contentBlockStop,
            global::Anthropic.PingEvent? ping,
            global::Anthropic.ErrorEvent? error
            )
        {
            Type = type;

            MessageStart = messageStart;
            MessageDelta = messageDelta;
            MessageStop = messageStop;
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
            MessageStop as object ??
            MessageDelta as object ??
            MessageStart as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && IsContentBlockDelta && !IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && IsContentBlockStop && !IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && IsPing && !IsError || !IsMessageStart && !IsMessageDelta && !IsMessageStop && !IsContentBlockStart && !IsContentBlockDelta && !IsContentBlockStop && !IsPing && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.MessageStartEvent?, TResult>? messageStart = null,
            global::System.Func<global::Anthropic.MessageDeltaEvent?, TResult>? messageDelta = null,
            global::System.Func<global::Anthropic.MessageStopEvent?, TResult>? messageStop = null,
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
            global::System.Action<global::Anthropic.MessageStartEvent?>? messageStart = null,
            global::System.Action<global::Anthropic.MessageDeltaEvent?>? messageDelta = null,
            global::System.Action<global::Anthropic.MessageStopEvent?>? messageStop = null,
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
                MessageStart,
                typeof(global::Anthropic.MessageStartEvent),
                MessageDelta,
                typeof(global::Anthropic.MessageDeltaEvent),
                MessageStop,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStartEvent?>.Default.Equals(MessageStart, other.MessageStart) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageDeltaEvent?>.Default.Equals(MessageDelta, other.MessageDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MessageStopEvent?>.Default.Equals(MessageStop, other.MessageStop) &&
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
