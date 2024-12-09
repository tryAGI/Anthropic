#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
    /// </summary>
    public readonly partial struct ToolChoice : global::System.IEquatable<ToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.ToolChoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// The model will automatically decide whether to use tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolChoiceAuto? Auto { get; init; }
#else
        public global::Anthropic.ToolChoiceAuto? Auto { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Auto))]
#endif
        public bool IsAuto => Auto != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::Anthropic.ToolChoiceAuto value) => new ToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolChoiceAuto?(ToolChoice @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::Anthropic.ToolChoiceAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        /// The model will use any available tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolChoiceAny? Any { get; init; }
#else
        public global::Anthropic.ToolChoiceAny? Any { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Any))]
#endif
        public bool IsAny => Any != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::Anthropic.ToolChoiceAny value) => new ToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolChoiceAny?(ToolChoice @this) => @this.Any;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::Anthropic.ToolChoiceAny? value)
        {
            Any = value;
        }

        /// <summary>
        /// The model will use the specified tool with `tool_choice.name`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ToolChoiceTool? Tool { get; init; }
#else
        public global::Anthropic.ToolChoiceTool? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolChoice(global::Anthropic.ToolChoiceTool value) => new ToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.ToolChoiceTool?(ToolChoice @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(global::Anthropic.ToolChoiceTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolChoice(
            global::Anthropic.ToolChoiceDiscriminatorType? type,
            global::Anthropic.ToolChoiceAuto? auto,
            global::Anthropic.ToolChoiceAny? any,
            global::Anthropic.ToolChoiceTool? tool
            )
        {
            Type = type;

            Auto = auto;
            Any = any;
            Tool = tool;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Tool as object ??
            Any as object ??
            Auto as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAuto && !IsAny && !IsTool || !IsAuto && IsAny && !IsTool || !IsAuto && !IsAny && IsTool;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.ToolChoiceAuto?, TResult>? auto = null,
            global::System.Func<global::Anthropic.ToolChoiceAny?, TResult>? any = null,
            global::System.Func<global::Anthropic.ToolChoiceTool?, TResult>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto && auto != null)
            {
                return auto(Auto!);
            }
            else if (IsAny && any != null)
            {
                return any(Any!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ToolChoiceAuto?>? auto = null,
            global::System.Action<global::Anthropic.ToolChoiceAny?>? any = null,
            global::System.Action<global::Anthropic.ToolChoiceTool?>? tool = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAuto)
            {
                auto?.Invoke(Auto!);
            }
            else if (IsAny)
            {
                any?.Invoke(Any!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Auto,
                typeof(global::Anthropic.ToolChoiceAuto),
                Any,
                typeof(global::Anthropic.ToolChoiceAny),
                Tool,
                typeof(global::Anthropic.ToolChoiceTool),
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
        public bool Equals(ToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolChoiceAuto?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolChoiceAny?>.Default.Equals(Any, other.Any) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ToolChoiceTool?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolChoice obj1, ToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolChoice obj1, ToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolChoice o && Equals(o);
        }
    }
}
