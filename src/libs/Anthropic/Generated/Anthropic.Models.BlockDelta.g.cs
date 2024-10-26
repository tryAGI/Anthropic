using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A delta in a streaming message.
    /// </summary>
    public readonly partial struct BlockDelta : global::System.IEquatable<BlockDelta>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BlockDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// A delta in a streaming text block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextBlockDelta? TextDelta { get; init; }
#else
        public global::Anthropic.TextBlockDelta? TextDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextDelta))]
#endif
        public bool IsTextDelta => TextDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::Anthropic.TextBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.TextBlockDelta?(BlockDelta @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::Anthropic.TextBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// A delta in a streaming input JSON.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.InputJsonBlockDelta? InputJsonDelta { get; init; }
#else
        public global::Anthropic.InputJsonBlockDelta? InputJsonDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJsonDelta))]
#endif
        public bool IsInputJsonDelta => InputJsonDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::Anthropic.InputJsonBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.InputJsonBlockDelta?(BlockDelta @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::Anthropic.InputJsonBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(
            global::Anthropic.BlockDeltaDiscriminatorType? type,
            global::Anthropic.TextBlockDelta? textDelta,
            global::Anthropic.InputJsonBlockDelta? inputJsonDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta || !IsTextDelta && IsInputJsonDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.TextBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::Anthropic.InputJsonBlockDelta?, TResult>? inputJsonDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta && textDelta != null)
            {
                return textDelta(TextDelta!);
            }
            else if (IsInputJsonDelta && inputJsonDelta != null)
            {
                return inputJsonDelta(InputJsonDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.TextBlockDelta?>? textDelta = null,
            global::System.Action<global::Anthropic.InputJsonBlockDelta?>? inputJsonDelta = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextDelta)
            {
                textDelta?.Invoke(TextDelta!);
            }
            else if (IsInputJsonDelta)
            {
                inputJsonDelta?.Invoke(InputJsonDelta!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextDelta,
                typeof(global::Anthropic.TextBlockDelta),
                InputJsonDelta,
                typeof(global::Anthropic.InputJsonBlockDelta),
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
        public bool Equals(BlockDelta other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.InputJsonBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BlockDelta obj1, BlockDelta obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BlockDelta>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BlockDelta obj1, BlockDelta obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BlockDelta o && Equals(o);
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
        public static global::Anthropic.BlockDelta? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Anthropic.BlockDelta),
                jsonSerializerContext) as global::Anthropic.BlockDelta?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Anthropic.BlockDelta? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Anthropic.BlockDelta>(
                json,
                jsonSerializerOptions);
        }

    }
}
