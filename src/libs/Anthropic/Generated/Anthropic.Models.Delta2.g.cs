#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Delta2 : global::System.IEquatable<Delta2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextContentBlockDelta? TextDelta { get; init; }
#else
        public global::Anthropic.TextContentBlockDelta? TextDelta { get; }
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
        public static implicit operator Delta2(global::Anthropic.TextContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.TextContentBlockDelta?(Delta2 @this) => @this.TextDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::Anthropic.TextContentBlockDelta? value)
        {
            TextDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.InputJsonContentBlockDelta? InputJsonDelta { get; init; }
#else
        public global::Anthropic.InputJsonContentBlockDelta? InputJsonDelta { get; }
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
        public static implicit operator Delta2(global::Anthropic.InputJsonContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.InputJsonContentBlockDelta?(Delta2 @this) => @this.InputJsonDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::Anthropic.InputJsonContentBlockDelta? value)
        {
            InputJsonDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta2(
            global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::Anthropic.TextContentBlockDelta? textDelta,
            global::Anthropic.InputJsonContentBlockDelta? inputJsonDelta
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
            global::System.Func<global::Anthropic.TextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::Anthropic.InputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
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
            global::System.Action<global::Anthropic.TextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::Anthropic.InputJsonContentBlockDelta?>? inputJsonDelta = null,
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
                typeof(global::Anthropic.TextContentBlockDelta),
                InputJsonDelta,
                typeof(global::Anthropic.InputJsonContentBlockDelta),
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
        public bool Equals(Delta2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextContentBlockDelta?>.Default.Equals(TextDelta, other.TextDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.InputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Delta2 obj1, Delta2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Delta2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Delta2 obj1, Delta2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Delta2 o && Equals(o);
        }
    }
}
