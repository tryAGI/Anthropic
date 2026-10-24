#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaAnalyticsReportActor : global::System.IEquatable<BetaAnalyticsReportActor>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsReportUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaAnalyticsReportUserActor? UserActor { get; }
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
            out global::Anthropic.BetaAnalyticsReportUserActor? value)
        {
            value = UserActor;
            return IsUserActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsReportUserActor PickUserActor() => UserActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsServiceAccountActor? ServiceAccountActor { get; init; }
#else
        public global::Anthropic.BetaAnalyticsServiceAccountActor? ServiceAccountActor { get; }
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
            out global::Anthropic.BetaAnalyticsServiceAccountActor? value)
        {
            value = ServiceAccountActor;
            return IsServiceAccountActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsServiceAccountActor PickServiceAccountActor() => ServiceAccountActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ServiceAccountActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsFederatedActor? FederatedActor { get; init; }
#else
        public global::Anthropic.BetaAnalyticsFederatedActor? FederatedActor { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FederatedActor))]
#endif
        public bool IsFederatedActor => FederatedActor != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFederatedActor(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAnalyticsFederatedActor? value)
        {
            value = FederatedActor;
            return IsFederatedActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsFederatedActor PickFederatedActor() => FederatedActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FederatedActor' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAnalyticsApiActor? ApiActor { get; init; }
#else
        public global::Anthropic.BetaAnalyticsApiActor? ApiActor { get; }
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
            out global::Anthropic.BetaAnalyticsApiActor? value)
        {
            value = ApiActor;
            return IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAnalyticsApiActor PickApiActor() => ApiActor is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiActor' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsReportUserActor value) => new BetaAnalyticsReportActor((global::Anthropic.BetaAnalyticsReportUserActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsReportUserActor?(BetaAnalyticsReportActor @this) => @this.UserActor;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsReportUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsReportActor FromUserActor(global::Anthropic.BetaAnalyticsReportUserActor? value) => new BetaAnalyticsReportActor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsServiceAccountActor value) => new BetaAnalyticsReportActor((global::Anthropic.BetaAnalyticsServiceAccountActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsServiceAccountActor?(BetaAnalyticsReportActor @this) => @this.ServiceAccountActor;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsServiceAccountActor? value)
        {
            ServiceAccountActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsReportActor FromServiceAccountActor(global::Anthropic.BetaAnalyticsServiceAccountActor? value) => new BetaAnalyticsReportActor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsFederatedActor value) => new BetaAnalyticsReportActor((global::Anthropic.BetaAnalyticsFederatedActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsFederatedActor?(BetaAnalyticsReportActor @this) => @this.FederatedActor;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsFederatedActor? value)
        {
            FederatedActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsReportActor FromFederatedActor(global::Anthropic.BetaAnalyticsFederatedActor? value) => new BetaAnalyticsReportActor(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsApiActor value) => new BetaAnalyticsReportActor((global::Anthropic.BetaAnalyticsApiActor?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAnalyticsApiActor?(BetaAnalyticsReportActor @this) => @this.ApiActor;

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsReportActor(global::Anthropic.BetaAnalyticsApiActor? value)
        {
            ApiActor = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaAnalyticsReportActor FromApiActor(global::Anthropic.BetaAnalyticsApiActor? value) => new BetaAnalyticsReportActor(value);

        /// <summary>
        ///
        /// </summary>
        public BetaAnalyticsReportActor(
            global::Anthropic.BetaAnalyticsReportActorDiscriminatorType? type,
            global::Anthropic.BetaAnalyticsReportUserActor? userActor,
            global::Anthropic.BetaAnalyticsServiceAccountActor? serviceAccountActor,
            global::Anthropic.BetaAnalyticsFederatedActor? federatedActor,
            global::Anthropic.BetaAnalyticsApiActor? apiActor
            )
        {
            Type = type;

            UserActor = userActor;
            ServiceAccountActor = serviceAccountActor;
            FederatedActor = federatedActor;
            ApiActor = apiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ApiActor as object ??
            FederatedActor as object ??
            ServiceAccountActor as object ??
            UserActor as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserActor?.ToString() ??
            ServiceAccountActor?.ToString() ??
            FederatedActor?.ToString() ??
            ApiActor?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserActor && !IsServiceAccountActor && !IsFederatedActor && !IsApiActor || !IsUserActor && IsServiceAccountActor && !IsFederatedActor && !IsApiActor || !IsUserActor && !IsServiceAccountActor && IsFederatedActor && !IsApiActor || !IsUserActor && !IsServiceAccountActor && !IsFederatedActor && IsApiActor;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaAnalyticsReportUserActor, TResult>? userActor = null,
            global::System.Func<global::Anthropic.BetaAnalyticsServiceAccountActor, TResult>? serviceAccountActor = null,
            global::System.Func<global::Anthropic.BetaAnalyticsFederatedActor, TResult>? federatedActor = null,
            global::System.Func<global::Anthropic.BetaAnalyticsApiActor, TResult>? apiActor = null,
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
            else if (FederatedActor is { } __value2 && federatedActor != null)
            {
                return federatedActor(__value2);
            }
            else if (ApiActor is { } __value3 && apiActor != null)
            {
                return apiActor(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaAnalyticsReportUserActor>? userActor = null,

            global::System.Action<global::Anthropic.BetaAnalyticsServiceAccountActor>? serviceAccountActor = null,

            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActor>? federatedActor = null,

            global::System.Action<global::Anthropic.BetaAnalyticsApiActor>? apiActor = null,
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
            else if (FederatedActor is { } __value2)
            {
                federatedActor?.Invoke(__value2);
            }
            else if (ApiActor is { } __value3)
            {
                apiActor?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaAnalyticsReportUserActor>? userActor = null,
            global::System.Action<global::Anthropic.BetaAnalyticsServiceAccountActor>? serviceAccountActor = null,
            global::System.Action<global::Anthropic.BetaAnalyticsFederatedActor>? federatedActor = null,
            global::System.Action<global::Anthropic.BetaAnalyticsApiActor>? apiActor = null,
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
            else if (FederatedActor is { } __value2)
            {
                federatedActor?.Invoke(__value2);
            }
            else if (ApiActor is { } __value3)
            {
                apiActor?.Invoke(__value3);
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
                typeof(global::Anthropic.BetaAnalyticsReportUserActor),
                ServiceAccountActor,
                typeof(global::Anthropic.BetaAnalyticsServiceAccountActor),
                FederatedActor,
                typeof(global::Anthropic.BetaAnalyticsFederatedActor),
                ApiActor,
                typeof(global::Anthropic.BetaAnalyticsApiActor),
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
        public bool Equals(BetaAnalyticsReportActor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsReportUserActor?>.Default.Equals(UserActor, other.UserActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsServiceAccountActor?>.Default.Equals(ServiceAccountActor, other.ServiceAccountActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsFederatedActor?>.Default.Equals(FederatedActor, other.FederatedActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAnalyticsApiActor?>.Default.Equals(ApiActor, other.ApiActor)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaAnalyticsReportActor obj1, BetaAnalyticsReportActor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaAnalyticsReportActor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaAnalyticsReportActor obj1, BetaAnalyticsReportActor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaAnalyticsReportActor o && Equals(o);
        }
    }
}
