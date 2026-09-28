#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CacheMissReason : global::System.IEquatable<CacheMissReason>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissReasonDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissModelChanged? ModelChanged { get; init; }
#else
        public global::Anthropic.CacheMissModelChanged? ModelChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelChanged))]
#endif
        public bool IsModelChanged => ModelChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissModelChanged? value)
        {
            value = ModelChanged;
            return IsModelChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissModelChanged PickModelChanged() => ModelChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissSystemChanged? SystemChanged { get; init; }
#else
        public global::Anthropic.CacheMissSystemChanged? SystemChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemChanged))]
#endif
        public bool IsSystemChanged => SystemChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSystemChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissSystemChanged? value)
        {
            value = SystemChanged;
            return IsSystemChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissSystemChanged PickSystemChanged() => SystemChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissToolsChanged? ToolsChanged { get; init; }
#else
        public global::Anthropic.CacheMissToolsChanged? ToolsChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolsChanged))]
#endif
        public bool IsToolsChanged => ToolsChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickToolsChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissToolsChanged? value)
        {
            value = ToolsChanged;
            return IsToolsChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissToolsChanged PickToolsChanged() => ToolsChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolsChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissMessagesChanged? MessagesChanged { get; init; }
#else
        public global::Anthropic.CacheMissMessagesChanged? MessagesChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesChanged))]
#endif
        public bool IsMessagesChanged => MessagesChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessagesChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissMessagesChanged? value)
        {
            value = MessagesChanged;
            return IsMessagesChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissMessagesChanged PickMessagesChanged() => MessagesChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissPreviousMessageNotFound? PreviousMessageNotFound { get; init; }
#else
        public global::Anthropic.CacheMissPreviousMessageNotFound? PreviousMessageNotFound { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PreviousMessageNotFound))]
#endif
        public bool IsPreviousMessageNotFound => PreviousMessageNotFound != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPreviousMessageNotFound(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissPreviousMessageNotFound? value)
        {
            value = PreviousMessageNotFound;
            return IsPreviousMessageNotFound;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissPreviousMessageNotFound PickPreviousMessageNotFound() => PreviousMessageNotFound is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviousMessageNotFound' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.CacheMissUnavailable? Unavailable { get; init; }
#else
        public global::Anthropic.CacheMissUnavailable? Unavailable { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unavailable))]
