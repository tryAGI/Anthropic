#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which tools' results contribute URLs that may be fetched.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWebFetchUrlSourceToolFilter : global::System.IEquatable<BetaManagedAgentsWebFetchUrlSourceToolFilter>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? Type { get; }

        /// <summary>
        /// Every URL from this source may be fetched. This is the default.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? All { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? All { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(All))]
#endif
        public bool IsAll => All != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll PickAll() => All is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// This source contributes no URLs that may be fetched.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? None { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? None { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone PickNone() => None is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// Only the named tools' results contribute URLs that may be fetched.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Only { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? Only { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Only))]
#endif
        public bool IsOnly => Only != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOnly(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? value)
        {
            value = Only;
            return IsOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly PickOnly() => Only is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Only' but the value was {ToString()}.");

        /// <summary>
        /// Every tool's results contribute URLs that may be fetched, except the named tools' results.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Except { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? Except { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Except))]
#endif
        public bool IsExcept => Except != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExcept(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? value)
        {
            value = Except;
            return IsExcept;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept PickExcept() => Except is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Except' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?(BetaManagedAgentsWebFetchUrlSourceToolFilter @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilter FromAll(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?(BetaManagedAgentsWebFetchUrlSourceToolFilter @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilter FromNone(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly?(BetaManagedAgentsWebFetchUrlSourceToolFilter @this) => @this.Only;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? value)
        {
            Only = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilter FromOnly(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept?(BetaManagedAgentsWebFetchUrlSourceToolFilter @this) => @this.Except;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilter(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? value)
        {
            Except = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceToolFilter FromExcept(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? value) => new BetaManagedAgentsWebFetchUrlSourceToolFilter(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceToolFilter(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceToolFilterDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? all,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? none,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly? only,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept? except
            )
        {
            Type = type;

            All = all;
            None = none;
            Only = only;
            Except = except;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Except as object ??
            Only as object ??
            None as object ??
            All as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            All?.ToString() ??
            None?.ToString() ??
            Only?.ToString() ??
            Except?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAll && !IsNone && !IsOnly && !IsExcept || !IsAll && IsNone && !IsOnly && !IsExcept || !IsAll && !IsNone && IsOnly && !IsExcept || !IsAll && !IsNone && !IsOnly && IsExcept;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone, TResult>? none = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly, TResult>? only = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept, TResult>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0 && all != null)
            {
                return all(__value0);
            }
            else if (None is { } __value1 && none != null)
            {
                return none(__value1);
            }
            else if (Only is { } __value2 && only != null)
            {
                return only(__value2);
            }
            else if (Except is { } __value3 && except != null)
            {
                return except(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone>? none = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly>? only = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0)
            {
                all?.Invoke(__value0);
            }
            else if (None is { } __value1)
            {
                none?.Invoke(__value1);
            }
            else if (Only is { } __value2)
            {
                only?.Invoke(__value2);
            }
            else if (Except is { } __value3)
            {
                except?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone>? none = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly>? only = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0)
            {
                all?.Invoke(__value0);
            }
            else if (None is { } __value1)
            {
                none?.Invoke(__value1);
            }
            else if (Only is { } __value2)
            {
                only?.Invoke(__value2);
            }
            else if (Except is { } __value3)
            {
                except?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                All,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll),
                None,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone),
                Only,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly),
                Except,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept),
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
        public bool Equals(BetaManagedAgentsWebFetchUrlSourceToolFilter other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceOnly?>.Default.Equals(Only, other.Only) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceExcept?>.Default.Equals(Except, other.Except)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWebFetchUrlSourceToolFilter obj1, BetaManagedAgentsWebFetchUrlSourceToolFilter obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWebFetchUrlSourceToolFilter>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWebFetchUrlSourceToolFilter obj1, BetaManagedAgentsWebFetchUrlSourceToolFilter obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWebFetchUrlSourceToolFilter o && Equals(o);
        }
    }
}
