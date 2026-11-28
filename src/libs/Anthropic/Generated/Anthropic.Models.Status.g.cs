#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Status : global::System.IEquatable<Status>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalStorageStatusDiscriminatorType? Type { get; }

        /// <summary>
        /// The storage isn't verified yet.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaPendingConfigurationExternalStorageStatus? PendingConfiguration { get; init; }
#else
        public global::Anthropic.BetaPendingConfigurationExternalStorageStatus? PendingConfiguration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PendingConfiguration))]
#endif
        public bool IsPendingConfiguration => PendingConfiguration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPendingConfiguration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaPendingConfigurationExternalStorageStatus? value)
        {
            value = PendingConfiguration;
            return IsPendingConfiguration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaPendingConfigurationExternalStorageStatus PickPendingConfiguration() => PendingConfiguration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PendingConfiguration' but the value was {ToString()}.");

        /// <summary>
        /// The storage is verified, no Workspace has it attached, and Anthropic doesn't use<br/>
        /// the bucket.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAvailableExternalStorageStatus? Available { get; init; }
#else
        public global::Anthropic.BetaAvailableExternalStorageStatus? Available { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Available))]
#endif
        public bool IsAvailable => Available != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAvailable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAvailableExternalStorageStatus? value)
        {
            value = Available;
            return IsAvailable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAvailableExternalStorageStatus PickAvailable() => Available is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Available' but the value was {ToString()}.");

        /// <summary>
        /// At least one Workspace has the storage attached.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaActiveExternalStorageStatus? Active { get; init; }
#else
        public global::Anthropic.BetaActiveExternalStorageStatus? Active { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Active))]
#endif
        public bool IsActive => Active != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickActive(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaActiveExternalStorageStatus? value)
        {
            value = Active;
            return IsActive;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaActiveExternalStorageStatus PickActive() => Active is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Active' but the value was {ToString()}.");

        /// <summary>
        /// No Workspace has the storage attached. A Workspace can attach it again, unless<br/>
        /// `removal_started` is true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaDrainingExternalStorageStatus? Draining { get; init; }
#else
        public global::Anthropic.BetaDrainingExternalStorageStatus? Draining { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Draining))]
