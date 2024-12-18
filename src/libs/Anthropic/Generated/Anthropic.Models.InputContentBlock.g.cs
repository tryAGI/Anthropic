#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputContentBlock : global::System.IEquatable<InputContentBlock>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.InputContentBlockDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestTextBlock? Text { get; init; }
#else
        public global::Anthropic.RequestTextBlock? Text { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestTextBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestTextBlock?(InputContentBlock @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestImageBlock? Image { get; init; }
#else
        public global::Anthropic.RequestImageBlock? Image { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestImageBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestImageBlock?(InputContentBlock @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestImageBlock? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolUseBlock? ToolUse { get; init; }
#else
        public global::Anthropic.RequestToolUseBlock? ToolUse { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestToolUseBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolUseBlock?(InputContentBlock @this) => @this.ToolUse;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestToolUseBlock? value)
        {
            ToolUse = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestToolResultBlock? ToolResult { get; init; }
#else
        public global::Anthropic.RequestToolResultBlock? ToolResult { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestToolResultBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestToolResultBlock?(InputContentBlock @this) => @this.ToolResult;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestToolResultBlock? value)
        {
            ToolResult = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestDocumentBlock? Document { get; init; }
#else
        public global::Anthropic.RequestDocumentBlock? Document { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestDocumentBlock value) => new InputContentBlock(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestDocumentBlock?(InputContentBlock @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestDocumentBlock? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(
            global::Anthropic.InputContentBlockDiscriminatorType? type,
            global::Anthropic.RequestTextBlock? text,
            global::Anthropic.RequestImageBlock? image,
            global::Anthropic.RequestToolUseBlock? toolUse,
            global::Anthropic.RequestToolResultBlock? toolResult,
            global::Anthropic.RequestDocumentBlock? document
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
            global::System.Func<global::Anthropic.RequestTextBlock?, TResult>? text = null,
            global::System.Func<global::Anthropic.RequestImageBlock?, TResult>? image = null,
            global::System.Func<global::Anthropic.RequestToolUseBlock?, TResult>? toolUse = null,
            global::System.Func<global::Anthropic.RequestToolResultBlock?, TResult>? toolResult = null,
            global::System.Func<global::Anthropic.RequestDocumentBlock?, TResult>? document = null,
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
            global::System.Action<global::Anthropic.RequestTextBlock?>? text = null,
            global::System.Action<global::Anthropic.RequestImageBlock?>? image = null,
            global::System.Action<global::Anthropic.RequestToolUseBlock?>? toolUse = null,
            global::System.Action<global::Anthropic.RequestToolResultBlock?>? toolResult = null,
            global::System.Action<global::Anthropic.RequestDocumentBlock?>? document = null,
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
                typeof(global::Anthropic.RequestTextBlock),
                Image,
                typeof(global::Anthropic.RequestImageBlock),
                ToolUse,
                typeof(global::Anthropic.RequestToolUseBlock),
                ToolResult,
                typeof(global::Anthropic.RequestToolResultBlock),
                Document,
                typeof(global::Anthropic.RequestDocumentBlock),
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
        public bool Equals(InputContentBlock other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestTextBlock?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestImageBlock?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolUseBlock?>.Default.Equals(ToolUse, other.ToolUse) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestToolResultBlock?>.Default.Equals(ToolResult, other.ToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestDocumentBlock?>.Default.Equals(Document, other.Document) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputContentBlock obj1, InputContentBlock obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputContentBlock>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputContentBlock obj1, InputContentBlock obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputContentBlock o && Equals(o);
        }
    }
}
