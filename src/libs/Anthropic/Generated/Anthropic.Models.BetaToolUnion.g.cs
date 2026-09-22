#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct BetaToolUnion : global::System.IEquatable<BetaToolUnion>
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
        public global::Anthropic.BetaTool PickTool() => IsTool
            ? Tool!
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
        public global::Anthropic.BetaBashTool20241022 PickBashTool20241022() => IsBashTool20241022
            ? BashTool20241022!
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
        public global::Anthropic.BetaBashTool20250124 PickBashTool20250124() => IsBashTool20250124
            ? BashTool20250124!
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashTool20250124' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCodeExecutionTool20250522? CodeExecutionTool20250522 { get; init; }
#else
        public global::Anthropic.BetaCodeExecutionTool20250522? CodeExecutionTool20250522 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionTool20250522))]
#endif
        public bool IsCodeExecutionTool20250522 => CodeExecutionTool20250522 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionTool20250522(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCodeExecutionTool20250522? value)
        {
            value = CodeExecutionTool20250522;
            return IsCodeExecutionTool20250522;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250522 PickCodeExecutionTool20250522() => IsCodeExecutionTool20250522
            ? CodeExecutionTool20250522!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionTool20250522' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCodeExecutionTool20250825? CodeExecutionTool20250825 { get; init; }
#else
        public global::Anthropic.BetaCodeExecutionTool20250825? CodeExecutionTool20250825 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionTool20250825))]
#endif
        public bool IsCodeExecutionTool20250825 => CodeExecutionTool20250825 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionTool20250825(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCodeExecutionTool20250825? value)
        {
            value = CodeExecutionTool20250825;
            return IsCodeExecutionTool20250825;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20250825 PickCodeExecutionTool20250825() => IsCodeExecutionTool20250825
            ? CodeExecutionTool20250825!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionTool20250825' but the value was {ToString()}.");

        /// <summary>
        /// Code execution tool with REPL state persistence (daemon mode + gVisor checkpoint).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCodeExecutionTool20260120? CodeExecutionTool20260120 { get; init; }
#else
        public global::Anthropic.BetaCodeExecutionTool20260120? CodeExecutionTool20260120 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionTool20260120))]
#endif
        public bool IsCodeExecutionTool20260120 => CodeExecutionTool20260120 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionTool20260120(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCodeExecutionTool20260120? value)
        {
            value = CodeExecutionTool20260120;
            return IsCodeExecutionTool20260120;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260120 PickCodeExecutionTool20260120() => IsCodeExecutionTool20260120
            ? CodeExecutionTool20260120!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionTool20260120' but the value was {ToString()}.");

        /// <summary>
        /// Code execution tool with REPL state persistence.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCodeExecutionTool20260521? CodeExecutionTool20260521 { get; init; }
#else
        public global::Anthropic.BetaCodeExecutionTool20260521? CodeExecutionTool20260521 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CodeExecutionTool20260521))]
#endif
        public bool IsCodeExecutionTool20260521 => CodeExecutionTool20260521 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCodeExecutionTool20260521(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaCodeExecutionTool20260521? value)
        {
            value = CodeExecutionTool20260521;
            return IsCodeExecutionTool20260521;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaCodeExecutionTool20260521 PickCodeExecutionTool20260521() => IsCodeExecutionTool20260521
            ? CodeExecutionTool20260521!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CodeExecutionTool20260521' but the value was {ToString()}.");

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
        public global::Anthropic.BetaBrowserToolset20260801 PickBrowserToolset20260801() => IsBrowserToolset20260801
            ? BrowserToolset20260801!
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
        public global::Anthropic.BetaComputerUseTool20241022 PickComputerUseTool20241022() => IsComputerUseTool20241022
            ? ComputerUseTool20241022!
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
        public global::Anthropic.BetaMemoryTool20250818 PickMemoryTool20250818() => IsMemoryTool20250818
            ? MemoryTool20250818!
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
        public global::Anthropic.BetaComputerUseTool20250124 PickComputerUseTool20250124() => IsComputerUseTool20250124
            ? ComputerUseTool20250124!
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
        public global::Anthropic.BetaTextEditor20241022 PickTextEditor20241022() => IsTextEditor20241022
            ? TextEditor20241022!
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
        public global::Anthropic.BetaComputerUseTool20251124 PickComputerUseTool20251124() => IsComputerUseTool20251124
            ? ComputerUseTool20251124!
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
        public global::Anthropic.BetaComputerToolset20260801 PickComputerToolset20260801() => IsComputerToolset20260801
            ? ComputerToolset20260801!
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
        public global::Anthropic.BetaTextEditor20250124 PickTextEditor20250124() => IsTextEditor20250124
            ? TextEditor20250124!
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
        public global::Anthropic.BetaTextEditor20250429 PickTextEditor20250429() => IsTextEditor20250429
            ? TextEditor20250429!
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
        public global::Anthropic.BetaTextEditor20250728 PickTextEditor20250728() => IsTextEditor20250728
            ? TextEditor20250728!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250728' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebSearchTool20250305? WebSearchTool20250305 { get; init; }
#else
        public global::Anthropic.BetaWebSearchTool20250305? WebSearchTool20250305 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchTool20250305))]
#endif
        public bool IsWebSearchTool20250305 => WebSearchTool20250305 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchTool20250305(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebSearchTool20250305? value)
        {
            value = WebSearchTool20250305;
            return IsWebSearchTool20250305;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20250305 PickWebSearchTool20250305() => IsWebSearchTool20250305
            ? WebSearchTool20250305!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchTool20250305' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchTool20250910? WebFetchTool20250910 { get; init; }
#else
        public global::Anthropic.BetaWebFetchTool20250910? WebFetchTool20250910 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchTool20250910))]
#endif
        public bool IsWebFetchTool20250910 => WebFetchTool20250910 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchTool20250910(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchTool20250910? value)
        {
            value = WebFetchTool20250910;
            return IsWebFetchTool20250910;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20250910 PickWebFetchTool20250910() => IsWebFetchTool20250910
            ? WebFetchTool20250910!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchTool20250910' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebSearchTool20260209? WebSearchTool20260209 { get; init; }
#else
        public global::Anthropic.BetaWebSearchTool20260209? WebSearchTool20260209 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchTool20260209))]
