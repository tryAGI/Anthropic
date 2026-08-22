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
        /// 
        /// </summary>
        public bool TryPickMcpOauth(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? value)
        {
            value = McpOauth;
            return IsMcpOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthCreateParams PickMcpOauth() => IsMcpOauth
            ? McpOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpOauth' but the value was {ToString()}.");

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
        public bool TryPickStaticBearer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? value)
        {
            value = StaticBearer;
            return IsStaticBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerCreateParams PickStaticBearer() => IsStaticBearer
            ? StaticBearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticBearer' but the value was {ToString()}.");

        /// <summary>
        /// Parameters for creating an environment variable credential.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? EnvironmentVariable { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? EnvironmentVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EnvironmentVariable))]
#endif
        public bool IsEnvironmentVariable => EnvironmentVariable != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickEnvironmentVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");
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
        public static BetaManagedAgentsCredentialCreateAuth FromMcpOauth(global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? value) => new BetaManagedAgentsCredentialCreateAuth(value);

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
        public static BetaManagedAgentsCredentialCreateAuth FromStaticBearer(global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? value) => new BetaManagedAgentsCredentialCreateAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams value) => new BetaManagedAgentsCredentialCreateAuth((global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams?(BetaManagedAgentsCredentialCreateAuth @this) => @this.EnvironmentVariable;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialCreateAuth(global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialCreateAuth FromEnvironmentVariable(global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? value) => new BetaManagedAgentsCredentialCreateAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialCreateAuth(
            global::Anthropic.BetaManagedAgentsCredentialCreateAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMcpOauthCreateParams? mcpOauth,
            global::Anthropic.BetaManagedAgentsStaticBearerCreateParams? staticBearer,
            global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams? environmentVariable
            )
        {
            Type = type;

            McpOauth = mcpOauth;
            StaticBearer = staticBearer;
            EnvironmentVariable = environmentVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            EnvironmentVariable as object ??
            StaticBearer as object ??
            McpOauth as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            McpOauth?.ToString() ??
            StaticBearer?.ToString() ??
            EnvironmentVariable?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsMcpOauth && !IsStaticBearer && !IsEnvironmentVariable || !IsMcpOauth && IsStaticBearer && !IsEnvironmentVariable || !IsMcpOauth && !IsStaticBearer && IsEnvironmentVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams, TResult>? mcpOauth = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams, TResult>? staticBearer = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams, TResult>? environmentVariable = null,
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
            else if (IsEnvironmentVariable && environmentVariable != null)
            {
                return environmentVariable(EnvironmentVariable!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams>? mcpOauth = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams>? staticBearer = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams>? environmentVariable = null,
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
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthCreateParams>? mcpOauth = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams>? staticBearer = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams>? environmentVariable = null,
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
            else if (IsEnvironmentVariable)
            {
                environmentVariable?.Invoke(EnvironmentVariable!);
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
                EnvironmentVariable,
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams),
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
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsStaticBearerCreateParams?>.Default.Equals(StaticBearer, other.StaticBearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentVariableCreateParams?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable) 
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
