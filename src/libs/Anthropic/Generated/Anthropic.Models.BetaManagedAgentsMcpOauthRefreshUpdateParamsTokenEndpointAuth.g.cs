#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth : global::System.IEquatable<BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Updated HTTP Basic authentication parameters for the token endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? ClientSecretBasic { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? ClientSecretBasic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientSecretBasic))]
#endif
        public bool IsClientSecretBasic => ClientSecretBasic != null;

        /// <summary>
        /// Updated POST body authentication parameters for the token endpoint.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? ClientSecretPost { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? ClientSecretPost { get; }
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
        public static implicit operator BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam value) => new BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam?(BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth @this) => @this.ClientSecretBasic;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? value)
        {
            ClientSecretBasic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam value) => new BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth((global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam?(BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth @this) => @this.ClientSecretPost;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? value)
        {
            ClientSecretPost = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth(
            global::Anthropic.BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam? clientSecretBasic,
            global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam? clientSecretPost
            )
        {
            Type = type;

            ClientSecretBasic = clientSecretBasic;
            ClientSecretPost = clientSecretPost;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ClientSecretPost as object ??
            ClientSecretBasic as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ClientSecretBasic?.ToString() ??
            ClientSecretPost?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsClientSecretBasic && !IsClientSecretPost || !IsClientSecretBasic && IsClientSecretPost;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam?, TResult>? clientSecretBasic = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam?, TResult>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientSecretBasic && clientSecretBasic != null)
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
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam?>? clientSecretBasic = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam?>? clientSecretPost = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsClientSecretBasic)
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
                ClientSecretBasic,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam),
                ClientSecretPost,
                typeof(global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam),
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
        public bool Equals(BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthBasicUpdateParam?>.Default.Equals(ClientSecretBasic, other.ClientSecretBasic) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsTokenEndpointAuthPostUpdateParam?>.Default.Equals(ClientSecretPost, other.ClientSecretPost) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth obj1, BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMcpOauthRefreshUpdateParamsTokenEndpointAuth o && Equals(o);
        }
    }
}
