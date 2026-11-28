#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Who sent a message.
    /// </summary>
    public readonly partial struct BetaComplianceReviewActor : global::System.IEquatable<BetaComplianceReviewActor>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewActorDiscriminatorType? Type { get; }

        /// <summary>
        /// A signed-in user.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewUserActor? UserActor { get; }
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
            out global::Anthropic.BetaComplianceReviewUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewUserActor PickUserActor() => UserActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        /// An API key.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewApiActor? ApiActor { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewApiActor? ApiActor { get; }
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
            out global::Anthropic.BetaComplianceReviewApiActor? value)
        {
            value = ApiActor;
            return IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewApiActor PickApiActor() => ApiActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiActor' but the value was {ToString()}.");

        /// <summary>
        /// A service account.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComplianceReviewServiceAccountActor? ServiceAccountActor { get; init; }
#else
        public global::Anthropic.BetaComplianceReviewServiceAccountActor? ServiceAccountActor { get; }
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
            out global::Anthropic.BetaComplianceReviewServiceAccountActor? value)
        {
            value = ServiceAccountActor;
            return IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComplianceReviewServiceAccountActor PickServiceAccountActor() => ServiceAccountActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccountActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewUserActor value) => new BetaComplianceReviewActor((global::Anthropic.BetaComplianceReviewUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewUserActor?(BetaComplianceReviewActor @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewActor FromUserActor(global::Anthropic.BetaComplianceReviewUserActor? value) => new BetaComplianceReviewActor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewApiActor value) => new BetaComplianceReviewActor((global::Anthropic.BetaComplianceReviewApiActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewApiActor?(BetaComplianceReviewActor @this) => @this.ApiActor;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewApiActor? value)
        {
            ApiActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewActor FromApiActor(global::Anthropic.BetaComplianceReviewApiActor? value) => new BetaComplianceReviewActor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewServiceAccountActor value) => new BetaComplianceReviewActor((global::Anthropic.BetaComplianceReviewServiceAccountActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComplianceReviewServiceAccountActor?(BetaComplianceReviewActor @this) => @this.ServiceAccountActor;

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewActor(global::Anthropic.BetaComplianceReviewServiceAccountActor? value)
        {
            ServiceAccountActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaComplianceReviewActor FromServiceAccountActor(global::Anthropic.BetaComplianceReviewServiceAccountActor? value) => new BetaComplianceReviewActor(value);

        /// <summary>
        ///
        /// </summary>
        public BetaComplianceReviewActor(
            global::Anthropic.BetaComplianceReviewActorDiscriminatorType? type,
            global::Anthropic.BetaComplianceReviewUserActor? userActor,
            global::Anthropic.BetaComplianceReviewApiActor? apiActor,
            global::Anthropic.BetaComplianceReviewServiceAccountActor? serviceAccountActor
            )
        {
            Type = type;

            UserActor = userActor;
            ApiActor = apiActor;
            ServiceAccountActor = serviceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ServiceAccountActor as object ??
            ApiActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ApiActor?.ToString() ??
            ServiceAccountActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsApiActor && !IsServiceAccountActor || !IsUserActor && IsApiActor && !IsServiceAccountActor || !IsUserActor && !IsApiActor && IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaComplianceReviewUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaComplianceReviewApiActor, TResult>? apiActor = null,
            global::System.Func<global::Anthropic.BetaComplianceReviewServiceAccountActor, TResult>? serviceAccountActor = null,
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
            else if (ApiActor is { } __value1 && apiActor != null)
            {
                return apiActor(__value1);
            }
            else if (ServiceAccountActor is { } __value2 && serviceAccountActor != null)
            {
                return serviceAccountActor(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaComplianceReviewUserActor>? userActor = null,

            global::System.Action<global::Anthropic.BetaComplianceReviewApiActor>? apiActor = null,

            global::System.Action<global::Anthropic.BetaComplianceReviewServiceAccountActor>? serviceAccountActor = null,
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
            else if (ApiActor is { } __value1)
            {
                apiActor?.Invoke(__value1);
            }
            else if (ServiceAccountActor is { } __value2)
            {
                serviceAccountActor?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaComplianceReviewUserActor>? userActor = null,
            global::System.Action<global::Anthropic.BetaComplianceReviewApiActor>? apiActor = null,
            global::System.Action<global::Anthropic.BetaComplianceReviewServiceAccountActor>? serviceAccountActor = null,
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
            else if (ApiActor is { } __value1)
            {
                apiActor?.Invoke(__value1);
            }
            else if (ServiceAccountActor is { } __value2)
            {
                serviceAccountActor?.Invoke(__value2);
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
                typeof(global::Anthropic.BetaComplianceReviewUserActor),
                ApiActor,
                typeof(global::Anthropic.BetaComplianceReviewApiActor),
                ServiceAccountActor,
                typeof(global::Anthropic.BetaComplianceReviewServiceAccountActor),
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
        public bool Equals(BetaComplianceReviewActor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewApiActor?>.Default.Equals(ApiActor, other.ApiActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComplianceReviewServiceAccountActor?>.Default.Equals(ServiceAccountActor, other.ServiceAccountActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaComplianceReviewActor obj1, BetaComplianceReviewActor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaComplianceReviewActor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaComplianceReviewActor obj1, BetaComplianceReviewActor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaComplianceReviewActor o && Equals(o);
        }
    }
}
