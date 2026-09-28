#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The policy category that triggered a refusal.
    /// </summary>
    public readonly partial struct BetaRefusalCategory : global::System.IEquatable<BetaRefusalCategory>
    {
        /// <summary>
        /// The request could enable cyber harm, such as malware or exploit development. Benign cybersecurity work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaRefusalCategoryVariant1 { get; init; }
#else
        public string? BetaRefusalCategoryVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRefusalCategoryVariant1))]
#endif
        public bool IsBetaRefusalCategoryVariant1 => BetaRefusalCategoryVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRefusalCategoryVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaRefusalCategoryVariant1;
            return IsBetaRefusalCategoryVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaRefusalCategoryVariant1() => BetaRefusalCategoryVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRefusalCategoryVariant1' but the value was {ToString()}.");

        /// <summary>
        /// The request could enable biological harm, such as dangerous lab methods. Beneficial life sciences work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaRefusalCategoryVariant2 { get; init; }
#else
        public string? BetaRefusalCategoryVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRefusalCategoryVariant2))]
#endif
        public bool IsBetaRefusalCategoryVariant2 => BetaRefusalCategoryVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRefusalCategoryVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaRefusalCategoryVariant2;
            return IsBetaRefusalCategoryVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaRefusalCategoryVariant2() => BetaRefusalCategoryVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRefusalCategoryVariant2' but the value was {ToString()}.");

        /// <summary>
        /// The request could assist the development of competing AI models, which is restricted under [Anthropic's commercial terms](https://www.anthropic.com/legal/commercial-terms). Benign machine learning work can also trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaRefusalCategoryVariant3 { get; init; }
#else
        public string? BetaRefusalCategoryVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRefusalCategoryVariant3))]
#endif
        public bool IsBetaRefusalCategoryVariant3 => BetaRefusalCategoryVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRefusalCategoryVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaRefusalCategoryVariant3;
            return IsBetaRefusalCategoryVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaRefusalCategoryVariant3() => BetaRefusalCategoryVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRefusalCategoryVariant3' but the value was {ToString()}.");

        /// <summary>
        /// The request asks the model to reproduce its internal reasoning in the response text. To get reasoning in a structured form instead, use [adaptive thinking](https://platform.claude.com/docs/en/build-with-claude/adaptive-thinking).
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaRefusalCategoryVariant4 { get; init; }
#else
        public string? BetaRefusalCategoryVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRefusalCategoryVariant4))]
#endif
        public bool IsBetaRefusalCategoryVariant4 => BetaRefusalCategoryVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRefusalCategoryVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaRefusalCategoryVariant4;
            return IsBetaRefusalCategoryVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaRefusalCategoryVariant4() => BetaRefusalCategoryVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRefusalCategoryVariant4' but the value was {ToString()}.");

        /// <summary>
        /// The request could be related to an area that was determined as harmful. Benign work might sometimes trigger this category.
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaRefusalCategoryVariant5 { get; init; }
#else
        public string? BetaRefusalCategoryVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaRefusalCategoryVariant5))]
