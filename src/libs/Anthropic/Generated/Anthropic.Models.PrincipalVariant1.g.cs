#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PrincipalVariant1 : global::System.IEquatable<PrincipalVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaApiKeyUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaApiKeyUserActor? UserActor { get; }
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
            out global::Anthropic.BetaApiKeyUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyUserActor PickUserActor() => IsUserActor
            ? UserActor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaApiKeyServiceAccountActor? ServiceAccountActor { get; init; }
#else
        public global::Anthropic.BetaApiKeyServiceAccountActor? ServiceAccountActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ServiceAccountActor))]
#endif
        public bool IsServiceAccountActor => ServiceAccountActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickServiceAccountActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaApiKeyServiceAccountActor? value)
        {
            value = ServiceAccountActor;
            return IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaApiKeyServiceAccountActor PickServiceAccountActor() => IsServiceAccountActor
            ? ServiceAccountActor!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccountActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PrincipalVariant1(global::Anthropic.BetaApiKeyUserActor value) => new PrincipalVariant1((global::Anthropic.BetaApiKeyUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaApiKeyUserActor?(PrincipalVariant1 @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant1(global::Anthropic.BetaApiKeyUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PrincipalVariant1 FromUserActor(global::Anthropic.BetaApiKeyUserActor? value) => new PrincipalVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PrincipalVariant1(global::Anthropic.BetaApiKeyServiceAccountActor value) => new PrincipalVariant1((global::Anthropic.BetaApiKeyServiceAccountActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaApiKeyServiceAccountActor?(PrincipalVariant1 @this) => @this.ServiceAccountActor;

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant1(global::Anthropic.BetaApiKeyServiceAccountActor? value)
        {
            ServiceAccountActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PrincipalVariant1 FromServiceAccountActor(global::Anthropic.BetaApiKeyServiceAccountActor? value) => new PrincipalVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant1(
            global::Anthropic.BetaApiKeyPrincipalVariant1DiscriminatorType? type,
            global::Anthropic.BetaApiKeyUserActor? userActor,
            global::Anthropic.BetaApiKeyServiceAccountActor? serviceAccountActor
            )
        {
            Type = type;

            UserActor = userActor;
            ServiceAccountActor = serviceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServiceAccountActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ServiceAccountActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsServiceAccountActor || !IsUserActor && IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaApiKeyUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaApiKeyServiceAccountActor, TResult>? serviceAccountActor = null,
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
            else if (IsServiceAccountActor && serviceAccountActor != null)
            {
                return serviceAccountActor(ServiceAccountActor!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaApiKeyUserActor>? userActor = null,

            global::System.Action<global::Anthropic.BetaApiKeyServiceAccountActor>? serviceAccountActor = null,
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
            else if (IsServiceAccountActor)
            {
                serviceAccountActor?.Invoke(ServiceAccountActor!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaApiKeyUserActor>? userActor = null,
            global::System.Action<global::Anthropic.BetaApiKeyServiceAccountActor>? serviceAccountActor = null,
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
            else if (IsServiceAccountActor)
            {
                serviceAccountActor?.Invoke(ServiceAccountActor!);
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
                typeof(global::Anthropic.BetaApiKeyUserActor),
                ServiceAccountActor,
                typeof(global::Anthropic.BetaApiKeyServiceAccountActor),
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
        public bool Equals(PrincipalVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaApiKeyUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaApiKeyServiceAccountActor?>.Default.Equals(ServiceAccountActor, other.ServiceAccountActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PrincipalVariant1 obj1, PrincipalVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrincipalVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrincipalVariant1 obj1, PrincipalVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrincipalVariant1 o && Equals(o);
        }
    }
}
