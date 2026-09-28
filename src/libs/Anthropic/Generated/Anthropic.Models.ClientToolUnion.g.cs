#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A tool that the client executes: the caller runs each `tool_use` request<br/>
    /// for it and returns the output in a `tool_result` block.
    /// </summary>
    public readonly partial struct ClientToolUnion : global::System.IEquatable<ClientToolUnion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.Tool5? Tool { get; init; }
#else
        public global::Anthropic.Tool5? Tool { get; }
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
            out global::Anthropic.Tool5? value)
        {
            value = Tool;
            return IsTool;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.Tool5 PickTool() => Tool is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Tool' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BashTool20250124? BashTool20250124 { get; init; }
#else
        public global::Anthropic.BashTool20250124? BashTool20250124 { get; }
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
            out global::Anthropic.BashTool20250124? value)
        {
            value = BashTool20250124;
            return IsBashTool20250124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BashTool20250124 PickBashTool20250124() => BashTool20250124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BashTool20250124' but the value was {ToString()}.");

        /// <summary>
        /// The browser toolset: a single ``tools[]`` entry (carrying no<br/>
        /// ``name``) that declares the browser tool family. The model is served<br/>
        /// the family's tool with any members disabled via ``configs`` removed<br/>
        /// from its schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserToolset20260801? BrowserToolset20260801 { get; init; }
#else
        public global::Anthropic.BrowserToolset20260801? BrowserToolset20260801 { get; }
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
            out global::Anthropic.BrowserToolset20260801? value)
        {
            value = BrowserToolset20260801;
            return IsBrowserToolset20260801;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserToolset20260801 PickBrowserToolset20260801() => BrowserToolset20260801 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BrowserToolset20260801' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.MemoryTool20250818? MemoryTool20250818 { get; init; }
#else
        public global::Anthropic.MemoryTool20250818? MemoryTool20250818 { get; }
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
            out global::Anthropic.MemoryTool20250818? value)
        {
            value = MemoryTool20250818;
            return IsMemoryTool20250818;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.MemoryTool20250818 PickMemoryTool20250818() => MemoryTool20250818 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryTool20250818' but the value was {ToString()}.");

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
        public global::Anthropic.ComputerToolset20260801? ComputerToolset20260801 { get; init; }
#else
        public global::Anthropic.ComputerToolset20260801? ComputerToolset20260801 { get; }
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
            out global::Anthropic.ComputerToolset20260801? value)
        {
            value = ComputerToolset20260801;
            return IsComputerToolset20260801;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ComputerToolset20260801 PickComputerToolset20260801() => ComputerToolset20260801 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ComputerToolset20260801' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextEditor20250124? TextEditor20250124 { get; init; }
#else
        public global::Anthropic.TextEditor20250124? TextEditor20250124 { get; }
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
            out global::Anthropic.TextEditor20250124? value)
        {
            value = TextEditor20250124;
            return IsTextEditor20250124;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250124 PickTextEditor20250124() => TextEditor20250124 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250124' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextEditor20250429? TextEditor20250429 { get; init; }
#else
        public global::Anthropic.TextEditor20250429? TextEditor20250429 { get; }
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
            out global::Anthropic.TextEditor20250429? value)
        {
            value = TextEditor20250429;
            return IsTextEditor20250429;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250429 PickTextEditor20250429() => TextEditor20250429 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250429' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.TextEditor20250728? TextEditor20250728 { get; init; }
#else
        public global::Anthropic.TextEditor20250728? TextEditor20250728 { get; }
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
            out global::Anthropic.TextEditor20250728? value)
        {
            value = TextEditor20250728;
            return IsTextEditor20250728;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.TextEditor20250728 PickTextEditor20250728() => TextEditor20250728 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextEditor20250728' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.Tool5 value) => new ClientToolUnion((global::Anthropic.Tool5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.Tool5?(ClientToolUnion @this) => @this.Tool;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.Tool5? value)
        {
            Tool = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromTool(global::Anthropic.Tool5? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.BashTool20250124 value) => new ClientToolUnion((global::Anthropic.BashTool20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BashTool20250124?(ClientToolUnion @this) => @this.BashTool20250124;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.BashTool20250124? value)
        {
            BashTool20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromBashTool20250124(global::Anthropic.BashTool20250124? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.BrowserToolset20260801 value) => new ClientToolUnion((global::Anthropic.BrowserToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserToolset20260801?(ClientToolUnion @this) => @this.BrowserToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.BrowserToolset20260801? value)
        {
            BrowserToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromBrowserToolset20260801(global::Anthropic.BrowserToolset20260801? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.MemoryTool20250818 value) => new ClientToolUnion((global::Anthropic.MemoryTool20250818?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.MemoryTool20250818?(ClientToolUnion @this) => @this.MemoryTool20250818;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.MemoryTool20250818? value)
        {
            MemoryTool20250818 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromMemoryTool20250818(global::Anthropic.MemoryTool20250818? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.ComputerToolset20260801 value) => new ClientToolUnion((global::Anthropic.ComputerToolset20260801?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.ComputerToolset20260801?(ClientToolUnion @this) => @this.ComputerToolset20260801;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.ComputerToolset20260801? value)
        {
            ComputerToolset20260801 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromComputerToolset20260801(global::Anthropic.ComputerToolset20260801? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.TextEditor20250124 value) => new ClientToolUnion((global::Anthropic.TextEditor20250124?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.TextEditor20250124?(ClientToolUnion @this) => @this.TextEditor20250124;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.TextEditor20250124? value)
        {
            TextEditor20250124 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromTextEditor20250124(global::Anthropic.TextEditor20250124? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.TextEditor20250429 value) => new ClientToolUnion((global::Anthropic.TextEditor20250429?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.TextEditor20250429?(ClientToolUnion @this) => @this.TextEditor20250429;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.TextEditor20250429? value)
        {
            TextEditor20250429 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromTextEditor20250429(global::Anthropic.TextEditor20250429? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ClientToolUnion(global::Anthropic.TextEditor20250728 value) => new ClientToolUnion((global::Anthropic.TextEditor20250728?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.TextEditor20250728?(ClientToolUnion @this) => @this.TextEditor20250728;

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(global::Anthropic.TextEditor20250728? value)
        {
            TextEditor20250728 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ClientToolUnion FromTextEditor20250728(global::Anthropic.TextEditor20250728? value) => new ClientToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public ClientToolUnion(
            global::Anthropic.Tool5? tool,
            global::Anthropic.BashTool20250124? bashTool20250124,
            global::Anthropic.BrowserToolset20260801? browserToolset20260801,
            global::Anthropic.MemoryTool20250818? memoryTool20250818,
            global::Anthropic.ComputerToolset20260801? computerToolset20260801,
            global::Anthropic.TextEditor20250124? textEditor20250124,
            global::Anthropic.TextEditor20250429? textEditor20250429,
            global::Anthropic.TextEditor20250728? textEditor20250728
            )
        {
            Tool = tool;
            BashTool20250124 = bashTool20250124;
            BrowserToolset20260801 = browserToolset20260801;
            MemoryTool20250818 = memoryTool20250818;
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
            MemoryTool20250818 as object ??
            BrowserToolset20260801 as object ??
            BashTool20250124 as object ??
            Tool as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Tool?.ToString() ??
            BashTool20250124?.ToString() ??
            BrowserToolset20260801?.ToString() ??
            MemoryTool20250818?.ToString() ??
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
            return IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && IsTextEditor20250124 && !IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && IsTextEditor20250429 && !IsTextEditor20250728 || !IsTool && !IsBashTool20250124 && !IsBrowserToolset20260801 && !IsMemoryTool20250818 && !IsComputerToolset20260801 && !IsTextEditor20250124 && !IsTextEditor20250429 && IsTextEditor20250728;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.Tool5, TResult>? tool = null,
            global::System.Func<global::Anthropic.BashTool20250124, TResult>? bashTool20250124 = null,
            global::System.Func<global::Anthropic.BrowserToolset20260801, TResult>? browserToolset20260801 = null,
            global::System.Func<global::Anthropic.MemoryTool20250818, TResult>? memoryTool20250818 = null,
            global::System.Func<global::Anthropic.ComputerToolset20260801, TResult>? computerToolset20260801 = null,
            global::System.Func<global::Anthropic.TextEditor20250124, TResult>? textEditor20250124 = null,
            global::System.Func<global::Anthropic.TextEditor20250429, TResult>? textEditor20250429 = null,
            global::System.Func<global::Anthropic.TextEditor20250728, TResult>? textEditor20250728 = null,
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
            else if (BashTool20250124 is { } __value1 && bashTool20250124 != null)
            {
                return bashTool20250124(__value1);
            }
            else if (BrowserToolset20260801 is { } __value2 && browserToolset20260801 != null)
            {
                return browserToolset20260801(__value2);
            }
            else if (MemoryTool20250818 is { } __value3 && memoryTool20250818 != null)
            {
                return memoryTool20250818(__value3);
            }
            else if (ComputerToolset20260801 is { } __value4 && computerToolset20260801 != null)
            {
                return computerToolset20260801(__value4);
            }
            else if (TextEditor20250124 is { } __value5 && textEditor20250124 != null)
            {
                return textEditor20250124(__value5);
            }
            else if (TextEditor20250429 is { } __value6 && textEditor20250429 != null)
            {
                return textEditor20250429(__value6);
            }
            else if (TextEditor20250728 is { } __value7 && textEditor20250728 != null)
            {
                return textEditor20250728(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.Tool5>? tool = null,

            global::System.Action<global::Anthropic.BashTool20250124>? bashTool20250124 = null,

            global::System.Action<global::Anthropic.BrowserToolset20260801>? browserToolset20260801 = null,

            global::System.Action<global::Anthropic.MemoryTool20250818>? memoryTool20250818 = null,

            global::System.Action<global::Anthropic.ComputerToolset20260801>? computerToolset20260801 = null,

            global::System.Action<global::Anthropic.TextEditor20250124>? textEditor20250124 = null,

            global::System.Action<global::Anthropic.TextEditor20250429>? textEditor20250429 = null,

            global::System.Action<global::Anthropic.TextEditor20250728>? textEditor20250728 = null,
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
            else if (BashTool20250124 is { } __value1)
            {
                bashTool20250124?.Invoke(__value1);
            }
            else if (BrowserToolset20260801 is { } __value2)
            {
                browserToolset20260801?.Invoke(__value2);
            }
            else if (MemoryTool20250818 is { } __value3)
            {
                memoryTool20250818?.Invoke(__value3);
            }
            else if (ComputerToolset20260801 is { } __value4)
            {
                computerToolset20260801?.Invoke(__value4);
            }
            else if (TextEditor20250124 is { } __value5)
            {
                textEditor20250124?.Invoke(__value5);
            }
            else if (TextEditor20250429 is { } __value6)
            {
                textEditor20250429?.Invoke(__value6);
            }
            else if (TextEditor20250728 is { } __value7)
            {
                textEditor20250728?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.Tool5>? tool = null,
            global::System.Action<global::Anthropic.BashTool20250124>? bashTool20250124 = null,
            global::System.Action<global::Anthropic.BrowserToolset20260801>? browserToolset20260801 = null,
            global::System.Action<global::Anthropic.MemoryTool20250818>? memoryTool20250818 = null,
            global::System.Action<global::Anthropic.ComputerToolset20260801>? computerToolset20260801 = null,
            global::System.Action<global::Anthropic.TextEditor20250124>? textEditor20250124 = null,
            global::System.Action<global::Anthropic.TextEditor20250429>? textEditor20250429 = null,
            global::System.Action<global::Anthropic.TextEditor20250728>? textEditor20250728 = null,
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
            else if (BashTool20250124 is { } __value1)
            {
                bashTool20250124?.Invoke(__value1);
            }
            else if (BrowserToolset20260801 is { } __value2)
            {
                browserToolset20260801?.Invoke(__value2);
            }
            else if (MemoryTool20250818 is { } __value3)
            {
                memoryTool20250818?.Invoke(__value3);
            }
            else if (ComputerToolset20260801 is { } __value4)
            {
                computerToolset20260801?.Invoke(__value4);
            }
            else if (TextEditor20250124 is { } __value5)
            {
                textEditor20250124?.Invoke(__value5);
            }
            else if (TextEditor20250429 is { } __value6)
            {
                textEditor20250429?.Invoke(__value6);
            }
            else if (TextEditor20250728 is { } __value7)
            {
                textEditor20250728?.Invoke(__value7);
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
                typeof(global::Anthropic.Tool5),
                BashTool20250124,
                typeof(global::Anthropic.BashTool20250124),
                BrowserToolset20260801,
                typeof(global::Anthropic.BrowserToolset20260801),
                MemoryTool20250818,
                typeof(global::Anthropic.MemoryTool20250818),
                ComputerToolset20260801,
                typeof(global::Anthropic.ComputerToolset20260801),
                TextEditor20250124,
                typeof(global::Anthropic.TextEditor20250124),
                TextEditor20250429,
                typeof(global::Anthropic.TextEditor20250429),
                TextEditor20250728,
                typeof(global::Anthropic.TextEditor20250728),
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
        public bool Equals(ClientToolUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.Tool5?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BashTool20250124?>.Default.Equals(BashTool20250124, other.BashTool20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserToolset20260801?>.Default.Equals(BrowserToolset20260801, other.BrowserToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.MemoryTool20250818?>.Default.Equals(MemoryTool20250818, other.MemoryTool20250818) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.ComputerToolset20260801?>.Default.Equals(ComputerToolset20260801, other.ComputerToolset20260801) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextEditor20250124?>.Default.Equals(TextEditor20250124, other.TextEditor20250124) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextEditor20250429?>.Default.Equals(TextEditor20250429, other.TextEditor20250429) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.TextEditor20250728?>.Default.Equals(TextEditor20250728, other.TextEditor20250728)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ClientToolUnion obj1, ClientToolUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ClientToolUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ClientToolUnion obj1, ClientToolUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ClientToolUnion o && Equals(o);
        }
    }
}
