#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The policy category that triggered a refusal.
    /// </summary>
    public readonly partial struct RefusalCategory : global::System.IEquatable<RefusalCategory>
    {
        /// <summary>
        /// The request could enable cyber harm, such as malware or exploit development. Benign cybersecurity work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RefusalCategoryVariant1 { get; init; }
#else
        public string? RefusalCategoryVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalCategoryVariant1))]
#endif
        public bool IsRefusalCategoryVariant1 => RefusalCategoryVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalCategoryVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RefusalCategoryVariant1;
            return IsRefusalCategoryVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickRefusalCategoryVariant1() => RefusalCategoryVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalCategoryVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The request could enable biological harm, such as dangerous lab methods. Beneficial life sciences work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RefusalCategoryVariant2 { get; init; }
#else
        public string? RefusalCategoryVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalCategoryVariant2))]
#endif
        public bool IsRefusalCategoryVariant2 => RefusalCategoryVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalCategoryVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RefusalCategoryVariant2;
            return IsRefusalCategoryVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickRefusalCategoryVariant2() => RefusalCategoryVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalCategoryVariant2' but the value was {ToString()}.");

        /// <summary>
        /// The request could assist the development of competing AI models, which is restricted under [Anthropic's commercial terms](https://www.anthropic.com/legal/commercial-terms). Benign machine learning work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RefusalCategoryVariant3 { get; init; }
#else
        public string? RefusalCategoryVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalCategoryVariant3))]
#endif
        public bool IsRefusalCategoryVariant3 => RefusalCategoryVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalCategoryVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RefusalCategoryVariant3;
            return IsRefusalCategoryVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickRefusalCategoryVariant3() => RefusalCategoryVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalCategoryVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The request asks the model to reproduce its internal reasoning in the response text. To get reasoning in a structured form instead, use [adaptive thinking](https://platform.claude.com/docs/en/build-with-claude/adaptive-thinking).
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RefusalCategoryVariant4 { get; init; }
#else
        public string? RefusalCategoryVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalCategoryVariant4))]
#endif
        public bool IsRefusalCategoryVariant4 => RefusalCategoryVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalCategoryVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RefusalCategoryVariant4;
            return IsRefusalCategoryVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickRefusalCategoryVariant4() => RefusalCategoryVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalCategoryVariant4' but the value was {ToString()}.");

        /// <summary>
        /// The request could be related to an area that was determined as harmful. Benign work might sometimes trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? RefusalCategoryVariant5 { get; init; }
#else
        public string? RefusalCategoryVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(RefusalCategoryVariant5))]
