#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Authentication details for a credential.<br/>
    /// Example: {"type":"static_bearer","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
    /// </summary>
    public readonly partial struct BetaManagedAgentsCredentialAuth : global::System.IEquatable<BetaManagedAgentsCredentialAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// OAuth credential details for an MCP server.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? McpOauth { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? McpOauth { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpOauth))]
#endif
        public bool IsMcpOauth => McpOauth != null;

        /// <summary>
        /// Static bearer token credential details for an MCP server.<br/>
        /// Example: {"type":"static_bearer","mcp_server_url":"https://example-server.modelcontextprotocol.io/sse"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? StaticBearer { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? StaticBearer { get; }
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
        public static implicit operator BetaManagedAgentsCredentialAuth(global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse value) => new BetaManagedAgentsCredentialAuth((global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse?(BetaManagedAgentsCredentialAuth @this) => @this.McpOauth;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialAuth(global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? value)
        {
            McpOauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialAuth(global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse value) => new BetaManagedAgentsCredentialAuth((global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse?(BetaManagedAgentsCredentialAuth @this) => @this.StaticBearer;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialAuth(global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialAuth(
            global::Anthropic.BetaManagedAgentsCredentialAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse? mcpOauth,
            global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse? staticBearer
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse?, TResult>? mcpOauth = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse?, TResult>? staticBearer = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse?>? mcpOauth = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse?>? staticBearer = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse),
                StaticBearer,
                typeof(global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse),
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
        public bool Equals(BetaManagedAgentsCredentialAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpOauthAuthResponse?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsStaticBearerAuthResponse?>.Default.Equals(StaticBearer, other.StaticBearer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCredentialAuth obj1, BetaManagedAgentsCredentialAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCredentialAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCredentialAuth obj1, BetaManagedAgentsCredentialAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCredentialAuth o && Equals(o);
        }
    }
}
