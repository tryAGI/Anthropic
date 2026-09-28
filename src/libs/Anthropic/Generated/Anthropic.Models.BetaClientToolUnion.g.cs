#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool that the client executes: the caller runs each `tool_use` request<br/>
    /// for it and returns the output in a `tool_result` block.
    /// </summary>
    public readonly partial struct BetaClientToolUnion : global::System.IEquatable<BetaClientToolUnion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTool? Tool { get; init; }
#else
        public global::Anthropic.BetaTool? Tool { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTool(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTool? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTool PickTool() => Tool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBashTool20241022? BashTool20241022 { get; init; }
#else
        public global::Anthropic.BetaBashTool20241022? BashTool20241022 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashTool20241022))]
#endif
        public bool IsBashTool20241022 => BashTool20241022 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashTool20241022(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBashTool20241022? value)
        {
            value = BashTool20241022;
            return IsBashTool20241022;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20241022 PickBashTool20241022() => BashTool20241022 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashTool20241022' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBashTool20250124? BashTool20250124 { get; init; }
#else
        public global::Anthropic.BetaBashTool20250124? BashTool20250124 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BashTool20250124))]
#endif
        public bool IsBashTool20250124 => BashTool20250124 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBashTool20250124(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBashTool20250124? value)
        {
            value = BashTool20250124;
            return IsBashTool20250124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBashTool20250124 PickBashTool20250124() => BashTool20250124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashTool20250124' but the value was {ToString()}.");

        /// <summary>
        /// The browser toolset: a single ``tools[]`` entry (carrying no<br/>
        /// ``name``) that declares the browser tool family. The model is served<br/>
        /// the family's tool with any members disabled via ``configs`` removed<br/>
        /// from its schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserToolset20260801? BrowserToolset20260801 { get; init; }
#else
        public global::Anthropic.BetaBrowserToolset20260801? BrowserToolset20260801 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BrowserToolset20260801))]
#endif
        public bool IsBrowserToolset20260801 => BrowserToolset20260801 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBrowserToolset20260801(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserToolset20260801? value)
        {
            value = BrowserToolset20260801;
            return IsBrowserToolset20260801;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaBrowserToolset20260801 PickBrowserToolset20260801() => BrowserToolset20260801 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserToolset20260801' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerUseTool20241022? ComputerUseTool20241022 { get; init; }
#else
        public global::Anthropic.BetaComputerUseTool20241022? ComputerUseTool20241022 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUseTool20241022))]
#endif
        public bool IsComputerUseTool20241022 => ComputerUseTool20241022 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerUseTool20241022(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerUseTool20241022? value)
        {
            value = ComputerUseTool20241022;
            return IsComputerUseTool20241022;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20241022 PickComputerUseTool20241022() => ComputerUseTool20241022 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUseTool20241022' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818? MemoryTool20250818 { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818? MemoryTool20250818 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryTool20250818))]
#endif
        public bool IsMemoryTool20250818 => MemoryTool20250818 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMemoryTool20250818(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaMemoryTool20250818? value)
        {
            value = MemoryTool20250818;
            return IsMemoryTool20250818;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818 PickMemoryTool20250818() => MemoryTool20250818 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryTool20250818' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerUseTool20250124? ComputerUseTool20250124 { get; init; }
#else
        public global::Anthropic.BetaComputerUseTool20250124? ComputerUseTool20250124 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUseTool20250124))]
#endif
        public bool IsComputerUseTool20250124 => ComputerUseTool20250124 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerUseTool20250124(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerUseTool20250124? value)
        {
            value = ComputerUseTool20250124;
            return IsComputerUseTool20250124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20250124 PickComputerUseTool20250124() => ComputerUseTool20250124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUseTool20250124' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextEditor20241022? TextEditor20241022 { get; init; }
#else
        public global::Anthropic.BetaTextEditor20241022? TextEditor20241022 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20241022))]
#endif
        public bool IsTextEditor20241022 => TextEditor20241022 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditor20241022(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTextEditor20241022? value)
        {
            value = TextEditor20241022;
            return IsTextEditor20241022;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20241022 PickTextEditor20241022() => TextEditor20241022 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20241022' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerUseTool20251124? ComputerUseTool20251124 { get; init; }
#else
        public global::Anthropic.BetaComputerUseTool20251124? ComputerUseTool20251124 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerUseTool20251124))]