#endif
        public bool IsRefusalCategoryVariant5 => RefusalCategoryVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRefusalCategoryVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = RefusalCategoryVariant5;
            return IsRefusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickRefusalCategoryVariant5() => RefusalCategoryVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'RefusalCategoryVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator RefusalCategory(string value) => new RefusalCategory((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(RefusalCategory @this) => @this.RefusalCategoryVariant1;

        /// <summary>
        ///
        /// </summary>
        public RefusalCategory(string? value)
        {
            RefusalCategoryVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static RefusalCategory FromRefusalCategoryVariant1(string? value) => new RefusalCategory(value);

        /// <summary>
        ///
        /// </summary>
        public RefusalCategory(
            string? refusalCategoryVariant1,
            string? refusalCategoryVariant2,
            string? refusalCategoryVariant3,
            string? refusalCategoryVariant4,
            string? refusalCategoryVariant5
            )
        {
            RefusalCategoryVariant1 = refusalCategoryVariant1;
            RefusalCategoryVariant2 = refusalCategoryVariant2;
            RefusalCategoryVariant3 = refusalCategoryVariant3;
            RefusalCategoryVariant4 = refusalCategoryVariant4;
            RefusalCategoryVariant5 = refusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            RefusalCategoryVariant5 as object ??
            RefusalCategoryVariant4 as object ??
            RefusalCategoryVariant3 as object ??
            RefusalCategoryVariant2 as object ??
            RefusalCategoryVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            RefusalCategoryVariant1?.ToString() ??
            RefusalCategoryVariant2?.ToString() ??
            RefusalCategoryVariant3?.ToString() ??
            RefusalCategoryVariant4?.ToString() ??
            RefusalCategoryVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsRefusalCategoryVariant1 || IsRefusalCategoryVariant2 || IsRefusalCategoryVariant3 || IsRefusalCategoryVariant4 || IsRefusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? refusalCategoryVariant1 = null,
            global::System.Func<string, TResult>? refusalCategoryVariant2 = null,
            global::System.Func<string, TResult>? refusalCategoryVariant3 = null,
            global::System.Func<string, TResult>? refusalCategoryVariant4 = null,
            global::System.Func<string, TResult>? refusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefusalCategoryVariant1 is { } __value0 && refusalCategoryVariant1 != null)
            {
                return refusalCategoryVariant1(__value0);
            }
            else if (RefusalCategoryVariant2 is { } __value1 && refusalCategoryVariant2 != null)
            {
                return refusalCategoryVariant2(__value1);
            }
            else if (RefusalCategoryVariant3 is { } __value2 && refusalCategoryVariant3 != null)
            {
                return refusalCategoryVariant3(__value2);
            }
            else if (RefusalCategoryVariant4 is { } __value3 && refusalCategoryVariant4 != null)
            {
                return refusalCategoryVariant4(__value3);
            }
            else if (RefusalCategoryVariant5 is { } __value4 && refusalCategoryVariant5 != null)
            {
                return refusalCategoryVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? refusalCategoryVariant1 = null,

            global::System.Action<string>? refusalCategoryVariant2 = null,

            global::System.Action<string>? refusalCategoryVariant3 = null,

            global::System.Action<string>? refusalCategoryVariant4 = null,

            global::System.Action<string>? refusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefusalCategoryVariant1 is { } __value0)
            {
                refusalCategoryVariant1?.Invoke(__value0);
            }
            else if (RefusalCategoryVariant2 is { } __value1)
            {
                refusalCategoryVariant2?.Invoke(__value1);
            }
            else if (RefusalCategoryVariant3 is { } __value2)
            {
                refusalCategoryVariant3?.Invoke(__value2);
            }
            else if (RefusalCategoryVariant4 is { } __value3)
            {
                refusalCategoryVariant4?.Invoke(__value3);
            }
            else if (RefusalCategoryVariant5 is { } __value4)
            {
                refusalCategoryVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? refusalCategoryVariant1 = null,
            global::System.Action<string>? refusalCategoryVariant2 = null,
            global::System.Action<string>? refusalCategoryVariant3 = null,
            global::System.Action<string>? refusalCategoryVariant4 = null,
            global::System.Action<string>? refusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (RefusalCategoryVariant1 is { } __value0)
            {
                refusalCategoryVariant1?.Invoke(__value0);
            }
            else if (RefusalCategoryVariant2 is { } __value1)
            {
                refusalCategoryVariant2?.Invoke(__value1);
            }
            else if (RefusalCategoryVariant3 is { } __value2)
            {
                refusalCategoryVariant3?.Invoke(__value2);
            }
            else if (RefusalCategoryVariant4 is { } __value3)
            {
                refusalCategoryVariant4?.Invoke(__value3);
            }
            else if (RefusalCategoryVariant5 is { } __value4)
            {
                refusalCategoryVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                RefusalCategoryVariant1,
                typeof(string),
                RefusalCategoryVariant2,
                typeof(string),
                RefusalCategoryVariant3,
                typeof(string),
                RefusalCategoryVariant4,
                typeof(string),
                RefusalCategoryVariant5,
                typeof(string),
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
        public bool Equals(RefusalCategory other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RefusalCategoryVariant1, other.RefusalCategoryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RefusalCategoryVariant2, other.RefusalCategoryVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RefusalCategoryVariant3, other.RefusalCategoryVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RefusalCategoryVariant4, other.RefusalCategoryVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(RefusalCategoryVariant5, other.RefusalCategoryVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(RefusalCategory obj1, RefusalCategory obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RefusalCategory>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(RefusalCategory obj1, RefusalCategory obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RefusalCategory o && Equals(o);
        }
    }
}
