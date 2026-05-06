#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric for grading the quality of an outcome.
    /// </summary>
    public readonly partial struct BetaManagedAgentsRubricParams : global::System.IEquatable<BetaManagedAgentsRubricParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Rubric referenced by a file uploaded via the Files API.<br/>
        /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileRubricParams? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileRubricParams? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// Rubric content provided inline as text.<br/>
        /// Example: {"type":"text","content":"Must cover all five sections; cite sources inline."}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Text { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTextRubricParams? Text { get; }
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
        public static implicit operator BetaManagedAgentsRubricParams(global::Anthropic.BetaManagedAgentsFileRubricParams value) => new BetaManagedAgentsRubricParams((global::Anthropic.BetaManagedAgentsFileRubricParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileRubricParams?(BetaManagedAgentsRubricParams @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubricParams(global::Anthropic.BetaManagedAgentsFileRubricParams? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRubricParams(global::Anthropic.BetaManagedAgentsTextRubricParams value) => new BetaManagedAgentsRubricParams((global::Anthropic.BetaManagedAgentsTextRubricParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTextRubricParams?(BetaManagedAgentsRubricParams @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubricParams(global::Anthropic.BetaManagedAgentsTextRubricParams? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubricParams(
            global::Anthropic.BetaManagedAgentsRubricParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsFileRubricParams? file,
            global::Anthropic.BetaManagedAgentsTextRubricParams? text
            )
        {
            Type = type;

            File = file;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            File as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            File?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFile && !IsText || !IsFile && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsFileRubricParams?, TResult>? file = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTextRubricParams?, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsFileRubricParams?>? file = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTextRubricParams?>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsText)
            {
                text?.Invoke(Text!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileRubricParams),
                Text,
                typeof(global::Anthropic.BetaManagedAgentsTextRubricParams),
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
        public bool Equals(BetaManagedAgentsRubricParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileRubricParams?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTextRubricParams?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsRubricParams obj1, BetaManagedAgentsRubricParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsRubricParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsRubricParams obj1, BetaManagedAgentsRubricParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsRubricParams o && Equals(o);
        }
    }
}
