#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which server tools' results contribute fetchable URLs: "all", "none", or an only or except list of server tool names from tools[]; only web_search and web_fetch results ever contribute.
    /// </summary>
    public readonly partial struct ServerToolResults : global::System.IEquatable<ServerToolResults>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? Type { get; }

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes in<br/>
        /// full: every result of the tool filter's source, or all user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceAll? All { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceAll? All { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(All))]
#endif
        public bool IsAll => All != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchUrlSourceAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceAll PickAll() => IsAll
            ? All!
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes nothing:<br/>
        /// no result of the tool filter's source, or no user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceNone? None { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceNone? None { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(None))]
#endif
        public bool IsNone => None != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchUrlSourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// The tool filter variant under which only the named tools' results<br/>
        /// contribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Only { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceOnly? Only { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Only))]
#endif
        public bool IsOnly => Only != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOnly(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchUrlSourceOnly? value)
        {
            value = Only;
            return IsOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceOnly PickOnly() => IsOnly
            ? Only!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Only' but the value was {ToString()}.");

        /// <summary>
        /// The tool filter variant under which every result but the named<br/>
        /// tools' contributes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Except { get; init; }
#else
        public global::Anthropic.BetaWebFetchUrlSourceExcept? Except { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Except))]
#endif
        public bool IsExcept => Except != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExcept(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaWebFetchUrlSourceExcept? value)
        {
            value = Except;
            return IsExcept;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaWebFetchUrlSourceExcept PickExcept() => IsExcept
            ? Except!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Except' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceAll value) => new ServerToolResults((global::Anthropic.BetaWebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceAll?(ServerToolResults @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults FromAll(global::Anthropic.BetaWebFetchUrlSourceAll? value) => new ServerToolResults(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceNone value) => new ServerToolResults((global::Anthropic.BetaWebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceNone?(ServerToolResults @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults FromNone(global::Anthropic.BetaWebFetchUrlSourceNone? value) => new ServerToolResults(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceOnly value) => new ServerToolResults((global::Anthropic.BetaWebFetchUrlSourceOnly?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceOnly?(ServerToolResults @this) => @this.Only;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceOnly? value)
        {
            Only = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults FromOnly(global::Anthropic.BetaWebFetchUrlSourceOnly? value) => new ServerToolResults(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceExcept value) => new ServerToolResults((global::Anthropic.BetaWebFetchUrlSourceExcept?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaWebFetchUrlSourceExcept?(ServerToolResults @this) => @this.Except;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults(global::Anthropic.BetaWebFetchUrlSourceExcept? value)
        {
            Except = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults FromExcept(global::Anthropic.BetaWebFetchUrlSourceExcept? value) => new ServerToolResults(value);

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults(
            global::Anthropic.BetaWebFetchUrlSourcesServerToolResultsDiscriminatorType? type,
            global::Anthropic.BetaWebFetchUrlSourceAll? all,
            global::Anthropic.BetaWebFetchUrlSourceNone? none,
            global::Anthropic.BetaWebFetchUrlSourceOnly? only,
            global::Anthropic.BetaWebFetchUrlSourceExcept? except
            )
        {
            Type = type;

            All = all;
            None = none;
            Only = only;
            Except = except;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Except as object ??
            Only as object ??
            None as object ??
            All as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            All?.ToString() ??
            None?.ToString() ??
            Only?.ToString() ??
            Except?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAll && !IsNone && !IsOnly && !IsExcept || !IsAll && IsNone && !IsOnly && !IsExcept || !IsAll && !IsNone && IsOnly && !IsExcept || !IsAll && !IsNone && !IsOnly && IsExcept;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceNone, TResult>? none = null,
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceOnly, TResult>? only = null,
            global::System.Func<global::Anthropic.BetaWebFetchUrlSourceExcept, TResult>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll && all != null)
            {
                return all(All!);
            }
            else if (IsNone && none != null)
            {
                return none(None!);
            }
            else if (IsOnly && only != null)
            {
                return only(Only!);
            }
            else if (IsExcept && except != null)
            {
                return except(Except!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceNone>? none = null,

            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceOnly>? only = null,

            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceExcept>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsOnly)
            {
                only?.Invoke(Only!);
            }
            else if (IsExcept)
            {
                except?.Invoke(Except!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceNone>? none = null,
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceOnly>? only = null,
            global::System.Action<global::Anthropic.BetaWebFetchUrlSourceExcept>? except = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsNone)
            {
                none?.Invoke(None!);
            }
            else if (IsOnly)
            {
                only?.Invoke(Only!);
            }
            else if (IsExcept)
            {
                except?.Invoke(Except!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                All,
                typeof(global::Anthropic.BetaWebFetchUrlSourceAll),
                None,
                typeof(global::Anthropic.BetaWebFetchUrlSourceNone),
                Only,
                typeof(global::Anthropic.BetaWebFetchUrlSourceOnly),
                Except,
                typeof(global::Anthropic.BetaWebFetchUrlSourceExcept),
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
        public bool Equals(ServerToolResults other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceOnly?>.Default.Equals(Only, other.Only) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaWebFetchUrlSourceExcept?>.Default.Equals(Except, other.Except)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerToolResults obj1, ServerToolResults obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerToolResults>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolResults obj1, ServerToolResults obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolResults o && Equals(o);
        }
    }
}
