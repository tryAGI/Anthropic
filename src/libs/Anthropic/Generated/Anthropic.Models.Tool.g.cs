#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Tool : global::System.IEquatable<Tool>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? Type { get; }

        /// <summary>
        /// Reference to a single tool, by the name the model uses to call it: a<br/>
        /// tool declared in ``tools`` or defined by an earlier ``tool_addition``<br/>
        /// block. Does not accept the composed ``{server}_{name}`` form the server<br/>
        /// assigns to MCP-resolved tools; use ``mcp_tool_reference`` or<br/>
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
        /// Reference to a single MCP tool by its server and remote name; the<br/>
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
        /// A tool defined by value: `definition` is a `tools` entry (any kind<br/>
        /// `tools` accepts, an MCP toolset included). An `mcp_toolset` given here<br/>
        /// also requires the `mcp-client-2026-09-15` beta.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolChangeToolDefinition? ToolDefinition { get; init; }
#else
        public global::Anthropic.BetaToolChangeToolDefinition? ToolDefinition { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolDefinition))]
#endif
        public bool IsToolDefinition => ToolDefinition != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolDefinition(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolChangeToolDefinition? value)
        {
            value = ToolDefinition;
            return IsToolDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolChangeToolDefinition PickToolDefinition() => IsToolDefinition
            ? ToolDefinition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolDefinition' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Anthropic.BetaToolChangeToolReference value) => new Tool((global::Anthropic.BetaToolChangeToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeToolReference?(Tool @this) => @this.ToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Anthropic.BetaToolChangeToolReference? value)
        {
            ToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromToolReference(global::Anthropic.BetaToolChangeToolReference? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Anthropic.BetaToolChangeMCPToolReference value) => new Tool((global::Anthropic.BetaToolChangeMCPToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeMCPToolReference?(Tool @this) => @this.McpToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Anthropic.BetaToolChangeMCPToolReference? value)
        {
            McpToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromMcpToolReference(global::Anthropic.BetaToolChangeMCPToolReference? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Anthropic.BetaToolChangeMCPToolsetReference value) => new Tool((global::Anthropic.BetaToolChangeMCPToolsetReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeMCPToolsetReference?(Tool @this) => @this.McpToolsetReference;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Anthropic.BetaToolChangeMCPToolsetReference? value)
        {
            McpToolsetReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromMcpToolsetReference(global::Anthropic.BetaToolChangeMCPToolsetReference? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool(global::Anthropic.BetaToolChangeToolDefinition value) => new Tool((global::Anthropic.BetaToolChangeToolDefinition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolChangeToolDefinition?(Tool @this) => @this.ToolDefinition;

        /// <summary>
        ///
        /// </summary>
        public Tool(global::Anthropic.BetaToolChangeToolDefinition? value)
        {
            ToolDefinition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool FromToolDefinition(global::Anthropic.BetaToolChangeToolDefinition? value) => new Tool(value);

        /// <summary>
        ///
        /// </summary>
        public Tool(
            global::Anthropic.BetaRequestToolAdditionBlockToolDiscriminatorType? type,
            global::Anthropic.BetaToolChangeToolReference? toolReference,
            global::Anthropic.BetaToolChangeMCPToolReference? mcpToolReference,
            global::Anthropic.BetaToolChangeMCPToolsetReference? mcpToolsetReference,
            global::Anthropic.BetaToolChangeToolDefinition? toolDefinition
            )
        {
            Type = type;

            ToolReference = toolReference;
            McpToolReference = mcpToolReference;
            McpToolsetReference = mcpToolsetReference;
            ToolDefinition = toolDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ToolDefinition as object ??
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
            McpToolsetReference?.ToString() ??
            ToolDefinition?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsToolReference && !IsMcpToolReference && !IsMcpToolsetReference && !IsToolDefinition || !IsToolReference && IsMcpToolReference && !IsMcpToolsetReference && !IsToolDefinition || !IsToolReference && !IsMcpToolReference && IsMcpToolsetReference && !IsToolDefinition || !IsToolReference && !IsMcpToolReference && !IsMcpToolsetReference && IsToolDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaToolChangeToolReference, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.BetaToolChangeMCPToolReference, TResult>? mcpToolReference = null,
            global::System.Func<global::Anthropic.BetaToolChangeMCPToolsetReference, TResult>? mcpToolsetReference = null,
            global::System.Func<global::Anthropic.BetaToolChangeToolDefinition, TResult>? toolDefinition = null,
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
            else if (IsToolDefinition && toolDefinition != null)
            {
                return toolDefinition(ToolDefinition!);
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

            global::System.Action<global::Anthropic.BetaToolChangeToolDefinition>? toolDefinition = null,
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
            else if (IsToolDefinition)
            {
                toolDefinition?.Invoke(ToolDefinition!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaToolChangeToolReference>? toolReference = null,
            global::System.Action<global::Anthropic.BetaToolChangeMCPToolReference>? mcpToolReference = null,
            global::System.Action<global::Anthropic.BetaToolChangeMCPToolsetReference>? mcpToolsetReference = null,
            global::System.Action<global::Anthropic.BetaToolChangeToolDefinition>? toolDefinition = null,
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
            else if (IsToolDefinition)
            {
                toolDefinition?.Invoke(ToolDefinition!);
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
                ToolDefinition,
                typeof(global::Anthropic.BetaToolChangeToolDefinition),
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
        public bool Equals(Tool other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeToolReference?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeMCPToolReference?>.Default.Equals(McpToolReference, other.McpToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeMCPToolsetReference?>.Default.Equals(McpToolsetReference, other.McpToolsetReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolChangeToolDefinition?>.Default.Equals(ToolDefinition, other.ToolDefinition)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool obj1, Tool obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool obj1, Tool obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool o && Equals(o);
        }
    }
}