#endif
        public bool IsComputerUseTool20251124 => ComputerUseTool20251124 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerUseTool20251124(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerUseTool20251124? value)
        {
            value = ComputerUseTool20251124;
            return IsComputerUseTool20251124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerUseTool20251124 PickComputerUseTool20251124() => ComputerUseTool20251124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerUseTool20251124' but the value was {ToString()}.");

        /// <summary>
        /// The computer toolset: a single ``tools[]`` entry (carrying no<br/>
        /// ``name``) that declares the computer tool family. The model is<br/>
        /// served the family's tool with any members disabled via ``configs``<br/>
        /// removed from its schema. Every member is enabled by default, zoom<br/>
        /// included. The single-tool options ``display_number`` and<br/>
        /// ``enable_zoom`` are not fields of a toolset entry — it carries only<br/>
        /// ``type``, ``configs``, and ``cache_control``; zoom is controlled<br/>
        /// via ``configs.zoom.enabled``.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaComputerToolset20260801? ComputerToolset20260801 { get; init; }
#else
        public global::Anthropic.BetaComputerToolset20260801? ComputerToolset20260801 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ComputerToolset20260801))]
#endif
        public bool IsComputerToolset20260801 => ComputerToolset20260801 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickComputerToolset20260801(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaComputerToolset20260801? value)
        {
            value = ComputerToolset20260801;
            return IsComputerToolset20260801;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaComputerToolset20260801 PickComputerToolset20260801() => ComputerToolset20260801 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerToolset20260801' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextEditor20250124? TextEditor20250124 { get; init; }
#else
        public global::Anthropic.BetaTextEditor20250124? TextEditor20250124 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20250124))]
#endif
        public bool IsTextEditor20250124 => TextEditor20250124 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditor20250124(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTextEditor20250124? value)
        {
            value = TextEditor20250124;
            return IsTextEditor20250124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250124 PickTextEditor20250124() => TextEditor20250124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250124' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextEditor20250429? TextEditor20250429 { get; init; }
#else
        public global::Anthropic.BetaTextEditor20250429? TextEditor20250429 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20250429))]
#endif
        public bool IsTextEditor20250429 => TextEditor20250429 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditor20250429(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTextEditor20250429? value)
        {
            value = TextEditor20250429;
            return IsTextEditor20250429;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250429 PickTextEditor20250429() => TextEditor20250429 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250429' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTextEditor20250728? TextEditor20250728 { get; init; }
#else
        public global::Anthropic.BetaTextEditor20250728? TextEditor20250728 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20250728))]
