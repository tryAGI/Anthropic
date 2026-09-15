#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether URLs in user messages are fetchable: "all" or "none".
    /// </summary>
    public readonly partial struct UserInput2 : global::System.IEquatable<UserInput2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? Type { get; }

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes in<br/>
        /// full: every result of the tool filter's source, or all user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceAll? All { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceAll? All { get; }
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
            out global::Anthropic.WebFetchUrlSourceAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll PickAll() => IsAll
            ? All!
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes nothing:<br/>
        /// no result of the tool filter's source, or no user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceNone? None { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceNone? None { get; }
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
            out global::Anthropic.WebFetchUrlSourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserInput2(global::Anthropic.WebFetchUrlSourceAll value) => new UserInput2((global::Anthropic.WebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceAll?(UserInput2 @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public UserInput2(global::Anthropic.WebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserInput2 FromAll(global::Anthropic.WebFetchUrlSourceAll? value) => new UserInput2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator UserInput2(global::Anthropic.WebFetchUrlSourceNone value) => new UserInput2((global::Anthropic.WebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceNone?(UserInput2 @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public UserInput2(global::Anthropic.WebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static UserInput2 FromNone(global::Anthropic.WebFetchUrlSourceNone? value) => new UserInput2(value);

        /// <summary>
        ///
        /// </summary>
        public UserInput2(
            global::Anthropic.WebFetchUrlSourcesUserInputDiscriminatorType? type,
            global::Anthropic.WebFetchUrlSourceAll? all,
            global::Anthropic.WebFetchUrlSourceNone? none
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
            global::System.Func<global::Anthropic.WebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.WebFetchUrlSourceNone, TResult>? none = null,
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
            global::System.Action<global::Anthropic.WebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.WebFetchUrlSourceNone>? none = null,
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
            global::System.Action<global::Anthropic.WebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.WebFetchUrlSourceNone>? none = null,
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
                typeof(global::Anthropic.WebFetchUrlSourceAll),
                None,
                typeof(global::Anthropic.WebFetchUrlSourceNone),
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
        public bool Equals(UserInput2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceNone?>.Default.Equals(None, other.None)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(UserInput2 obj1, UserInput2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UserInput2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(UserInput2 obj1, UserInput2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UserInput2 o && Equals(o);
        }
    }
}
