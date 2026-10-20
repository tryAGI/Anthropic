#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The action that the person who opens the URL takes, discriminated by `type`.
    /// </summary>
    public readonly partial struct BetaUserProfileAction : global::System.IEquatable<BetaUserProfileAction>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileActionDiscriminatorType? Type { get; }

        /// <summary>
        /// The end-user that the profile represents enrolls in a program.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? EnrollEndUser { get; init; }
#else
        public global::Anthropic.BetaUserProfileEnrollEndUserAction? EnrollEndUser { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnrollEndUser))]
#endif
        public bool IsEnrollEndUser => EnrollEndUser != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEnrollEndUser(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaUserProfileEnrollEndUserAction? value)
        {
            value = EnrollEndUser;
            return IsEnrollEndUser;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserProfileEnrollEndUserAction PickEnrollEndUser() => EnrollEndUser is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnrollEndUser' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaUserProfileAction(global::Anthropic.BetaUserProfileEnrollEndUserAction value) => new BetaUserProfileAction((global::Anthropic.BetaUserProfileEnrollEndUserAction?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaUserProfileEnrollEndUserAction?(BetaUserProfileAction @this) => @this.EnrollEndUser;

        /// <summary>
        ///
        /// </summary>
        public BetaUserProfileAction(global::Anthropic.BetaUserProfileEnrollEndUserAction? value)
        {
            EnrollEndUser = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaUserProfileAction FromEnrollEndUser(global::Anthropic.BetaUserProfileEnrollEndUserAction? value) => new BetaUserProfileAction(value);

        /// <summary>
        ///
        /// </summary>
        public BetaUserProfileAction(
            global::Anthropic.BetaUserProfileActionDiscriminatorType? type,
            global::Anthropic.BetaUserProfileEnrollEndUserAction? enrollEndUser
            )
        {
            Type = type;

            EnrollEndUser = enrollEndUser;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            EnrollEndUser as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            EnrollEndUser?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsEnrollEndUser;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUserProfileEnrollEndUserAction, TResult>? enrollEndUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnrollEndUser is { } __value0 && enrollEndUser != null)
            {
                return enrollEndUser(__value0);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaUserProfileEnrollEndUserAction>? enrollEndUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnrollEndUser is { } __value0)
            {
                enrollEndUser?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaUserProfileEnrollEndUserAction>? enrollEndUser = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (EnrollEndUser is { } __value0)
            {
                enrollEndUser?.Invoke(__value0);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                EnrollEndUser,
                typeof(global::Anthropic.BetaUserProfileEnrollEndUserAction),
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
        public bool Equals(BetaUserProfileAction other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUserProfileEnrollEndUserAction?>.Default.Equals(EnrollEndUser, other.EnrollEndUser)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaUserProfileAction obj1, BetaUserProfileAction obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaUserProfileAction>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaUserProfileAction obj1, BetaUserProfileAction obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaUserProfileAction o && Equals(o);
        }
    }
}