#endif
        public bool IsDraining => Draining != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDraining(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaDrainingExternalStorageStatus? value)
        {
            value = Draining;
            return IsDraining;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaDrainingExternalStorageStatus PickDraining() => Draining is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Draining' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaPendingConfigurationExternalStorageStatus value) => new Status((global::Anthropic.BetaPendingConfigurationExternalStorageStatus?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaPendingConfigurationExternalStorageStatus?(Status @this) => @this.PendingConfiguration;

        /// <summary>
        ///
        /// </summary>
        public Status(global::Anthropic.BetaPendingConfigurationExternalStorageStatus? value)
        {
            PendingConfiguration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status FromPendingConfiguration(global::Anthropic.BetaPendingConfigurationExternalStorageStatus? value) => new Status(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaAvailableExternalStorageStatus value) => new Status((global::Anthropic.BetaAvailableExternalStorageStatus?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAvailableExternalStorageStatus?(Status @this) => @this.Available;

        /// <summary>
        ///
        /// </summary>
        public Status(global::Anthropic.BetaAvailableExternalStorageStatus? value)
        {
            Available = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status FromAvailable(global::Anthropic.BetaAvailableExternalStorageStatus? value) => new Status(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaActiveExternalStorageStatus value) => new Status((global::Anthropic.BetaActiveExternalStorageStatus?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaActiveExternalStorageStatus?(Status @this) => @this.Active;

        /// <summary>
        ///
        /// </summary>
        public Status(global::Anthropic.BetaActiveExternalStorageStatus? value)
        {
            Active = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status FromActive(global::Anthropic.BetaActiveExternalStorageStatus? value) => new Status(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Status(global::Anthropic.BetaDrainingExternalStorageStatus value) => new Status((global::Anthropic.BetaDrainingExternalStorageStatus?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaDrainingExternalStorageStatus?(Status @this) => @this.Draining;

        /// <summary>
        ///
        /// </summary>
        public Status(global::Anthropic.BetaDrainingExternalStorageStatus? value)
        {
            Draining = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Status FromDraining(global::Anthropic.BetaDrainingExternalStorageStatus? value) => new Status(value);

        /// <summary>
        ///
        /// </summary>
        public Status(
            global::Anthropic.BetaExternalStorageStatusDiscriminatorType? type,
            global::Anthropic.BetaPendingConfigurationExternalStorageStatus? pendingConfiguration,
            global::Anthropic.BetaAvailableExternalStorageStatus? available,
            global::Anthropic.BetaActiveExternalStorageStatus? active,
            global::Anthropic.BetaDrainingExternalStorageStatus? draining
            )
        {
            Type = type;

            PendingConfiguration = pendingConfiguration;
            Available = available;
            Active = active;
            Draining = draining;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Draining as object ??
            Active as object ??
            Available as object ??
            PendingConfiguration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PendingConfiguration?.ToString() ??
            Available?.ToString() ??
            Active?.ToString() ??
            Draining?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPendingConfiguration && !IsAvailable && !IsActive && !IsDraining || !IsPendingConfiguration && IsAvailable && !IsActive && !IsDraining || !IsPendingConfiguration && !IsAvailable && IsActive && !IsDraining || !IsPendingConfiguration && !IsAvailable && !IsActive && IsDraining;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaPendingConfigurationExternalStorageStatus, TResult>? pendingConfiguration = null,
            global::System.Func<global::Anthropic.BetaAvailableExternalStorageStatus, TResult>? available = null,
            global::System.Func<global::Anthropic.BetaActiveExternalStorageStatus, TResult>? active = null,
            global::System.Func<global::Anthropic.BetaDrainingExternalStorageStatus, TResult>? draining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PendingConfiguration is { } __value0 && pendingConfiguration != null)
            {
                return pendingConfiguration(__value0);
            }
            else if (Available is { } __value1 && available != null)
            {
                return available(__value1);
            }
            else if (Active is { } __value2 && active != null)
            {
                return active(__value2);
            }
            else if (Draining is { } __value3 && draining != null)
            {
                return draining(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaPendingConfigurationExternalStorageStatus>? pendingConfiguration = null,

            global::System.Action<global::Anthropic.BetaAvailableExternalStorageStatus>? available = null,

            global::System.Action<global::Anthropic.BetaActiveExternalStorageStatus>? active = null,

            global::System.Action<global::Anthropic.BetaDrainingExternalStorageStatus>? draining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PendingConfiguration is { } __value0)
            {
                pendingConfiguration?.Invoke(__value0);
            }
            else if (Available is { } __value1)
            {
                available?.Invoke(__value1);
            }
            else if (Active is { } __value2)
            {
                active?.Invoke(__value2);
            }
            else if (Draining is { } __value3)
            {
                draining?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaPendingConfigurationExternalStorageStatus>? pendingConfiguration = null,
            global::System.Action<global::Anthropic.BetaAvailableExternalStorageStatus>? available = null,
            global::System.Action<global::Anthropic.BetaActiveExternalStorageStatus>? active = null,
            global::System.Action<global::Anthropic.BetaDrainingExternalStorageStatus>? draining = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PendingConfiguration is { } __value0)
            {
                pendingConfiguration?.Invoke(__value0);
            }
            else if (Available is { } __value1)
            {
                available?.Invoke(__value1);
            }
            else if (Active is { } __value2)
            {
                active?.Invoke(__value2);
            }
            else if (Draining is { } __value3)
            {
                draining?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PendingConfiguration,
                typeof(global::Anthropic.BetaPendingConfigurationExternalStorageStatus),
                Available,
                typeof(global::Anthropic.BetaAvailableExternalStorageStatus),
                Active,
                typeof(global::Anthropic.BetaActiveExternalStorageStatus),
                Draining,
                typeof(global::Anthropic.BetaDrainingExternalStorageStatus),
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
        public bool Equals(Status other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaPendingConfigurationExternalStorageStatus?>.Default.Equals(PendingConfiguration, other.PendingConfiguration) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAvailableExternalStorageStatus?>.Default.Equals(Available, other.Available) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaActiveExternalStorageStatus?>.Default.Equals(Active, other.Active) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaDrainingExternalStorageStatus?>.Default.Equals(Draining, other.Draining)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Status obj1, Status obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Status>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Status obj1, Status obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Status o && Equals(o);
        }
    }
}
