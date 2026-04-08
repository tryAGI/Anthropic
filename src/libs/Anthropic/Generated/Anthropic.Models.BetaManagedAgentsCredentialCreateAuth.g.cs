#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Authentication details for creating a credential.<br/>
    /// Example: {"type":"static_bearer","token":"bearer_exampletoken","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public readonly partial struct BetaManagedAgentsCredentialCreateAuth : global::System.IEquatable<BetaManagedAgentsCredentialCreateAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Parameters for creating an MCP OAuth credential.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? McpOauth { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? McpOauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpOauth))]
#endif
        public bool IsMcpOauth => McpOauth != null;

        /// <summary>
        /// Parameters for creating a static bearer token credential.<br/>
        /// Example: {"type":"static_bearer","token":"bearer_exampletoken","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? StaticBearer { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? StaticBearer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticBearer))]
#endif
        public bool IsStaticBearer => StaticBearer != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsMcpOauthCreateParams value) => new BetaManagedAgentsCredentialCreateAuth((global::Anthropic.BetaManagedAgentsMcpOauthCreateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpOauthCreateParams?(BetaManagedAgentsCredentialCreateAuth @this) => @this.McpOauth;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? value)
        {
            McpOauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsStaticBearerCreateParams value) => new BetaManagedAgentsCredentialCreateAuth((global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?(BetaManagedAgentsCredentialCreateAuth @this) => @this.StaticBearer;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialCreateAuth(
            global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? mcpOauth,
            global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? staticBearer
            )
        {
            Type = type;

            McpOauth = mcpOauth;
            StaticBearer = staticBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticBearer as object ??
            McpOauth as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            McpOauth?.ToString() ??
            StaticBearer?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcpOauth && !IsStaticBearer || !IsMcpOauth && IsStaticBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams?, TResult>? mcpOauth = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?, TResult>? staticBearer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpOauth && mcpOauth != null)
            {
                return mcpOauth(McpOauth!);
            }
            else if (IsStaticBearer && staticBearer != null)
            {
                return staticBearer(StaticBearer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams?>? mcpOauth = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?>? staticBearer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsMcpOauth)
            {
                mcpOauth?.Invoke(McpOauth!);
            }
            else if (IsStaticBearer)
            {
                staticBearer?.Invoke(StaticBearer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                McpOauth,
                typeof(global::Anthropic.BetaManagedAgentsMcpOauthCreateParams),
                StaticBearer,
                typeof(global::Anthropic.BetaManagedAgentsStaticBearerCreateParams),
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
        public bool Equals(BetaManagedAgentsCredentialCreateAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?>.Default.Equals(StaticBearer, other.StaticBearer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCredentialCreateAuth obj1, BetaManagedAgentsCredentialCreateAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCredentialCreateAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCredentialCreateAuth obj1, BetaManagedAgentsCredentialCreateAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCredentialCreateAuth o && Equals(o);
        }
    }
}
