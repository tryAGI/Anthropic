#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaResponseToolUseBlockUnion : global::System.IEquatable<BetaResponseToolUseBlockUnion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseBrowserToolUseBlock? ResponseBrowserToolUseBlock { get; init; }
#else
        public global::Anthropic.BetaResponseBrowserToolUseBlock? ResponseBrowserToolUseBlock { get; }
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
            out global::Anthropic.BetaResponseBrowserToolUseBlock? value)
        {
            value = ResponseBrowserToolUseBlock;
            return IsResponseBrowserToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseBrowserToolUseBlock PickResponseBrowserToolUseBlock() => ResponseBrowserToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseBrowserToolUseBlock' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseComputerToolUseBlock? ResponseComputerToolUseBlock { get; init; }
#else
        public global::Anthropic.BetaResponseComputerToolUseBlock? ResponseComputerToolUseBlock { get; }
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
            out global::Anthropic.BetaResponseComputerToolUseBlock? value)
        {
            value = ResponseComputerToolUseBlock;
            return IsResponseComputerToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseComputerToolUseBlock PickResponseComputerToolUseBlock() => ResponseComputerToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseComputerToolUseBlock' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolUseBlock? ResponseToolUseBlock { get; init; }
#else
        public global::Anthropic.BetaResponseToolUseBlock? ResponseToolUseBlock { get; }
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
            out global::Anthropic.BetaResponseToolUseBlock? value)
        {
            value = ResponseToolUseBlock;
            return IsResponseToolUseBlock;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolUseBlock PickResponseToolUseBlock() => ResponseToolUseBlock is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponseToolUseBlock' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseBrowserToolUseBlock value) => new BetaResponseToolUseBlockUnion((global::Anthropic.BetaResponseBrowserToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseBrowserToolUseBlock?(BetaResponseToolUseBlockUnion @this) => @this.ResponseBrowserToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseBrowserToolUseBlock? value)
        {
            ResponseBrowserToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseToolUseBlockUnion FromResponseBrowserToolUseBlock(global::Anthropic.BetaResponseBrowserToolUseBlock? value) => new BetaResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseComputerToolUseBlock value) => new BetaResponseToolUseBlockUnion((global::Anthropic.BetaResponseComputerToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseComputerToolUseBlock?(BetaResponseToolUseBlockUnion @this) => @this.ResponseComputerToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseComputerToolUseBlock? value)
        {
            ResponseComputerToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseToolUseBlockUnion FromResponseComputerToolUseBlock(global::Anthropic.BetaResponseComputerToolUseBlock? value) => new BetaResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseToolUseBlock value) => new BetaResponseToolUseBlockUnion((global::Anthropic.BetaResponseToolUseBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolUseBlock?(BetaResponseToolUseBlockUnion @this) => @this.ResponseToolUseBlock;

        /// <summary>
        ///
        /// </summary>
        public BetaResponseToolUseBlockUnion(global::Anthropic.BetaResponseToolUseBlock? value)
        {
            ResponseToolUseBlock = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaResponseToolUseBlockUnion FromResponseToolUseBlock(global::Anthropic.BetaResponseToolUseBlock? value) => new BetaResponseToolUseBlockUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaResponseToolUseBlockUnion(
            global::Anthropic.BetaResponseBrowserToolUseBlock? responseBrowserToolUseBlock,
            global::Anthropic.BetaResponseComputerToolUseBlock? responseComputerToolUseBlock,
            global::Anthropic.BetaResponseToolUseBlock? responseToolUseBlock
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
            global::System.Func<global::Anthropic.BetaResponseBrowserToolUseBlock?, TResult>? responseBrowserToolUseBlock = null,
            global::System.Func<global::Anthropic.BetaResponseComputerToolUseBlock?, TResult>? responseComputerToolUseBlock = null,
            global::System.Func<global::Anthropic.BetaResponseToolUseBlock, TResult>? responseToolUseBlock = null,
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
            global::System.Action<global::Anthropic.BetaResponseBrowserToolUseBlock?>? responseBrowserToolUseBlock = null,

            global::System.Action<global::Anthropic.BetaResponseComputerToolUseBlock?>? responseComputerToolUseBlock = null,

            global::System.Action<global::Anthropic.BetaResponseToolUseBlock>? responseToolUseBlock = null,
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
            global::System.Action<global::Anthropic.BetaResponseBrowserToolUseBlock?>? responseBrowserToolUseBlock = null,
            global::System.Action<global::Anthropic.BetaResponseComputerToolUseBlock?>? responseComputerToolUseBlock = null,
            global::System.Action<global::Anthropic.BetaResponseToolUseBlock>? responseToolUseBlock = null,
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
                typeof(global::Anthropic.BetaResponseBrowserToolUseBlock),
                ResponseComputerToolUseBlock,
                typeof(global::Anthropic.BetaResponseComputerToolUseBlock),
                ResponseToolUseBlock,
                typeof(global::Anthropic.BetaResponseToolUseBlock),
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
        public bool Equals(BetaResponseToolUseBlockUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseBrowserToolUseBlock?>.Default.Equals(ResponseBrowserToolUseBlock, other.ResponseBrowserToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseComputerToolUseBlock?>.Default.Equals(ResponseComputerToolUseBlock, other.ResponseComputerToolUseBlock) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolUseBlock?>.Default.Equals(ResponseToolUseBlock, other.ResponseToolUseBlock)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaResponseToolUseBlockUnion obj1, BetaResponseToolUseBlockUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaResponseToolUseBlockUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaResponseToolUseBlockUnion obj1, BetaResponseToolUseBlockUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaResponseToolUseBlockUnion o && Equals(o);
        }
    }
}
