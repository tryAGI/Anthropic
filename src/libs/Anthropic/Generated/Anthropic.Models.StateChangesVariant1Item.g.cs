#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StateChangesVariant1Item : global::System.IEquatable<StateChangesVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A tab this call's execution opened that remains open at its end —<br/>
        /// the creation delta of the `tabs` inventory, not an event log.<br/>
        /// Carries only the `tab_id`; the tab's `title` and `url` live on its<br/>
        /// `tabs` entry, which must include the same `tab_id`. A tab opened<br/>
        /// during a failed call gets no deferred `tab_opened`; it simply appears<br/>
        /// in the next result's `tabs` inventory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserStateChangeTabOpened? TabOpened { get; init; }
#else
        public global::Anthropic.BetaBrowserStateChangeTabOpened? TabOpened { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TabOpened))]
#endif
        public bool IsTabOpened => TabOpened != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTabOpened(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserStateChangeTabOpened? value)
        {
            value = TabOpened;
            return IsTabOpened;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeTabOpened PickTabOpened() => IsTabOpened
            ? TabOpened!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TabOpened' but the value was {ToString()}.");

        /// <summary>
        /// A file download that started during this call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? DownloadStarted { get; init; }
#else
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted? DownloadStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DownloadStarted))]
#endif
        public bool IsDownloadStarted => DownloadStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDownloadStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserStateChangeDownloadStarted? value)
        {
            value = DownloadStarted;
            return IsDownloadStarted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadStarted PickDownloadStarted() => IsDownloadStarted
            ? DownloadStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadStarted' but the value was {ToString()}.");

        /// <summary>
        /// A file download that finished during this call, reported with the<br/>
        /// same `download_id` as its `download_started` — or without a prior<br/>
        /// `download_started`, when the download finished during the call that<br/>
        /// started it (at most one state change per `download_id` per result).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? DownloadCompleted { get; init; }
#else
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted? DownloadCompleted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DownloadCompleted))]
#endif
        public bool IsDownloadCompleted => DownloadCompleted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDownloadCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserStateChangeDownloadCompleted? value)
        {
            value = DownloadCompleted;
            return IsDownloadCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadCompleted PickDownloadCompleted() => IsDownloadCompleted
            ? DownloadCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadCompleted' but the value was {ToString()}.");

        /// <summary>
        /// A file download that failed — or was cancelled — during this call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? DownloadFailed { get; init; }
#else
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed? DownloadFailed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DownloadFailed))]
#endif
        public bool IsDownloadFailed => DownloadFailed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDownloadFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaBrowserStateChangeDownloadFailed? value)
        {
            value = DownloadFailed;
            return IsDownloadFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaBrowserStateChangeDownloadFailed PickDownloadFailed() => IsDownloadFailed
            ? DownloadFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadFailed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeTabOpened value) => new StateChangesVariant1Item((global::Anthropic.BetaBrowserStateChangeTabOpened?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserStateChangeTabOpened?(StateChangesVariant1Item @this) => @this.TabOpened;

        /// <summary>
        /// 
        /// </summary>
        public StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeTabOpened? value)
        {
            TabOpened = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StateChangesVariant1Item FromTabOpened(global::Anthropic.BetaBrowserStateChangeTabOpened? value) => new StateChangesVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadStarted value) => new StateChangesVariant1Item((global::Anthropic.BetaBrowserStateChangeDownloadStarted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserStateChangeDownloadStarted?(StateChangesVariant1Item @this) => @this.DownloadStarted;

        /// <summary>
        /// 
        /// </summary>
        public StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadStarted? value)
        {
            DownloadStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StateChangesVariant1Item FromDownloadStarted(global::Anthropic.BetaBrowserStateChangeDownloadStarted? value) => new StateChangesVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadCompleted value) => new StateChangesVariant1Item((global::Anthropic.BetaBrowserStateChangeDownloadCompleted?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserStateChangeDownloadCompleted?(StateChangesVariant1Item @this) => @this.DownloadCompleted;

        /// <summary>
        /// 
        /// </summary>
        public StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadCompleted? value)
        {
            DownloadCompleted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StateChangesVariant1Item FromDownloadCompleted(global::Anthropic.BetaBrowserStateChangeDownloadCompleted? value) => new StateChangesVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadFailed value) => new StateChangesVariant1Item((global::Anthropic.BetaBrowserStateChangeDownloadFailed?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaBrowserStateChangeDownloadFailed?(StateChangesVariant1Item @this) => @this.DownloadFailed;

        /// <summary>
        /// 
        /// </summary>
        public StateChangesVariant1Item(global::Anthropic.BetaBrowserStateChangeDownloadFailed? value)
        {
            DownloadFailed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StateChangesVariant1Item FromDownloadFailed(global::Anthropic.BetaBrowserStateChangeDownloadFailed? value) => new StateChangesVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public StateChangesVariant1Item(
            global::Anthropic.BetaRequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? type,
            global::Anthropic.BetaBrowserStateChangeTabOpened? tabOpened,
            global::Anthropic.BetaBrowserStateChangeDownloadStarted? downloadStarted,
            global::Anthropic.BetaBrowserStateChangeDownloadCompleted? downloadCompleted,
            global::Anthropic.BetaBrowserStateChangeDownloadFailed? downloadFailed
            )
        {
            Type = type;

            TabOpened = tabOpened;
            DownloadStarted = downloadStarted;
            DownloadCompleted = downloadCompleted;
            DownloadFailed = downloadFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DownloadFailed as object ??
            DownloadCompleted as object ??
            DownloadStarted as object ??
            TabOpened as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TabOpened?.ToString() ??
            DownloadStarted?.ToString() ??
            DownloadCompleted?.ToString() ??
            DownloadFailed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTabOpened && !IsDownloadStarted && !IsDownloadCompleted && !IsDownloadFailed || !IsTabOpened && IsDownloadStarted && !IsDownloadCompleted && !IsDownloadFailed || !IsTabOpened && !IsDownloadStarted && IsDownloadCompleted && !IsDownloadFailed || !IsTabOpened && !IsDownloadStarted && !IsDownloadCompleted && IsDownloadFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaBrowserStateChangeTabOpened, TResult>? tabOpened = null,
            global::System.Func<global::Anthropic.BetaBrowserStateChangeDownloadStarted, TResult>? downloadStarted = null,
            global::System.Func<global::Anthropic.BetaBrowserStateChangeDownloadCompleted, TResult>? downloadCompleted = null,
            global::System.Func<global::Anthropic.BetaBrowserStateChangeDownloadFailed, TResult>? downloadFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTabOpened && tabOpened != null)
            {
                return tabOpened(TabOpened!);
            }
            else if (IsDownloadStarted && downloadStarted != null)
            {
                return downloadStarted(DownloadStarted!);
            }
            else if (IsDownloadCompleted && downloadCompleted != null)
            {
                return downloadCompleted(DownloadCompleted!);
            }
            else if (IsDownloadFailed && downloadFailed != null)
            {
                return downloadFailed(DownloadFailed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaBrowserStateChangeTabOpened>? tabOpened = null,

            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadStarted>? downloadStarted = null,

            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadCompleted>? downloadCompleted = null,

            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadFailed>? downloadFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTabOpened)
            {
                tabOpened?.Invoke(TabOpened!);
            }
            else if (IsDownloadStarted)
            {
                downloadStarted?.Invoke(DownloadStarted!);
            }
            else if (IsDownloadCompleted)
            {
                downloadCompleted?.Invoke(DownloadCompleted!);
            }
            else if (IsDownloadFailed)
            {
                downloadFailed?.Invoke(DownloadFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaBrowserStateChangeTabOpened>? tabOpened = null,
            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadStarted>? downloadStarted = null,
            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadCompleted>? downloadCompleted = null,
            global::System.Action<global::Anthropic.BetaBrowserStateChangeDownloadFailed>? downloadFailed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTabOpened)
            {
                tabOpened?.Invoke(TabOpened!);
            }
            else if (IsDownloadStarted)
            {
                downloadStarted?.Invoke(DownloadStarted!);
            }
            else if (IsDownloadCompleted)
            {
                downloadCompleted?.Invoke(DownloadCompleted!);
            }
            else if (IsDownloadFailed)
            {
                downloadFailed?.Invoke(DownloadFailed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TabOpened,
                typeof(global::Anthropic.BetaBrowserStateChangeTabOpened),
                DownloadStarted,
                typeof(global::Anthropic.BetaBrowserStateChangeDownloadStarted),
                DownloadCompleted,
                typeof(global::Anthropic.BetaBrowserStateChangeDownloadCompleted),
                DownloadFailed,
                typeof(global::Anthropic.BetaBrowserStateChangeDownloadFailed),
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
        public bool Equals(StateChangesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserStateChangeTabOpened?>.Default.Equals(TabOpened, other.TabOpened) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserStateChangeDownloadStarted?>.Default.Equals(DownloadStarted, other.DownloadStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserStateChangeDownloadCompleted?>.Default.Equals(DownloadCompleted, other.DownloadCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaBrowserStateChangeDownloadFailed?>.Default.Equals(DownloadFailed, other.DownloadFailed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StateChangesVariant1Item obj1, StateChangesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StateChangesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StateChangesVariant1Item obj1, StateChangesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StateChangesVariant1Item o && Equals(o);
        }
    }
}
