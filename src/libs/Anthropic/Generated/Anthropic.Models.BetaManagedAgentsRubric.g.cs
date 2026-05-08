#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Rubric for grading the quality of an outcome.
    /// </summary>
    public readonly partial struct BetaManagedAgentsRubric : global::System.IEquatable<BetaManagedAgentsRubric>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? Type { get; }

        /// <summary>
        /// Rubric referenced by a file uploaded via the Files API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileRubric? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileRubric? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsFileRubric? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        /// Rubric content provided inline as text.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTextRubric? Text { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTextRubric? Text { get; }
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsTextRubric? value)
        {
            value = Text;
            return IsText;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRubric(global::Anthropic.BetaManagedAgentsFileRubric value) => new BetaManagedAgentsRubric((global::Anthropic.BetaManagedAgentsFileRubric?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileRubric?(BetaManagedAgentsRubric @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubric(global::Anthropic.BetaManagedAgentsFileRubric? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsRubric(global::Anthropic.BetaManagedAgentsTextRubric value) => new BetaManagedAgentsRubric((global::Anthropic.BetaManagedAgentsTextRubric?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTextRubric?(BetaManagedAgentsRubric @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubric(global::Anthropic.BetaManagedAgentsTextRubric? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsRubric(
            global::Anthropic.BetaManagedAgentsRubricDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsFileRubric? file,
            global::Anthropic.BetaManagedAgentsTextRubric? text
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
            global::System.Func<global::Anthropic.BetaManagedAgentsFileRubric, TResult>? file = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTextRubric, TResult>? text = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsFileRubric>? file = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsTextRubric>? text = null,
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
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsFileRubric>? file = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTextRubric>? text = null,
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
                typeof(global::Anthropic.BetaManagedAgentsFileRubric),
                Text,
                typeof(global::Anthropic.BetaManagedAgentsTextRubric),
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
        public bool Equals(BetaManagedAgentsRubric other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileRubric?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTextRubric?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsRubric obj1, BetaManagedAgentsRubric obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsRubric>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsRubric obj1, BetaManagedAgentsRubric obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsRubric o && Equals(o);
        }
    }
}
