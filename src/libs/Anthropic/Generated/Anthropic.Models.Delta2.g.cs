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
#if NET6_0_OR_GREATER
        public global::Anthropic.CitationsDelta? CitationsDelta { get; init; }
#else
        public global::Anthropic.CitationsDelta? CitationsDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CitationsDelta))]
#endif
        public bool IsCitationsDelta => CitationsDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::Anthropic.CitationsDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.CitationsDelta?(Delta2 @this) => @this.CitationsDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::Anthropic.CitationsDelta? value)
        {
            CitationsDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ThinkingContentBlockDelta? ThinkingDelta { get; init; }
#else
        public global::Anthropic.ThinkingContentBlockDelta? ThinkingDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ThinkingDelta))]
#endif
        public bool IsThinkingDelta => ThinkingDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::Anthropic.ThinkingContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ThinkingContentBlockDelta?(Delta2 @this) => @this.ThinkingDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::Anthropic.ThinkingContentBlockDelta? value)
        {
            ThinkingDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.SignatureContentBlockDelta? SignatureDelta { get; init; }
#else
        public global::Anthropic.SignatureContentBlockDelta? SignatureDelta { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SignatureDelta))]
#endif
        public bool IsSignatureDelta => SignatureDelta != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Delta2(global::Anthropic.SignatureContentBlockDelta value) => new Delta2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.SignatureContentBlockDelta?(Delta2 @this) => @this.SignatureDelta;

        /// <summary>
        /// 
        /// </summary>
        public Delta2(global::Anthropic.SignatureContentBlockDelta? value)
        {
            SignatureDelta = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Delta2(
            global::Anthropic.ContentBlockDeltaEventDeltaDiscriminatorType? type,
            global::Anthropic.TextContentBlockDelta? textDelta,
            global::Anthropic.InputJsonContentBlockDelta? inputJsonDelta,
            global::Anthropic.CitationsDelta? citationsDelta,
            global::Anthropic.ThinkingContentBlockDelta? thinkingDelta,
            global::Anthropic.SignatureContentBlockDelta? signatureDelta
            )
        {
            Type = type;

            TextDelta = textDelta;
            InputJsonDelta = inputJsonDelta;
            CitationsDelta = citationsDelta;
            ThinkingDelta = thinkingDelta;
            SignatureDelta = signatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SignatureDelta as object ??
            ThinkingDelta as object ??
            CitationsDelta as object ??
            InputJsonDelta as object ??
            TextDelta as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && IsCitationsDelta && !IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && IsThinkingDelta && !IsSignatureDelta || !IsTextDelta && !IsInputJsonDelta && !IsCitationsDelta && !IsThinkingDelta && IsSignatureDelta;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.TextContentBlockDelta?, TResult>? textDelta = null,
            global::System.Func<global::Anthropic.InputJsonContentBlockDelta?, TResult>? inputJsonDelta = null,
            global::System.Func<global::Anthropic.CitationsDelta?, TResult>? citationsDelta = null,
            global::System.Func<global::Anthropic.ThinkingContentBlockDelta?, TResult>? thinkingDelta = null,
            global::System.Func<global::Anthropic.SignatureContentBlockDelta?, TResult>? signatureDelta = null,
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
            else if (IsCitationsDelta && citationsDelta != null)
            {
                return citationsDelta(CitationsDelta!);
            }
            else if (IsThinkingDelta && thinkingDelta != null)
            {
                return thinkingDelta(ThinkingDelta!);
            }
            else if (IsSignatureDelta && signatureDelta != null)
            {
                return signatureDelta(SignatureDelta!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.TextContentBlockDelta?>? textDelta = null,
            global::System.Action<global::Anthropic.InputJsonContentBlockDelta?>? inputJsonDelta = null,
            global::System.Action<global::Anthropic.CitationsDelta?>? citationsDelta = null,
            global::System.Action<global::Anthropic.ThinkingContentBlockDelta?>? thinkingDelta = null,
            global::System.Action<global::Anthropic.SignatureContentBlockDelta?>? signatureDelta = null,
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
            else if (IsCitationsDelta)
            {
                citationsDelta?.Invoke(CitationsDelta!);
            }
            else if (IsThinkingDelta)
            {
                thinkingDelta?.Invoke(ThinkingDelta!);
            }
            else if (IsSignatureDelta)
            {
                signatureDelta?.Invoke(SignatureDelta!);
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
                CitationsDelta,
                typeof(global::Anthropic.CitationsDelta),
                ThinkingDelta,
                typeof(global::Anthropic.ThinkingContentBlockDelta),
                SignatureDelta,
                typeof(global::Anthropic.SignatureContentBlockDelta),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.InputJsonContentBlockDelta?>.Default.Equals(InputJsonDelta, other.InputJsonDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CitationsDelta?>.Default.Equals(CitationsDelta, other.CitationsDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ThinkingContentBlockDelta?>.Default.Equals(ThinkingDelta, other.ThinkingDelta) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.SignatureContentBlockDelta?>.Default.Equals(SignatureDelta, other.SignatureDelta) 
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
