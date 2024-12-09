#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// How the model should use the provided tools. The model can use a specific tool, any available tool, or decide by itself.
    /// </summary>
    public readonly partial struct BetaToolChoice : global::System.IEquatable<BetaToolChoice>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaToolChoiceDiscriminatorType? Type { get; }

        /// <summary>
        /// The model will automatically decide whether to use tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChoiceAuto? Auto { get; init; }
#else
        public global::Anthropic.BetaToolChoiceAuto? Auto { get; }
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
        public static implicit operator BetaToolChoice(global::Anthropic.BetaToolChoiceAuto value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChoiceAuto?(BetaToolChoice @this) => @this.Auto;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::Anthropic.BetaToolChoiceAuto? value)
        {
            Auto = value;
        }

        /// <summary>
        /// The model will use any available tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChoiceAny? Any { get; init; }
#else
        public global::Anthropic.BetaToolChoiceAny? Any { get; }
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
        public static implicit operator BetaToolChoice(global::Anthropic.BetaToolChoiceAny value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChoiceAny?(BetaToolChoice @this) => @this.Any;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::Anthropic.BetaToolChoiceAny? value)
        {
            Any = value;
        }

        /// <summary>
        /// The model will use the specified tool with `tool_choice.name`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChoiceTool? Tool { get; init; }
#else
        public global::Anthropic.BetaToolChoiceTool? Tool { get; }
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
        public static implicit operator BetaToolChoice(global::Anthropic.BetaToolChoiceTool value) => new BetaToolChoice(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChoiceTool?(BetaToolChoice @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(global::Anthropic.BetaToolChoiceTool? value)
        {
            Tool = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaToolChoice(
            global::Anthropic.BetaToolChoiceDiscriminatorType? type,
            global::Anthropic.BetaToolChoiceAuto? auto,
            global::Anthropic.BetaToolChoiceAny? any,
            global::Anthropic.BetaToolChoiceTool? tool
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
            global::System.Func<global::Anthropic.BetaToolChoiceAuto?, TResult>? auto = null,
            global::System.Func<global::Anthropic.BetaToolChoiceAny?, TResult>? any = null,
            global::System.Func<global::Anthropic.BetaToolChoiceTool?, TResult>? tool = null,
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
            global::System.Action<global::Anthropic.BetaToolChoiceAuto?>? auto = null,
            global::System.Action<global::Anthropic.BetaToolChoiceAny?>? any = null,
            global::System.Action<global::Anthropic.BetaToolChoiceTool?>? tool = null,
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
                typeof(global::Anthropic.BetaToolChoiceAuto),
                Any,
                typeof(global::Anthropic.BetaToolChoiceAny),
                Tool,
                typeof(global::Anthropic.BetaToolChoiceTool),
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
        public bool Equals(BetaToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChoiceAuto?>.Default.Equals(Auto, other.Auto) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChoiceAny?>.Default.Equals(Any, other.Any) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChoiceTool?>.Default.Equals(Tool, other.Tool) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaToolChoice obj1, BetaToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaToolChoice obj1, BetaToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolChoice o && Equals(o);
        }
    }
}
