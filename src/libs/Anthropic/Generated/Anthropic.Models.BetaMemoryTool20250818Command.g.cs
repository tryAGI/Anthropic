#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BetaMemoryTool20250818Command : global::System.IEquatable<BetaMemoryTool20250818Command>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? Command { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? View { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818ViewCommand? View { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(View))]
#endif
        public bool IsView => View != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818ViewCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818ViewCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818ViewCommand?(BetaMemoryTool20250818Command @this) => @this.View;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818ViewCommand? value)
        {
            View = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Create { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818CreateCommand? Create { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Create))]
#endif
        public bool IsCreate => Create != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818CreateCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818CreateCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818CreateCommand?(BetaMemoryTool20250818Command @this) => @this.Create;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818CreateCommand? value)
        {
            Create = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? StrReplace { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? StrReplace { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StrReplace))]
#endif
        public bool IsStrReplace => StrReplace != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?(BetaMemoryTool20250818Command @this) => @this.StrReplace;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? value)
        {
            StrReplace = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Insert { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818InsertCommand? Insert { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Insert))]
#endif
        public bool IsInsert => Insert != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818InsertCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818InsertCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818InsertCommand?(BetaMemoryTool20250818Command @this) => @this.Insert;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818InsertCommand? value)
        {
            Insert = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Delete { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818DeleteCommand? Delete { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Delete))]
#endif
        public bool IsDelete => Delete != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818DeleteCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818DeleteCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818DeleteCommand?(BetaMemoryTool20250818Command @this) => @this.Delete;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818DeleteCommand? value)
        {
            Delete = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Rename { get; init; }
#else
        public global::Anthropic.BetaMemoryTool20250818RenameCommand? Rename { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Rename))]
#endif
        public bool IsRename => Rename != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818RenameCommand value) => new BetaMemoryTool20250818Command((global::Anthropic.BetaMemoryTool20250818RenameCommand?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaMemoryTool20250818RenameCommand?(BetaMemoryTool20250818Command @this) => @this.Rename;

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(global::Anthropic.BetaMemoryTool20250818RenameCommand? value)
        {
            Rename = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaMemoryTool20250818Command(
            global::Anthropic.BetaMemoryTool20250818CommandDiscriminatorCommand? command,
            global::Anthropic.BetaMemoryTool20250818ViewCommand? view,
            global::Anthropic.BetaMemoryTool20250818CreateCommand? create,
            global::Anthropic.BetaMemoryTool20250818StrReplaceCommand? strReplace,
            global::Anthropic.BetaMemoryTool20250818InsertCommand? insert,
            global::Anthropic.BetaMemoryTool20250818DeleteCommand? delete,
            global::Anthropic.BetaMemoryTool20250818RenameCommand? rename
            )
        {
            Command = command;

            View = view;
            Create = create;
            StrReplace = strReplace;
            Insert = insert;
            Delete = delete;
            Rename = rename;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Rename as object ??
            Delete as object ??
            Insert as object ??
            StrReplace as object ??
            Create as object ??
            View as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            View?.ToString() ??
            Create?.ToString() ??
            StrReplace?.ToString() ??
            Insert?.ToString() ??
            Delete?.ToString() ??
            Rename?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsView && !IsCreate && !IsStrReplace && !IsInsert && !IsDelete && !IsRename || !IsView && IsCreate && !IsStrReplace && !IsInsert && !IsDelete && !IsRename || !IsView && !IsCreate && IsStrReplace && !IsInsert && !IsDelete && !IsRename || !IsView && !IsCreate && !IsStrReplace && IsInsert && !IsDelete && !IsRename || !IsView && !IsCreate && !IsStrReplace && !IsInsert && IsDelete && !IsRename || !IsView && !IsCreate && !IsStrReplace && !IsInsert && !IsDelete && IsRename;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaMemoryTool20250818ViewCommand?, TResult>? view = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818CreateCommand?, TResult>? create = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?, TResult>? strReplace = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818InsertCommand?, TResult>? insert = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818DeleteCommand?, TResult>? delete = null,
            global::System.Func<global::Anthropic.BetaMemoryTool20250818RenameCommand?, TResult>? rename = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsView && view != null)
            {
                return view(View!);
            }
            else if (IsCreate && create != null)
            {
                return create(Create!);
            }
            else if (IsStrReplace && strReplace != null)
            {
                return strReplace(StrReplace!);
            }
            else if (IsInsert && insert != null)
            {
                return insert(Insert!);
            }
            else if (IsDelete && delete != null)
            {
                return delete(Delete!);
            }
            else if (IsRename && rename != null)
            {
                return rename(Rename!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaMemoryTool20250818ViewCommand?>? view = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818CreateCommand?>? create = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?>? strReplace = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818InsertCommand?>? insert = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818DeleteCommand?>? delete = null,
            global::System.Action<global::Anthropic.BetaMemoryTool20250818RenameCommand?>? rename = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsView)
            {
                view?.Invoke(View!);
            }
            else if (IsCreate)
            {
                create?.Invoke(Create!);
            }
            else if (IsStrReplace)
            {
                strReplace?.Invoke(StrReplace!);
            }
            else if (IsInsert)
            {
                insert?.Invoke(Insert!);
            }
            else if (IsDelete)
            {
                delete?.Invoke(Delete!);
            }
            else if (IsRename)
            {
                rename?.Invoke(Rename!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                View,
                typeof(global::Anthropic.BetaMemoryTool20250818ViewCommand),
                Create,
                typeof(global::Anthropic.BetaMemoryTool20250818CreateCommand),
                StrReplace,
                typeof(global::Anthropic.BetaMemoryTool20250818StrReplaceCommand),
                Insert,
                typeof(global::Anthropic.BetaMemoryTool20250818InsertCommand),
                Delete,
                typeof(global::Anthropic.BetaMemoryTool20250818DeleteCommand),
                Rename,
                typeof(global::Anthropic.BetaMemoryTool20250818RenameCommand),
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
        public bool Equals(BetaMemoryTool20250818Command other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818ViewCommand?>.Default.Equals(View, other.View) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818CreateCommand?>.Default.Equals(Create, other.Create) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818StrReplaceCommand?>.Default.Equals(StrReplace, other.StrReplace) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818InsertCommand?>.Default.Equals(Insert, other.Insert) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818DeleteCommand?>.Default.Equals(Delete, other.Delete) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaMemoryTool20250818RenameCommand?>.Default.Equals(Rename, other.Rename) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaMemoryTool20250818Command obj1, BetaMemoryTool20250818Command obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaMemoryTool20250818Command>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaMemoryTool20250818Command obj1, BetaMemoryTool20250818Command obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaMemoryTool20250818Command o && Equals(o);
        }
    }
}
