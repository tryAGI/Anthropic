#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether URLs in the text of user messages may be fetched.
    /// </summary>
    public readonly partial struct BetaManagedAgentsWebFetchUrlSourceUserInput : global::System.IEquatable<BetaManagedAgentsWebFetchUrlSourceUserInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? Type { get; }

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
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceUserInput(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll value) => new BetaManagedAgentsWebFetchUrlSourceUserInput((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?(BetaManagedAgentsWebFetchUrlSourceUserInput @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInput(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceUserInput FromAll(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? value) => new BetaManagedAgentsWebFetchUrlSourceUserInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsWebFetchUrlSourceUserInput(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone value) => new BetaManagedAgentsWebFetchUrlSourceUserInput((global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?(BetaManagedAgentsWebFetchUrlSourceUserInput @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInput(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsWebFetchUrlSourceUserInput FromNone(global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? value) => new BetaManagedAgentsWebFetchUrlSourceUserInput(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsWebFetchUrlSourceUserInput(
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceUserInputDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll? all,
            global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone? none
            )
        {
            Type = type;

            All = all;
            None = none;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            None as object ??
            All as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            All?.ToString() ??
            None?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAll && !IsNone || !IsAll && IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone, TResult>? none = null,
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

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone>? none = null,
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
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone>? none = null,
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
        public bool Equals(BetaManagedAgentsWebFetchUrlSourceUserInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchUrlSourceNone?>.Default.Equals(None, other.None)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsWebFetchUrlSourceUserInput obj1, BetaManagedAgentsWebFetchUrlSourceUserInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsWebFetchUrlSourceUserInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsWebFetchUrlSourceUserInput obj1, BetaManagedAgentsWebFetchUrlSourceUserInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsWebFetchUrlSourceUserInput o && Equals(o);
        }
    }
}
