#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth : global::System.IEquatable<BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Token endpoint requires no client authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? None { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? None { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        /// Token endpoint uses HTTP Basic authentication with client credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? ClientSecretBasic { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? ClientSecretBasic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientSecretBasic))]
#endif
        public bool IsClientSecretBasic => ClientSecretBasic != null;

        /// <summary>
        /// Token endpoint uses POST body authentication with client credentials.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? ClientSecretPost { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? ClientSecretPost { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientSecretPost))]
#endif
        public bool IsClientSecretPost => ClientSecretPost != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse value) => new BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse?(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse value) => new BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse?(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth @this) => @this.ClientSecretBasic;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse value) => new BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse?(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth @this) => @this.ClientSecretPost;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth(
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse? none,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse? clientSecretBasic,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse? clientSecretPost
            )
        {
            Type = type;

            None = none;
            ClientSecretBasic = clientSecretBasic;
            ClientSecretPost = clientSecretPost;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientSecretPost as object ??
            ClientSecretBasic as object ??
            None as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            None?.ToString() ??
            ClientSecretBasic?.ToString() ??
            ClientSecretPost?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsNone && !IsClientSecretBasic && !IsClientSecretPost || !IsNone && IsClientSecretBasic && !IsClientSecretPost || !IsNone && !IsClientSecretBasic && IsClientSecretPost;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse?, TResult>? none = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse?, TResult>? clientSecretBasic = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse?, TResult>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsClientSecretBasic && clientSecretBasic != null)
            {
                return clientSecretBasic(ClientSecretBasic!);
            }
            else if (IsClientSecretPost && clientSecretPost != null)
            {
                return clientSecretPost(ClientSecretPost!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse?>? none = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse?>? clientSecretBasic = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse?>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsClientSecretBasic)
            {
                clientSecretBasic?.Invoke(ClientSecretBasic!);
            }
            else if (IsClientSecretPost)
            {
                clientSecretPost?.Invoke(ClientSecretPost!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                None,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse),
                ClientSecretBasic,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse),
                ClientSecretPost,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse),
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
        public bool Equals(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneResponse?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicResponse?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostResponse?>.Default.Equals(ClientSecretPost, other.ClientSecretPost) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMcpOauthRefreshResponseTokenEndpointAuth o && Equals(o);
        }
    }
}
