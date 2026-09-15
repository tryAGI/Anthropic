#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which server tools' results contribute fetchable URLs: "all", "none", or an only or except list of server tool names from tools[]; only web_search and web_fetch results ever contribute.
    /// </summary>
    public readonly partial struct ServerToolResults2 : global::System.IEquatable<ServerToolResults2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? Type { get; }

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes in<br/>
        /// full: every result of the tool filter's source, or all user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceAll? All { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceAll? All { get; }
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
            out global::Anthropic.WebFetchUrlSourceAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceAll PickAll() => IsAll
            ? All!
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// The ``url_sources`` variant under which a source contributes nothing:<br/>
        /// no result of the tool filter's source, or no user input.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceNone? None { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceNone? None { get; }
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
            out global::Anthropic.WebFetchUrlSourceNone? value)
        {
            value = None;
            return IsNone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceNone PickNone() => IsNone
            ? None!
            : throw new global::System.InvalidOperationException($"Expected union variant 'None' but the value was {ToString()}.");

        /// <summary>
        /// The tool filter variant under which only the named tools' results<br/>
        /// contribute.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceOnly? Only { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceOnly? Only { get; }
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
            out global::Anthropic.WebFetchUrlSourceOnly? value)
        {
            value = Only;
            return IsOnly;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceOnly PickOnly() => IsOnly
            ? Only!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Only' but the value was {ToString()}.");

        /// <summary>
        /// The tool filter variant under which every result but the named<br/>
        /// tools' contributes.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.WebFetchUrlSourceExcept? Except { get; init; }
#else
        public global::Anthropic.WebFetchUrlSourceExcept? Except { get; }
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
            out global::Anthropic.WebFetchUrlSourceExcept? value)
        {
            value = Except;
            return IsExcept;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.WebFetchUrlSourceExcept PickExcept() => IsExcept
            ? Except!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Except' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults2(global::Anthropic.WebFetchUrlSourceAll value) => new ServerToolResults2((global::Anthropic.WebFetchUrlSourceAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceAll?(ServerToolResults2 @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults2(global::Anthropic.WebFetchUrlSourceAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults2 FromAll(global::Anthropic.WebFetchUrlSourceAll? value) => new ServerToolResults2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults2(global::Anthropic.WebFetchUrlSourceNone value) => new ServerToolResults2((global::Anthropic.WebFetchUrlSourceNone?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceNone?(ServerToolResults2 @this) => @this.None;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults2(global::Anthropic.WebFetchUrlSourceNone? value)
        {
            None = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults2 FromNone(global::Anthropic.WebFetchUrlSourceNone? value) => new ServerToolResults2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults2(global::Anthropic.WebFetchUrlSourceOnly value) => new ServerToolResults2((global::Anthropic.WebFetchUrlSourceOnly?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceOnly?(ServerToolResults2 @this) => @this.Only;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults2(global::Anthropic.WebFetchUrlSourceOnly? value)
        {
            Only = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults2 FromOnly(global::Anthropic.WebFetchUrlSourceOnly? value) => new ServerToolResults2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ServerToolResults2(global::Anthropic.WebFetchUrlSourceExcept value) => new ServerToolResults2((global::Anthropic.WebFetchUrlSourceExcept?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.WebFetchUrlSourceExcept?(ServerToolResults2 @this) => @this.Except;

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults2(global::Anthropic.WebFetchUrlSourceExcept? value)
        {
            Except = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ServerToolResults2 FromExcept(global::Anthropic.WebFetchUrlSourceExcept? value) => new ServerToolResults2(value);

        /// <summary>
        ///
        /// </summary>
        public ServerToolResults2(
            global::Anthropic.WebFetchUrlSourcesServerToolResultsDiscriminatorType? type,
            global::Anthropic.WebFetchUrlSourceAll? all,
            global::Anthropic.WebFetchUrlSourceNone? none,
            global::Anthropic.WebFetchUrlSourceOnly? only,
            global::Anthropic.WebFetchUrlSourceExcept? except
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
            global::System.Func<global::Anthropic.WebFetchUrlSourceAll, TResult>? all = null,
            global::System.Func<global::Anthropic.WebFetchUrlSourceNone, TResult>? none = null,
            global::System.Func<global::Anthropic.WebFetchUrlSourceOnly, TResult>? only = null,
            global::System.Func<global::Anthropic.WebFetchUrlSourceExcept, TResult>? except = null,
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
            global::System.Action<global::Anthropic.WebFetchUrlSourceAll>? all = null,

            global::System.Action<global::Anthropic.WebFetchUrlSourceNone>? none = null,

            global::System.Action<global::Anthropic.WebFetchUrlSourceOnly>? only = null,

            global::System.Action<global::Anthropic.WebFetchUrlSourceExcept>? except = null,
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
            global::System.Action<global::Anthropic.WebFetchUrlSourceAll>? all = null,
            global::System.Action<global::Anthropic.WebFetchUrlSourceNone>? none = null,
            global::System.Action<global::Anthropic.WebFetchUrlSourceOnly>? only = null,
            global::System.Action<global::Anthropic.WebFetchUrlSourceExcept>? except = null,
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
                typeof(global::Anthropic.WebFetchUrlSourceAll),
                None,
                typeof(global::Anthropic.WebFetchUrlSourceNone),
                Only,
                typeof(global::Anthropic.WebFetchUrlSourceOnly),
                Except,
                typeof(global::Anthropic.WebFetchUrlSourceExcept),
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
        public bool Equals(ServerToolResults2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceNone?>.Default.Equals(None, other.None) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceOnly?>.Default.Equals(Only, other.Only) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.WebFetchUrlSourceExcept?>.Default.Equals(Except, other.Except)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ServerToolResults2 obj1, ServerToolResults2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerToolResults2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ServerToolResults2 obj1, ServerToolResults2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerToolResults2 o && Equals(o);
        }
    }
}
