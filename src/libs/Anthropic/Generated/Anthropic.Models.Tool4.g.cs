#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A reference to the withdrawn `tools` entry, MCP tool or MCP toolset.
    /// </summary>
    public readonly partial struct Tool4 : global::System.IEquatable<Tool4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? Type { get; }

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
        ///
        /// </summary>
        public static implicit operator Tool4(global::Anthropic.BetaResponseToolChangeToolReference value) => new Tool4((global::Anthropic.BetaResponseToolChangeToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeToolReference?(Tool4 @this) => @this.ToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool4(global::Anthropic.BetaResponseToolChangeToolReference? value)
        {
            ToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool4 FromToolReference(global::Anthropic.BetaResponseToolChangeToolReference? value) => new Tool4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool4(global::Anthropic.BetaResponseToolChangeMCPToolReference value) => new Tool4((global::Anthropic.BetaResponseToolChangeMCPToolReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeMCPToolReference?(Tool4 @this) => @this.McpToolReference;

        /// <summary>
        ///
        /// </summary>
        public Tool4(global::Anthropic.BetaResponseToolChangeMCPToolReference? value)
        {
            McpToolReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool4 FromMcpToolReference(global::Anthropic.BetaResponseToolChangeMCPToolReference? value) => new Tool4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Tool4(global::Anthropic.BetaResponseToolChangeMCPToolsetReference value) => new Tool4((global::Anthropic.BetaResponseToolChangeMCPToolsetReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaResponseToolChangeMCPToolsetReference?(Tool4 @this) => @this.McpToolsetReference;

        /// <summary>
        ///
        /// </summary>
        public Tool4(global::Anthropic.BetaResponseToolChangeMCPToolsetReference? value)
        {
            McpToolsetReference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Tool4 FromMcpToolsetReference(global::Anthropic.BetaResponseToolChangeMCPToolsetReference? value) => new Tool4(value);

        /// <summary>
        ///
        /// </summary>
        public Tool4(
            global::Anthropic.BetaResponseToolRemovalBlockToolDiscriminatorType? type,
            global::Anthropic.BetaResponseToolChangeToolReference? toolReference,
            global::Anthropic.BetaResponseToolChangeMCPToolReference? mcpToolReference,
            global::Anthropic.BetaResponseToolChangeMCPToolsetReference? mcpToolsetReference
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
            global::System.Func<global::Anthropic.BetaResponseToolChangeToolReference, TResult>? toolReference = null,
            global::System.Func<global::Anthropic.BetaResponseToolChangeMCPToolReference, TResult>? mcpToolReference = null,
            global::System.Func<global::Anthropic.BetaResponseToolChangeMCPToolsetReference, TResult>? mcpToolsetReference = null,
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
            global::System.Action<global::Anthropic.BetaResponseToolChangeToolReference>? toolReference = null,

            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolReference>? mcpToolReference = null,

            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolsetReference>? mcpToolsetReference = null,
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
            global::System.Action<global::Anthropic.BetaResponseToolChangeToolReference>? toolReference = null,
            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolReference>? mcpToolReference = null,
            global::System.Action<global::Anthropic.BetaResponseToolChangeMCPToolsetReference>? mcpToolsetReference = null,
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
                typeof(global::Anthropic.BetaResponseToolChangeToolReference),
                McpToolReference,
                typeof(global::Anthropic.BetaResponseToolChangeMCPToolReference),
                McpToolsetReference,
                typeof(global::Anthropic.BetaResponseToolChangeMCPToolsetReference),
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
        public bool Equals(Tool4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeToolReference?>.Default.Equals(ToolReference, other.ToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeMCPToolReference?>.Default.Equals(McpToolReference, other.McpToolReference) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaResponseToolChangeMCPToolsetReference?>.Default.Equals(McpToolsetReference, other.McpToolsetReference)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Tool4 obj1, Tool4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Tool4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Tool4 obj1, Tool4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Tool4 o && Equals(o);
        }
    }
}
