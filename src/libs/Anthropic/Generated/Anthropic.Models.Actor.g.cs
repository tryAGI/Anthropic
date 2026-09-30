#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Actor : global::System.IEquatable<Actor>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType? Type { get; }

        /// <summary>
        /// A user within the organization. `name` and `email_address` are<br/>
        /// null when the underlying account is unavailable or has been deleted;<br/>
        /// `deleted` is true only for deleted accounts.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUserActorSchema? UserActor { get; init; }
#else
        public global::Anthropic.BetaUserActorSchema? UserActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserActor))]
#endif
        public bool IsUserActor => UserActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaUserActorSchema? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUserActorSchema PickUserActor() => UserActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        /// A scoped Admin API key acting on behalf of the organization.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaScopedApiKeyActorSchema? ScopedApiKeyActor { get; init; }
#else
        public global::Anthropic.BetaScopedApiKeyActorSchema? ScopedApiKeyActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ScopedApiKeyActor))]
#endif
        public bool IsScopedApiKeyActor => ScopedApiKeyActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickScopedApiKeyActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaScopedApiKeyActorSchema? value)
        {
            value = ScopedApiKeyActor;
            return IsScopedApiKeyActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaScopedApiKeyActorSchema PickScopedApiKeyActor() => ScopedApiKeyActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ScopedApiKeyActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Actor(global::Anthropic.BetaUserActorSchema value) => new Actor((global::Anthropic.BetaUserActorSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaUserActorSchema?(Actor @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public Actor(global::Anthropic.BetaUserActorSchema? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Actor FromUserActor(global::Anthropic.BetaUserActorSchema? value) => new Actor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Actor(global::Anthropic.BetaScopedApiKeyActorSchema value) => new Actor((global::Anthropic.BetaScopedApiKeyActorSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaScopedApiKeyActorSchema?(Actor @this) => @this.ScopedApiKeyActor;

        /// <summary>
        ///
        /// </summary>
        public Actor(global::Anthropic.BetaScopedApiKeyActorSchema? value)
        {
            ScopedApiKeyActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Actor FromScopedApiKeyActor(global::Anthropic.BetaScopedApiKeyActorSchema? value) => new Actor(value);

        /// <summary>
        ///
        /// </summary>
        public Actor(
            global::Anthropic.BetaApproveSpendLimitIncreaseRequestResponseActorDiscriminatorType? type,
            global::Anthropic.BetaUserActorSchema? userActor,
            global::Anthropic.BetaScopedApiKeyActorSchema? scopedApiKeyActor
            )
        {
            Type = type;

            UserActor = userActor;
            ScopedApiKeyActor = scopedApiKeyActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ScopedApiKeyActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ScopedApiKeyActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsScopedApiKeyActor || !IsUserActor && IsScopedApiKeyActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaUserActorSchema, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaScopedApiKeyActorSchema, TResult>? scopedApiKeyActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0 && userActor != null)
            {
                return userActor(__value0);
            }
            else if (ScopedApiKeyActor is { } __value1 && scopedApiKeyActor != null)
            {
                return scopedApiKeyActor(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaUserActorSchema>? userActor = null,

            global::System.Action<global::Anthropic.BetaScopedApiKeyActorSchema>? scopedApiKeyActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0)
            {
                userActor?.Invoke(__value0);
            }
            else if (ScopedApiKeyActor is { } __value1)
            {
                scopedApiKeyActor?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaUserActorSchema>? userActor = null,
            global::System.Action<global::Anthropic.BetaScopedApiKeyActorSchema>? scopedApiKeyActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserActor is { } __value0)
            {
                userActor?.Invoke(__value0);
            }
            else if (ScopedApiKeyActor is { } __value1)
            {
                scopedApiKeyActor?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserActor,
                typeof(global::Anthropic.BetaUserActorSchema),
                ScopedApiKeyActor,
                typeof(global::Anthropic.BetaScopedApiKeyActorSchema),
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
        public bool Equals(Actor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUserActorSchema?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaScopedApiKeyActorSchema?>.Default.Equals(ScopedApiKeyActor, other.ScopedApiKeyActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Actor obj1, Actor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Actor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Actor obj1, Actor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Actor o && Equals(o);
        }
    }
}
