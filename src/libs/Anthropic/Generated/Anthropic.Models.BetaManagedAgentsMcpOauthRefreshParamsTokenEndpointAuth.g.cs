#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth : global::System.IEquatable<BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Token endpoint requires no client authentication.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? None { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? None { get; }
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
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? ClientSecretBasic { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? ClientSecretBasic { get; }
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
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? ClientSecretPost { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? ClientSecretPost { get; }
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
        public static implicit operator BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam value) => new BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam?(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth @this) => @this.None;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? value)
        {
            None = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam value) => new BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam?(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth @this) => @this.ClientSecretBasic;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam value) => new BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam?(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth @this) => @this.ClientSecretPost;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth(
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam? none,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam? clientSecretBasic,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam? clientSecretPost
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
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam?, TResult>? none = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam?, TResult>? clientSecretBasic = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam?, TResult>? clientSecretPost = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam?>? none = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam?>? clientSecretBasic = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam?>? clientSecretPost = null,
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
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam),
                ClientSecretBasic,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam),
                ClientSecretPost,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam),
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
        public bool Equals(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthNoneParam?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicParam?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostParam?>.Default.Equals(ClientSecretPost, other.ClientSecretPost) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMcpOauthRefreshParamsTokenEndpointAuth o && Equals(o);
        }
    }
}
