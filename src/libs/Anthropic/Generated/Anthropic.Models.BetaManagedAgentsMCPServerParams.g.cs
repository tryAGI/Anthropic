#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for MCP server connection definitions.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMCPServerParams : global::System.IEquatable<BetaManagedAgentsMCPServerParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// URL-based MCP server connection.<br/>
        /// Example: {"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Url { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsURLMCPServerParams? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsMCPServerParams(global::Anthropic.BetaManagedAgentsURLMCPServerParams value) => new BetaManagedAgentsMCPServerParams((global::Anthropic.BetaManagedAgentsURLMCPServerParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsURLMCPServerParams?(BetaManagedAgentsMCPServerParams @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMCPServerParams(global::Anthropic.BetaManagedAgentsURLMCPServerParams? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMCPServerParams(
            global::Anthropic.BetaManagedAgentsMCPServerParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsURLMCPServerParams? url
            )
        {
            Type = type;

            Url = url;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsURLMCPServerParams?, TResult>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsURLMCPServerParams?>? url = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::Anthropic.BetaManagedAgentsURLMCPServerParams),
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
        public bool Equals(BetaManagedAgentsMCPServerParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsURLMCPServerParams?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMCPServerParams obj1, BetaManagedAgentsMCPServerParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMCPServerParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMCPServerParams obj1, BetaManagedAgentsMCPServerParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMCPServerParams o && Equals(o);
        }
    }
}
