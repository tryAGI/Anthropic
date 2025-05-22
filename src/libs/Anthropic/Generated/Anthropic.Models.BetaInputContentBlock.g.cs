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
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestServerToolUseBlock? Value1 { get; init; }
#else
        public global::Anthropic.BetaRequestServerToolUseBlock? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestServerToolUseBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestServerToolUseBlock?(BetaInputContentBlock @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestServerToolUseBlock? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Value2 { get; init; }
#else
        public global::Anthropic.BetaRequestWebSearchToolResultBlock? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestWebSearchToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestWebSearchToolResultBlock?(BetaInputContentBlock @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestWebSearchToolResultBlock? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Value3 { get; init; }
#else
        public global::Anthropic.BetaRequestCodeExecutionToolResultBlock? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestCodeExecutionToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestCodeExecutionToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestCodeExecutionToolResultBlock?(BetaInputContentBlock @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestMCPToolUseBlock? Value4 { get; init; }
#else
        public global::Anthropic.BetaRequestMCPToolUseBlock? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolUseBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestMCPToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestMCPToolUseBlock?(BetaInputContentBlock @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolUseBlock? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestMCPToolResultBlock? Value5 { get; init; }
#else
        public global::Anthropic.BetaRequestMCPToolResultBlock? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolResultBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestMCPToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestMCPToolResultBlock?(BetaInputContentBlock @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestMCPToolResultBlock? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// Regular text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>? Value6 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>? Value6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value6))]
#endif
        public bool IsValue6 => Value6 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>?(BetaInputContentBlock @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Image content specified directly as base64 data or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>? Value7 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>? Value7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value7))]
#endif
        public bool IsValue7 => Value7 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>?(BetaInputContentBlock @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// A block indicating a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>? Value8 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>? Value8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value8))]
#endif
        public bool IsValue8 => Value8 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>?(BetaInputContentBlock @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// A block specifying the results of a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>? Value9 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>? Value9 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value9))]
#endif
        public bool IsValue9 => Value9 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>?(BetaInputContentBlock @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>? Value10 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>? Value10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value10))]
#endif
        public bool IsValue10 => Value10 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>?(BetaInputContentBlock @this) => @this.Value10;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>? value)
        {
            Value10 = value;
        }

        /// <summary>
        /// A block specifying internal thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>? Value11 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>? Value11 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value11))]
#endif
        public bool IsValue11 => Value11 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>?(BetaInputContentBlock @this) => @this.Value11;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>? value)
        {
            Value11 = value;
        }

        /// <summary>
        /// A block specifying internal, redacted thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>? Value12 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>? Value12 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value12))]
#endif
        public bool IsValue12 => Value12 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock> value) => new BetaInputContentBlock((global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>?(BetaInputContentBlock @this) => @this.Value12;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>? value)
        {
            Value12 = value;
        }

        /// <summary>
        /// A content block that represents a file to be uploaded to the container<br/>
        /// Files uploaded via this block will be available in the container's input directory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaRequestContainerUploadBlock? Value13 { get; init; }
#else
        public global::Anthropic.BetaRequestContainerUploadBlock? Value13 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value13))]
