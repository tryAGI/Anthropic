#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem2 : global::System.IEquatable<ToolsItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCreateMessageParamsToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTool? Custom { get; init; }
#else
        public global::Anthropic.BetaTool? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::Anthropic.BetaTool value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaTool?(ToolsItem2 @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::Anthropic.BetaTool? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerUseTool20241022? Computer20241022 { get; init; }
#else
        public global::Anthropic.BetaComputerUseTool20241022? Computer20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer20241022))]
#endif
        public bool IsComputer20241022 => Computer20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::Anthropic.BetaComputerUseTool20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20241022?(ToolsItem2 @this) => @this.Computer20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::Anthropic.BetaComputerUseTool20241022? value)
        {
            Computer20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBashTool20241022? Bash20241022 { get; init; }
#else
        public global::Anthropic.BetaBashTool20241022? Bash20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash20241022))]
#endif
        public bool IsBash20241022 => Bash20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::Anthropic.BetaBashTool20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBashTool20241022?(ToolsItem2 @this) => @this.Bash20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::Anthropic.BetaBashTool20241022? value)
        {
            Bash20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextEditor20241022? TextEditor20241022 { get; init; }
#else
        public global::Anthropic.BetaTextEditor20241022? TextEditor20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20241022))]
#endif
        public bool IsTextEditor20241022 => TextEditor20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem2(global::Anthropic.BetaTextEditor20241022 value) => new ToolsItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20241022?(ToolsItem2 @this) => @this.TextEditor20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(global::Anthropic.BetaTextEditor20241022? value)
        {
            TextEditor20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem2(
            global::Anthropic.BetaCreateMessageParamsToolDiscriminatorType? type,
            global::Anthropic.BetaTool? custom,
            global::Anthropic.BetaComputerUseTool20241022? computer20241022,
            global::Anthropic.BetaBashTool20241022? bash20241022,
            global::Anthropic.BetaTextEditor20241022? textEditor20241022
            )
        {
            Type = type;

            Custom = custom;
            Computer20241022 = computer20241022;
            Bash20241022 = bash20241022;
            TextEditor20241022 = textEditor20241022;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextEditor20241022 as object ??
            Bash20241022 as object ??
            Computer20241022 as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 || !IsCustom && IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 || !IsCustom && !IsComputer20241022 && IsBash20241022 && !IsTextEditor20241022 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && IsTextEditor20241022;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTool?, TResult>? custom = null,
            global::System.Func<global::Anthropic.BetaComputerUseTool20241022?, TResult>? computer20241022 = null,
            global::System.Func<global::Anthropic.BetaBashTool20241022?, TResult>? bash20241022 = null,
            global::System.Func<global::Anthropic.BetaTextEditor20241022?, TResult>? textEditor20241022 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsComputer20241022 && computer20241022 != null)
            {
                return computer20241022(Computer20241022!);
            }
            else if (IsBash20241022 && bash20241022 != null)
            {
                return bash20241022(Bash20241022!);
            }
            else if (IsTextEditor20241022 && textEditor20241022 != null)
            {
                return textEditor20241022(TextEditor20241022!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTool?>? custom = null,
            global::System.Action<global::Anthropic.BetaComputerUseTool20241022?>? computer20241022 = null,
            global::System.Action<global::Anthropic.BetaBashTool20241022?>? bash20241022 = null,
            global::System.Action<global::Anthropic.BetaTextEditor20241022?>? textEditor20241022 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsComputer20241022)
            {
                computer20241022?.Invoke(Computer20241022!);
            }
            else if (IsBash20241022)
            {
                bash20241022?.Invoke(Bash20241022!);
            }
            else if (IsTextEditor20241022)
            {
                textEditor20241022?.Invoke(TextEditor20241022!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::Anthropic.BetaTool),
                Computer20241022,
                typeof(global::Anthropic.BetaComputerUseTool20241022),
                Bash20241022,
                typeof(global::Anthropic.BetaBashTool20241022),
                TextEditor20241022,
                typeof(global::Anthropic.BetaTextEditor20241022),
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
        public bool Equals(ToolsItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20241022?>.Default.Equals(Computer20241022, other.Computer20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBashTool20241022?>.Default.Equals(Bash20241022, other.Bash20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20241022?>.Default.Equals(TextEditor20241022, other.TextEditor20241022) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem2 obj1, ToolsItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem2 o && Equals(o);
        }
    }
}
