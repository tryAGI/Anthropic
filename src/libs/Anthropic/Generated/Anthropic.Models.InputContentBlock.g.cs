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
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestServerToolUseBlock? Value1 { get; init; }
#else
        public global::Anthropic.RequestServerToolUseBlock? Value1 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestServerToolUseBlock value) => new InputContentBlock((global::Anthropic.RequestServerToolUseBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestServerToolUseBlock?(InputContentBlock @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestServerToolUseBlock? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.RequestWebSearchToolResultBlock? Value2 { get; init; }
#else
        public global::Anthropic.RequestWebSearchToolResultBlock? Value2 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.RequestWebSearchToolResultBlock value) => new InputContentBlock((global::Anthropic.RequestWebSearchToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.RequestWebSearchToolResultBlock?(InputContentBlock @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.RequestWebSearchToolResultBlock? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// Regular text content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>? Value3 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>? Value3 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>?(InputContentBlock @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// Image content specified directly as base64 data or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>? Value4 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>? Value4 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>?(InputContentBlock @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// A block indicating a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>? Value5 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>? Value5 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>?(InputContentBlock @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// A block specifying the results of a tool use by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>? Value6 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>? Value6 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>?(InputContentBlock @this) => @this.Value6;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>? value)
        {
            Value6 = value;
        }

        /// <summary>
        /// Document content, either specified directly as base64 data, as text, or as a reference via a URL.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>? Value7 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>? Value7 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>?(InputContentBlock @this) => @this.Value7;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>? value)
        {
            Value7 = value;
        }

        /// <summary>
        /// A block specifying internal thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>? Value8 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>? Value8 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>?(InputContentBlock @this) => @this.Value8;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>? value)
        {
            Value8 = value;
        }

        /// <summary>
        /// A block specifying internal, redacted thinking by the model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>? Value9 { get; init; }
#else
        public global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>? Value9 { get; }
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
        public static implicit operator InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock> value) => new InputContentBlock((global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>?(InputContentBlock @this) => @this.Value9;

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>? value)
        {
            Value9 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public InputContentBlock(
            global::Anthropic.RequestServerToolUseBlock? value1,
            global::Anthropic.RequestWebSearchToolResultBlock? value2,
            global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>? value3,
            global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>? value4,
            global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>? value5,
            global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>? value6,
            global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>? value7,
            global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>? value8,
            global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>? value9
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
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
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
            Value9?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && IsValue6 && !IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && IsValue7 && !IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && IsValue8 && !IsValue9 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 && !IsValue6 && !IsValue7 && !IsValue8 && IsValue9;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.RequestServerToolUseBlock?, TResult>? value1 = null,
            global::System.Func<global::Anthropic.RequestWebSearchToolResultBlock?, TResult>? value2 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>?, TResult>? value3 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>?, TResult>? value4 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>?, TResult>? value5 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>?, TResult>? value6 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>?, TResult>? value7 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>?, TResult>? value8 = null,
            global::System.Func<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>?, TResult>? value9 = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.RequestServerToolUseBlock?>? value1 = null,
            global::System.Action<global::Anthropic.RequestWebSearchToolResultBlock?>? value2 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>?>? value3 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>?>? value4 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>?>? value5 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>?>? value6 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>?>? value7 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>?>? value8 = null,
            global::System.Action<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>?>? value9 = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::Anthropic.RequestServerToolUseBlock),
                Value2,
                typeof(global::Anthropic.RequestWebSearchToolResultBlock),
                Value3,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>),
                Value4,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>),
                Value5,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>),
                Value6,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>),
                Value7,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>),
                Value8,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>),
                Value9,
                typeof(global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestServerToolUseBlock?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.RequestWebSearchToolResultBlock?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestTextBlock>?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestImageBlock>?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestToolUseBlock>?>.Default.Equals(Value5, other.Value5) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestToolResultBlock>?>.Default.Equals(Value6, other.Value6) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestDocumentBlock>?>.Default.Equals(Value7, other.Value7) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestThinkingBlock>?>.Default.Equals(Value8, other.Value8) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AllOf<global::Anthropic.RequestRedactedThinkingBlock>?>.Default.Equals(Value9, other.Value9) 
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