#endif
        public bool IsUnavailable => Unavailable != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnavailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.CacheMissUnavailable? value)
        {
            value = Unavailable;
            return IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.CacheMissUnavailable PickUnavailable() => Unavailable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unavailable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissModelChanged value) => new CacheMissReason((global::Anthropic.CacheMissModelChanged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissModelChanged?(CacheMissReason @this) => @this.ModelChanged;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissModelChanged? value)
        {
            ModelChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromModelChanged(global::Anthropic.CacheMissModelChanged? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissSystemChanged value) => new CacheMissReason((global::Anthropic.CacheMissSystemChanged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissSystemChanged?(CacheMissReason @this) => @this.SystemChanged;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissSystemChanged? value)
        {
            SystemChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromSystemChanged(global::Anthropic.CacheMissSystemChanged? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissToolsChanged value) => new CacheMissReason((global::Anthropic.CacheMissToolsChanged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissToolsChanged?(CacheMissReason @this) => @this.ToolsChanged;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissToolsChanged? value)
        {
            ToolsChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromToolsChanged(global::Anthropic.CacheMissToolsChanged? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissMessagesChanged value) => new CacheMissReason((global::Anthropic.CacheMissMessagesChanged?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissMessagesChanged?(CacheMissReason @this) => @this.MessagesChanged;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissMessagesChanged? value)
        {
            MessagesChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromMessagesChanged(global::Anthropic.CacheMissMessagesChanged? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissPreviousMessageNotFound value) => new CacheMissReason((global::Anthropic.CacheMissPreviousMessageNotFound?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissPreviousMessageNotFound?(CacheMissReason @this) => @this.PreviousMessageNotFound;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissPreviousMessageNotFound? value)
        {
            PreviousMessageNotFound = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromPreviousMessageNotFound(global::Anthropic.CacheMissPreviousMessageNotFound? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CacheMissReason(global::Anthropic.CacheMissUnavailable value) => new CacheMissReason((global::Anthropic.CacheMissUnavailable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.CacheMissUnavailable?(CacheMissReason @this) => @this.Unavailable;

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(global::Anthropic.CacheMissUnavailable? value)
        {
            Unavailable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CacheMissReason FromUnavailable(global::Anthropic.CacheMissUnavailable? value) => new CacheMissReason(value);

        /// <summary>
        ///
        /// </summary>
        public CacheMissReason(
            global::Anthropic.CacheMissReasonDiscriminatorType? type,
            global::Anthropic.CacheMissModelChanged? modelChanged,
            global::Anthropic.CacheMissSystemChanged? systemChanged,
            global::Anthropic.CacheMissToolsChanged? toolsChanged,
            global::Anthropic.CacheMissMessagesChanged? messagesChanged,
            global::Anthropic.CacheMissPreviousMessageNotFound? previousMessageNotFound,
            global::Anthropic.CacheMissUnavailable? unavailable
            )
        {
            Type = type;

            ModelChanged = modelChanged;
            SystemChanged = systemChanged;
            ToolsChanged = toolsChanged;
            MessagesChanged = messagesChanged;
            PreviousMessageNotFound = previousMessageNotFound;
            Unavailable = unavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unavailable as object ??
            PreviousMessageNotFound as object ??
            MessagesChanged as object ??
            ToolsChanged as object ??
            SystemChanged as object ??
            ModelChanged as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ModelChanged?.ToString() ??
            SystemChanged?.ToString() ??
            ToolsChanged?.ToString() ??
            MessagesChanged?.ToString() ??
            PreviousMessageNotFound?.ToString() ??
            Unavailable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsModelChanged && !IsSystemChanged && !IsToolsChanged && !IsMessagesChanged && !IsPreviousMessageNotFound && !IsUnavailable || !IsModelChanged && IsSystemChanged && !IsToolsChanged && !IsMessagesChanged && !IsPreviousMessageNotFound && !IsUnavailable || !IsModelChanged && !IsSystemChanged && IsToolsChanged && !IsMessagesChanged && !IsPreviousMessageNotFound && !IsUnavailable || !IsModelChanged && !IsSystemChanged && !IsToolsChanged && IsMessagesChanged && !IsPreviousMessageNotFound && !IsUnavailable || !IsModelChanged && !IsSystemChanged && !IsToolsChanged && !IsMessagesChanged && IsPreviousMessageNotFound && !IsUnavailable || !IsModelChanged && !IsSystemChanged && !IsToolsChanged && !IsMessagesChanged && !IsPreviousMessageNotFound && IsUnavailable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.CacheMissModelChanged, TResult>? modelChanged = null,
            global::System.Func<global::Anthropic.CacheMissSystemChanged, TResult>? systemChanged = null,
            global::System.Func<global::Anthropic.CacheMissToolsChanged, TResult>? toolsChanged = null,
            global::System.Func<global::Anthropic.CacheMissMessagesChanged, TResult>? messagesChanged = null,
            global::System.Func<global::Anthropic.CacheMissPreviousMessageNotFound, TResult>? previousMessageNotFound = null,
            global::System.Func<global::Anthropic.CacheMissUnavailable, TResult>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelChanged is { } __value0 && modelChanged != null)
            {
                return modelChanged(__value0);
            }
            else if (SystemChanged is { } __value1 && systemChanged != null)
            {
                return systemChanged(__value1);
            }
            else if (ToolsChanged is { } __value2 && toolsChanged != null)
            {
                return toolsChanged(__value2);
            }
            else if (MessagesChanged is { } __value3 && messagesChanged != null)
            {
                return messagesChanged(__value3);
            }
            else if (PreviousMessageNotFound is { } __value4 && previousMessageNotFound != null)
            {
                return previousMessageNotFound(__value4);
            }
            else if (Unavailable is { } __value5 && unavailable != null)
            {
                return unavailable(__value5);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.CacheMissModelChanged>? modelChanged = null,

            global::System.Action<global::Anthropic.CacheMissSystemChanged>? systemChanged = null,

            global::System.Action<global::Anthropic.CacheMissToolsChanged>? toolsChanged = null,

            global::System.Action<global::Anthropic.CacheMissMessagesChanged>? messagesChanged = null,

            global::System.Action<global::Anthropic.CacheMissPreviousMessageNotFound>? previousMessageNotFound = null,

            global::System.Action<global::Anthropic.CacheMissUnavailable>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelChanged is { } __value0)
            {
                modelChanged?.Invoke(__value0);
            }
            else if (SystemChanged is { } __value1)
            {
                systemChanged?.Invoke(__value1);
            }
            else if (ToolsChanged is { } __value2)
            {
                toolsChanged?.Invoke(__value2);
            }
            else if (MessagesChanged is { } __value3)
            {
                messagesChanged?.Invoke(__value3);
            }
            else if (PreviousMessageNotFound is { } __value4)
            {
                previousMessageNotFound?.Invoke(__value4);
            }
            else if (Unavailable is { } __value5)
            {
                unavailable?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.CacheMissModelChanged>? modelChanged = null,
            global::System.Action<global::Anthropic.CacheMissSystemChanged>? systemChanged = null,
            global::System.Action<global::Anthropic.CacheMissToolsChanged>? toolsChanged = null,
            global::System.Action<global::Anthropic.CacheMissMessagesChanged>? messagesChanged = null,
            global::System.Action<global::Anthropic.CacheMissPreviousMessageNotFound>? previousMessageNotFound = null,
            global::System.Action<global::Anthropic.CacheMissUnavailable>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelChanged is { } __value0)
            {
                modelChanged?.Invoke(__value0);
            }
            else if (SystemChanged is { } __value1)
            {
                systemChanged?.Invoke(__value1);
            }
            else if (ToolsChanged is { } __value2)
            {
                toolsChanged?.Invoke(__value2);
            }
            else if (MessagesChanged is { } __value3)
            {
                messagesChanged?.Invoke(__value3);
            }
            else if (PreviousMessageNotFound is { } __value4)
            {
                previousMessageNotFound?.Invoke(__value4);
            }
            else if (Unavailable is { } __value5)
            {
                unavailable?.Invoke(__value5);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelChanged,
                typeof(global::Anthropic.CacheMissModelChanged),
                SystemChanged,
                typeof(global::Anthropic.CacheMissSystemChanged),
                ToolsChanged,
                typeof(global::Anthropic.CacheMissToolsChanged),
                MessagesChanged,
                typeof(global::Anthropic.CacheMissMessagesChanged),
                PreviousMessageNotFound,
                typeof(global::Anthropic.CacheMissPreviousMessageNotFound),
                Unavailable,
                typeof(global::Anthropic.CacheMissUnavailable),
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
        public bool Equals(CacheMissReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissModelChanged?>.Default.Equals(ModelChanged, other.ModelChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissSystemChanged?>.Default.Equals(SystemChanged, other.SystemChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissToolsChanged?>.Default.Equals(ToolsChanged, other.ToolsChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissMessagesChanged?>.Default.Equals(MessagesChanged, other.MessagesChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissPreviousMessageNotFound?>.Default.Equals(PreviousMessageNotFound, other.PreviousMessageNotFound) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.CacheMissUnavailable?>.Default.Equals(Unavailable, other.Unavailable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CacheMissReason obj1, CacheMissReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CacheMissReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CacheMissReason obj1, CacheMissReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CacheMissReason o && Equals(o);
        }
    }
}
