#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The user or API key that performed the Claude Code actions.
    /// </summary>
    public readonly partial struct Actor : global::System.IEquatable<Actor>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeUserActor? UserActor { get; }
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
            out global::Anthropic.BetaClaudeCodeUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeUserActor PickUserActor() => IsUserActor
            ? UserActor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaClaudeCodeApiActor? ApiActor { get; init; }
#else
        public global::Anthropic.BetaClaudeCodeApiActor? ApiActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiActor))]
#endif
        public bool IsApiActor => ApiActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickApiActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaClaudeCodeApiActor? value)
        {
            value = ApiActor;
            return IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaClaudeCodeApiActor PickApiActor() => IsApiActor
            ? ApiActor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Actor(global::Anthropic.BetaClaudeCodeUserActor value) => new Actor((global::Anthropic.BetaClaudeCodeUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeUserActor?(Actor @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public Actor(global::Anthropic.BetaClaudeCodeUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Actor FromUserActor(global::Anthropic.BetaClaudeCodeUserActor? value) => new Actor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Actor(global::Anthropic.BetaClaudeCodeApiActor value) => new Actor((global::Anthropic.BetaClaudeCodeApiActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaClaudeCodeApiActor?(Actor @this) => @this.ApiActor;

        /// <summary>
        ///
        /// </summary>
        public Actor(global::Anthropic.BetaClaudeCodeApiActor? value)
        {
            ApiActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Actor FromApiActor(global::Anthropic.BetaClaudeCodeApiActor? value) => new Actor(value);

        /// <summary>
        ///
        /// </summary>
        public Actor(
            global::Anthropic.BetaClaudeCodeUsageReportItemActorDiscriminatorType? type,
            global::Anthropic.BetaClaudeCodeUserActor? userActor,
            global::Anthropic.BetaClaudeCodeApiActor? apiActor
            )
        {
            Type = type;

            UserActor = userActor;
            ApiActor = apiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApiActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ApiActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsApiActor || !IsUserActor && IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaClaudeCodeUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaClaudeCodeApiActor, TResult>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserActor && userActor != null)
            {
                return userActor(UserActor!);
            }
            else if (IsApiActor && apiActor != null)
            {
                return apiActor(ApiActor!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaClaudeCodeUserActor>? userActor = null,

            global::System.Action<global::Anthropic.BetaClaudeCodeApiActor>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserActor)
            {
                userActor?.Invoke(UserActor!);
            }
            else if (IsApiActor)
            {
                apiActor?.Invoke(ApiActor!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaClaudeCodeUserActor>? userActor = null,
            global::System.Action<global::Anthropic.BetaClaudeCodeApiActor>? apiActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUserActor)
            {
                userActor?.Invoke(UserActor!);
            }
            else if (IsApiActor)
            {
                apiActor?.Invoke(ApiActor!);
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
                typeof(global::Anthropic.BetaClaudeCodeUserActor),
                ApiActor,
                typeof(global::Anthropic.BetaClaudeCodeApiActor),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaClaudeCodeApiActor?>.Default.Equals(ApiActor, other.ApiActor)
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
