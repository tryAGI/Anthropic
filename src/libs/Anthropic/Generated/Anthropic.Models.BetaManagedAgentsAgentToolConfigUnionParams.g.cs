#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Configuration override for a specific tool within a toolset.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAgentToolConfigUnionParams : global::System.IEquatable<BetaManagedAgentsAgentToolConfigUnionParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Configuration override for the bash tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Bash { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams? Bash { get; }
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
            out global::Anthropic.BetaManagedAgentsBashToolConfigParams? value)
        {
            value = Bash;
            return IsBash;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsBashToolConfigParams PickBash() => IsBash
            ? Bash!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bash' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the edit tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Edit { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams? Edit { get; }
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
            out global::Anthropic.BetaManagedAgentsEditToolConfigParams? value)
        {
            value = Edit;
            return IsEdit;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsEditToolConfigParams PickEdit() => IsEdit
            ? Edit!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Edit' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the read tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Read { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams? Read { get; }
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
            out global::Anthropic.BetaManagedAgentsReadToolConfigParams? value)
        {
            value = Read;
            return IsRead;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsReadToolConfigParams PickRead() => IsRead
            ? Read!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Read' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the write tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Write { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams? Write { get; }
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
            out global::Anthropic.BetaManagedAgentsWriteToolConfigParams? value)
        {
            value = Write;
            return IsWrite;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWriteToolConfigParams PickWrite() => IsWrite
            ? Write!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Write' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the glob tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Glob { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams? Glob { get; }
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
            out global::Anthropic.BetaManagedAgentsGlobToolConfigParams? value)
        {
            value = Glob;
            return IsGlob;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGlobToolConfigParams PickGlob() => IsGlob
            ? Glob!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Glob' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the grep tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Grep { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams? Grep { get; }
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
            out global::Anthropic.BetaManagedAgentsGrepToolConfigParams? value)
        {
            value = Grep;
            return IsGrep;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGrepToolConfigParams PickGrep() => IsGrep
            ? Grep!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Grep' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the web_fetch tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? WebFetch { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? WebFetch { get; }
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
            out global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? value)
        {
            value = WebFetch;
            return IsWebFetch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams PickWebFetch() => IsWebFetch
            ? WebFetch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebFetch' but the value was {ToString()}.");

        /// <summary>
        /// Configuration override for the web_search tool.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? WebSearch { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? WebSearch { get; }
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
            out global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? value)
        {
            value = WebSearch;
            return IsWebSearch;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams PickWebSearch() => IsWebSearch
            ? WebSearch!
            : throw new global::System.InvalidOperationException($"Expected union variant 'WebSearch' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsBashToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsBashToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsBashToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Bash;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsBashToolConfigParams? value)
        {
            Bash = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromBash(global::Anthropic.BetaManagedAgentsBashToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsEditToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsEditToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsEditToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Edit;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsEditToolConfigParams? value)
        {
            Edit = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromEdit(global::Anthropic.BetaManagedAgentsEditToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsReadToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsReadToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsReadToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Read;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsReadToolConfigParams? value)
        {
            Read = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromRead(global::Anthropic.BetaManagedAgentsReadToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWriteToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsWriteToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWriteToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Write;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWriteToolConfigParams? value)
        {
            Write = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromWrite(global::Anthropic.BetaManagedAgentsWriteToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsGlobToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsGlobToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGlobToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Glob;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsGlobToolConfigParams? value)
        {
            Glob = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromGlob(global::Anthropic.BetaManagedAgentsGlobToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsGrepToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsGrepToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGrepToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.Grep;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsGrepToolConfigParams? value)
        {
            Grep = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromGrep(global::Anthropic.BetaManagedAgentsGrepToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.WebFetch;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? value)
        {
            WebFetch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromWebFetch(global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams value) => new BetaManagedAgentsAgentToolConfigUnionParams((global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams?(BetaManagedAgentsAgentToolConfigUnionParams @this) => @this.WebSearch;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? value)
        {
            WebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParams FromWebSearch(global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? value) => new BetaManagedAgentsAgentToolConfigUnionParams(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAgentToolConfigUnionParams(
            global::Anthropic.BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsBashToolConfigParams? bash,
            global::Anthropic.BetaManagedAgentsEditToolConfigParams? edit,
            global::Anthropic.BetaManagedAgentsReadToolConfigParams? read,
            global::Anthropic.BetaManagedAgentsWriteToolConfigParams? write,
            global::Anthropic.BetaManagedAgentsGlobToolConfigParams? glob,
            global::Anthropic.BetaManagedAgentsGrepToolConfigParams? grep,
            global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams? webFetch,
            global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams? webSearch
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
            global::System.Func<global::Anthropic.BetaManagedAgentsBashToolConfigParams, TResult>? bash = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsEditToolConfigParams, TResult>? edit = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsReadToolConfigParams, TResult>? read = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWriteToolConfigParams, TResult>? write = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsGlobToolConfigParams, TResult>? glob = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsGrepToolConfigParams, TResult>? grep = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams, TResult>? webFetch = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams, TResult>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBash && bash != null)
            {
                return bash(Bash!);
            }
            else if (IsEdit && edit != null)
            {
                return edit(Edit!);
            }
            else if (IsRead && read != null)
            {
                return read(Read!);
            }
            else if (IsWrite && write != null)
            {
                return write(Write!);
            }
            else if (IsGlob && glob != null)
            {
                return glob(Glob!);
            }
            else if (IsGrep && grep != null)
            {
                return grep(Grep!);
            }
            else if (IsWebFetch && webFetch != null)
            {
                return webFetch(WebFetch!);
            }
            else if (IsWebSearch && webSearch != null)
            {
                return webSearch(WebSearch!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsBashToolConfigParams>? bash = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsEditToolConfigParams>? edit = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsReadToolConfigParams>? read = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWriteToolConfigParams>? write = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsGlobToolConfigParams>? glob = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsGrepToolConfigParams>? grep = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams>? webFetch = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
            else if (IsEdit)
            {
                edit?.Invoke(Edit!);
            }
            else if (IsRead)
            {
                read?.Invoke(Read!);
            }
            else if (IsWrite)
            {
                write?.Invoke(Write!);
            }
            else if (IsGlob)
            {
                glob?.Invoke(Glob!);
            }
            else if (IsGrep)
            {
                grep?.Invoke(Grep!);
            }
            else if (IsWebFetch)
            {
                webFetch?.Invoke(WebFetch!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsBashToolConfigParams>? bash = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsEditToolConfigParams>? edit = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsReadToolConfigParams>? read = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWriteToolConfigParams>? write = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsGlobToolConfigParams>? glob = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsGrepToolConfigParams>? grep = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams>? webFetch = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams>? webSearch = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBash)
            {
                bash?.Invoke(Bash!);
            }
            else if (IsEdit)
            {
                edit?.Invoke(Edit!);
            }
            else if (IsRead)
            {
                read?.Invoke(Read!);
            }
            else if (IsWrite)
            {
                write?.Invoke(Write!);
            }
            else if (IsGlob)
            {
                glob?.Invoke(Glob!);
            }
            else if (IsGrep)
            {
                grep?.Invoke(Grep!);
            }
            else if (IsWebFetch)
            {
                webFetch?.Invoke(WebFetch!);
            }
            else if (IsWebSearch)
            {
                webSearch?.Invoke(WebSearch!);
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
                typeof(global::Anthropic.BetaManagedAgentsBashToolConfigParams),
                Edit,
                typeof(global::Anthropic.BetaManagedAgentsEditToolConfigParams),
                Read,
                typeof(global::Anthropic.BetaManagedAgentsReadToolConfigParams),
                Write,
                typeof(global::Anthropic.BetaManagedAgentsWriteToolConfigParams),
                Glob,
                typeof(global::Anthropic.BetaManagedAgentsGlobToolConfigParams),
                Grep,
                typeof(global::Anthropic.BetaManagedAgentsGrepToolConfigParams),
                WebFetch,
                typeof(global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams),
                WebSearch,
                typeof(global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams),
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
        public bool Equals(BetaManagedAgentsAgentToolConfigUnionParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsBashToolConfigParams?>.Default.Equals(Bash, other.Bash) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsEditToolConfigParams?>.Default.Equals(Edit, other.Edit) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsReadToolConfigParams?>.Default.Equals(Read, other.Read) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWriteToolConfigParams?>.Default.Equals(Write, other.Write) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGlobToolConfigParams?>.Default.Equals(Glob, other.Glob) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGrepToolConfigParams?>.Default.Equals(Grep, other.Grep) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebFetchToolConfigParams?>.Default.Equals(WebFetch, other.WebFetch) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsWebSearchToolConfigParams?>.Default.Equals(WebSearch, other.WebSearch) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAgentToolConfigUnionParams obj1, BetaManagedAgentsAgentToolConfigUnionParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAgentToolConfigUnionParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAgentToolConfigUnionParams obj1, BetaManagedAgentsAgentToolConfigUnionParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAgentToolConfigUnionParams o && Equals(o);
        }
    }
}
