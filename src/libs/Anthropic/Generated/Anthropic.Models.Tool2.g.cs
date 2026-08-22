#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Tool2 : global::System.IEquatable<Tool2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? Type { get; }

        /// <summary>
        /// Reference to a single tool the caller declared directly in<br/>
        /// ``tools[]``. Does not accept the composed ``{server}_{name}`` form the<br/>
        /// server assigns to MCP-resolved tools — use ``mcp_tool_reference`` or<br/>
        /// ``mcp_toolset_reference`` for those.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChangeToolReference? ToolReference { get; init; }
#else
        public global::Anthropic.BetaToolChangeToolReference? ToolReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolReference))]
#endif
        public bool IsToolReference => ToolReference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickToolReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolChangeToolReference? value)
        {
            value = ToolReference;
            return IsToolReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaToolChangeToolReference PickToolReference() => IsToolReference
            ? ToolReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolReference' but the value was {ToString()}.");

        /// <summary>
        /// Reference to a single MCP tool by its server and remote name — the<br/>
        /// same ``server_name``/``name`` pair ``mcp_tool_use`` carries.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChangeMCPToolReference? McpToolReference { get; init; }
#else
        public global::Anthropic.BetaToolChangeMCPToolReference? McpToolReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolReference))]
#endif
        public bool IsMcpToolReference => McpToolReference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpToolReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolChangeMCPToolReference? value)
        {
            value = McpToolReference;
            return IsMcpToolReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolReference PickMcpToolReference() => IsMcpToolReference
            ? McpToolReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolReference' but the value was {ToString()}.");

        /// <summary>
        /// Reference to every tool in the named MCP server's toolset.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChangeMCPToolsetReference? McpToolsetReference { get; init; }
#else
        public global::Anthropic.BetaToolChangeMCPToolsetReference? McpToolsetReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(McpToolsetReference))]
#endif
        public bool IsMcpToolsetReference => McpToolsetReference != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcpToolsetReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolChangeMCPToolsetReference? value)
        {
            value = McpToolsetReference;
            return IsMcpToolsetReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaToolChangeMCPToolsetReference PickMcpToolsetReference() => IsMcpToolsetReference
            ? McpToolsetReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolsetReference' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool2(global::Anthropic.BetaToolChangeToolReference value) => new Tool2((global::Anthropic.BetaToolChangeToolReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeToolReference?(Tool2 @this) => @this.ToolReference;

        /// <summary>
        /// 
        /// </summary>
        public Tool2(global::Anthropic.BetaToolChangeToolReference? value)
        {
            ToolReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool2 FromToolReference(global::Anthropic.BetaToolChangeToolReference? value) => new Tool2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool2(global::Anthropic.BetaToolChangeMCPToolReference value) => new Tool2((global::Anthropic.BetaToolChangeMCPToolReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeMCPToolReference?(Tool2 @this) => @this.McpToolReference;

        /// <summary>
        /// 
        /// </summary>
        public Tool2(global::Anthropic.BetaToolChangeMCPToolReference? value)
        {
            McpToolReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool2 FromMcpToolReference(global::Anthropic.BetaToolChangeMCPToolReference? value) => new Tool2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Tool2(global::Anthropic.BetaToolChangeMCPToolsetReference value) => new Tool2((global::Anthropic.BetaToolChangeMCPToolsetReference?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeMCPToolsetReference?(Tool2 @this) => @this.McpToolsetReference;

        /// <summary>
        /// 
        /// </summary>
        public Tool2(global::Anthropic.BetaToolChangeMCPToolsetReference? value)
        {
            McpToolsetReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Tool2 FromMcpToolsetReference(global::Anthropic.BetaToolChangeMCPToolsetReference? value) => new Tool2(value);

        /// <summary>
        /// 
        /// </summary>
        public Tool2(
            global::Anthropic.BetaRequestToolRemovalBlockToolDiscriminatorType? type,
            global::Anthropic.BetaToolChangeToolReference? toolReference,
            global::Anthropic.BetaToolChangeMCPToolReference? mcpToolReference,
            global::Anthropic.BetaToolChangeMCPToolsetReference? mcpToolsetReference
            )
        {
            Type = type;

            ToolReference = toolReference;
            McpToolReference = mcpToolReference;
            McpToolsetReference = mcpToolsetReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            McpToolsetReference as object ??
            McpToolReference as object ??
            ToolReference as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ToolReference?.ToString() ??
            McpToolReference?.ToString() ??
            McpToolsetReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsToolReference && !IsMcpToolReference && !IsMcpToolsetReference || !IsToolReference && IsMcpToolReference && !IsMcpToolsetReference || !IsToolReference && !IsMcpToolReference && IsMcpToolsetReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaToolChangeToolReference, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.BetaToolChangeMCPToolReference, TResult>? mcpToolReference = null,
            global::System.Func<global::Anthropic.BetaToolChangeMCPToolsetReference, TResult>? mcpToolsetReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolReference && toolReference != null)
            {
                return toolReference(ToolReference!);
            }
            else if (IsMcpToolReference && mcpToolReference != null)
            {
                return mcpToolReference(McpToolReference!);
            }
            else if (IsMcpToolsetReference && mcpToolsetReference != null)
            {
                return mcpToolsetReference(McpToolsetReference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaToolChangeToolReference>? toolReference = null,

            global::System.Action<global::Anthropic.BetaToolChangeMCPToolReference>? mcpToolReference = null,

            global::System.Action<global::Anthropic.BetaToolChangeMCPToolsetReference>? mcpToolsetReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolReference)
            {
                toolReference?.Invoke(ToolReference!);
            }
            else if (IsMcpToolReference)
            {
                mcpToolReference?.Invoke(McpToolReference!);
            }
            else if (IsMcpToolsetReference)
            {
                mcpToolsetReference?.Invoke(McpToolsetReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaToolChangeToolReference>? toolReference = null,
            global::System.Action<global::Anthropic.BetaToolChangeMCPToolReference>? mcpToolReference = null,
            global::System.Action<global::Anthropic.BetaToolChangeMCPToolsetReference>? mcpToolsetReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsToolReference)
            {
                toolReference?.Invoke(ToolReference!);
            }
            else if (IsMcpToolReference)
            {
                mcpToolReference?.Invoke(McpToolReference!);
            }
            else if (IsMcpToolsetReference)
            {
                mcpToolsetReference?.Invoke(McpToolsetReference!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ToolReference,
                typeof(global::Anthropic.BetaToolChangeToolReference),
                McpToolReference,
                typeof(global::Anthropic.BetaToolChangeMCPToolReference),
                McpToolsetReference,
                typeof(global::Anthropic.BetaToolChangeMCPToolsetReference),
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
        public bool Equals(Tool2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeToolReference?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeMCPToolReference?>.Default.Equals(McpToolReference, other.McpToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeMCPToolsetReference?>.Default.Equals(McpToolsetReference, other.McpToolsetReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Tool2 obj1, Tool2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Tool2 obj1, Tool2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool2 o && Equals(o);
        }
    }
}
