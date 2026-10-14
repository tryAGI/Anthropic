#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Why the destination is disabled: `caller` when a caller disabled it, or the reason the API disabled it automatically (`sustained_failure`, `invalid_address`, or `redirect`). Every automatic disable is reversible with an update that sets `state` to `enabled`. An update that sets `disabled` on a destination that is already disabled keeps its reason.
    /// </summary>
    public readonly partial struct BetaTelemetryDestinationDisabledReason : global::System.IEquatable<BetaTelemetryDestinationDisabledReason>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? Type { get; }

        /// <summary>
        /// A caller disabled the destination with an update that set `state` to `disabled`.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Caller { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? Caller { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Caller))]
#endif
        public bool IsCaller => Caller != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickCaller(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? value)
        {
            value = Caller;
            return IsCaller;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller PickCaller() => Caller is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Caller' but the value was {ToString()}.");

        /// <summary>
        /// The API disabled the destination because deliveries to it failed, with no successful delivery in between, for longer than a threshold that Anthropic configures and that is not part of this contract. The reason is `invalid_address` instead when the most recent failed delivery failed with an invalid address.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? SustainedFailure { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? SustainedFailure { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SustainedFailure))]
#endif
        public bool IsSustainedFailure => SustainedFailure != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSustainedFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? value)
        {
            value = SustainedFailure;
            return IsSustainedFailure;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure PickSustainedFailure() => SustainedFailure is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SustainedFailure' but the value was {ToString()}.");

        /// <summary>
        /// The API disabled the destination because deliveries to it failed for longer than the same threshold as for `sustained_failure`, and the most recent failed delivery failed with an invalid address: the DNS answer says that the endpoint's hostname doesn't exist or doesn't have an address, or the address that the API would connect to isn't publicly routable or is reserved, for example a loopback, link-local, private-network, or cloud-metadata address. The API doesn't connect to such an address, and retries the delivery a bounded number of times as it does after a timeout. A timeout or a server failure of the DNS lookup is a temporary DNS failure instead, not an invalid address.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? InvalidAddress { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? InvalidAddress { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InvalidAddress))]
#endif
        public bool IsInvalidAddress => InvalidAddress != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInvalidAddress(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? value)
        {
            value = InvalidAddress;
            return IsInvalidAddress;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress PickInvalidAddress() => InvalidAddress is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InvalidAddress' but the value was {ToString()}.");

        /// <summary>
        /// The API disabled the destination because the endpoint answered a delivery with a 3xx status. Redirects are never followed, and one such answer disables the destination at once.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Redirect { get; init; }
#else
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? Redirect { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Redirect))]
#endif
        public bool IsRedirect => Redirect != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickRedirect(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? value)
        {
            value = Redirect;
            return IsRedirect;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect PickRedirect() => Redirect is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Redirect' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller value) => new BetaTelemetryDestinationDisabledReason((global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller?(BetaTelemetryDestinationDisabledReason @this) => @this.Caller;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? value)
        {
            Caller = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationDisabledReason FromCaller(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? value) => new BetaTelemetryDestinationDisabledReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure value) => new BetaTelemetryDestinationDisabledReason((global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure?(BetaTelemetryDestinationDisabledReason @this) => @this.SustainedFailure;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? value)
        {
            SustainedFailure = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationDisabledReason FromSustainedFailure(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? value) => new BetaTelemetryDestinationDisabledReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress value) => new BetaTelemetryDestinationDisabledReason((global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress?(BetaTelemetryDestinationDisabledReason @this) => @this.InvalidAddress;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? value)
        {
            InvalidAddress = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationDisabledReason FromInvalidAddress(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? value) => new BetaTelemetryDestinationDisabledReason(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect value) => new BetaTelemetryDestinationDisabledReason((global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect?(BetaTelemetryDestinationDisabledReason @this) => @this.Redirect;

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationDisabledReason(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? value)
        {
            Redirect = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BetaTelemetryDestinationDisabledReason FromRedirect(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? value) => new BetaTelemetryDestinationDisabledReason(value);

        /// <summary>
        ///
        /// </summary>
        public BetaTelemetryDestinationDisabledReason(
            global::Anthropic.BetaTelemetryDestinationDisabledReasonDiscriminatorType? type,
            global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller? caller,
            global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure? sustainedFailure,
            global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress? invalidAddress,
            global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect? redirect
            )
        {
            Type = type;

            Caller = caller;
            SustainedFailure = sustainedFailure;
            InvalidAddress = invalidAddress;
            Redirect = redirect;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Redirect as object ??
            InvalidAddress as object ??
            SustainedFailure as object ??
            Caller as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Caller?.ToString() ??
            SustainedFailure?.ToString() ??
            InvalidAddress?.ToString() ??
            Redirect?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsCaller && !IsSustainedFailure && !IsInvalidAddress && !IsRedirect || !IsCaller && IsSustainedFailure && !IsInvalidAddress && !IsRedirect || !IsCaller && !IsSustainedFailure && IsInvalidAddress && !IsRedirect || !IsCaller && !IsSustainedFailure && !IsInvalidAddress && IsRedirect;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller, TResult>? caller = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure, TResult>? sustainedFailure = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress, TResult>? invalidAddress = null,
            global::System.Func<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect, TResult>? redirect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Caller is { } __value0 && caller != null)
            {
                return caller(__value0);
            }
            else if (SustainedFailure is { } __value1 && sustainedFailure != null)
            {
                return sustainedFailure(__value1);
            }
            else if (InvalidAddress is { } __value2 && invalidAddress != null)
            {
                return invalidAddress(__value2);
            }
            else if (Redirect is { } __value3 && redirect != null)
            {
                return redirect(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller>? caller = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure>? sustainedFailure = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress>? invalidAddress = null,

            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect>? redirect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Caller is { } __value0)
            {
                caller?.Invoke(__value0);
            }
            else if (SustainedFailure is { } __value1)
            {
                sustainedFailure?.Invoke(__value1);
            }
            else if (InvalidAddress is { } __value2)
            {
                invalidAddress?.Invoke(__value2);
            }
            else if (Redirect is { } __value3)
            {
                redirect?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller>? caller = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure>? sustainedFailure = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress>? invalidAddress = null,
            global::System.Action<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect>? redirect = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Caller is { } __value0)
            {
                caller?.Invoke(__value0);
            }
            else if (SustainedFailure is { } __value1)
            {
                sustainedFailure?.Invoke(__value1);
            }
            else if (InvalidAddress is { } __value2)
            {
                invalidAddress?.Invoke(__value2);
            }
            else if (Redirect is { } __value3)
            {
                redirect?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Caller,
                typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller),
                SustainedFailure,
                typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure),
                InvalidAddress,
                typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress),
                Redirect,
                typeof(global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect),
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
        public bool Equals(BetaTelemetryDestinationDisabledReason other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationDisabledReasonCaller?>.Default.Equals(Caller, other.Caller) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationDisabledReasonSustainedFailure?>.Default.Equals(SustainedFailure, other.SustainedFailure) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationDisabledReasonInvalidAddress?>.Default.Equals(InvalidAddress, other.InvalidAddress) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaTelemetryDestinationDisabledReasonRedirect?>.Default.Equals(Redirect, other.Redirect)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BetaTelemetryDestinationDisabledReason obj1, BetaTelemetryDestinationDisabledReason obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaTelemetryDestinationDisabledReason>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BetaTelemetryDestinationDisabledReason obj1, BetaTelemetryDestinationDisabledReason obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaTelemetryDestinationDisabledReason o && Equals(o);
        }
    }
}
