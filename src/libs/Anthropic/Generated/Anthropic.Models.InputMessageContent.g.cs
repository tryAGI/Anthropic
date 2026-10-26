#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputMessageContent : global::System.IEquatable<InputMessageContent>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InputMessageContentVariant1 { get; init; }
#else
        public string? InputMessageContentVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageContentVariant1))]
#endif
        public bool IsInputMessageContentVariant1 => InputMessageContentVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputMessageContentVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InputMessageContentVariant1;
            return IsInputMessageContentVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickInputMessageContentVariant1() => InputMessageContentVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessageContentVariant1' but the value was {ToString()}.");

        /// <summary>
        /// Example: [{"text":"What is a quaternion?","type":"text"}]
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? InputMessageContentVariant2 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? InputMessageContentVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputMessageContentVariant2))]
#endif
        public bool IsInputMessageContentVariant2 => InputMessageContentVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputMessageContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? value)
        {
            value = InputMessageContentVariant2;
            return IsInputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock> PickInputMessageContentVariant2() => InputMessageContentVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputMessageContentVariant2' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputMessageContent(string value) => new InputMessageContent((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(InputMessageContent @this) => @this.InputMessageContentVariant1;

        /// <summary>
        ///
        /// </summary>
        public InputMessageContent(string? value)
        {
            InputMessageContentVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputMessageContent FromInputMessageContentVariant1(string? value) => new InputMessageContent(value);

        /// <summary>
        ///
        /// </summary>
        public InputMessageContent(
            string? inputMessageContentVariant1,
            global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>? inputMessageContentVariant2
            )
        {
            InputMessageContentVariant1 = inputMessageContentVariant1;
            InputMessageContentVariant2 = inputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputMessageContentVariant2 as object ??
            InputMessageContentVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputMessageContentVariant1?.ToString() ??
            InputMessageContentVariant2?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputMessageContentVariant1 || IsInputMessageContentVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? inputMessageContentVariant1 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>, TResult>? inputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputMessageContentVariant1 is { } __value0 && inputMessageContentVariant1 != null)
            {
                return inputMessageContentVariant1(__value0);
            }
            else if (InputMessageContentVariant2 is { } __value1 && inputMessageContentVariant2 != null)
            {
                return inputMessageContentVariant2(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? inputMessageContentVariant1 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>? inputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputMessageContentVariant1 is { } __value0)
            {
                inputMessageContentVariant1?.Invoke(__value0);
            }
            else if (InputMessageContentVariant2 is { } __value1)
            {
                inputMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? inputMessageContentVariant1 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>>? inputMessageContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputMessageContentVariant1 is { } __value0)
            {
                inputMessageContentVariant1?.Invoke(__value0);
            }
            else if (InputMessageContentVariant2 is { } __value1)
            {
                inputMessageContentVariant2?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputMessageContentVariant1,
                typeof(string),
                InputMessageContentVariant2,
                typeof(global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>),
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
        public bool Equals(InputMessageContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputMessageContentVariant1, other.InputMessageContentVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::Anthropic.InputContentBlock>?>.Default.Equals(InputMessageContentVariant2, other.InputMessageContentVariant2)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputMessageContent obj1, InputMessageContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputMessageContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputMessageContent obj1, InputMessageContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputMessageContent o && Equals(o);
        }
    }
}
