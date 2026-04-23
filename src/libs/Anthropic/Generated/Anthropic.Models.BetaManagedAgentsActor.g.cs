#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsActor : global::System.IEquatable<BetaManagedAgentsActor>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsActorDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsSessionActor? SessionActor { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsSessionActor? SessionActor { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionActor))]
#endif
        public bool IsSessionActor => SessionActor != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsApiActor? ApiActor { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsApiActor? ApiActor { get; }
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
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsUserActor? UserActor { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsUserActor? UserActor { get; }
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
        public static implicit operator BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsSessionActor value) => new BetaManagedAgentsActor((global::Anthropic.BetaManagedAgentsSessionActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsSessionActor?(BetaManagedAgentsActor @this) => @this.SessionActor;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsSessionActor? value)
        {
            SessionActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsApiActor value) => new BetaManagedAgentsActor((global::Anthropic.BetaManagedAgentsApiActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsApiActor?(BetaManagedAgentsActor @this) => @this.ApiActor;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsApiActor? value)
        {
            ApiActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsUserActor value) => new BetaManagedAgentsActor((global::Anthropic.BetaManagedAgentsUserActor?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsUserActor?(BetaManagedAgentsActor @this) => @this.UserActor;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsActor(global::Anthropic.BetaManagedAgentsUserActor? value)
        {
            UserActor = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsActor(
            global::Anthropic.BetaManagedAgentsActorDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsSessionActor? sessionActor,
            global::Anthropic.BetaManagedAgentsApiActor? apiActor,
            global::Anthropic.BetaManagedAgentsUserActor? userActor
            )
        {
            Type = type;

            SessionActor = sessionActor;
            ApiActor = apiActor;
            UserActor = userActor;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            UserActor as object ??
            ApiActor as object ??
            SessionActor as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionActor?.ToString() ??
            ApiActor?.ToString() ??
            UserActor?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionActor && !IsApiActor && !IsUserActor || !IsSessionActor && IsApiActor && !IsUserActor || !IsSessionActor && !IsApiActor && IsUserActor;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsSessionActor?, TResult>? sessionActor = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsApiActor?, TResult>? apiActor = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsUserActor?, TResult>? userActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionActor && sessionActor != null)
            {
                return sessionActor(SessionActor!);
            }
            else if (IsApiActor && apiActor != null)
            {
                return apiActor(ApiActor!);
            }
            else if (IsUserActor && userActor != null)
            {
                return userActor(UserActor!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsSessionActor?>? sessionActor = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsApiActor?>? apiActor = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsUserActor?>? userActor = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionActor)
            {
                sessionActor?.Invoke(SessionActor!);
            }
            else if (IsApiActor)
            {
                apiActor?.Invoke(ApiActor!);
            }
            else if (IsUserActor)
            {
                userActor?.Invoke(UserActor!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionActor,
                typeof(global::Anthropic.BetaManagedAgentsSessionActor),
                ApiActor,
                typeof(global::Anthropic.BetaManagedAgentsApiActor),
                UserActor,
                typeof(global::Anthropic.BetaManagedAgentsUserActor),
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
        public bool Equals(BetaManagedAgentsActor other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsSessionActor?>.Default.Equals(SessionActor, other.SessionActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsApiActor?>.Default.Equals(ApiActor, other.ApiActor) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsUserActor?>.Default.Equals(UserActor, other.UserActor) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsActor obj1, BetaManagedAgentsActor obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsActor>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsActor obj1, BetaManagedAgentsActor obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsActor o && Equals(o);
        }
    }
}
