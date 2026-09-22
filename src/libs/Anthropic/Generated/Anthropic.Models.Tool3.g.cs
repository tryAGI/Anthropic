#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The tool made available: a reference to a `tools` entry or MCP toolset, or a `tool_definition` carrying the definition by value.
    /// </summary>
    public readonly partial struct Tool3 : global::System.IEquatable<Tool3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? Type { get; }

        /// <summary>
        /// Reference to a single tool, by the name the model uses to call it, as<br/>
        /// a ``compaction`` block's ``tool_changes`` entry reports it: a tool<br/>
        /// declared in ``tools`` or defined by an earlier ``tool_addition`` block.<br/>
        /// Send it back unchanged with the block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolChangeToolReference? ToolReference { get; init; }
#else
        public global::Anthropic.BetaResponseToolChangeToolReference? ToolReference { get; }
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
            out global::Anthropic.BetaResponseToolChangeToolReference? value)
        {
            value = ToolReference;
            return IsToolReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolReference PickToolReference() => IsToolReference
            ? ToolReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolReference' but the value was {ToString()}.");

        /// <summary>
        /// Reference to a single MCP tool, by its server and its name on that<br/>
        /// server, as a ``compaction`` block's ``tool_changes`` entry reports it.<br/>
        /// Send it back unchanged with the block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? McpToolReference { get; init; }
#else
        public global::Anthropic.BetaResponseToolChangeMCPToolReference? McpToolReference { get; }
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
            out global::Anthropic.BetaResponseToolChangeMCPToolReference? value)
        {
            value = McpToolReference;
            return IsMcpToolReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolReference PickMcpToolReference() => IsMcpToolReference
            ? McpToolReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolReference' but the value was {ToString()}.");

        /// <summary>
        /// Reference to every tool in the named MCP server's toolset, as a<br/>
        /// ``compaction`` block's ``tool_changes`` entry reports it. Send it back<br/>
        /// unchanged with the block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? McpToolsetReference { get; init; }
#else
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference? McpToolsetReference { get; }
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
            out global::Anthropic.BetaResponseToolChangeMCPToolsetReference? value)
        {
            value = McpToolsetReference;
            return IsMcpToolsetReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeMCPToolsetReference PickMcpToolsetReference() => IsMcpToolsetReference
            ? McpToolsetReference!
            : throw new global::System.InvalidOperationException($"Expected union variant 'McpToolsetReference' but the value was {ToString()}.");

        /// <summary>
        /// A tool defined by value, as a `compaction` block's `tool_changes` entry<br/>
        /// reports it: `definition` is the tool's definition as it was sent, in the<br/>
        /// form of a `tools` entry, without `cache_control`. Send it back unchanged<br/>
        /// with the block.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaResponseToolChangeToolDefinition? ToolDefinition { get; init; }
#else
        public global::Anthropic.BetaResponseToolChangeToolDefinition? ToolDefinition { get; }
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
            out global::Anthropic.BetaResponseToolChangeToolDefinition? value)
        {
            value = ToolDefinition;
            return IsToolDefinition;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolChangeToolDefinition PickToolDefinition() => IsToolDefinition
            ? ToolDefinition!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolDefinition' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool3(global::Anthropic.BetaResponseToolChangeToolReference value) => new Tool3((global::Anthropic.BetaResponseToolChangeToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeToolReference?(Tool3 @this) => @this.ToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool3(global::Anthropic.BetaResponseToolChangeToolReference? value)
        {
            ToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool3 FromToolReference(global::Anthropic.BetaResponseToolChangeToolReference? value) => new Tool3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool3(global::Anthropic.BetaResponseToolChangeMCPToolReference value) => new Tool3((global::Anthropic.BetaResponseToolChangeMCPToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeMCPToolReference?(Tool3 @this) => @this.McpToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool3(global::Anthropic.BetaResponseToolChangeMCPToolReference? value)
        {
            McpToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool3 FromMcpToolReference(global::Anthropic.BetaResponseToolChangeMCPToolReference? value) => new Tool3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool3(global::Anthropic.BetaResponseToolChangeMCPToolsetReference value) => new Tool3((global::Anthropic.BetaResponseToolChangeMCPToolsetReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeMCPToolsetReference?(Tool3 @this) => @this.McpToolsetReference;

        /// <summary>
        ///
        /// </summary>
        public Tool3(global::Anthropic.BetaResponseToolChangeMCPToolsetReference? value)
        {
            McpToolsetReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool3 FromMcpToolsetReference(global::Anthropic.BetaResponseToolChangeMCPToolsetReference? value) => new Tool3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool3(global::Anthropic.BetaResponseToolChangeToolDefinition value) => new Tool3((global::Anthropic.BetaResponseToolChangeToolDefinition?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeToolDefinition?(Tool3 @this) => @this.ToolDefinition;

        /// <summary>
        ///
        /// </summary>
        public Tool3(global::Anthropic.BetaResponseToolChangeToolDefinition? value)
        {
            ToolDefinition = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool3 FromToolDefinition(global::Anthropic.BetaResponseToolChangeToolDefinition? value) => new Tool3(value);

        /// <summary>
        ///
        /// </summary>
        public Tool3(
            global::Anthropic.BetaResponseToolAdditionBlockToolDiscriminatorType? type,
            global::Anthropic.BetaResponseToolChangeToolReference? toolReference,
            global::Anthropic.BetaResponseToolChangeMCPToolReference? mcpToolReference,
            global::Anthropic.BetaResponseToolChangeMCPToolsetReference? mcpToolsetReference,
            global::Anthropic.BetaResponseToolChangeToolDefinition? toolDefinition
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
            global::System.Func<global::Anthropic.BetaResponseToolChangeToolReference, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.BetaResponseToolChangeMCPToolReference, TResult>? mcpToolReference = null,
            global::System.Func<global::Anthropic.BetaResponseToolChangeMCPToolsetReference, TResult>? mcpToolsetReference = null,
            global::System.Func<global::Anthropic.BetaResponseToolChangeToolDefinition, TResult>? toolDefinition = null,
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
            global::System.Action<global::Anthropic.BetaResponseToolChangeToolReference>? toolReference = null,

            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolReference>? mcpToolReference = null,

            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolsetReference>? mcpToolsetReference = null,

            global::System.Action<global::Anthropic.BetaResponseToolChangeToolDefinition>? toolDefinition = null,
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
            global::System.Action<global::Anthropic.BetaResponseToolChangeToolReference>? toolReference = null,
            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolReference>? mcpToolReference = null,
            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolsetReference>? mcpToolsetReference = null,
            global::System.Action<global::Anthropic.BetaResponseToolChangeToolDefinition>? toolDefinition = null,
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
                typeof(global::Anthropic.BetaResponseToolChangeToolReference),
                McpToolReference,
                typeof(global::Anthropic.BetaResponseToolChangeMCPToolReference),
                McpToolsetReference,
                typeof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference),
                ToolDefinition,
                typeof(global::Anthropic.BetaResponseToolChangeToolDefinition),
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
        public bool Equals(Tool3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeToolReference?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeMCPToolReference?>.Default.Equals(McpToolReference, other.McpToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeMCPToolsetReference?>.Default.Equals(McpToolsetReference, other.McpToolsetReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeToolDefinition?>.Default.Equals(ToolDefinition, other.ToolDefinition)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool3 obj1, Tool3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool3 obj1, Tool3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool3 o && Equals(o);
        }
    }
}
