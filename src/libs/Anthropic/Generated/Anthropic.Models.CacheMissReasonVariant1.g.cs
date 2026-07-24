#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CacheMissReasonVariant1 : global::System.IEquatable<CacheMissReasonVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissModelChanged? ModelChanged { get; init; }
#else
        public global::Anthropic.BetaCacheMissModelChanged? ModelChanged { get; }
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
            out global::Anthropic.BetaCacheMissModelChanged? value)
        {
            value = ModelChanged;
            return IsModelChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissModelChanged PickModelChanged() => IsModelChanged
            ? ModelChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelChanged' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissSystemChanged? SystemChanged { get; init; }
#else
        public global::Anthropic.BetaCacheMissSystemChanged? SystemChanged { get; }
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
            out global::Anthropic.BetaCacheMissSystemChanged? value)
        {
            value = SystemChanged;
            return IsSystemChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissSystemChanged PickSystemChanged() => IsSystemChanged
            ? SystemChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SystemChanged' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissToolsChanged? ToolsChanged { get; init; }
#else
        public global::Anthropic.BetaCacheMissToolsChanged? ToolsChanged { get; }
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
            out global::Anthropic.BetaCacheMissToolsChanged? value)
        {
            value = ToolsChanged;
            return IsToolsChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissToolsChanged PickToolsChanged() => IsToolsChanged
            ? ToolsChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ToolsChanged' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissMessagesChanged? MessagesChanged { get; init; }
#else
        public global::Anthropic.BetaCacheMissMessagesChanged? MessagesChanged { get; }
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
            out global::Anthropic.BetaCacheMissMessagesChanged? value)
        {
            value = MessagesChanged;
            return IsMessagesChanged;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissMessagesChanged PickMessagesChanged() => IsMessagesChanged
            ? MessagesChanged!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesChanged' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? PreviousMessageNotFound { get; init; }
#else
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound? PreviousMessageNotFound { get; }
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
            out global::Anthropic.BetaCacheMissPreviousMessageNotFound? value)
        {
            value = PreviousMessageNotFound;
            return IsPreviousMessageNotFound;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissPreviousMessageNotFound PickPreviousMessageNotFound() => IsPreviousMessageNotFound
            ? PreviousMessageNotFound!
            : throw new global::System.InvalidOperationException($"Expected union variant 'PreviousMessageNotFound' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaCacheMissUnavailable? Unavailable { get; init; }
#else
        public global::Anthropic.BetaCacheMissUnavailable? Unavailable { get; }
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
            out global::Anthropic.BetaCacheMissUnavailable? value)
        {
            value = Unavailable;
            return IsUnavailable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaCacheMissUnavailable PickUnavailable() => IsUnavailable
            ? Unavailable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unavailable' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissModelChanged value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissModelChanged?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissModelChanged?(CacheMissReasonVariant1 @this) => @this.ModelChanged;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissModelChanged? value)
        {
            ModelChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromModelChanged(global::Anthropic.BetaCacheMissModelChanged? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissSystemChanged value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissSystemChanged?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissSystemChanged?(CacheMissReasonVariant1 @this) => @this.SystemChanged;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissSystemChanged? value)
        {
            SystemChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromSystemChanged(global::Anthropic.BetaCacheMissSystemChanged? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissToolsChanged value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissToolsChanged?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissToolsChanged?(CacheMissReasonVariant1 @this) => @this.ToolsChanged;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissToolsChanged? value)
        {
            ToolsChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromToolsChanged(global::Anthropic.BetaCacheMissToolsChanged? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissMessagesChanged value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissMessagesChanged?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissMessagesChanged?(CacheMissReasonVariant1 @this) => @this.MessagesChanged;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissMessagesChanged? value)
        {
            MessagesChanged = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromMessagesChanged(global::Anthropic.BetaCacheMissMessagesChanged? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissPreviousMessageNotFound value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissPreviousMessageNotFound?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissPreviousMessageNotFound?(CacheMissReasonVariant1 @this) => @this.PreviousMessageNotFound;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissPreviousMessageNotFound? value)
        {
            PreviousMessageNotFound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromPreviousMessageNotFound(global::Anthropic.BetaCacheMissPreviousMessageNotFound? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CacheMissReasonVariant1(global::Anthropic.BetaCacheMissUnavailable value) => new CacheMissReasonVariant1((global::Anthropic.BetaCacheMissUnavailable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaCacheMissUnavailable?(CacheMissReasonVariant1 @this) => @this.Unavailable;

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(global::Anthropic.BetaCacheMissUnavailable? value)
        {
            Unavailable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static CacheMissReasonVariant1 FromUnavailable(global::Anthropic.BetaCacheMissUnavailable? value) => new CacheMissReasonVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public CacheMissReasonVariant1(
            global::Anthropic.BetaDiagnosticsCacheMissReasonVariant1DiscriminatorType? type,
            global::Anthropic.BetaCacheMissModelChanged? modelChanged,
            global::Anthropic.BetaCacheMissSystemChanged? systemChanged,
            global::Anthropic.BetaCacheMissToolsChanged? toolsChanged,
            global::Anthropic.BetaCacheMissMessagesChanged? messagesChanged,
            global::Anthropic.BetaCacheMissPreviousMessageNotFound? previousMessageNotFound,
            global::Anthropic.BetaCacheMissUnavailable? unavailable
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
            global::System.Func<global::Anthropic.BetaCacheMissModelChanged, TResult>? modelChanged = null,
            global::System.Func<global::Anthropic.BetaCacheMissSystemChanged, TResult>? systemChanged = null,
            global::System.Func<global::Anthropic.BetaCacheMissToolsChanged, TResult>? toolsChanged = null,
            global::System.Func<global::Anthropic.BetaCacheMissMessagesChanged, TResult>? messagesChanged = null,
            global::System.Func<global::Anthropic.BetaCacheMissPreviousMessageNotFound, TResult>? previousMessageNotFound = null,
            global::System.Func<global::Anthropic.BetaCacheMissUnavailable, TResult>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelChanged && modelChanged != null)
            {
                return modelChanged(ModelChanged!);
            }
            else if (IsSystemChanged && systemChanged != null)
            {
                return systemChanged(SystemChanged!);
            }
            else if (IsToolsChanged && toolsChanged != null)
            {
                return toolsChanged(ToolsChanged!);
            }
            else if (IsMessagesChanged && messagesChanged != null)
            {
                return messagesChanged(MessagesChanged!);
            }
            else if (IsPreviousMessageNotFound && previousMessageNotFound != null)
            {
                return previousMessageNotFound(PreviousMessageNotFound!);
            }
            else if (IsUnavailable && unavailable != null)
            {
                return unavailable(Unavailable!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaCacheMissModelChanged>? modelChanged = null,

            global::System.Action<global::Anthropic.BetaCacheMissSystemChanged>? systemChanged = null,

            global::System.Action<global::Anthropic.BetaCacheMissToolsChanged>? toolsChanged = null,

            global::System.Action<global::Anthropic.BetaCacheMissMessagesChanged>? messagesChanged = null,

            global::System.Action<global::Anthropic.BetaCacheMissPreviousMessageNotFound>? previousMessageNotFound = null,

            global::System.Action<global::Anthropic.BetaCacheMissUnavailable>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelChanged)
            {
                modelChanged?.Invoke(ModelChanged!);
            }
            else if (IsSystemChanged)
            {
                systemChanged?.Invoke(SystemChanged!);
            }
            else if (IsToolsChanged)
            {
                toolsChanged?.Invoke(ToolsChanged!);
            }
            else if (IsMessagesChanged)
            {
                messagesChanged?.Invoke(MessagesChanged!);
            }
            else if (IsPreviousMessageNotFound)
            {
                previousMessageNotFound?.Invoke(PreviousMessageNotFound!);
            }
            else if (IsUnavailable)
            {
                unavailable?.Invoke(Unavailable!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaCacheMissModelChanged>? modelChanged = null,
            global::System.Action<global::Anthropic.BetaCacheMissSystemChanged>? systemChanged = null,
            global::System.Action<global::Anthropic.BetaCacheMissToolsChanged>? toolsChanged = null,
            global::System.Action<global::Anthropic.BetaCacheMissMessagesChanged>? messagesChanged = null,
            global::System.Action<global::Anthropic.BetaCacheMissPreviousMessageNotFound>? previousMessageNotFound = null,
            global::System.Action<global::Anthropic.BetaCacheMissUnavailable>? unavailable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsModelChanged)
            {
                modelChanged?.Invoke(ModelChanged!);
            }
            else if (IsSystemChanged)
            {
                systemChanged?.Invoke(SystemChanged!);
            }
            else if (IsToolsChanged)
            {
                toolsChanged?.Invoke(ToolsChanged!);
            }
            else if (IsMessagesChanged)
            {
                messagesChanged?.Invoke(MessagesChanged!);
            }
            else if (IsPreviousMessageNotFound)
            {
                previousMessageNotFound?.Invoke(PreviousMessageNotFound!);
            }
            else if (IsUnavailable)
            {
                unavailable?.Invoke(Unavailable!);
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
                typeof(global::Anthropic.BetaCacheMissModelChanged),
                SystemChanged,
                typeof(global::Anthropic.BetaCacheMissSystemChanged),
                ToolsChanged,
                typeof(global::Anthropic.BetaCacheMissToolsChanged),
                MessagesChanged,
                typeof(global::Anthropic.BetaCacheMissMessagesChanged),
                PreviousMessageNotFound,
                typeof(global::Anthropic.BetaCacheMissPreviousMessageNotFound),
                Unavailable,
                typeof(global::Anthropic.BetaCacheMissUnavailable),
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
        public bool Equals(CacheMissReasonVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissModelChanged?>.Default.Equals(ModelChanged, other.ModelChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissSystemChanged?>.Default.Equals(SystemChanged, other.SystemChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissToolsChanged?>.Default.Equals(ToolsChanged, other.ToolsChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissMessagesChanged?>.Default.Equals(MessagesChanged, other.MessagesChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissPreviousMessageNotFound?>.Default.Equals(PreviousMessageNotFound, other.PreviousMessageNotFound) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaCacheMissUnavailable?>.Default.Equals(Unavailable, other.Unavailable) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CacheMissReasonVariant1 obj1, CacheMissReasonVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CacheMissReasonVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CacheMissReasonVariant1 obj1, CacheMissReasonVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CacheMissReasonVariant1 o && Equals(o);
        }
    }
}
