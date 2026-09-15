#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether URLs in user messages are fetchable: "all" or "none".
    /// </summary>
    public readonly partial struct UserInput : global::System.IEquatable<UserInput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? Type { get; }

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes in<br/>
        /// full: every result of the tool filter's source, or all user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceAll? All { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceAll? All { get; }
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
            out global::Anthropic.BetaWebFetchUrlSourceAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll PickAll() => IsAll
            ? All!
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes nothing:<br/>
        /// no result of the tool filter's source, or no user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceNone? None { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceNone? None { get; }
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
            out global::Anthropic.BetaWebFetchUrlSourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserInput(global::Anthropic.BetaWebFetchUrlSourceAll value) => new UserInput((global::Anthropic.BetaWebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceAll?(UserInput @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public UserInput(global::Anthropic.BetaWebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserInput FromAll(global::Anthropic.BetaWebFetchUrlSourceAll? value) => new UserInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserInput(global::Anthropic.BetaWebFetchUrlSourceNone value) => new UserInput((global::Anthropic.BetaWebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceNone?(UserInput @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public UserInput(global::Anthropic.BetaWebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserInput FromNone(global::Anthropic.BetaWebFetchUrlSourceNone? value) => new UserInput(value);

        /// <summary>
        ///
        /// </summary>
        public UserInput(
            global::Anthropic.BetaWebFetchUrlSourcesUserInputDiscriminatorType? type,
            global::Anthropic.BetaWebFetchUrlSourceAll? all,
            global::Anthropic.BetaWebFetchUrlSourceNone? none
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
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceNone, TResult>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll && all != null)
            {
                return all(All!);
            }
            else if (IsNone && none != null)
            {
                return none(None!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceNone>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceNone>? none = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
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
                typeof(global::Anthropic.BetaWebFetchUrlSourceAll),
                None,
                typeof(global::Anthropic.BetaWebFetchUrlSourceNone),
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
        public bool Equals(UserInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceNone?>.Default.Equals(None, other.None)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UserInput obj1, UserInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UserInput obj1, UserInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserInput o && Equals(o);
        }
    }
}
