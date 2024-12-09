#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaInputContentBlock : global::System.IEquatable<BetaInputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaInputContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.BetaRequestTextBlock? Text { get; }
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
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestTextBlock value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestTextBlock?(BetaInputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.BetaRequestImageBlock? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestImageBlock value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestImageBlock?(BetaInputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.BetaRequestToolUseBlock? ToolUse { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolUse))]
#endif
        public bool IsToolUse => ToolUse != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolUseBlock value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolUseBlock?(BetaInputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.BetaRequestToolResultBlock? ToolResult { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolResult))]
#endif
        public bool IsToolResult => ToolResult != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestToolResultBlock value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestToolResultBlock?(BetaInputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestPDFBlock? Document { get; init; }
#else
        public global::Anthropic.BetaRequestPDFBlock? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestPDFBlock value) => new BetaInputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestPDFBlock?(BetaInputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestPDFBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(
            global::Anthropic.BetaInputContentBlockDiscriminatorType? type,
            global::Anthropic.BetaRequestTextBlock? text,
            global::Anthropic.BetaRequestImageBlock? image,
            global::Anthropic.BetaRequestToolUseBlock? toolUse,
            global::Anthropic.BetaRequestToolResultBlock? toolResult,
            global::Anthropic.BetaRequestPDFBlock? document
            )
        {
            Type = type;

            Text = text;
            Image = image;
            ToolUse = toolUse;
            ToolResult = toolResult;
            Document = document;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Document as object ??
            ToolResult as object ??
            ToolUse as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsToolUse && !IsToolResult && !IsDocument || !IsText && IsImage && !IsToolUse && !IsToolResult && !IsDocument || !IsText && !IsImage && IsToolUse && !IsToolResult && !IsDocument || !IsText && !IsImage && !IsToolUse && IsToolResult && !IsDocument || !IsText && !IsImage && !IsToolUse && !IsToolResult && IsDocument;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.BetaRequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.BetaRequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.BetaRequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.BetaRequestPDFBlock?, TResult>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsToolUse && toolUse != null)
            {
                return toolUse(ToolUse!);
            }
            else if (IsToolResult && toolResult != null)
            {
                return toolResult(ToolResult!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.BetaRequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.BetaRequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.BetaRequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::Anthropic.BetaRequestPDFBlock?>? document = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsToolUse)
            {
                toolUse?.Invoke(ToolUse!);
            }
            else if (IsToolResult)
            {
                toolResult?.Invoke(ToolResult!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::Anthropic.BetaRequestTextBlock),
                Image,
                typeof(global::Anthropic.BetaRequestImageBlock),
                ToolUse,
                typeof(global::Anthropic.BetaRequestToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.BetaRequestToolResultBlock),
                Document,
                typeof(global::Anthropic.BetaRequestPDFBlock),
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
        public bool Equals(BetaInputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestPDFBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaInputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaInputContentBlock obj1, BetaInputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaInputContentBlock o && Equals(o);
        }
    }
}