#endif
        public bool IsBetaRefusalCategoryVariant5 => BetaRefusalCategoryVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaRefusalCategoryVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaRefusalCategoryVariant5;
            return IsBetaRefusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaRefusalCategoryVariant5() => BetaRefusalCategoryVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaRefusalCategoryVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaRefusalCategory(string value) => new BetaRefusalCategory((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaRefusalCategory @this) => @this.BetaRefusalCategoryVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaRefusalCategory(string? value)
        {
            BetaRefusalCategoryVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaRefusalCategory FromBetaRefusalCategoryVariant1(string? value) => new BetaRefusalCategory(value);

        /// <summary>
        ///
        /// </summary>
        public BetaRefusalCategory(
            string? betaRefusalCategoryVariant1,
            string? betaRefusalCategoryVariant2,
            string? betaRefusalCategoryVariant3,
            string? betaRefusalCategoryVariant4,
            string? betaRefusalCategoryVariant5
            )
        {
            BetaRefusalCategoryVariant1 = betaRefusalCategoryVariant1;
            BetaRefusalCategoryVariant2 = betaRefusalCategoryVariant2;
            BetaRefusalCategoryVariant3 = betaRefusalCategoryVariant3;
            BetaRefusalCategoryVariant4 = betaRefusalCategoryVariant4;
            BetaRefusalCategoryVariant5 = betaRefusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaRefusalCategoryVariant5 as object ??
            BetaRefusalCategoryVariant4 as object ??
            BetaRefusalCategoryVariant3 as object ??
            BetaRefusalCategoryVariant2 as object ??
            BetaRefusalCategoryVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaRefusalCategoryVariant1?.ToString() ??
            BetaRefusalCategoryVariant2?.ToString() ??
            BetaRefusalCategoryVariant3?.ToString() ??
            BetaRefusalCategoryVariant4?.ToString() ??
            BetaRefusalCategoryVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaRefusalCategoryVariant1 || IsBetaRefusalCategoryVariant2 || IsBetaRefusalCategoryVariant3 || IsBetaRefusalCategoryVariant4 || IsBetaRefusalCategoryVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaRefusalCategoryVariant1 = null,
            global::System.Func<string, TResult>? betaRefusalCategoryVariant2 = null,
            global::System.Func<string, TResult>? betaRefusalCategoryVariant3 = null,
            global::System.Func<string, TResult>? betaRefusalCategoryVariant4 = null,
            global::System.Func<string, TResult>? betaRefusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaRefusalCategoryVariant1 is { } __value0 && betaRefusalCategoryVariant1 != null)
            {
                return betaRefusalCategoryVariant1(__value0);
            }
            else if (BetaRefusalCategoryVariant2 is { } __value1 && betaRefusalCategoryVariant2 != null)
            {
                return betaRefusalCategoryVariant2(__value1);
            }
            else if (BetaRefusalCategoryVariant3 is { } __value2 && betaRefusalCategoryVariant3 != null)
            {
                return betaRefusalCategoryVariant3(__value2);
            }
            else if (BetaRefusalCategoryVariant4 is { } __value3 && betaRefusalCategoryVariant4 != null)
            {
                return betaRefusalCategoryVariant4(__value3);
            }
            else if (BetaRefusalCategoryVariant5 is { } __value4 && betaRefusalCategoryVariant5 != null)
            {
                return betaRefusalCategoryVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaRefusalCategoryVariant1 = null,

            global::System.Action<string>? betaRefusalCategoryVariant2 = null,

            global::System.Action<string>? betaRefusalCategoryVariant3 = null,

            global::System.Action<string>? betaRefusalCategoryVariant4 = null,

            global::System.Action<string>? betaRefusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaRefusalCategoryVariant1 is { } __value0)
            {
                betaRefusalCategoryVariant1?.Invoke(__value0);
            }
            else if (BetaRefusalCategoryVariant2 is { } __value1)
            {
                betaRefusalCategoryVariant2?.Invoke(__value1);
            }
            else if (BetaRefusalCategoryVariant3 is { } __value2)
            {
                betaRefusalCategoryVariant3?.Invoke(__value2);
            }
            else if (BetaRefusalCategoryVariant4 is { } __value3)
            {
                betaRefusalCategoryVariant4?.Invoke(__value3);
            }
            else if (BetaRefusalCategoryVariant5 is { } __value4)
            {
                betaRefusalCategoryVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaRefusalCategoryVariant1 = null,
            global::System.Action<string>? betaRefusalCategoryVariant2 = null,
            global::System.Action<string>? betaRefusalCategoryVariant3 = null,
            global::System.Action<string>? betaRefusalCategoryVariant4 = null,
            global::System.Action<string>? betaRefusalCategoryVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaRefusalCategoryVariant1 is { } __value0)
            {
                betaRefusalCategoryVariant1?.Invoke(__value0);
            }
            else if (BetaRefusalCategoryVariant2 is { } __value1)
            {
                betaRefusalCategoryVariant2?.Invoke(__value1);
            }
            else if (BetaRefusalCategoryVariant3 is { } __value2)
            {
                betaRefusalCategoryVariant3?.Invoke(__value2);
            }
            else if (BetaRefusalCategoryVariant4 is { } __value3)
            {
                betaRefusalCategoryVariant4?.Invoke(__value3);
            }
            else if (BetaRefusalCategoryVariant5 is { } __value4)
            {
                betaRefusalCategoryVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaRefusalCategoryVariant1,
                typeof(string),
                BetaRefusalCategoryVariant2,
                typeof(string),
                BetaRefusalCategoryVariant3,
                typeof(string),
                BetaRefusalCategoryVariant4,
                typeof(string),
                BetaRefusalCategoryVariant5,
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
        public bool Equals(BetaRefusalCategory other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaRefusalCategoryVariant1, other.BetaRefusalCategoryVariant1) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaRefusalCategoryVariant2, other.BetaRefusalCategoryVariant2) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaRefusalCategoryVariant3, other.BetaRefusalCategoryVariant3) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaRefusalCategoryVariant4, other.BetaRefusalCategoryVariant4) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaRefusalCategoryVariant5, other.BetaRefusalCategoryVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaRefusalCategory obj1, BetaRefusalCategory obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaRefusalCategory>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaRefusalCategory obj1, BetaRefusalCategory obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaRefusalCategory o && Equals(o);
        }
    }
}