#endif
        public bool IsValue13 => Value13 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaInputContentBlock(global::Anthropic.BetaRequestContainerUploadBlock value) => new BetaInputContentBlock((global::Anthropic.BetaRequestContainerUploadBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaRequestContainerUploadBlock?(BetaInputContentBlock @this) => @this.Value13;

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(global::Anthropic.BetaRequestContainerUploadBlock? value)
        {
            Value13 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaInputContentBlock(
            global::Anthropic.BetaRequestServerToolUseBlock? value1,
            global::Anthropic.BetaRequestWebSearchToolResultBlock? value2,
            global::Anthropic.BetaRequestCodeExecutionToolResultBlock? value3,
            global::Anthropic.BetaRequestMCPToolUseBlock? value4,
            global::Anthropic.BetaRequestMCPToolResultBlock? value5,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>? value6,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>? value7,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>? value8,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>? value9,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>? value10,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>? value11,
            global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>? value12,
            global::Anthropic.BetaRequestContainerUploadBlock? value13
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
            Value6 = value6;
            Value7 = value7;
            Value8 = value8;
            Value9 = value9;
            Value10 = value10;
            Value11 = value11;
            Value12 = value12;
            Value13 = value13;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value13 as object ??
            Value12 as object ??
            Value11 as object ??
            Value10 as object ??
            Value9 as object ??
            Value8 as object ??
            Value7 as object ??
            Value6 as object ??
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToString() ??
            Value2?.ToString() ??
            Value3?.ToString() ??
            Value4?.ToString() ??
            Value5?.ToString() ??
            Value6?.ToString() ??
            Value7?.ToString() ??
            Value8?.ToString() ??
            Value9?.ToString() ??
            Value10?.ToString() ??
            Value11?.ToString() ??
            Value12?.ToString() ??
            Value13?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && IsValue10 && !IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && IsValue11 && !IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && IsValue12 && !IsValue13 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 && !IsValue10 && !IsValue11 && !IsValue12 && IsValue13;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaRequestServerToolUseBlock?, TResult>? value1 = null,
            global::System.Func<global::Anthropic.BetaRequestWebSearchToolResultBlock?, TResult>? value2 = null,
            global::System.Func<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?, TResult>? value3 = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolUseBlock?, TResult>? value4 = null,
            global::System.Func<global::Anthropic.BetaRequestMCPToolResultBlock?, TResult>? value5 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>?, TResult>? value6 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>?, TResult>? value7 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>?, TResult>? value8 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>?, TResult>? value9 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>?, TResult>? value10 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>?, TResult>? value11 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>?, TResult>? value12 = null,
            global::System.Func<global::Anthropic.BetaRequestContainerUploadBlock?, TResult>? value13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }
            else if (IsValue6 && value6 != null)
            {
                return value6(Value6!);
            }
            else if (IsValue7 && value7 != null)
            {
                return value7(Value7!);
            }
            else if (IsValue8 && value8 != null)
            {
                return value8(Value8!);
            }
            else if (IsValue9 && value9 != null)
            {
                return value9(Value9!);
            }
            else if (IsValue10 && value10 != null)
            {
                return value10(Value10!);
            }
            else if (IsValue11 && value11 != null)
            {
                return value11(Value11!);
            }
            else if (IsValue12 && value12 != null)
            {
                return value12(Value12!);
            }
            else if (IsValue13 && value13 != null)
            {
                return value13(Value13!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaRequestServerToolUseBlock?>? value1 = null,
            global::System.Action<global::Anthropic.BetaRequestWebSearchToolResultBlock?>? value2 = null,
            global::System.Action<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?>? value3 = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolUseBlock?>? value4 = null,
            global::System.Action<global::Anthropic.BetaRequestMCPToolResultBlock?>? value5 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>?>? value6 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>?>? value7 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>?>? value8 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>?>? value9 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>?>? value10 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>?>? value11 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>?>? value12 = null,
            global::System.Action<global::Anthropic.BetaRequestContainerUploadBlock?>? value13 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
            else if (IsValue6)
            {
                value6?.Invoke(Value6!);
            }
            else if (IsValue7)
            {
                value7?.Invoke(Value7!);
            }
            else if (IsValue8)
            {
                value8?.Invoke(Value8!);
            }
            else if (IsValue9)
            {
                value9?.Invoke(Value9!);
            }
            else if (IsValue10)
            {
                value10?.Invoke(Value10!);
            }
            else if (IsValue11)
            {
                value11?.Invoke(Value11!);
            }
            else if (IsValue12)
            {
                value12?.Invoke(Value12!);
            }
            else if (IsValue13)
            {
                value13?.Invoke(Value13!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Anthropic.BetaRequestServerToolUseBlock),
                Value2,
                typeof(global::Anthropic.BetaRequestWebSearchToolResultBlock),
                Value3,
                typeof(global::Anthropic.BetaRequestCodeExecutionToolResultBlock),
                Value4,
                typeof(global::Anthropic.BetaRequestMCPToolUseBlock),
                Value5,
                typeof(global::Anthropic.BetaRequestMCPToolResultBlock),
                Value6,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>),
                Value7,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>),
                Value8,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>),
                Value9,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>),
                Value10,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>),
                Value11,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>),
                Value12,
                typeof(global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>),
                Value13,
                typeof(global::Anthropic.BetaRequestContainerUploadBlock),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestServerToolUseBlock?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestWebSearchToolResultBlock?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestCodeExecutionToolResultBlock?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolUseBlock?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestMCPToolResultBlock?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestTextBlock>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestImageBlock>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolUseBlock>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestToolResultBlock>?>.Default.Equals(Value9, other.Value9) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestDocumentBlock>?>.Default.Equals(Value10, other.Value10) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestThinkingBlock>?>.Default.Equals(Value11, other.Value11) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.BetaRequestRedactedThinkingBlock>?>.Default.Equals(Value12, other.Value12) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaRequestContainerUploadBlock?>.Default.Equals(Value13, other.Value13) 
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
