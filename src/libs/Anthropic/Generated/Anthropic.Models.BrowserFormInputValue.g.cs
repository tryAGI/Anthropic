#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BrowserFormInputValue : global::System.IEquatable<BrowserFormInputValue>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BrowserFormInputValueVariant1 { get; init; }
#else
        public string? BrowserFormInputValueVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserFormInputValueVariant1))]
#endif
        public bool IsBrowserFormInputValueVariant1 => BrowserFormInputValueVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserFormInputValueVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BrowserFormInputValueVariant1;
            return IsBrowserFormInputValueVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBrowserFormInputValueVariant1() => BrowserFormInputValueVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFormInputValueVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? BrowserFormInputValueVariant2 { get; init; }
#else
        public double? BrowserFormInputValueVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserFormInputValueVariant2))]
#endif
        public bool IsBrowserFormInputValueVariant2 => BrowserFormInputValueVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserFormInputValueVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = BrowserFormInputValueVariant2;
            return IsBrowserFormInputValueVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickBrowserFormInputValueVariant2() => BrowserFormInputValueVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFormInputValueVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? BrowserFormInputValueVariant3 { get; init; }
#else
        public bool? BrowserFormInputValueVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserFormInputValueVariant3))]
#endif
        public bool IsBrowserFormInputValueVariant3 => BrowserFormInputValueVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserFormInputValueVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = BrowserFormInputValueVariant3;
            return IsBrowserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickBrowserFormInputValueVariant3() => BrowserFormInputValueVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserFormInputValueVariant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserFormInputValue(string value) => new BrowserFormInputValue((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BrowserFormInputValue @this) => @this.BrowserFormInputValueVariant1;

        /// <summary>
        ///
        /// </summary>
        public BrowserFormInputValue(string? value)
        {
            BrowserFormInputValueVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserFormInputValue FromBrowserFormInputValueVariant1(string? value) => new BrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserFormInputValue(double value) => new BrowserFormInputValue((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(BrowserFormInputValue @this) => @this.BrowserFormInputValueVariant2;

        /// <summary>
        ///
        /// </summary>
        public BrowserFormInputValue(double? value)
        {
            BrowserFormInputValueVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserFormInputValue FromBrowserFormInputValueVariant2(double? value) => new BrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BrowserFormInputValue(bool value) => new BrowserFormInputValue((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(BrowserFormInputValue @this) => @this.BrowserFormInputValueVariant3;

        /// <summary>
        ///
        /// </summary>
        public BrowserFormInputValue(bool? value)
        {
            BrowserFormInputValueVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BrowserFormInputValue FromBrowserFormInputValueVariant3(bool? value) => new BrowserFormInputValue(value);

        /// <summary>
        ///
        /// </summary>
        public BrowserFormInputValue(
            string? browserFormInputValueVariant1,
            double? browserFormInputValueVariant2,
            bool? browserFormInputValueVariant3
            )
        {
            BrowserFormInputValueVariant1 = browserFormInputValueVariant1;
            BrowserFormInputValueVariant2 = browserFormInputValueVariant2;
            BrowserFormInputValueVariant3 = browserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            BrowserFormInputValueVariant3 as object ??
            BrowserFormInputValueVariant2 as object ??
            BrowserFormInputValueVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BrowserFormInputValueVariant1?.ToString() ??
            BrowserFormInputValueVariant2?.ToString() ??
            BrowserFormInputValueVariant3?.ToString().ToLowerInvariant()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBrowserFormInputValueVariant1 || IsBrowserFormInputValueVariant2 || IsBrowserFormInputValueVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? browserFormInputValueVariant1 = null,
            global::System.Func<double?, TResult>? browserFormInputValueVariant2 = null,
            global::System.Func<bool?, TResult>? browserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserFormInputValueVariant1 is { } __value0 && browserFormInputValueVariant1 != null)
            {
                return browserFormInputValueVariant1(__value0);
            }
            else if (BrowserFormInputValueVariant2 is { } __value1 && browserFormInputValueVariant2 != null)
            {
                return browserFormInputValueVariant2(__value1);
            }
            else if (BrowserFormInputValueVariant3 is { } __value2 && browserFormInputValueVariant3 != null)
            {
                return browserFormInputValueVariant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? browserFormInputValueVariant1 = null,

            global::System.Action<double?>? browserFormInputValueVariant2 = null,

            global::System.Action<bool?>? browserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserFormInputValueVariant1 is { } __value0)
            {
                browserFormInputValueVariant1?.Invoke(__value0);
            }
            else if (BrowserFormInputValueVariant2 is { } __value1)
            {
                browserFormInputValueVariant2?.Invoke(__value1);
            }
            else if (BrowserFormInputValueVariant3 is { } __value2)
            {
                browserFormInputValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? browserFormInputValueVariant1 = null,
            global::System.Action<double?>? browserFormInputValueVariant2 = null,
            global::System.Action<bool?>? browserFormInputValueVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BrowserFormInputValueVariant1 is { } __value0)
            {
                browserFormInputValueVariant1?.Invoke(__value0);
            }
            else if (BrowserFormInputValueVariant2 is { } __value1)
            {
                browserFormInputValueVariant2?.Invoke(__value1);
            }
            else if (BrowserFormInputValueVariant3 is { } __value2)
            {
                browserFormInputValueVariant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BrowserFormInputValueVariant1,
                typeof(string),
                BrowserFormInputValueVariant2,
                typeof(double),
                BrowserFormInputValueVariant3,
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
        public bool Equals(BrowserFormInputValue other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BrowserFormInputValueVariant1, other.BrowserFormInputValueVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(BrowserFormInputValueVariant2, other.BrowserFormInputValueVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(BrowserFormInputValueVariant3, other.BrowserFormInputValueVariant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BrowserFormInputValue obj1, BrowserFormInputValue obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BrowserFormInputValue>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BrowserFormInputValue obj1, BrowserFormInputValue obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BrowserFormInputValue o && Equals(o);
        }
    }
}
