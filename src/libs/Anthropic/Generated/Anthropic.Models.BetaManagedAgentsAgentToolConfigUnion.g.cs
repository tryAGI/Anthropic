#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration for a specific agent tool.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentToolConfigUnion : global::System.IEquatable<BetaManagedAgentsAgentToolConfigUnion>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration for the bash tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Bash { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBashToolConfig? Bash { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash))]
#endif
        public bool IsBash => Bash != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBash(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsBashToolConfig? value)
        {
            value = Bash;
            return IsBash;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfig PickBash() => Bash is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bash' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the edit tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Edit { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEditToolConfig? Edit { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Edit))]
#endif
        public bool IsEdit => Edit != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEdit(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsEditToolConfig? value)
        {
            value = Edit;
            return IsEdit;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfig PickEdit() => Edit is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Edit' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the read tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Read { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsReadToolConfig? Read { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Read))]
#endif
        public bool IsRead => Read != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRead(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsReadToolConfig? value)
        {
            value = Read;
            return IsRead;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfig PickRead() => Read is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Read' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the write tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Write { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWriteToolConfig? Write { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Write))]
#endif
        public bool IsWrite => Write != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWrite(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWriteToolConfig? value)
        {
            value = Write;
            return IsWrite;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfig PickWrite() => Write is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Write' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the glob tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Glob { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGlobToolConfig? Glob { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Glob))]
#endif
        public bool IsGlob => Glob != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGlob(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsGlobToolConfig? value)
        {
            value = Glob;
            return IsGlob;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfig PickGlob() => Glob is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Glob' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the grep tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Grep { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGrepToolConfig? Grep { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Grep))]
#endif
        public bool IsGrep => Grep != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGrep(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsGrepToolConfig? value)
        {
            value = Grep;
            return IsGrep;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfig PickGrep() => Grep is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grep' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the web_fetch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? WebFetch { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig? WebFetch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebFetch))]
#endif
        public bool IsWebFetch => WebFetch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebFetch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebFetchToolConfig? value)
        {
            value = WebFetch;
            return IsWebFetch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfig PickWebFetch() => WebFetch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetch' but the value was {ToString()}.");

        /// <summary>
        /// Configuration for the web_search tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? WebSearch { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig? WebSearch { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearch))]
#endif
        public bool IsWebSearch => WebSearch != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWebSearch(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsWebSearchToolConfig? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfig PickWebSearch() => WebSearch is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsBashToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsBashToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBashToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Bash;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsBashToolConfig? value)
        {
            Bash = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromBash(global::Anthropic.BetaManagedAgentsBashToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsEditToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsEditToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEditToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Edit;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsEditToolConfig? value)
        {
            Edit = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromEdit(global::Anthropic.BetaManagedAgentsEditToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsReadToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsReadToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsReadToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Read;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsReadToolConfig? value)
        {
            Read = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromRead(global::Anthropic.BetaManagedAgentsReadToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWriteToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsWriteToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWriteToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Write;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWriteToolConfig? value)
        {
            Write = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromWrite(global::Anthropic.BetaManagedAgentsWriteToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsGlobToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsGlobToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGlobToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Glob;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsGlobToolConfig? value)
        {
            Glob = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromGlob(global::Anthropic.BetaManagedAgentsGlobToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsGrepToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsGrepToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGrepToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.Grep;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsGrepToolConfig? value)
        {
            Grep = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromGrep(global::Anthropic.BetaManagedAgentsGrepToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWebFetchToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsWebFetchToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.WebFetch;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWebFetchToolConfig? value)
        {
            WebFetch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromWebFetch(global::Anthropic.BetaManagedAgentsWebFetchToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWebSearchToolConfig value) => new BetaManagedAgentsAgentToolConfigUnion((global::Anthropic.BetaManagedAgentsWebSearchToolConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebSearchToolConfig?(BetaManagedAgentsAgentToolConfigUnion @this) => @this.WebSearch;

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(global::Anthropic.BetaManagedAgentsWebSearchToolConfig? value)
        {
            WebSearch = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnion FromWebSearch(global::Anthropic.BetaManagedAgentsWebSearchToolConfig? value) => new BetaManagedAgentsAgentToolConfigUnion(value);

        /// <summary>
        ///
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnion(
            global::Anthropic.BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBashToolConfig? bash,
            global::Anthropic.BetaManagedAgentsEditToolConfig? edit,
            global::Anthropic.BetaManagedAgentsReadToolConfig? read,
            global::Anthropic.BetaManagedAgentsWriteToolConfig? write,
            global::Anthropic.BetaManagedAgentsGlobToolConfig? glob,
            global::Anthropic.BetaManagedAgentsGrepToolConfig? grep,
            global::Anthropic.BetaManagedAgentsWebFetchToolConfig? webFetch,
            global::Anthropic.BetaManagedAgentsWebSearchToolConfig? webSearch
            )
        {
            Type = type;

            Bash = bash;
            Edit = edit;
            Read = read;
            Write = write;
            Glob = glob;
            Grep = grep;
            WebFetch = webFetch;
            WebSearch = webSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            WebSearch as object ??
            WebFetch as object ??
            Grep as object ??
            Glob as object ??
            Write as object ??
            Read as object ??
            Edit as object ??
            Bash as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Bash?.ToString() ??
            Edit?.ToString() ??
            Read?.ToString() ??
            Write?.ToString() ??
            Glob?.ToString() ??
            Grep?.ToString() ??
            WebFetch?.ToString() ??
            WebSearch?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBash && !IsEdit && !IsRead && !IsWrite && !IsGlob && !IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && IsEdit && !IsRead && !IsWrite && !IsGlob && !IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && IsRead && !IsWrite && !IsGlob && !IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && !IsRead && IsWrite && !IsGlob && !IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && !IsRead && !IsWrite && IsGlob && !IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && !IsRead && !IsWrite && !IsGlob && IsGrep && !IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && !IsRead && !IsWrite && !IsGlob && !IsGrep && IsWebFetch && !IsWebSearch || !IsBash && !IsEdit && !IsRead && !IsWrite && !IsGlob && !IsGrep && !IsWebFetch && IsWebSearch;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsBashToolConfig, TResult>? bash = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEditToolConfig, TResult>? edit = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsReadToolConfig, TResult>? read = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWriteToolConfig, TResult>? write = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsGlobToolConfig, TResult>? glob = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsGrepToolConfig, TResult>? grep = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchToolConfig, TResult>? webFetch = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebSearchToolConfig, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bash is { } __value0 && bash != null)
            {
                return bash(__value0);
            }
            else if (Edit is { } __value1 && edit != null)
            {
                return edit(__value1);
            }
            else if (Read is { } __value2 && read != null)
            {
                return read(__value2);
            }
            else if (Write is { } __value3 && write != null)
            {
                return write(__value3);
            }
            else if (Glob is { } __value4 && glob != null)
            {
                return glob(__value4);
            }
            else if (Grep is { } __value5 && grep != null)
            {
                return grep(__value5);
            }
            else if (WebFetch is { } __value6 && webFetch != null)
            {
                return webFetch(__value6);
            }
            else if (WebSearch is { } __value7 && webSearch != null)
            {
                return webSearch(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsBashToolConfig>? bash = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEditToolConfig>? edit = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsReadToolConfig>? read = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWriteToolConfig>? write = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsGlobToolConfig>? glob = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsGrepToolConfig>? grep = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchToolConfig>? webFetch = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebSearchToolConfig>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bash is { } __value0)
            {
                bash?.Invoke(__value0);
            }
            else if (Edit is { } __value1)
            {
                edit?.Invoke(__value1);
            }
            else if (Read is { } __value2)
            {
                read?.Invoke(__value2);
            }
            else if (Write is { } __value3)
            {
                write?.Invoke(__value3);
            }
            else if (Glob is { } __value4)
            {
                glob?.Invoke(__value4);
            }
            else if (Grep is { } __value5)
            {
                grep?.Invoke(__value5);
            }
            else if (WebFetch is { } __value6)
            {
                webFetch?.Invoke(__value6);
            }
            else if (WebSearch is { } __value7)
            {
                webSearch?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsBashToolConfig>? bash = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEditToolConfig>? edit = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsReadToolConfig>? read = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWriteToolConfig>? write = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsGlobToolConfig>? glob = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsGrepToolConfig>? grep = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchToolConfig>? webFetch = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebSearchToolConfig>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bash is { } __value0)
            {
                bash?.Invoke(__value0);
            }
            else if (Edit is { } __value1)
            {
                edit?.Invoke(__value1);
            }
            else if (Read is { } __value2)
            {
                read?.Invoke(__value2);
            }
            else if (Write is { } __value3)
            {
                write?.Invoke(__value3);
            }
            else if (Glob is { } __value4)
            {
                glob?.Invoke(__value4);
            }
            else if (Grep is { } __value5)
            {
                grep?.Invoke(__value5);
            }
            else if (WebFetch is { } __value6)
            {
                webFetch?.Invoke(__value6);
            }
            else if (WebSearch is { } __value7)
            {
                webSearch?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bash,
                typeof(global::Anthropic.BetaManagedAgentsBashToolConfig),
                Edit,
                typeof(global::Anthropic.BetaManagedAgentsEditToolConfig),
                Read,
                typeof(global::Anthropic.BetaManagedAgentsReadToolConfig),
                Write,
                typeof(global::Anthropic.BetaManagedAgentsWriteToolConfig),
                Glob,
                typeof(global::Anthropic.BetaManagedAgentsGlobToolConfig),
                Grep,
                typeof(global::Anthropic.BetaManagedAgentsGrepToolConfig),
                WebFetch,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchToolConfig),
                WebSearch,
                typeof(global::Anthropic.BetaManagedAgentsWebSearchToolConfig),
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
        public bool Equals(BetaManagedAgentsAgentToolConfigUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBashToolConfig?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEditToolConfig?>.Default.Equals(Edit, other.Edit) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsReadToolConfig?>.Default.Equals(Read, other.Read) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWriteToolConfig?>.Default.Equals(Write, other.Write) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGlobToolConfig?>.Default.Equals(Glob, other.Glob) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGrepToolConfig?>.Default.Equals(Grep, other.Grep) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchToolConfig?>.Default.Equals(WebFetch, other.WebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebSearchToolConfig?>.Default.Equals(WebSearch, other.WebSearch)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentToolConfigUnion obj1, BetaManagedAgentsAgentToolConfigUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentToolConfigUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentToolConfigUnion obj1, BetaManagedAgentsAgentToolConfigUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentToolConfigUnion o && Equals(o);
        }
    }
}