#endif
        public bool IsWebSearchTool20260209 => WebSearchTool20260209 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchTool20260209(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebSearchTool20260209? value)
        {
            value = WebSearchTool20260209;
            return IsWebSearchTool20260209;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260209 PickWebSearchTool20260209() => IsWebSearchTool20260209
            ? WebSearchTool20260209!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchTool20260209' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchTool20260209? WebFetchTool20260209 { get; init; }
#else
        public global::Anthropic.BetaWebFetchTool20260209? WebFetchTool20260209 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchTool20260209))]
#endif
        public bool IsWebFetchTool20260209 => WebFetchTool20260209 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchTool20260209(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchTool20260209? value)
        {
            value = WebFetchTool20260209;
            return IsWebFetchTool20260209;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260209 PickWebFetchTool20260209() => IsWebFetchTool20260209
            ? WebFetchTool20260209!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchTool20260209' but the value was {ToString()}.");

        /// <summary>
        /// Web fetch tool with use_cache parameter for bypassing cached content.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchTool20260309? WebFetchTool20260309 { get; init; }
#else
        public global::Anthropic.BetaWebFetchTool20260309? WebFetchTool20260309 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchTool20260309))]
#endif
        public bool IsWebFetchTool20260309 => WebFetchTool20260309 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchTool20260309(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchTool20260309? value)
        {
            value = WebFetchTool20260309;
            return IsWebFetchTool20260309;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260309 PickWebFetchTool20260309() => IsWebFetchTool20260309
            ? WebFetchTool20260309!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchTool20260309' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebSearchTool20260318? WebSearchTool20260318 { get; init; }
#else
        public global::Anthropic.BetaWebSearchTool20260318? WebSearchTool20260318 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchTool20260318))]
#endif
        public bool IsWebSearchTool20260318 => WebSearchTool20260318 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearchTool20260318(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebSearchTool20260318? value)
        {
            value = WebSearchTool20260318;
            return IsWebSearchTool20260318;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebSearchTool20260318 PickWebSearchTool20260318() => IsWebSearchTool20260318
            ? WebSearchTool20260318!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearchTool20260318' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchTool20260318? WebFetchTool20260318 { get; init; }
#else
        public global::Anthropic.BetaWebFetchTool20260318? WebFetchTool20260318 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetchTool20260318))]
#endif
        public bool IsWebFetchTool20260318 => WebFetchTool20260318 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetchTool20260318(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchTool20260318? value)
        {
            value = WebFetchTool20260318;
            return IsWebFetchTool20260318;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchTool20260318 PickWebFetchTool20260318() => IsWebFetchTool20260318
            ? WebFetchTool20260318!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetchTool20260318' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAdvisorTool20260301? AdvisorTool20260301 { get; init; }
#else
        public global::Anthropic.BetaAdvisorTool20260301? AdvisorTool20260301 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AdvisorTool20260301))]
#endif
        public bool IsAdvisorTool20260301 => AdvisorTool20260301 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAdvisorTool20260301(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAdvisorTool20260301? value)
        {
            value = AdvisorTool20260301;
            return IsAdvisorTool20260301;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAdvisorTool20260301 PickAdvisorTool20260301() => IsAdvisorTool20260301
            ? AdvisorTool20260301!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AdvisorTool20260301' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolSearchToolBM2520251119? ToolSearchToolBM2520251119 { get; init; }
#else
        public global::Anthropic.BetaToolSearchToolBM2520251119? ToolSearchToolBM2520251119 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolBM2520251119))]
#endif
        public bool IsToolSearchToolBM2520251119 => ToolSearchToolBM2520251119 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchToolBM2520251119(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolSearchToolBM2520251119? value)
        {
            value = ToolSearchToolBM2520251119;
            return IsToolSearchToolBM2520251119;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolBM2520251119 PickToolSearchToolBM2520251119() => IsToolSearchToolBM2520251119
            ? ToolSearchToolBM2520251119!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolBM2520251119' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaToolSearchToolRegex20251119? ToolSearchToolRegex20251119 { get; init; }
#else
        public global::Anthropic.BetaToolSearchToolRegex20251119? ToolSearchToolRegex20251119 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolSearchToolRegex20251119))]
#endif
        public bool IsToolSearchToolRegex20251119 => ToolSearchToolRegex20251119 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolSearchToolRegex20251119(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaToolSearchToolRegex20251119? value)
        {
            value = ToolSearchToolRegex20251119;
            return IsToolSearchToolRegex20251119;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaToolSearchToolRegex20251119 PickToolSearchToolRegex20251119() => IsToolSearchToolRegex20251119
            ? ToolSearchToolRegex20251119!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolSearchToolRegex20251119' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for a group of tools from an MCP server.<br/>
        /// Allows configuring enabled status and defer_loading for all tools<br/>
        /// from an MCP server, with optional per-tool overrides.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMCPToolset? MCPToolset { get; init; }
#else
        public global::Anthropic.BetaMCPToolset? MCPToolset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MCPToolset))]
