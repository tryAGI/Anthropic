#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Updated authentication details for a credential.
    /// </summary>
    public readonly partial struct BetaManagedAgentsCredentialUpdateAuth : global::System.IEquatable<BetaManagedAgentsCredentialUpdateAuth>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? Type { get; }

        /// <summary>
        /// Parameters for updating an MCP OAuth credential. The `mcp_server_url` is immutable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? McpOauth { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? McpOauth { get; }
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
            out global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? value)
        {
            value = McpOauth;
            return IsMcpOauth;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams PickMcpOauth() => IsMcpOauth
            ? McpOauth!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpOauth' but the value was {ToString()}.");

        /// <summary>
        /// Parameters for updating a static bearer token credential. The `mcp_server_url` is immutable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? StaticBearer { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? StaticBearer { get; }
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
            out global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? value)
        {
            value = StaticBearer;
            return IsStaticBearer;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams PickStaticBearer() => IsStaticBearer
            ? StaticBearer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StaticBearer' but the value was {ToString()}.");

        /// <summary>
        /// Parameters for updating an environment variable credential. `secret_name` is immutable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? EnvironmentVariable { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? EnvironmentVariable { get; }
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
            out global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? value)
        {
            value = EnvironmentVariable;
            return IsEnvironmentVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams PickEnvironmentVariable() => IsEnvironmentVariable
            ? EnvironmentVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'EnvironmentVariable' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams value) => new BetaManagedAgentsCredentialUpdateAuth((global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams?(BetaManagedAgentsCredentialUpdateAuth @this) => @this.McpOauth;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? value)
        {
            McpOauth = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialUpdateAuth FromMcpOauth(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? value) => new BetaManagedAgentsCredentialUpdateAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams value) => new BetaManagedAgentsCredentialUpdateAuth((global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams?(BetaManagedAgentsCredentialUpdateAuth @this) => @this.StaticBearer;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? value)
        {
            StaticBearer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialUpdateAuth FromStaticBearer(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? value) => new BetaManagedAgentsCredentialUpdateAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams value) => new BetaManagedAgentsCredentialUpdateAuth((global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams?(BetaManagedAgentsCredentialUpdateAuth @this) => @this.EnvironmentVariable;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialUpdateAuth(global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? value)
        {
            EnvironmentVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsCredentialUpdateAuth FromEnvironmentVariable(global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? value) => new BetaManagedAgentsCredentialUpdateAuth(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsCredentialUpdateAuth(
            global::Anthropic.BetaManagedAgentsCredentialUpdateAuthDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams? mcpOauth,
            global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams? staticBearer,
            global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams? environmentVariable
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams, TResult>? mcpOauth = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams, TResult>? staticBearer = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams, TResult>? environmentVariable = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams>? mcpOauth = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams>? staticBearer = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams>? environmentVariable = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams>? mcpOauth = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams>? staticBearer = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams>? environmentVariable = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams),
                StaticBearer,
                typeof(global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams),
                EnvironmentVariable,
                typeof(global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams),
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
        public bool Equals(BetaManagedAgentsCredentialUpdateAuth other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMcpOauthUpdateParams?>.Default.Equals(McpOauth, other.McpOauth) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsStaticBearerUpdateParams?>.Default.Equals(StaticBearer, other.StaticBearer) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEnvironmentVariableUpdateParams?>.Default.Equals(EnvironmentVariable, other.EnvironmentVariable) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsCredentialUpdateAuth obj1, BetaManagedAgentsCredentialUpdateAuth obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsCredentialUpdateAuth>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsCredentialUpdateAuth obj1, BetaManagedAgentsCredentialUpdateAuth obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsCredentialUpdateAuth o && Equals(o);
        }
    }
}
