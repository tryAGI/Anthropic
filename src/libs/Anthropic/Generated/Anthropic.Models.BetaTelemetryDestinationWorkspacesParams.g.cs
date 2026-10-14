#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Which of the organization's workspaces a telemetry destination covers, as a create or update request sets it.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationWorkspacesParams : global::System.IEquatable<BetaTelemetryDestinationWorkspacesParams>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Cover every workspace of the organization. Doesn't take `workspace_ids`.<br/>
        /// An update that sets `all` empties the destination's workspace list.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? All { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? All { get; }
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
            out global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams PickAll() => All is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// Cover only the workspaces on the list.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Include { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? Include { get; }
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
            out global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? value)
        {
            value = Include;
            return IsInclude;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams PickInclude() => Include is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Include' but the value was {ToString()}.");

        /// <summary>
        /// Cover every workspace of the organization except the workspaces on the list.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Exclude { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? Exclude { get; }
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
            out global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? value)
        {
            value = Exclude;
            return IsExclude;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams PickExclude() => Exclude is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exclude' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams value) => new BetaTelemetryDestinationWorkspacesParams((global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams?(BetaTelemetryDestinationWorkspacesParams @this) => @this.All;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? value)
        {
            All = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspacesParams FromAll(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? value) => new BetaTelemetryDestinationWorkspacesParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams value) => new BetaTelemetryDestinationWorkspacesParams((global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams?(BetaTelemetryDestinationWorkspacesParams @this) => @this.Include;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? value)
        {
            Include = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspacesParams FromInclude(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? value) => new BetaTelemetryDestinationWorkspacesParams(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams value) => new BetaTelemetryDestinationWorkspacesParams((global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams?(BetaTelemetryDestinationWorkspacesParams @this) => @this.Exclude;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspacesParams(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? value)
        {
            Exclude = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationWorkspacesParams FromExclude(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? value) => new BetaTelemetryDestinationWorkspacesParams(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationWorkspacesParams(
            global::Anthropic.BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams? all,
            global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams? include,
            global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams? exclude
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
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams, TResult>? all = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams, TResult>? include = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams, TResult>? exclude = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams>? all = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams>? include = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams>? exclude = null,
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
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams>? all = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams>? include = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams>? exclude = null,
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
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams),
                Include,
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams),
                Exclude,
                typeof(global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams),
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
        public bool Equals(BetaTelemetryDestinationWorkspacesParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesAllParams?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesIncludeParams?>.Default.Equals(Include, other.Include) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationWorkspacesExcludeParams?>.Default.Equals(Exclude, other.Exclude)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationWorkspacesParams obj1, BetaTelemetryDestinationWorkspacesParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationWorkspacesParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationWorkspacesParams obj1, BetaTelemetryDestinationWorkspacesParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationWorkspacesParams o && Equals(o);
        }
    }
}