#endif
        public bool IsMCPToolset => MCPToolset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMCPToolset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaMCPToolset? value)
        {
            value = MCPToolset;
            return IsMCPToolset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaMCPToolset PickMCPToolset() => IsMCPToolset
            ? MCPToolset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MCPToolset' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaTool value) => new BetaToolUnion((global::Anthropic.BetaTool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTool?(BetaToolUnion @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaTool? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromTool(global::Anthropic.BetaTool? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaBashTool20241022 value) => new BetaToolUnion((global::Anthropic.BetaBashTool20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBashTool20241022?(BetaToolUnion @this) => @this.BashTool20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaBashTool20241022? value)
        {
            BashTool20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromBashTool20241022(global::Anthropic.BetaBashTool20241022? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaBashTool20250124 value) => new BetaToolUnion((global::Anthropic.BetaBashTool20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBashTool20250124?(BetaToolUnion @this) => @this.BashTool20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaBashTool20250124? value)
        {
            BashTool20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromBashTool20250124(global::Anthropic.BetaBashTool20250124? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20250522 value) => new BetaToolUnion((global::Anthropic.BetaCodeExecutionTool20250522?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCodeExecutionTool20250522?(BetaToolUnion @this) => @this.CodeExecutionTool20250522;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20250522? value)
        {
            CodeExecutionTool20250522 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromCodeExecutionTool20250522(global::Anthropic.BetaCodeExecutionTool20250522? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20250825 value) => new BetaToolUnion((global::Anthropic.BetaCodeExecutionTool20250825?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCodeExecutionTool20250825?(BetaToolUnion @this) => @this.CodeExecutionTool20250825;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20250825? value)
        {
            CodeExecutionTool20250825 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromCodeExecutionTool20250825(global::Anthropic.BetaCodeExecutionTool20250825? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20260120 value) => new BetaToolUnion((global::Anthropic.BetaCodeExecutionTool20260120?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCodeExecutionTool20260120?(BetaToolUnion @this) => @this.CodeExecutionTool20260120;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20260120? value)
        {
            CodeExecutionTool20260120 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromCodeExecutionTool20260120(global::Anthropic.BetaCodeExecutionTool20260120? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20260521 value) => new BetaToolUnion((global::Anthropic.BetaCodeExecutionTool20260521?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaCodeExecutionTool20260521?(BetaToolUnion @this) => @this.CodeExecutionTool20260521;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaCodeExecutionTool20260521? value)
        {
            CodeExecutionTool20260521 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromCodeExecutionTool20260521(global::Anthropic.BetaCodeExecutionTool20260521? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaBrowserToolset20260801 value) => new BetaToolUnion((global::Anthropic.BetaBrowserToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserToolset20260801?(BetaToolUnion @this) => @this.BrowserToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaBrowserToolset20260801? value)
        {
            BrowserToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromBrowserToolset20260801(global::Anthropic.BetaBrowserToolset20260801? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaComputerUseTool20241022 value) => new BetaToolUnion((global::Anthropic.BetaComputerUseTool20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20241022?(BetaToolUnion @this) => @this.ComputerUseTool20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaComputerUseTool20241022? value)
        {
            ComputerUseTool20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromComputerUseTool20241022(global::Anthropic.BetaComputerUseTool20241022? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaMemoryTool20250818 value) => new BetaToolUnion((global::Anthropic.BetaMemoryTool20250818?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818?(BetaToolUnion @this) => @this.MemoryTool20250818;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaMemoryTool20250818? value)
        {
            MemoryTool20250818 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromMemoryTool20250818(global::Anthropic.BetaMemoryTool20250818? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaComputerUseTool20250124 value) => new BetaToolUnion((global::Anthropic.BetaComputerUseTool20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20250124?(BetaToolUnion @this) => @this.ComputerUseTool20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaComputerUseTool20250124? value)
        {
            ComputerUseTool20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromComputerUseTool20250124(global::Anthropic.BetaComputerUseTool20250124? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaTextEditor20241022 value) => new BetaToolUnion((global::Anthropic.BetaTextEditor20241022?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20241022?(BetaToolUnion @this) => @this.TextEditor20241022;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaTextEditor20241022? value)
        {
            TextEditor20241022 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromTextEditor20241022(global::Anthropic.BetaTextEditor20241022? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaComputerUseTool20251124 value) => new BetaToolUnion((global::Anthropic.BetaComputerUseTool20251124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerUseTool20251124?(BetaToolUnion @this) => @this.ComputerUseTool20251124;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaComputerUseTool20251124? value)
        {
            ComputerUseTool20251124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromComputerUseTool20251124(global::Anthropic.BetaComputerUseTool20251124? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaComputerToolset20260801 value) => new BetaToolUnion((global::Anthropic.BetaComputerToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaComputerToolset20260801?(BetaToolUnion @this) => @this.ComputerToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaComputerToolset20260801? value)
        {
            ComputerToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromComputerToolset20260801(global::Anthropic.BetaComputerToolset20260801? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaTextEditor20250124 value) => new BetaToolUnion((global::Anthropic.BetaTextEditor20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250124?(BetaToolUnion @this) => @this.TextEditor20250124;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaTextEditor20250124? value)
        {
            TextEditor20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromTextEditor20250124(global::Anthropic.BetaTextEditor20250124? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaTextEditor20250429 value) => new BetaToolUnion((global::Anthropic.BetaTextEditor20250429?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250429?(BetaToolUnion @this) => @this.TextEditor20250429;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaTextEditor20250429? value)
        {
            TextEditor20250429 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromTextEditor20250429(global::Anthropic.BetaTextEditor20250429? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaTextEditor20250728 value) => new BetaToolUnion((global::Anthropic.BetaTextEditor20250728?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTextEditor20250728?(BetaToolUnion @this) => @this.TextEditor20250728;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaTextEditor20250728? value)
        {
            TextEditor20250728 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromTextEditor20250728(global::Anthropic.BetaTextEditor20250728? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebSearchTool20250305 value) => new BetaToolUnion((global::Anthropic.BetaWebSearchTool20250305?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebSearchTool20250305?(BetaToolUnion @this) => @this.WebSearchTool20250305;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebSearchTool20250305? value)
        {
            WebSearchTool20250305 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebSearchTool20250305(global::Anthropic.BetaWebSearchTool20250305? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebFetchTool20250910 value) => new BetaToolUnion((global::Anthropic.BetaWebFetchTool20250910?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchTool20250910?(BetaToolUnion @this) => @this.WebFetchTool20250910;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebFetchTool20250910? value)
        {
            WebFetchTool20250910 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebFetchTool20250910(global::Anthropic.BetaWebFetchTool20250910? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebSearchTool20260209 value) => new BetaToolUnion((global::Anthropic.BetaWebSearchTool20260209?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebSearchTool20260209?(BetaToolUnion @this) => @this.WebSearchTool20260209;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebSearchTool20260209? value)
        {
            WebSearchTool20260209 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebSearchTool20260209(global::Anthropic.BetaWebSearchTool20260209? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebFetchTool20260209 value) => new BetaToolUnion((global::Anthropic.BetaWebFetchTool20260209?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchTool20260209?(BetaToolUnion @this) => @this.WebFetchTool20260209;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebFetchTool20260209? value)
        {
            WebFetchTool20260209 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebFetchTool20260209(global::Anthropic.BetaWebFetchTool20260209? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebFetchTool20260309 value) => new BetaToolUnion((global::Anthropic.BetaWebFetchTool20260309?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchTool20260309?(BetaToolUnion @this) => @this.WebFetchTool20260309;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebFetchTool20260309? value)
        {
            WebFetchTool20260309 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebFetchTool20260309(global::Anthropic.BetaWebFetchTool20260309? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebSearchTool20260318 value) => new BetaToolUnion((global::Anthropic.BetaWebSearchTool20260318?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebSearchTool20260318?(BetaToolUnion @this) => @this.WebSearchTool20260318;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebSearchTool20260318? value)
        {
            WebSearchTool20260318 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebSearchTool20260318(global::Anthropic.BetaWebSearchTool20260318? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaWebFetchTool20260318 value) => new BetaToolUnion((global::Anthropic.BetaWebFetchTool20260318?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchTool20260318?(BetaToolUnion @this) => @this.WebFetchTool20260318;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaWebFetchTool20260318? value)
        {
            WebFetchTool20260318 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromWebFetchTool20260318(global::Anthropic.BetaWebFetchTool20260318? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaAdvisorTool20260301 value) => new BetaToolUnion((global::Anthropic.BetaAdvisorTool20260301?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAdvisorTool20260301?(BetaToolUnion @this) => @this.AdvisorTool20260301;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaAdvisorTool20260301? value)
        {
            AdvisorTool20260301 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromAdvisorTool20260301(global::Anthropic.BetaAdvisorTool20260301? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaToolSearchToolBM2520251119 value) => new BetaToolUnion((global::Anthropic.BetaToolSearchToolBM2520251119?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolSearchToolBM2520251119?(BetaToolUnion @this) => @this.ToolSearchToolBM2520251119;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaToolSearchToolBM2520251119? value)
        {
            ToolSearchToolBM2520251119 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromToolSearchToolBM2520251119(global::Anthropic.BetaToolSearchToolBM2520251119? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaToolSearchToolRegex20251119 value) => new BetaToolUnion((global::Anthropic.BetaToolSearchToolRegex20251119?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaToolSearchToolRegex20251119?(BetaToolUnion @this) => @this.ToolSearchToolRegex20251119;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaToolSearchToolRegex20251119? value)
        {
            ToolSearchToolRegex20251119 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromToolSearchToolRegex20251119(global::Anthropic.BetaToolSearchToolRegex20251119? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaToolUnion(global::Anthropic.BetaMCPToolset value) => new BetaToolUnion((global::Anthropic.BetaMCPToolset?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaMCPToolset?(BetaToolUnion @this) => @this.MCPToolset;

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(global::Anthropic.BetaMCPToolset? value)
        {
            MCPToolset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaToolUnion FromMCPToolset(global::Anthropic.BetaMCPToolset? value) => new BetaToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaToolUnion(
            global::Anthropic.BetaTool? tool,
            global::Anthropic.BetaBashTool20241022? bashTool20241022,
            global::Anthropic.BetaBashTool20250124? bashTool20250124,
            global::Anthropic.BetaCodeExecutionTool20250522? codeExecutionTool20250522,
            global::Anthropic.BetaCodeExecutionTool20250825? codeExecutionTool20250825,
            global::Anthropic.BetaCodeExecutionTool20260120? codeExecutionTool20260120,
            global::Anthropic.BetaCodeExecutionTool20260521? codeExecutionTool20260521,
            global::Anthropic.BetaBrowserToolset20260801? browserToolset20260801,
            global::Anthropic.BetaComputerUseTool20241022? computerUseTool20241022,
            global::Anthropic.BetaMemoryTool20250818? memoryTool20250818,
            global::Anthropic.BetaComputerUseTool20250124? computerUseTool20250124,
            global::Anthropic.BetaTextEditor20241022? textEditor20241022,
            global::Anthropic.BetaComputerUseTool20251124? computerUseTool20251124,
            global::Anthropic.BetaComputerToolset20260801? computerToolset20260801,
            global::Anthropic.BetaTextEditor20250124? textEditor20250124,
            global::Anthropic.BetaTextEditor20250429? textEditor20250429,
            global::Anthropic.BetaTextEditor20250728? textEditor20250728,
            global::Anthropic.BetaWebSearchTool20250305? webSearchTool20250305,
            global::Anthropic.BetaWebFetchTool20250910? webFetchTool20250910,
            global::Anthropic.BetaWebSearchTool20260209? webSearchTool20260209,
            global::Anthropic.BetaWebFetchTool20260209? webFetchTool20260209,
            global::Anthropic.BetaWebFetchTool20260309? webFetchTool20260309,
            global::Anthropic.BetaWebSearchTool20260318? webSearchTool20260318,
            global::Anthropic.BetaWebFetchTool20260318? webFetchTool20260318,
            global::Anthropic.BetaAdvisorTool20260301? advisorTool20260301,
            global::Anthropic.BetaToolSearchToolBM2520251119? toolSearchToolBM2520251119,
            global::Anthropic.BetaToolSearchToolRegex20251119? toolSearchToolRegex20251119,
            global::Anthropic.BetaMCPToolset? mCPToolset
            )
        {
            Tool = tool;
            BashTool20241022 = bashTool20241022;
            BashTool20250124 = bashTool20250124;
            CodeExecutionTool20250522 = codeExecutionTool20250522;
            CodeExecutionTool20250825 = codeExecutionTool20250825;
            CodeExecutionTool20260120 = codeExecutionTool20260120;
            CodeExecutionTool20260521 = codeExecutionTool20260521;
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
            WebSearchTool20250305 = webSearchTool20250305;
            WebFetchTool20250910 = webFetchTool20250910;
            WebSearchTool20260209 = webSearchTool20260209;
            WebFetchTool20260209 = webFetchTool20260209;
            WebFetchTool20260309 = webFetchTool20260309;
            WebSearchTool20260318 = webSearchTool20260318;
            WebFetchTool20260318 = webFetchTool20260318;
            AdvisorTool20260301 = advisorTool20260301;
            ToolSearchToolBM2520251119 = toolSearchToolBM2520251119;
            ToolSearchToolRegex20251119 = toolSearchToolRegex20251119;
            MCPToolset = mCPToolset;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MCPToolset as object ??
            ToolSearchToolRegex20251119 as object ??
            ToolSearchToolBM2520251119 as object ??
            AdvisorTool20260301 as object ??
            WebFetchTool20260318 as object ??
            WebSearchTool20260318 as object ??
            WebFetchTool20260309 as object ??
            WebFetchTool20260209 as object ??
            WebSearchTool20260209 as object ??
            WebFetchTool20250910 as object ??
            WebSearchTool20250305 as object ??
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
            CodeExecutionTool20260521 as object ??
            CodeExecutionTool20260120 as object ??
            CodeExecutionTool20250825 as object ??
            CodeExecutionTool20250522 as object ??
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
            CodeExecutionTool20250522?.ToString() ??
            CodeExecutionTool20250825?.ToString() ??
            CodeExecutionTool20260120?.ToString() ??
            CodeExecutionTool20260521?.ToString() ??
            BrowserToolset20260801?.ToString() ??
            ComputerUseTool20241022?.ToString() ??
            MemoryTool20250818?.ToString() ??
            ComputerUseTool20250124?.ToString() ??
            TextEditor20241022?.ToString() ??
            ComputerUseTool20251124?.ToString() ??
            ComputerToolset20260801?.ToString() ??
            TextEditor20250124?.ToString() ??
            TextEditor20250429?.ToString() ??
            TextEditor20250728?.ToString() ??
            WebSearchTool20250305?.ToString() ??
            WebFetchTool20250910?.ToString() ??
            WebSearchTool20260209?.ToString() ??
            WebFetchTool20260209?.ToString() ??
            WebFetchTool20260309?.ToString() ??
            WebSearchTool20260318?.ToString() ??
            WebFetchTool20260318?.ToString() ??
            AdvisorTool20260301?.ToString() ??
            ToolSearchToolBM2520251119?.ToString() ??
            ToolSearchToolRegex20251119?.ToString() ??
            MCPToolset?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && IsToolSearchToolRegex20251119 && !IsMCPToolset || !IsTool && !IsBashTool20241022 && !IsBashTool20250124 && !IsCodeExecutionTool20250522 && !IsCodeExecutionTool20250825 && !IsCodeExecutionTool20260120 && !IsCodeExecutionTool20260521 && !IsBrowserToolset20260801 && !IsComputerUseTool20241022 && !IsMemoryTool20250818 && !IsComputerUseTool20250124 && !IsTextEditor20241022 && !IsComputerUseTool20251124 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 && !IsWebSearchTool20250305 && !IsWebFetchTool20250910 && !IsWebSearchTool20260209 && !IsWebFetchTool20260209 && !IsWebFetchTool20260309 && !IsWebSearchTool20260318 && !IsWebFetchTool20260318 && !IsAdvisorTool20260301 && !IsToolSearchToolBM2520251119 && !IsToolSearchToolRegex20251119 && IsMCPToolset;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTool, TResult>? tool = null,
            global::System.Func<global::Anthropic.BetaBashTool20241022, TResult>? bashTool20241022 = null,
            global::System.Func<global::Anthropic.BetaBashTool20250124, TResult>? bashTool20250124 = null,
            global::System.Func<global::Anthropic.BetaCodeExecutionTool20250522, TResult>? codeExecutionTool20250522 = null,
            global::System.Func<global::Anthropic.BetaCodeExecutionTool20250825, TResult>? codeExecutionTool20250825 = null,
            global::System.Func<global::Anthropic.BetaCodeExecutionTool20260120, TResult>? codeExecutionTool20260120 = null,
            global::System.Func<global::Anthropic.BetaCodeExecutionTool20260521, TResult>? codeExecutionTool20260521 = null,
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
            global::System.Func<global::Anthropic.BetaWebSearchTool20250305, TResult>? webSearchTool20250305 = null,
            global::System.Func<global::Anthropic.BetaWebFetchTool20250910, TResult>? webFetchTool20250910 = null,
            global::System.Func<global::Anthropic.BetaWebSearchTool20260209, TResult>? webSearchTool20260209 = null,
            global::System.Func<global::Anthropic.BetaWebFetchTool20260209, TResult>? webFetchTool20260209 = null,
            global::System.Func<global::Anthropic.BetaWebFetchTool20260309, TResult>? webFetchTool20260309 = null,
            global::System.Func<global::Anthropic.BetaWebSearchTool20260318, TResult>? webSearchTool20260318 = null,
            global::System.Func<global::Anthropic.BetaWebFetchTool20260318, TResult>? webFetchTool20260318 = null,
            global::System.Func<global::Anthropic.BetaAdvisorTool20260301, TResult>? advisorTool20260301 = null,
            global::System.Func<global::Anthropic.BetaToolSearchToolBM2520251119, TResult>? toolSearchToolBM2520251119 = null,
            global::System.Func<global::Anthropic.BetaToolSearchToolRegex20251119, TResult>? toolSearchToolRegex20251119 = null,
            global::System.Func<global::Anthropic.BetaMCPToolset, TResult>? mCPToolset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsBashTool20241022 && bashTool20241022 != null)
            {
                return bashTool20241022(BashTool20241022!);
            }
            else if (IsBashTool20250124 && bashTool20250124 != null)
            {
                return bashTool20250124(BashTool20250124!);
            }
            else if (IsCodeExecutionTool20250522 && codeExecutionTool20250522 != null)
            {
                return codeExecutionTool20250522(CodeExecutionTool20250522!);
            }
            else if (IsCodeExecutionTool20250825 && codeExecutionTool20250825 != null)
            {
                return codeExecutionTool20250825(CodeExecutionTool20250825!);
            }
            else if (IsCodeExecutionTool20260120 && codeExecutionTool20260120 != null)
            {
                return codeExecutionTool20260120(CodeExecutionTool20260120!);
            }
            else if (IsCodeExecutionTool20260521 && codeExecutionTool20260521 != null)
            {
                return codeExecutionTool20260521(CodeExecutionTool20260521!);
            }
            else if (IsBrowserToolset20260801 && browserToolset20260801 != null)
            {
                return browserToolset20260801(BrowserToolset20260801!);
            }
            else if (IsComputerUseTool20241022 && computerUseTool20241022 != null)
            {
                return computerUseTool20241022(ComputerUseTool20241022!);
            }
            else if (IsMemoryTool20250818 && memoryTool20250818 != null)
            {
                return memoryTool20250818(MemoryTool20250818!);
            }
            else if (IsComputerUseTool20250124 && computerUseTool20250124 != null)
            {
                return computerUseTool20250124(ComputerUseTool20250124!);
            }
            else if (IsTextEditor20241022 && textEditor20241022 != null)
            {
                return textEditor20241022(TextEditor20241022!);
            }
            else if (IsComputerUseTool20251124 && computerUseTool20251124 != null)
            {
                return computerUseTool20251124(ComputerUseTool20251124!);
            }
            else if (IsComputerToolset20260801 && computerToolset20260801 != null)
            {
                return computerToolset20260801(ComputerToolset20260801!);
            }
            else if (IsTextEditor20250124 && textEditor20250124 != null)
            {
                return textEditor20250124(TextEditor20250124!);
            }
            else if (IsTextEditor20250429 && textEditor20250429 != null)
            {
                return textEditor20250429(TextEditor20250429!);
            }
            else if (IsTextEditor20250728 && textEditor20250728 != null)
            {
                return textEditor20250728(TextEditor20250728!);
            }
            else if (IsWebSearchTool20250305 && webSearchTool20250305 != null)
            {
                return webSearchTool20250305(WebSearchTool20250305!);
            }
            else if (IsWebFetchTool20250910 && webFetchTool20250910 != null)
            {
                return webFetchTool20250910(WebFetchTool20250910!);
            }
            else if (IsWebSearchTool20260209 && webSearchTool20260209 != null)
            {
                return webSearchTool20260209(WebSearchTool20260209!);
            }
            else if (IsWebFetchTool20260209 && webFetchTool20260209 != null)
            {
                return webFetchTool20260209(WebFetchTool20260209!);
            }
            else if (IsWebFetchTool20260309 && webFetchTool20260309 != null)
            {
                return webFetchTool20260309(WebFetchTool20260309!);
            }
            else if (IsWebSearchTool20260318 && webSearchTool20260318 != null)
            {
                return webSearchTool20260318(WebSearchTool20260318!);
            }
            else if (IsWebFetchTool20260318 && webFetchTool20260318 != null)
            {
                return webFetchTool20260318(WebFetchTool20260318!);
            }
            else if (IsAdvisorTool20260301 && advisorTool20260301 != null)
            {
                return advisorTool20260301(AdvisorTool20260301!);
            }
            else if (IsToolSearchToolBM2520251119 && toolSearchToolBM2520251119 != null)
            {
                return toolSearchToolBM2520251119(ToolSearchToolBM2520251119!);
            }
            else if (IsToolSearchToolRegex20251119 && toolSearchToolRegex20251119 != null)
            {
                return toolSearchToolRegex20251119(ToolSearchToolRegex20251119!);
            }
            else if (IsMCPToolset && mCPToolset != null)
            {
                return mCPToolset(MCPToolset!);
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

            global::System.Action<global::Anthropic.BetaCodeExecutionTool20250522>? codeExecutionTool20250522 = null,

            global::System.Action<global::Anthropic.BetaCodeExecutionTool20250825>? codeExecutionTool20250825 = null,

            global::System.Action<global::Anthropic.BetaCodeExecutionTool20260120>? codeExecutionTool20260120 = null,

            global::System.Action<global::Anthropic.BetaCodeExecutionTool20260521>? codeExecutionTool20260521 = null,

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

            global::System.Action<global::Anthropic.BetaWebSearchTool20250305>? webSearchTool20250305 = null,

            global::System.Action<global::Anthropic.BetaWebFetchTool20250910>? webFetchTool20250910 = null,

            global::System.Action<global::Anthropic.BetaWebSearchTool20260209>? webSearchTool20260209 = null,

            global::System.Action<global::Anthropic.BetaWebFetchTool20260209>? webFetchTool20260209 = null,

            global::System.Action<global::Anthropic.BetaWebFetchTool20260309>? webFetchTool20260309 = null,

            global::System.Action<global::Anthropic.BetaWebSearchTool20260318>? webSearchTool20260318 = null,

            global::System.Action<global::Anthropic.BetaWebFetchTool20260318>? webFetchTool20260318 = null,

            global::System.Action<global::Anthropic.BetaAdvisorTool20260301>? advisorTool20260301 = null,

            global::System.Action<global::Anthropic.BetaToolSearchToolBM2520251119>? toolSearchToolBM2520251119 = null,

            global::System.Action<global::Anthropic.BetaToolSearchToolRegex20251119>? toolSearchToolRegex20251119 = null,

            global::System.Action<global::Anthropic.BetaMCPToolset>? mCPToolset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsBashTool20241022)
            {
                bashTool20241022?.Invoke(BashTool20241022!);
            }
            else if (IsBashTool20250124)
            {
                bashTool20250124?.Invoke(BashTool20250124!);
            }
            else if (IsCodeExecutionTool20250522)
            {
                codeExecutionTool20250522?.Invoke(CodeExecutionTool20250522!);
            }
            else if (IsCodeExecutionTool20250825)
            {
                codeExecutionTool20250825?.Invoke(CodeExecutionTool20250825!);
            }
            else if (IsCodeExecutionTool20260120)
            {
                codeExecutionTool20260120?.Invoke(CodeExecutionTool20260120!);
            }
            else if (IsCodeExecutionTool20260521)
            {
                codeExecutionTool20260521?.Invoke(CodeExecutionTool20260521!);
            }
            else if (IsBrowserToolset20260801)
            {
                browserToolset20260801?.Invoke(BrowserToolset20260801!);
            }
            else if (IsComputerUseTool20241022)
            {
                computerUseTool20241022?.Invoke(ComputerUseTool20241022!);
            }
            else if (IsMemoryTool20250818)
            {
                memoryTool20250818?.Invoke(MemoryTool20250818!);
            }
            else if (IsComputerUseTool20250124)
            {
                computerUseTool20250124?.Invoke(ComputerUseTool20250124!);
            }
            else if (IsTextEditor20241022)
            {
                textEditor20241022?.Invoke(TextEditor20241022!);
            }
            else if (IsComputerUseTool20251124)
            {
                computerUseTool20251124?.Invoke(ComputerUseTool20251124!);
            }
            else if (IsComputerToolset20260801)
            {
                computerToolset20260801?.Invoke(ComputerToolset20260801!);
            }
            else if (IsTextEditor20250124)
            {
                textEditor20250124?.Invoke(TextEditor20250124!);
            }
            else if (IsTextEditor20250429)
            {
                textEditor20250429?.Invoke(TextEditor20250429!);
            }
            else if (IsTextEditor20250728)
            {
                textEditor20250728?.Invoke(TextEditor20250728!);
            }
            else if (IsWebSearchTool20250305)
            {
                webSearchTool20250305?.Invoke(WebSearchTool20250305!);
            }
            else if (IsWebFetchTool20250910)
            {
                webFetchTool20250910?.Invoke(WebFetchTool20250910!);
            }
            else if (IsWebSearchTool20260209)
            {
                webSearchTool20260209?.Invoke(WebSearchTool20260209!);
            }
            else if (IsWebFetchTool20260209)
            {
                webFetchTool20260209?.Invoke(WebFetchTool20260209!);
            }
            else if (IsWebFetchTool20260309)
            {
                webFetchTool20260309?.Invoke(WebFetchTool20260309!);
            }
            else if (IsWebSearchTool20260318)
            {
                webSearchTool20260318?.Invoke(WebSearchTool20260318!);
            }
            else if (IsWebFetchTool20260318)
            {
                webFetchTool20260318?.Invoke(WebFetchTool20260318!);
            }
            else if (IsAdvisorTool20260301)
            {
                advisorTool20260301?.Invoke(AdvisorTool20260301!);
            }
            else if (IsToolSearchToolBM2520251119)
            {
                toolSearchToolBM2520251119?.Invoke(ToolSearchToolBM2520251119!);
            }
            else if (IsToolSearchToolRegex20251119)
            {
                toolSearchToolRegex20251119?.Invoke(ToolSearchToolRegex20251119!);
            }
            else if (IsMCPToolset)
            {
                mCPToolset?.Invoke(MCPToolset!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaTool>? tool = null,
            global::System.Action<global::Anthropic.BetaBashTool20241022>? bashTool20241022 = null,
            global::System.Action<global::Anthropic.BetaBashTool20250124>? bashTool20250124 = null,
            global::System.Action<global::Anthropic.BetaCodeExecutionTool20250522>? codeExecutionTool20250522 = null,
            global::System.Action<global::Anthropic.BetaCodeExecutionTool20250825>? codeExecutionTool20250825 = null,
            global::System.Action<global::Anthropic.BetaCodeExecutionTool20260120>? codeExecutionTool20260120 = null,
            global::System.Action<global::Anthropic.BetaCodeExecutionTool20260521>? codeExecutionTool20260521 = null,
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
            global::System.Action<global::Anthropic.BetaWebSearchTool20250305>? webSearchTool20250305 = null,
            global::System.Action<global::Anthropic.BetaWebFetchTool20250910>? webFetchTool20250910 = null,
            global::System.Action<global::Anthropic.BetaWebSearchTool20260209>? webSearchTool20260209 = null,
            global::System.Action<global::Anthropic.BetaWebFetchTool20260209>? webFetchTool20260209 = null,
            global::System.Action<global::Anthropic.BetaWebFetchTool20260309>? webFetchTool20260309 = null,
            global::System.Action<global::Anthropic.BetaWebSearchTool20260318>? webSearchTool20260318 = null,
            global::System.Action<global::Anthropic.BetaWebFetchTool20260318>? webFetchTool20260318 = null,
            global::System.Action<global::Anthropic.BetaAdvisorTool20260301>? advisorTool20260301 = null,
            global::System.Action<global::Anthropic.BetaToolSearchToolBM2520251119>? toolSearchToolBM2520251119 = null,
            global::System.Action<global::Anthropic.BetaToolSearchToolRegex20251119>? toolSearchToolRegex20251119 = null,
            global::System.Action<global::Anthropic.BetaMCPToolset>? mCPToolset = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsBashTool20241022)
            {
                bashTool20241022?.Invoke(BashTool20241022!);
            }
            else if (IsBashTool20250124)
            {
                bashTool20250124?.Invoke(BashTool20250124!);
            }
            else if (IsCodeExecutionTool20250522)
            {
                codeExecutionTool20250522?.Invoke(CodeExecutionTool20250522!);
            }
            else if (IsCodeExecutionTool20250825)
            {
                codeExecutionTool20250825?.Invoke(CodeExecutionTool20250825!);
            }
            else if (IsCodeExecutionTool20260120)
            {
                codeExecutionTool20260120?.Invoke(CodeExecutionTool20260120!);
            }
            else if (IsCodeExecutionTool20260521)
            {
                codeExecutionTool20260521?.Invoke(CodeExecutionTool20260521!);
            }
            else if (IsBrowserToolset20260801)
            {
                browserToolset20260801?.Invoke(BrowserToolset20260801!);
            }
            else if (IsComputerUseTool20241022)
            {
                computerUseTool20241022?.Invoke(ComputerUseTool20241022!);
            }
            else if (IsMemoryTool20250818)
            {
                memoryTool20250818?.Invoke(MemoryTool20250818!);
            }
            else if (IsComputerUseTool20250124)
            {
                computerUseTool20250124?.Invoke(ComputerUseTool20250124!);
            }
            else if (IsTextEditor20241022)
            {
                textEditor20241022?.Invoke(TextEditor20241022!);
            }
            else if (IsComputerUseTool20251124)
            {
                computerUseTool20251124?.Invoke(ComputerUseTool20251124!);
            }
            else if (IsComputerToolset20260801)
            {
                computerToolset20260801?.Invoke(ComputerToolset20260801!);
            }
            else if (IsTextEditor20250124)
            {
                textEditor20250124?.Invoke(TextEditor20250124!);
            }
            else if (IsTextEditor20250429)
            {
                textEditor20250429?.Invoke(TextEditor20250429!);
            }
            else if (IsTextEditor20250728)
            {
                textEditor20250728?.Invoke(TextEditor20250728!);
            }
            else if (IsWebSearchTool20250305)
            {
                webSearchTool20250305?.Invoke(WebSearchTool20250305!);
            }
            else if (IsWebFetchTool20250910)
            {
                webFetchTool20250910?.Invoke(WebFetchTool20250910!);
            }
            else if (IsWebSearchTool20260209)
            {
                webSearchTool20260209?.Invoke(WebSearchTool20260209!);
            }
            else if (IsWebFetchTool20260209)
            {
                webFetchTool20260209?.Invoke(WebFetchTool20260209!);
            }
            else if (IsWebFetchTool20260309)
            {
                webFetchTool20260309?.Invoke(WebFetchTool20260309!);
            }
            else if (IsWebSearchTool20260318)
            {
                webSearchTool20260318?.Invoke(WebSearchTool20260318!);
            }
            else if (IsWebFetchTool20260318)
            {
                webFetchTool20260318?.Invoke(WebFetchTool20260318!);
            }
            else if (IsAdvisorTool20260301)
            {
                advisorTool20260301?.Invoke(AdvisorTool20260301!);
            }
            else if (IsToolSearchToolBM2520251119)
            {
                toolSearchToolBM2520251119?.Invoke(ToolSearchToolBM2520251119!);
            }
            else if (IsToolSearchToolRegex20251119)
            {
                toolSearchToolRegex20251119?.Invoke(ToolSearchToolRegex20251119!);
            }
            else if (IsMCPToolset)
            {
                mCPToolset?.Invoke(MCPToolset!);
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
                CodeExecutionTool20250522,
                typeof(global::Anthropic.BetaCodeExecutionTool20250522),
                CodeExecutionTool20250825,
                typeof(global::Anthropic.BetaCodeExecutionTool20250825),
                CodeExecutionTool20260120,
                typeof(global::Anthropic.BetaCodeExecutionTool20260120),
                CodeExecutionTool20260521,
                typeof(global::Anthropic.BetaCodeExecutionTool20260521),
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
                WebSearchTool20250305,
                typeof(global::Anthropic.BetaWebSearchTool20250305),
                WebFetchTool20250910,
                typeof(global::Anthropic.BetaWebFetchTool20250910),
                WebSearchTool20260209,
                typeof(global::Anthropic.BetaWebSearchTool20260209),
                WebFetchTool20260209,
                typeof(global::Anthropic.BetaWebFetchTool20260209),
                WebFetchTool20260309,
                typeof(global::Anthropic.BetaWebFetchTool20260309),
                WebSearchTool20260318,
                typeof(global::Anthropic.BetaWebSearchTool20260318),
                WebFetchTool20260318,
                typeof(global::Anthropic.BetaWebFetchTool20260318),
                AdvisorTool20260301,
                typeof(global::Anthropic.BetaAdvisorTool20260301),
                ToolSearchToolBM2520251119,
                typeof(global::Anthropic.BetaToolSearchToolBM2520251119),
                ToolSearchToolRegex20251119,
                typeof(global::Anthropic.BetaToolSearchToolRegex20251119),
                MCPToolset,
                typeof(global::Anthropic.BetaMCPToolset),
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
        public bool Equals(BetaToolUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTool?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBashTool20241022?>.Default.Equals(BashTool20241022, other.BashTool20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBashTool20250124?>.Default.Equals(BashTool20250124, other.BashTool20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCodeExecutionTool20250522?>.Default.Equals(CodeExecutionTool20250522, other.CodeExecutionTool20250522) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCodeExecutionTool20250825?>.Default.Equals(CodeExecutionTool20250825, other.CodeExecutionTool20250825) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCodeExecutionTool20260120?>.Default.Equals(CodeExecutionTool20260120, other.CodeExecutionTool20260120) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCodeExecutionTool20260521?>.Default.Equals(CodeExecutionTool20260521, other.CodeExecutionTool20260521) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserToolset20260801?>.Default.Equals(BrowserToolset20260801, other.BrowserToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20241022?>.Default.Equals(ComputerUseTool20241022, other.ComputerUseTool20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818?>.Default.Equals(MemoryTool20250818, other.MemoryTool20250818) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20250124?>.Default.Equals(ComputerUseTool20250124, other.ComputerUseTool20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20241022?>.Default.Equals(TextEditor20241022, other.TextEditor20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerUseTool20251124?>.Default.Equals(ComputerUseTool20251124, other.ComputerUseTool20251124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaComputerToolset20260801?>.Default.Equals(ComputerToolset20260801, other.ComputerToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250124?>.Default.Equals(TextEditor20250124, other.TextEditor20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250429?>.Default.Equals(TextEditor20250429, other.TextEditor20250429) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTextEditor20250728?>.Default.Equals(TextEditor20250728, other.TextEditor20250728) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebSearchTool20250305?>.Default.Equals(WebSearchTool20250305, other.WebSearchTool20250305) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchTool20250910?>.Default.Equals(WebFetchTool20250910, other.WebFetchTool20250910) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebSearchTool20260209?>.Default.Equals(WebSearchTool20260209, other.WebSearchTool20260209) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchTool20260209?>.Default.Equals(WebFetchTool20260209, other.WebFetchTool20260209) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchTool20260309?>.Default.Equals(WebFetchTool20260309, other.WebFetchTool20260309) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebSearchTool20260318?>.Default.Equals(WebSearchTool20260318, other.WebSearchTool20260318) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchTool20260318?>.Default.Equals(WebFetchTool20260318, other.WebFetchTool20260318) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAdvisorTool20260301?>.Default.Equals(AdvisorTool20260301, other.AdvisorTool20260301) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolSearchToolBM2520251119?>.Default.Equals(ToolSearchToolBM2520251119, other.ToolSearchToolBM2520251119) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaToolSearchToolRegex20251119?>.Default.Equals(ToolSearchToolRegex20251119, other.ToolSearchToolRegex20251119) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMCPToolset?>.Default.Equals(MCPToolset, other.MCPToolset)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaToolUnion obj1, BetaToolUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaToolUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaToolUnion obj1, BetaToolUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaToolUnion o && Equals(o);
        }
    }
}
