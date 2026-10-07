#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ResponseToolUseBlockUnion : global::System.IEquatable<ResponseToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseBrowserToolUseBlock? ResponseBrowserToolUseBlock { get; init; }
#else
        public global::Anthropic.ResponseBrowserToolUseBlock? ResponseBrowserToolUseBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseBrowserToolUseBlock))]
#endif
        public bool IsResponseBrowserToolUseBlock => ResponseBrowserToolUseBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseBrowserToolUseBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseBrowserToolUseBlock? value)
        {
            value = ResponseBrowserToolUseBlock;
            return IsResponseBrowserToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseBrowserToolUseBlock PickResponseBrowserToolUseBlock() => ResponseBrowserToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseBrowserToolUseBlock' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseComputerToolUseBlock? ResponseComputerToolUseBlock { get; init; }
#else
        public global::Anthropic.ResponseComputerToolUseBlock? ResponseComputerToolUseBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseComputerToolUseBlock))]
#endif
        public bool IsResponseComputerToolUseBlock => ResponseComputerToolUseBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseComputerToolUseBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseComputerToolUseBlock? value)
        {
            value = ResponseComputerToolUseBlock;
            return IsResponseComputerToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseComputerToolUseBlock PickResponseComputerToolUseBlock() => ResponseComputerToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseComputerToolUseBlock' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ResponseToolUseBlock? ResponseToolUseBlock { get; init; }
#else
        public global::Anthropic.ResponseToolUseBlock? ResponseToolUseBlock { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponseToolUseBlock))]
