#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union type for MCP server connection definitions returned in API responses.
    /// </summary>
    public readonly partial struct BetaManagedAgentsMCPServer : global::System.IEquatable<BetaManagedAgentsMCPServer>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? Type { get; }

        /// <summary>
        /// URL-based MCP server connection as returned in API responses.<br/>
        /// Example: {"type":"url","name":"example-mcp","url":"https://example-server.modelcontextprotocol.io/sse"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Url { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? Url { get; }
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
        public static implicit operator BetaManagedAgentsMCPServer(global::Anthropic.BetaManagedAgentsMCPServerURLDefinition value) => new BetaManagedAgentsMCPServer((global::Anthropic.BetaManagedAgentsMCPServerURLDefinition?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMCPServerURLDefinition?(BetaManagedAgentsMCPServer @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMCPServer(global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsMCPServer(
            global::Anthropic.BetaManagedAgentsMCPServerDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsMCPServerURLDefinition? url
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
            global::System.Func<global::Anthropic.BetaManagedAgentsMCPServerURLDefinition?, TResult>? url = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsMCPServerURLDefinition?>? url = null,
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
                typeof(global::Anthropic.BetaManagedAgentsMCPServerURLDefinition),
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
        public bool Equals(BetaManagedAgentsMCPServer other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMCPServerURLDefinition?>.Default.Equals(Url, other.Url) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsMCPServer obj1, BetaManagedAgentsMCPServer obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsMCPServer>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsMCPServer obj1, BetaManagedAgentsMCPServer obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsMCPServer o && Equals(o);
        }
    }
}
