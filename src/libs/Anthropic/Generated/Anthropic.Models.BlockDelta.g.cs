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
#if NET6_0_OR_GREATER
        public global::Anthropic.TextBlockDelta? Text { get; init; }
#else
        public global::Anthropic.TextBlockDelta? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::Anthropic.TextBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.TextBlockDelta?(BlockDelta @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::Anthropic.TextBlockDelta? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.InputJsonBlockDelta? InputJson { get; init; }
#else
        public global::Anthropic.InputJsonBlockDelta? InputJson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputJson))]
#endif
        public bool IsInputJson => InputJson != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BlockDelta(global::Anthropic.InputJsonBlockDelta value) => new BlockDelta(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.InputJsonBlockDelta?(BlockDelta @this) => @this.InputJson;

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(global::Anthropic.InputJsonBlockDelta? value)
        {
            InputJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BlockDelta(
            global::Anthropic.TextBlockDelta? text,
            global::Anthropic.InputJsonBlockDelta? inputJson
            )
        {
            Text = text;
            InputJson = inputJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputJson as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsInputJson || !IsText && IsInputJson;
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.TextBlockDelta),
                InputJson,
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextBlockDelta?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.InputJsonBlockDelta?>.Default.Equals(InputJson, other.InputJson) 
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
    }
}
