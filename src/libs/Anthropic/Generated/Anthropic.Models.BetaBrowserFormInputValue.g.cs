#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaBrowserFormInputValue : global::System.IEquatable<BetaBrowserFormInputValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BetaBrowserFormInputValueVariant1 { get; init; }
#else
        public string? BetaBrowserFormInputValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaBrowserFormInputValueVariant1))]
#endif
        public bool IsBetaBrowserFormInputValueVariant1 => BetaBrowserFormInputValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaBrowserFormInputValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BetaBrowserFormInputValueVariant1;
            return IsBetaBrowserFormInputValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBetaBrowserFormInputValueVariant1() => BetaBrowserFormInputValueVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaBrowserFormInputValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? BetaBrowserFormInputValueVariant2 { get; init; }
#else
        public double? BetaBrowserFormInputValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaBrowserFormInputValueVariant2))]
#endif
        public bool IsBetaBrowserFormInputValueVariant2 => BetaBrowserFormInputValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaBrowserFormInputValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = BetaBrowserFormInputValueVariant2;
            return IsBetaBrowserFormInputValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickBetaBrowserFormInputValueVariant2() => BetaBrowserFormInputValueVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaBrowserFormInputValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? BetaBrowserFormInputValueVariant3 { get; init; }
#else
        public bool? BetaBrowserFormInputValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BetaBrowserFormInputValueVariant3))]
#endif
        public bool IsBetaBrowserFormInputValueVariant3 => BetaBrowserFormInputValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBetaBrowserFormInputValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = BetaBrowserFormInputValueVariant3;
            return IsBetaBrowserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickBetaBrowserFormInputValueVariant3() => BetaBrowserFormInputValueVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BetaBrowserFormInputValueVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserFormInputValue(string value) => new BetaBrowserFormInputValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BetaBrowserFormInputValue @this) => @this.BetaBrowserFormInputValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserFormInputValue(string? value)
        {
            BetaBrowserFormInputValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserFormInputValue FromBetaBrowserFormInputValueVariant1(string? value) => new BetaBrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserFormInputValue(double value) => new BetaBrowserFormInputValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(BetaBrowserFormInputValue @this) => @this.BetaBrowserFormInputValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserFormInputValue(double? value)
        {
            BetaBrowserFormInputValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserFormInputValue FromBetaBrowserFormInputValueVariant2(double? value) => new BetaBrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaBrowserFormInputValue(bool value) => new BetaBrowserFormInputValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(BetaBrowserFormInputValue @this) => @this.BetaBrowserFormInputValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserFormInputValue(bool? value)
        {
            BetaBrowserFormInputValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaBrowserFormInputValue FromBetaBrowserFormInputValueVariant3(bool? value) => new BetaBrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public BetaBrowserFormInputValue(
            string? betaBrowserFormInputValueVariant1,
            double? betaBrowserFormInputValueVariant2,
            bool? betaBrowserFormInputValueVariant3
            )
        {
            BetaBrowserFormInputValueVariant1 = betaBrowserFormInputValueVariant1;
            BetaBrowserFormInputValueVariant2 = betaBrowserFormInputValueVariant2;
            BetaBrowserFormInputValueVariant3 = betaBrowserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BetaBrowserFormInputValueVariant3 as object ??
            BetaBrowserFormInputValueVariant2 as object ??
            BetaBrowserFormInputValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BetaBrowserFormInputValueVariant1?.ToString() ??
            BetaBrowserFormInputValueVariant2?.ToString() ??
            BetaBrowserFormInputValueVariant3?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBetaBrowserFormInputValueVariant1 || IsBetaBrowserFormInputValueVariant2 || IsBetaBrowserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? betaBrowserFormInputValueVariant1 = null,
            global::System.Func<double?, TResult>? betaBrowserFormInputValueVariant2 = null,
            global::System.Func<bool?, TResult>? betaBrowserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaBrowserFormInputValueVariant1 is { } __value0 && betaBrowserFormInputValueVariant1 != null)
            {
                return betaBrowserFormInputValueVariant1(__value0);
            }
            else if (BetaBrowserFormInputValueVariant2 is { } __value1 && betaBrowserFormInputValueVariant2 != null)
            {
                return betaBrowserFormInputValueVariant2(__value1);
            }
            else if (BetaBrowserFormInputValueVariant3 is { } __value2 && betaBrowserFormInputValueVariant3 != null)
            {
                return betaBrowserFormInputValueVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? betaBrowserFormInputValueVariant1 = null,

            global::System.Action<double?>? betaBrowserFormInputValueVariant2 = null,

            global::System.Action<bool?>? betaBrowserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaBrowserFormInputValueVariant1 is { } __value0)
            {
                betaBrowserFormInputValueVariant1?.Invoke(__value0);
            }
            else if (BetaBrowserFormInputValueVariant2 is { } __value1)
            {
                betaBrowserFormInputValueVariant2?.Invoke(__value1);
            }
            else if (BetaBrowserFormInputValueVariant3 is { } __value2)
            {
                betaBrowserFormInputValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? betaBrowserFormInputValueVariant1 = null,
            global::System.Action<double?>? betaBrowserFormInputValueVariant2 = null,
            global::System.Action<bool?>? betaBrowserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BetaBrowserFormInputValueVariant1 is { } __value0)
            {
                betaBrowserFormInputValueVariant1?.Invoke(__value0);
            }
            else if (BetaBrowserFormInputValueVariant2 is { } __value1)
            {
                betaBrowserFormInputValueVariant2?.Invoke(__value1);
            }
            else if (BetaBrowserFormInputValueVariant3 is { } __value2)
            {
                betaBrowserFormInputValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BetaBrowserFormInputValueVariant1,
                typeof(string),
                BetaBrowserFormInputValueVariant2,
                typeof(double),
                BetaBrowserFormInputValueVariant3,
                typeof(bool),
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
        public bool Equals(BetaBrowserFormInputValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BetaBrowserFormInputValueVariant1, other.BetaBrowserFormInputValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(BetaBrowserFormInputValueVariant2, other.BetaBrowserFormInputValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(BetaBrowserFormInputValueVariant3, other.BetaBrowserFormInputValueVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaBrowserFormInputValue obj1, BetaBrowserFormInputValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaBrowserFormInputValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaBrowserFormInputValue obj1, BetaBrowserFormInputValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaBrowserFormInputValue o && Equals(o);
        }
    }
}
