#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PrincipalVariant12 : global::System.IEquatable<PrincipalVariant12>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ApiKeyUserActor? UserActor { get; init; }
#else
        public global::Anthropic.ApiKeyUserActor? UserActor { get; }
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
            out global::Anthropic.ApiKeyUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyUserActor PickUserActor() => UserActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.ApiKeyServiceAccountActor? ServiceAccountActor { get; init; }
#else
        public global::Anthropic.ApiKeyServiceAccountActor? ServiceAccountActor { get; }
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
            out global::Anthropic.ApiKeyServiceAccountActor? value)
        {
            value = ServiceAccountActor;
            return IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ApiKeyServiceAccountActor PickServiceAccountActor() => ServiceAccountActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccountActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PrincipalVariant12(global::Anthropic.ApiKeyUserActor value) => new PrincipalVariant12((global::Anthropic.ApiKeyUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ApiKeyUserActor?(PrincipalVariant12 @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant12(global::Anthropic.ApiKeyUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PrincipalVariant12 FromUserActor(global::Anthropic.ApiKeyUserActor? value) => new PrincipalVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PrincipalVariant12(global::Anthropic.ApiKeyServiceAccountActor value) => new PrincipalVariant12((global::Anthropic.ApiKeyServiceAccountActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ApiKeyServiceAccountActor?(PrincipalVariant12 @this) => @this.ServiceAccountActor;

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant12(global::Anthropic.ApiKeyServiceAccountActor? value)
        {
            ServiceAccountActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PrincipalVariant12 FromServiceAccountActor(global::Anthropic.ApiKeyServiceAccountActor? value) => new PrincipalVariant12(value);

        /// <summary>
        ///
        /// </summary>
        public PrincipalVariant12(
            global::Anthropic.ApiKeyPrincipalVariant1DiscriminatorType? type,
            global::Anthropic.ApiKeyUserActor? userActor,
            global::Anthropic.ApiKeyServiceAccountActor? serviceAccountActor
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
            global::System.Func<global::Anthropic.ApiKeyUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.ApiKeyServiceAccountActor, TResult>? serviceAccountActor = null,
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
            else if (ServiceAccountActor is { } __value1 && serviceAccountActor != null)
            {
                return serviceAccountActor(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.ApiKeyUserActor>? userActor = null,

            global::System.Action<global::Anthropic.ApiKeyServiceAccountActor>? serviceAccountActor = null,
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
            else if (ServiceAccountActor is { } __value1)
            {
                serviceAccountActor?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.ApiKeyUserActor>? userActor = null,
            global::System.Action<global::Anthropic.ApiKeyServiceAccountActor>? serviceAccountActor = null,
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
            else if (ServiceAccountActor is { } __value1)
            {
                serviceAccountActor?.Invoke(__value1);
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
                typeof(global::Anthropic.ApiKeyUserActor),
                ServiceAccountActor,
                typeof(global::Anthropic.ApiKeyServiceAccountActor),
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
        public bool Equals(PrincipalVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ApiKeyUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ApiKeyServiceAccountActor?>.Default.Equals(ServiceAccountActor, other.ServiceAccountActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PrincipalVariant12 obj1, PrincipalVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PrincipalVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PrincipalVariant12 obj1, PrincipalVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PrincipalVariant12 o && Equals(o);
        }
    }
}