#endif
        public bool IsTextEditor20250728 => TextEditor20250728 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextEditor20250728(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTextEditor20250728? value)
        {
            value = TextEditor20250728;
            return IsTextEditor20250728;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTextEditor20250728 PickTextEditor20250728() => TextEditor20250728 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250728' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaTool value) => new BetaClientToolUnion((global::Anthropic.BetaTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTool?(BetaClientToolUnion @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaTool? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromTool(global::Anthropic.BetaTool? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaBashTool20241022 value) => new BetaClientToolUnion((global::Anthropic.BetaBashTool20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBashTool20241022?(BetaClientToolUnion @this) => @this.BashTool20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaBashTool20241022? value)
        {
            BashTool20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromBashTool20241022(global::Anthropic.BetaBashTool20241022? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaBashTool20250124 value) => new BetaClientToolUnion((global::Anthropic.BetaBashTool20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBashTool20250124?(BetaClientToolUnion @this) => @this.BashTool20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaBashTool20250124? value)
        {
            BashTool20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromBashTool20250124(global::Anthropic.BetaBashTool20250124? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaBrowserToolset20260801 value) => new BetaClientToolUnion((global::Anthropic.BetaBrowserToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserToolset20260801?(BetaClientToolUnion @this) => @this.BrowserToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaBrowserToolset20260801? value)
        {
            BrowserToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromBrowserToolset20260801(global::Anthropic.BetaBrowserToolset20260801? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20241022 value) => new BetaClientToolUnion((global::Anthropic.BetaComputerUseTool20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20241022?(BetaClientToolUnion @this) => @this.ComputerUseTool20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20241022? value)
        {
            ComputerUseTool20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromComputerUseTool20241022(global::Anthropic.BetaComputerUseTool20241022? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaMemoryTool20250818 value) => new BetaClientToolUnion((global::Anthropic.BetaMemoryTool20250818?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818?(BetaClientToolUnion @this) => @this.MemoryTool20250818;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaMemoryTool20250818? value)
        {
            MemoryTool20250818 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromMemoryTool20250818(global::Anthropic.BetaMemoryTool20250818? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20250124 value) => new BetaClientToolUnion((global::Anthropic.BetaComputerUseTool20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20250124?(BetaClientToolUnion @this) => @this.ComputerUseTool20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20250124? value)
        {
            ComputerUseTool20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromComputerUseTool20250124(global::Anthropic.BetaComputerUseTool20250124? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaTextEditor20241022 value) => new BetaClientToolUnion((global::Anthropic.BetaTextEditor20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20241022?(BetaClientToolUnion @this) => @this.TextEditor20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaTextEditor20241022? value)
        {
            TextEditor20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromTextEditor20241022(global::Anthropic.BetaTextEditor20241022? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20251124 value) => new BetaClientToolUnion((global::Anthropic.BetaComputerUseTool20251124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20251124?(BetaClientToolUnion @this) => @this.ComputerUseTool20251124;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaComputerUseTool20251124? value)
        {
            ComputerUseTool20251124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromComputerUseTool20251124(global::Anthropic.BetaComputerUseTool20251124? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaComputerToolset20260801 value) => new BetaClientToolUnion((global::Anthropic.BetaComputerToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerToolset20260801?(BetaClientToolUnion @this) => @this.ComputerToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaComputerToolset20260801? value)
        {
            ComputerToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromComputerToolset20260801(global::Anthropic.BetaComputerToolset20260801? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaTextEditor20250124 value) => new BetaClientToolUnion((global::Anthropic.BetaTextEditor20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250124?(BetaClientToolUnion @this) => @this.TextEditor20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaTextEditor20250124? value)
        {
            TextEditor20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromTextEditor20250124(global::Anthropic.BetaTextEditor20250124? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaTextEditor20250429 value) => new BetaClientToolUnion((global::Anthropic.BetaTextEditor20250429?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250429?(BetaClientToolUnion @this) => @this.TextEditor20250429;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaTextEditor20250429? value)
        {
            TextEditor20250429 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromTextEditor20250429(global::Anthropic.BetaTextEditor20250429? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaClientToolUnion(global::Anthropic.BetaTextEditor20250728 value) => new BetaClientToolUnion((global::Anthropic.BetaTextEditor20250728?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250728?(BetaClientToolUnion @this) => @this.TextEditor20250728;

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(global::Anthropic.BetaTextEditor20250728? value)
        {
            TextEditor20250728 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaClientToolUnion FromTextEditor20250728(global::Anthropic.BetaTextEditor20250728? value) => new BetaClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaClientToolUnion(
            global::Anthropic.BetaTool? tool,
            global::Anthropic.BetaBashTool20241022? bashTool20241022,
            global::Anthropic.BetaBashTool20250124? bashTool20250124,
            global::Anthropic.BetaBrowserToolset20260801? browserToolset20260801,
            global::Anthropic.BetaComputerUseTool20241022? computerUseTool20241022,
            global::Anthropic.BetaMemoryTool20250818? memoryTool20250818,
            global::Anthropic.BetaComputerUseTool20250124? computerUseTool20250124,
            global::Anthropic.BetaTextEditor20241022? textEditor20241022,
            global::Anthropic.BetaComputerUseTool20251124? computerUseTool20251124,
            global::Anthropic.BetaComputerToolset20260801? computerToolset20260801,
            global::Anthropic.BetaTextEditor20250124? textEditor20250124,
            global::Anthropic.BetaTextEditor20250429? textEditor20250429,
            global::Anthropic.BetaTextEditor20250728? textEditor20250728
            )
        {
            Tool = tool;
            BashTool20241022 = bashTool20241022;
            BashTool20250124 = bashTool20250124;
            BrowserToolset20260801 = browserToolset20260801;
            ComputerUseTool20241022 = computerUseTool20241022;
            MemoryTool20250818 = memoryTool20250818;
            ComputerUseTool20250124 = computerUseTool20250124;
            TextEditor20241022 = textEditor20241022;
            ComputerUseTool20251124 = computerUseTool20251124;
            ComputerToolset20260801 = computerToolset20260801;
            TextEditor20250124 = textEditor20250124;
            TextEditor20250429 = textEditor20250429;
            TextEditor20250728 = textEditor20250728;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TextEditor20250728 as object ??
            TextEditor20250429 as object ??
            TextEditor20250124 as object ??
            ComputerToolset20260801 as object ??
            ComputerUseTool20251124 as object ??
            TextEditor20241022 as object ??
            ComputerUseTool20250124 as object ??
            MemoryTool20250818 as object ??
            ComputerUseTool20241022 as object ??
            BrowserToolset20260801 as object ??
            BashTool20250124 as object ??
            BashTool20241022 as object ??
            Tool as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Tool?.ToString() ??
            BashTool20241022?.ToString() ??
            BashTool20250124?.ToString() ??
            BrowserToolset20260801?.ToString() ??
            ComputerUseTool20241022?.ToString() ??
            MemoryTool20250818?.ToString() ??
            ComputerUseTool20250124?.ToString() ??
            TextEditor20241022?.ToString() ??
            ComputerUseTool20251124?.ToString() ??
            ComputerToolset20260801?.ToString() ??
            TextEditor20250124?.ToString() ??
            TextEditor20250429?.ToString() ??
            TextEditor20250728?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && IsTextEditor20250728;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTool, TResult>? tool = null,
            global::System.Func<global::Anthropic.BetaBashTool20241022, TResult>? bashTool20241022 = null,
            global::System.Func<global::Anthropic.BetaBashTool20250124, TResult>? bashTool20250124 = null,
            global::System.Func<global::Anthropic.BetaBrowserToolset20260801, TResult>? browserToolset20260801 = null,
            global::System.Func<global::Anthropic.BetaComputerUseTool20241022, TResult>? computerUseTool20241022 = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818, TResult>? memoryTool20250818 = null,
            global::System.Func<global::Anthropic.BetaComputerUseTool20250124, TResult>? computerUseTool20250124 = null,
            global::System.Func<global::Anthropic.BetaTextEditor20241022, TResult>? textEditor20241022 = null,
            global::System.Func<global::Anthropic.BetaComputerUseTool20251124, TResult>? computerUseTool20251124 = null,
            global::System.Func<global::Anthropic.BetaComputerToolset20260801, TResult>? computerToolset20260801 = null,
            global::System.Func<global::Anthropic.BetaTextEditor20250124, TResult>? textEditor20250124 = null,
            global::System.Func<global::Anthropic.BetaTextEditor20250429, TResult>? textEditor20250429 = null,
            global::System.Func<global::Anthropic.BetaTextEditor20250728, TResult>? textEditor20250728 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Tool is { } __value0 && tool != null)
            {
                return tool(__value0);
            }
            else if (BashTool20241022 is { } __value1 && bashTool20241022 != null)
            {
                return bashTool20241022(__value1);
            }
            else if (BashTool20250124 is { } __value2 && bashTool20250124 != null)
            {
                return bashTool20250124(__value2);
            }
            else if (BrowserToolset20260801 is { } __value3 && browserToolset20260801 != null)
            {
                return browserToolset20260801(__value3);
            }
            else if (ComputerUseTool20241022 is { } __value4 && computerUseTool20241022 != null)
            {
                return computerUseTool20241022(__value4);
            }
            else if (MemoryTool20250818 is { } __value5 && memoryTool20250818 != null)
            {
                return memoryTool20250818(__value5);
            }
            else if (ComputerUseTool20250124 is { } __value6 && computerUseTool20250124 != null)
            {
                return computerUseTool20250124(__value6);
            }
            else if (TextEditor20241022 is { } __value7 && textEditor20241022 != null)
            {
                return textEditor20241022(__value7);
            }
            else if (ComputerUseTool20251124 is { } __value8 && computerUseTool20251124 != null)
            {
                return computerUseTool20251124(__value8);
            }
            else if (ComputerToolset20260801 is { } __value9 && computerToolset20260801 != null)
            {
                return computerToolset20260801(__value9);
            }
            else if (TextEditor20250124 is { } __value10 && textEditor20250124 != null)
            {
                return textEditor20250124(__value10);
            }
            else if (TextEditor20250429 is { } __value11 && textEditor20250429 != null)
            {
                return textEditor20250429(__value11);
            }
            else if (TextEditor20250728 is { } __value12 && textEditor20250728 != null)
            {
                return textEditor20250728(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTool>? tool = null,

            global::System.Action<global::Anthropic.BetaBashTool20241022>? bashTool20241022 = null,

            global::System.Action<global::Anthropic.BetaBashTool20250124>? bashTool20250124 = null,

            global::System.Action<global::Anthropic.BetaBrowserToolset20260801>? browserToolset20260801 = null,

            global::System.Action<global::Anthropic.BetaComputerUseTool20241022>? computerUseTool20241022 = null,

            global::System.Action<global::Anthropic.BetaMemoryTool20250818>? memoryTool20250818 = null,

            global::System.Action<global::Anthropic.BetaComputerUseTool20250124>? computerUseTool20250124 = null,

            global::System.Action<global::Anthropic.BetaTextEditor20241022>? textEditor20241022 = null,

            global::System.Action<global::Anthropic.BetaComputerUseTool20251124>? computerUseTool20251124 = null,

            global::System.Action<global::Anthropic.BetaComputerToolset20260801>? computerToolset20260801 = null,

            global::System.Action<global::Anthropic.BetaTextEditor20250124>? textEditor20250124 = null,

            global::System.Action<global::Anthropic.BetaTextEditor20250429>? textEditor20250429 = null,

            global::System.Action<global::Anthropic.BetaTextEditor20250728>? textEditor20250728 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Tool is { } __value0)
            {
                tool?.Invoke(__value0);
            }
            else if (BashTool20241022 is { } __value1)
            {
                bashTool20241022?.Invoke(__value1);
            }
            else if (BashTool20250124 is { } __value2)
            {
                bashTool20250124?.Invoke(__value2);
            }
            else if (BrowserToolset20260801 is { } __value3)
            {
                browserToolset20260801?.Invoke(__value3);
            }
            else if (ComputerUseTool20241022 is { } __value4)
            {
                computerUseTool20241022?.Invoke(__value4);
            }
            else if (MemoryTool20250818 is { } __value5)
            {
                memoryTool20250818?.Invoke(__value5);
            }
            else if (ComputerUseTool20250124 is { } __value6)
            {
                computerUseTool20250124?.Invoke(__value6);
            }
            else if (TextEditor20241022 is { } __value7)
            {
                textEditor20241022?.Invoke(__value7);
            }
            else if (ComputerUseTool20251124 is { } __value8)
            {
                computerUseTool20251124?.Invoke(__value8);
            }
            else if (ComputerToolset20260801 is { } __value9)
            {
                computerToolset20260801?.Invoke(__value9);
            }
            else if (TextEditor20250124 is { } __value10)
            {
                textEditor20250124?.Invoke(__value10);
            }
            else if (TextEditor20250429 is { } __value11)
            {
                textEditor20250429?.Invoke(__value11);
            }
            else if (TextEditor20250728 is { } __value12)
            {
                textEditor20250728?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaTool>? tool = null,
            global::System.Action<global::Anthropic.BetaBashTool20241022>? bashTool20241022 = null,
            global::System.Action<global::Anthropic.BetaBashTool20250124>? bashTool20250124 = null,
            global::System.Action<global::Anthropic.BetaBrowserToolset20260801>? browserToolset20260801 = null,
            global::System.Action<global::Anthropic.BetaComputerUseTool20241022>? computerUseTool20241022 = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818>? memoryTool20250818 = null,
            global::System.Action<global::Anthropic.BetaComputerUseTool20250124>? computerUseTool20250124 = null,
            global::System.Action<global::Anthropic.BetaTextEditor20241022>? textEditor20241022 = null,
            global::System.Action<global::Anthropic.BetaComputerUseTool20251124>? computerUseTool20251124 = null,
            global::System.Action<global::Anthropic.BetaComputerToolset20260801>? computerToolset20260801 = null,
            global::System.Action<global::Anthropic.BetaTextEditor20250124>? textEditor20250124 = null,
            global::System.Action<global::Anthropic.BetaTextEditor20250429>? textEditor20250429 = null,
            global::System.Action<global::Anthropic.BetaTextEditor20250728>? textEditor20250728 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Tool is { } __value0)
            {
                tool?.Invoke(__value0);
            }
            else if (BashTool20241022 is { } __value1)
            {
                bashTool20241022?.Invoke(__value1);
            }
            else if (BashTool20250124 is { } __value2)
            {
                bashTool20250124?.Invoke(__value2);
            }
            else if (BrowserToolset20260801 is { } __value3)
            {
                browserToolset20260801?.Invoke(__value3);
            }
            else if (ComputerUseTool20241022 is { } __value4)
            {
                computerUseTool20241022?.Invoke(__value4);
            }
            else if (MemoryTool20250818 is { } __value5)
            {
                memoryTool20250818?.Invoke(__value5);
            }
            else if (ComputerUseTool20250124 is { } __value6)
            {
                computerUseTool20250124?.Invoke(__value6);
            }
            else if (TextEditor20241022 is { } __value7)
            {
                textEditor20241022?.Invoke(__value7);
            }
            else if (ComputerUseTool20251124 is { } __value8)
            {
                computerUseTool20251124?.Invoke(__value8);
            }
            else if (ComputerToolset20260801 is { } __value9)
            {
                computerToolset20260801?.Invoke(__value9);
            }
            else if (TextEditor20250124 is { } __value10)
            {
                textEditor20250124?.Invoke(__value10);
            }
            else if (TextEditor20250429 is { } __value11)
            {
                textEditor20250429?.Invoke(__value11);
            }
            else if (TextEditor20250728 is { } __value12)
            {
                textEditor20250728?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Tool,
                typeof(global::Anthropic.BetaTool),
                BashTool20241022,
                typeof(global::Anthropic.BetaBashTool20241022),
                BashTool20250124,
                typeof(global::Anthropic.BetaBashTool20250124),
                BrowserToolset20260801,
                typeof(global::Anthropic.BetaBrowserToolset20260801),
                ComputerUseTool20241022,
                typeof(global::Anthropic.BetaComputerUseTool20241022),
                MemoryTool20250818,
                typeof(global::Anthropic.BetaMemoryTool20250818),
                ComputerUseTool20250124,
                typeof(global::Anthropic.BetaComputerUseTool20250124),
                TextEditor20241022,
                typeof(global::Anthropic.BetaTextEditor20241022),
                ComputerUseTool20251124,
                typeof(global::Anthropic.BetaComputerUseTool20251124),
                ComputerToolset20260801,
                typeof(global::Anthropic.BetaComputerToolset20260801),
                TextEditor20250124,
                typeof(global::Anthropic.BetaTextEditor20250124),
                TextEditor20250429,
                typeof(global::Anthropic.BetaTextEditor20250429),
                TextEditor20250728,
                typeof(global::Anthropic.BetaTextEditor20250728),
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
        public bool Equals(BetaClientToolUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTool?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBashTool20241022?>.Default.Equals(BashTool20241022, other.BashTool20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBashTool20250124?>.Default.Equals(BashTool20250124, other.BashTool20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserToolset20260801?>.Default.Equals(BrowserToolset20260801, other.BrowserToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20241022?>.Default.Equals(ComputerUseTool20241022, other.ComputerUseTool20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818?>.Default.Equals(MemoryTool20250818, other.MemoryTool20250818) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20250124?>.Default.Equals(ComputerUseTool20250124, other.ComputerUseTool20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20241022?>.Default.Equals(TextEditor20241022, other.TextEditor20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20251124?>.Default.Equals(ComputerUseTool20251124, other.ComputerUseTool20251124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerToolset20260801?>.Default.Equals(ComputerToolset20260801, other.ComputerToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250124?>.Default.Equals(TextEditor20250124, other.TextEditor20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250429?>.Default.Equals(TextEditor20250429, other.TextEditor20250429) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250728?>.Default.Equals(TextEditor20250728, other.TextEditor20250728)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaClientToolUnion obj1, BetaClientToolUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaClientToolUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaClientToolUnion obj1, BetaClientToolUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaClientToolUnion o && Equals(o);
        }
    }
}
