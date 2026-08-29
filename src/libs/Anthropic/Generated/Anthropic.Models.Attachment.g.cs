#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether any workspace uses this config to encrypt its data — counting live and archived workspaces (an archived workspace's data remains encrypted under the config), excluding deleted ones. Only an attached config is used by the encryption path; an `unattached` config is inert and can be deleted.
    /// </summary>
    public readonly partial struct Attachment : global::System.IEquatable<Attachment>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaAttachedAttachment? Attached { get; init; }
#else
        public global::Anthropic.BetaAttachedAttachment? Attached { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Attached))]
#endif
        public bool IsAttached => Attached != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAttached(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaAttachedAttachment? value)
        {
            value = Attached;
            return IsAttached;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaAttachedAttachment PickAttached() => IsAttached
            ? Attached!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Attached' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaUnattachedAttachment? Unattached { get; init; }
#else
        public global::Anthropic.BetaUnattachedAttachment? Unattached { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Unattached))]
#endif
        public bool IsUnattached => Unattached != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUnattached(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaUnattachedAttachment? value)
        {
            value = Unattached;
            return IsUnattached;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.BetaUnattachedAttachment PickUnattached() => IsUnattached
            ? Unattached!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unattached' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attachment(global::Anthropic.BetaAttachedAttachment value) => new Attachment((global::Anthropic.BetaAttachedAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaAttachedAttachment?(Attachment @this) => @this.Attached;

        /// <summary>
        ///
        /// </summary>
        public Attachment(global::Anthropic.BetaAttachedAttachment? value)
        {
            Attached = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attachment FromAttached(global::Anthropic.BetaAttachedAttachment? value) => new Attachment(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attachment(global::Anthropic.BetaUnattachedAttachment value) => new Attachment((global::Anthropic.BetaUnattachedAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.BetaUnattachedAttachment?(Attachment @this) => @this.Unattached;

        /// <summary>
        ///
        /// </summary>
        public Attachment(global::Anthropic.BetaUnattachedAttachment? value)
        {
            Unattached = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attachment FromUnattached(global::Anthropic.BetaUnattachedAttachment? value) => new Attachment(value);

        /// <summary>
        ///
        /// </summary>
        public Attachment(
            global::Anthropic.BetaExternalKeyAttachmentDiscriminatorType? type,
            global::Anthropic.BetaAttachedAttachment? attached,
            global::Anthropic.BetaUnattachedAttachment? unattached
            )
        {
            Type = type;

            Attached = attached;
            Unattached = unattached;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Unattached as object ??
            Attached as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Attached?.ToString() ??
            Unattached?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAttached && !IsUnattached || !IsAttached && IsUnattached;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaAttachedAttachment, TResult>? attached = null,
            global::System.Func<global::Anthropic.BetaUnattachedAttachment, TResult>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttached && attached != null)
            {
                return attached(Attached!);
            }
            else if (IsUnattached && unattached != null)
            {
                return unattached(Unattached!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaAttachedAttachment>? attached = null,

            global::System.Action<global::Anthropic.BetaUnattachedAttachment>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttached)
            {
                attached?.Invoke(Attached!);
            }
            else if (IsUnattached)
            {
                unattached?.Invoke(Unattached!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.BetaAttachedAttachment>? attached = null,
            global::System.Action<global::Anthropic.BetaUnattachedAttachment>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAttached)
            {
                attached?.Invoke(Attached!);
            }
            else if (IsUnattached)
            {
                unattached?.Invoke(Unattached!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Attached,
                typeof(global::Anthropic.BetaAttachedAttachment),
                Unattached,
                typeof(global::Anthropic.BetaUnattachedAttachment),
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
        public bool Equals(Attachment other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaAttachedAttachment?>.Default.Equals(Attached, other.Attached) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaUnattachedAttachment?>.Default.Equals(Unattached, other.Unattached)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Attachment obj1, Attachment obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Attachment>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Attachment obj1, Attachment obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Attachment o && Equals(o);
        }
    }
}
