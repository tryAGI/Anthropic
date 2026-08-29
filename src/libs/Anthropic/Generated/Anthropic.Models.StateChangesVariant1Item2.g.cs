#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct StateChangesVariant1Item2 : global::System.IEquatable<StateChangesVariant1Item2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A tab this call's execution opened that remains open at its end —<br/>
        /// the creation delta of the `tabs` inventory, not an event log.<br/>
        /// Carries only the `tab_id`; the tab's `title` and `url` live on its<br/>
        /// `tabs` entry, which must include the same `tab_id`. A tab opened<br/>
        /// during a failed call gets no deferred `tab_opened`; it simply appears<br/>
        /// in the next result's `tabs` inventory.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserStateChangeTabOpened? TabOpened { get; init; }
#else
        public global::Anthropic.BrowserStateChangeTabOpened? TabOpened { get; }
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
            out global::Anthropic.BrowserStateChangeTabOpened? value)
        {
            value = TabOpened;
            return IsTabOpened;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeTabOpened PickTabOpened() => IsTabOpened
            ? TabOpened!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TabOpened' but the value was {ToString()}.");

        /// <summary>
        /// A file download that started during this call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserStateChangeDownloadStarted? DownloadStarted { get; init; }
#else
        public global::Anthropic.BrowserStateChangeDownloadStarted? DownloadStarted { get; }
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
            out global::Anthropic.BrowserStateChangeDownloadStarted? value)
        {
            value = DownloadStarted;
            return IsDownloadStarted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadStarted PickDownloadStarted() => IsDownloadStarted
            ? DownloadStarted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadStarted' but the value was {ToString()}.");

        /// <summary>
        /// A file download that finished during this call, reported with the<br/>
        /// same `download_id` as its `download_started` — or without a prior<br/>
        /// `download_started`, when the download finished during the call that<br/>
        /// started it (at most one state change per `download_id` per result).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserStateChangeDownloadCompleted? DownloadCompleted { get; init; }
#else
        public global::Anthropic.BrowserStateChangeDownloadCompleted? DownloadCompleted { get; }
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
            out global::Anthropic.BrowserStateChangeDownloadCompleted? value)
        {
            value = DownloadCompleted;
            return IsDownloadCompleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadCompleted PickDownloadCompleted() => IsDownloadCompleted
            ? DownloadCompleted!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadCompleted' but the value was {ToString()}.");

        /// <summary>
        /// A file download that failed — or was cancelled — during this call.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BrowserStateChangeDownloadFailed? DownloadFailed { get; init; }
#else
        public global::Anthropic.BrowserStateChangeDownloadFailed? DownloadFailed { get; }
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
            out global::Anthropic.BrowserStateChangeDownloadFailed? value)
        {
            value = DownloadFailed;
            return IsDownloadFailed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BrowserStateChangeDownloadFailed PickDownloadFailed() => IsDownloadFailed
            ? DownloadFailed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadFailed' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeTabOpened value) => new StateChangesVariant1Item2((global::Anthropic.BrowserStateChangeTabOpened?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserStateChangeTabOpened?(StateChangesVariant1Item2 @this) => @this.TabOpened;

        /// <summary>
        ///
        /// </summary>
        public StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeTabOpened? value)
        {
            TabOpened = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StateChangesVariant1Item2 FromTabOpened(global::Anthropic.BrowserStateChangeTabOpened? value) => new StateChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadStarted value) => new StateChangesVariant1Item2((global::Anthropic.BrowserStateChangeDownloadStarted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserStateChangeDownloadStarted?(StateChangesVariant1Item2 @this) => @this.DownloadStarted;

        /// <summary>
        ///
        /// </summary>
        public StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadStarted? value)
        {
            DownloadStarted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StateChangesVariant1Item2 FromDownloadStarted(global::Anthropic.BrowserStateChangeDownloadStarted? value) => new StateChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadCompleted value) => new StateChangesVariant1Item2((global::Anthropic.BrowserStateChangeDownloadCompleted?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserStateChangeDownloadCompleted?(StateChangesVariant1Item2 @this) => @this.DownloadCompleted;

        /// <summary>
        ///
        /// </summary>
        public StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadCompleted? value)
        {
            DownloadCompleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StateChangesVariant1Item2 FromDownloadCompleted(global::Anthropic.BrowserStateChangeDownloadCompleted? value) => new StateChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadFailed value) => new StateChangesVariant1Item2((global::Anthropic.BrowserStateChangeDownloadFailed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BrowserStateChangeDownloadFailed?(StateChangesVariant1Item2 @this) => @this.DownloadFailed;

        /// <summary>
        ///
        /// </summary>
        public StateChangesVariant1Item2(global::Anthropic.BrowserStateChangeDownloadFailed? value)
        {
            DownloadFailed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static StateChangesVariant1Item2 FromDownloadFailed(global::Anthropic.BrowserStateChangeDownloadFailed? value) => new StateChangesVariant1Item2(value);

        /// <summary>
        ///
        /// </summary>
        public StateChangesVariant1Item2(
            global::Anthropic.RequestBrowserStateBlockStateChangesVariant1ItemDiscriminatorType? type,
            global::Anthropic.BrowserStateChangeTabOpened? tabOpened,
            global::Anthropic.BrowserStateChangeDownloadStarted? downloadStarted,
            global::Anthropic.BrowserStateChangeDownloadCompleted? downloadCompleted,
            global::Anthropic.BrowserStateChangeDownloadFailed? downloadFailed
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
            global::System.Func<global::Anthropic.BrowserStateChangeTabOpened, TResult>? tabOpened = null,
            global::System.Func<global::Anthropic.BrowserStateChangeDownloadStarted, TResult>? downloadStarted = null,
            global::System.Func<global::Anthropic.BrowserStateChangeDownloadCompleted, TResult>? downloadCompleted = null,
            global::System.Func<global::Anthropic.BrowserStateChangeDownloadFailed, TResult>? downloadFailed = null,
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
            global::System.Action<global::Anthropic.BrowserStateChangeTabOpened>? tabOpened = null,

            global::System.Action<global::Anthropic.BrowserStateChangeDownloadStarted>? downloadStarted = null,

            global::System.Action<global::Anthropic.BrowserStateChangeDownloadCompleted>? downloadCompleted = null,

            global::System.Action<global::Anthropic.BrowserStateChangeDownloadFailed>? downloadFailed = null,
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
            global::System.Action<global::Anthropic.BrowserStateChangeTabOpened>? tabOpened = null,
            global::System.Action<global::Anthropic.BrowserStateChangeDownloadStarted>? downloadStarted = null,
            global::System.Action<global::Anthropic.BrowserStateChangeDownloadCompleted>? downloadCompleted = null,
            global::System.Action<global::Anthropic.BrowserStateChangeDownloadFailed>? downloadFailed = null,
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
                typeof(global::Anthropic.BrowserStateChangeTabOpened),
                DownloadStarted,
                typeof(global::Anthropic.BrowserStateChangeDownloadStarted),
                DownloadCompleted,
                typeof(global::Anthropic.BrowserStateChangeDownloadCompleted),
                DownloadFailed,
                typeof(global::Anthropic.BrowserStateChangeDownloadFailed),
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
        public bool Equals(StateChangesVariant1Item2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserStateChangeTabOpened?>.Default.Equals(TabOpened, other.TabOpened) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserStateChangeDownloadStarted?>.Default.Equals(DownloadStarted, other.DownloadStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserStateChangeDownloadCompleted?>.Default.Equals(DownloadCompleted, other.DownloadCompleted) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BrowserStateChangeDownloadFailed?>.Default.Equals(DownloadFailed, other.DownloadFailed)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(StateChangesVariant1Item2 obj1, StateChangesVariant1Item2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StateChangesVariant1Item2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(StateChangesVariant1Item2 obj1, StateChangesVariant1Item2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StateChangesVariant1Item2 o && Equals(o);
        }
    }
}