#endif
        public bool IsResponseToolUseBlock => ResponseToolUseBlock != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickResponseToolUseBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.ResponseToolUseBlock? value)
        {
            value = ResponseToolUseBlock;
            return IsResponseToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ResponseToolUseBlock PickResponseToolUseBlock() => ResponseToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseToolUseBlock' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseToolUseBlockUnion(global::Anthropic.ResponseBrowserToolUseBlock value) => new ResponseToolUseBlockUnion((global::Anthropic.ResponseBrowserToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseBrowserToolUseBlock?(ResponseToolUseBlockUnion @this) => @this.ResponseBrowserToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public ResponseToolUseBlockUnion(global::Anthropic.ResponseBrowserToolUseBlock? value)
        {
            ResponseBrowserToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseToolUseBlockUnion FromResponseBrowserToolUseBlock(global::Anthropic.ResponseBrowserToolUseBlock? value) => new ResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseToolUseBlockUnion(global::Anthropic.ResponseComputerToolUseBlock value) => new ResponseToolUseBlockUnion((global::Anthropic.ResponseComputerToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseComputerToolUseBlock?(ResponseToolUseBlockUnion @this) => @this.ResponseComputerToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public ResponseToolUseBlockUnion(global::Anthropic.ResponseComputerToolUseBlock? value)
        {
            ResponseComputerToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseToolUseBlockUnion FromResponseComputerToolUseBlock(global::Anthropic.ResponseComputerToolUseBlock? value) => new ResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ResponseToolUseBlockUnion(global::Anthropic.ResponseToolUseBlock value) => new ResponseToolUseBlockUnion((global::Anthropic.ResponseToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ResponseToolUseBlock?(ResponseToolUseBlockUnion @this) => @this.ResponseToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public ResponseToolUseBlockUnion(global::Anthropic.ResponseToolUseBlock? value)
        {
            ResponseToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ResponseToolUseBlockUnion FromResponseToolUseBlock(global::Anthropic.ResponseToolUseBlock? value) => new ResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public ResponseToolUseBlockUnion(
            global::Anthropic.ResponseBrowserToolUseBlock? responseBrowserToolUseBlock,
            global::Anthropic.ResponseComputerToolUseBlock? responseComputerToolUseBlock,
            global::Anthropic.ResponseToolUseBlock? responseToolUseBlock
            )
        {
            ResponseBrowserToolUseBlock = responseBrowserToolUseBlock;
            ResponseComputerToolUseBlock = responseComputerToolUseBlock;
            ResponseToolUseBlock = responseToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ResponseToolUseBlock as object ??
            ResponseComputerToolUseBlock as object ??
            ResponseBrowserToolUseBlock as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ResponseBrowserToolUseBlock?.ToString() ??
            ResponseComputerToolUseBlock?.ToString() ??
            ResponseToolUseBlock?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsResponseBrowserToolUseBlock && !IsResponseComputerToolUseBlock && !IsResponseToolUseBlock || !IsResponseBrowserToolUseBlock && IsResponseComputerToolUseBlock && !IsResponseToolUseBlock || !IsResponseBrowserToolUseBlock && !IsResponseComputerToolUseBlock && IsResponseToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ResponseBrowserToolUseBlock?, TResult>? responseBrowserToolUseBlock = null,
            global::System.Func<global::Anthropic.ResponseComputerToolUseBlock?, TResult>? responseComputerToolUseBlock = null,
            global::System.Func<global::Anthropic.ResponseToolUseBlock, TResult>? responseToolUseBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseBrowserToolUseBlock is { } __value0 && responseBrowserToolUseBlock != null)
            {
                return responseBrowserToolUseBlock(__value0);
            }
            else if (ResponseComputerToolUseBlock is { } __value1 && responseComputerToolUseBlock != null)
            {
                return responseComputerToolUseBlock(__value1);
            }
            else if (ResponseToolUseBlock is { } __value2 && responseToolUseBlock != null)
            {
                return responseToolUseBlock(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ResponseBrowserToolUseBlock?>? responseBrowserToolUseBlock = null,

            global::System.Action<global::Anthropic.ResponseComputerToolUseBlock?>? responseComputerToolUseBlock = null,

            global::System.Action<global::Anthropic.ResponseToolUseBlock>? responseToolUseBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseBrowserToolUseBlock is { } __value0)
            {
                responseBrowserToolUseBlock?.Invoke(__value0);
            }
            else if (ResponseComputerToolUseBlock is { } __value1)
            {
                responseComputerToolUseBlock?.Invoke(__value1);
            }
            else if (ResponseToolUseBlock is { } __value2)
            {
                responseToolUseBlock?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.ResponseBrowserToolUseBlock?>? responseBrowserToolUseBlock = null,
            global::System.Action<global::Anthropic.ResponseComputerToolUseBlock?>? responseComputerToolUseBlock = null,
            global::System.Action<global::Anthropic.ResponseToolUseBlock>? responseToolUseBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ResponseBrowserToolUseBlock is { } __value0)
            {
                responseBrowserToolUseBlock?.Invoke(__value0);
            }
            else if (ResponseComputerToolUseBlock is { } __value1)
            {
                responseComputerToolUseBlock?.Invoke(__value1);
            }
            else if (ResponseToolUseBlock is { } __value2)
            {
                responseToolUseBlock?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponseBrowserToolUseBlock,
                typeof(global::Anthropic.ResponseBrowserToolUseBlock),
                ResponseComputerToolUseBlock,
                typeof(global::Anthropic.ResponseComputerToolUseBlock),
                ResponseToolUseBlock,
                typeof(global::Anthropic.ResponseToolUseBlock),
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
        public bool Equals(ResponseToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseBrowserToolUseBlock?>.Default.Equals(ResponseBrowserToolUseBlock, other.ResponseBrowserToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseComputerToolUseBlock?>.Default.Equals(ResponseComputerToolUseBlock, other.ResponseComputerToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ResponseToolUseBlock?>.Default.Equals(ResponseToolUseBlock, other.ResponseToolUseBlock)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ResponseToolUseBlockUnion obj1, ResponseToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponseToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ResponseToolUseBlockUnion obj1, ResponseToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponseToolUseBlockUnion o && Equals(o);
        }
    }
}
