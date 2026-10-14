#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which of the organization's workspaces a telemetry destination covers.<br/>
    /// Several destinations can cover the same workspace. Each of them receives the workspace's spans while it is enabled.<br/>
    /// The workspace list of an `include` or `exclude` destination isn't part of the destination object. List the destination's workspaces to read it. Add or remove one workspace at a time, or replace the whole list with an update. A list holds at most 1,000 workspaces.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationWorkspaces : global::System.IEquatable<BetaTelemetryDestinationWorkspaces>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? Type { get; }

        /// <summary>
        /// The destination covers every workspace of the organization, including the default workspace, archived workspaces, and workspaces created later. It doesn't have a list.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? All { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll? All { get; }
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
            out global::Anthropic.BetaTelemetryDestinationWorkspacesAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAll PickAll() => All is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// The destination covers the workspaces on its list, and no others.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Include { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? Include { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Include))]
#endif
        public bool IsInclude => Include != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInclude(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? value)
        {
            value = Include;
            return IsInclude;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesInclude PickInclude() => Include is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Include' but the value was {ToString()}.");

        /// <summary>
        /// The destination covers every workspace of the organization except the workspaces on its list. A workspace created later is covered until it is added to the list.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Exclude { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? Exclude { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exclude))]
#endif
        public bool IsExclude => Exclude != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExclude(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? value)
        {
            value = Exclude;
            return IsExclude;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExclude PickExclude() => Exclude is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exclude' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesAll value) => new BetaTelemetryDestinationWorkspaces((global::Anthropic.BetaTelemetryDestinationWorkspacesAll?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesAll?(BetaTelemetryDestinationWorkspaces @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesAll? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspaces FromAll(global::Anthropic.BetaTelemetryDestinationWorkspacesAll? value) => new BetaTelemetryDestinationWorkspaces(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude value) => new BetaTelemetryDestinationWorkspaces((global::Anthropic.BetaTelemetryDestinationWorkspacesInclude?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesInclude?(BetaTelemetryDestinationWorkspaces @this) => @this.Include;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? value)
        {
            Include = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspaces FromInclude(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? value) => new BetaTelemetryDestinationWorkspaces(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude value) => new BetaTelemetryDestinationWorkspaces((global::Anthropic.BetaTelemetryDestinationWorkspacesExclude?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesExclude?(BetaTelemetryDestinationWorkspaces @this) => @this.Exclude;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspaces(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? value)
        {
            Exclude = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspaces FromExclude(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? value) => new BetaTelemetryDestinationWorkspaces(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspaces(
            global::Anthropic.BetaTelemetryDestinationWorkspacesDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationWorkspacesAll? all,
            global::Anthropic.BetaTelemetryDestinationWorkspacesInclude? include,
            global::Anthropic.BetaTelemetryDestinationWorkspacesExclude? exclude
            )
        {
            Type = type;

            All = all;
            Include = include;
            Exclude = exclude;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Exclude as object ??
            Include as object ??
            All as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            All?.ToString() ??
            Include?.ToString() ??
            Exclude?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAll && !IsInclude && !IsExclude || !IsAll && IsInclude && !IsExclude || !IsAll && !IsInclude && IsExclude;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesAll, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude, TResult>? include = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude, TResult>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0 && all != null)
            {
                return all(__value0);
            }
            else if (Include is { } __value1 && include != null)
            {
                return include(__value1);
            }
            else if (Exclude is { } __value2 && exclude != null)
            {
                return exclude(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesAll>? all = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude>? include = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0)
            {
                all?.Invoke(__value0);
            }
            else if (Include is { } __value1)
            {
                include?.Invoke(__value1);
            }
            else if (Exclude is { } __value2)
            {
                exclude?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesAll>? all = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude>? include = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude>? exclude = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (All is { } __value0)
            {
                all?.Invoke(__value0);
            }
            else if (Include is { } __value1)
            {
                include?.Invoke(__value1);
            }
            else if (Exclude is { } __value2)
            {
                exclude?.Invoke(__value2);
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
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAll),
                Include,
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesInclude),
                Exclude,
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExclude),
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
        public bool Equals(BetaTelemetryDestinationWorkspaces other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesInclude?>.Default.Equals(Include, other.Include) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesExclude?>.Default.Equals(Exclude, other.Exclude)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationWorkspaces obj1, BetaTelemetryDestinationWorkspaces obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationWorkspaces>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationWorkspaces obj1, BetaTelemetryDestinationWorkspaces obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationWorkspaces o && Equals(o);
        }
    }
}
