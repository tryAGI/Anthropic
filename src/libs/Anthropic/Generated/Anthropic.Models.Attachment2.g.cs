#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Whether any workspace uses this config to encrypt its data — counting live and archived workspaces (an archived workspace's data remains encrypted under the config), excluding deleted ones. Only an attached config is used by the encryption path; an `unattached` config is inert and can be deleted.
    /// </summary>
    public readonly partial struct Attachment2 : global::System.IEquatable<Attachment2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.ExternalKeyAttachmentDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.AttachedAttachment? Attached { get; init; }
#else
        public global::Anthropic.AttachedAttachment? Attached { get; }
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
            out global::Anthropic.AttachedAttachment? value)
        {
            value = Attached;
            return IsAttached;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.AttachedAttachment PickAttached() => Attached is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Attached' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.UnattachedAttachment? Unattached { get; init; }
#else
        public global::Anthropic.UnattachedAttachment? Unattached { get; }
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
            out global::Anthropic.UnattachedAttachment? value)
        {
            value = Unattached;
            return IsUnattached;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Anthropic.UnattachedAttachment PickUnattached() => Unattached is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Unattached' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attachment2(global::Anthropic.AttachedAttachment value) => new Attachment2((global::Anthropic.AttachedAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.AttachedAttachment?(Attachment2 @this) => @this.Attached;

        /// <summary>
        ///
        /// </summary>
        public Attachment2(global::Anthropic.AttachedAttachment? value)
        {
            Attached = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attachment2 FromAttached(global::Anthropic.AttachedAttachment? value) => new Attachment2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Attachment2(global::Anthropic.UnattachedAttachment value) => new Attachment2((global::Anthropic.UnattachedAttachment?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Anthropic.UnattachedAttachment?(Attachment2 @this) => @this.Unattached;

        /// <summary>
        ///
        /// </summary>
        public Attachment2(global::Anthropic.UnattachedAttachment? value)
        {
            Unattached = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Attachment2 FromUnattached(global::Anthropic.UnattachedAttachment? value) => new Attachment2(value);

        /// <summary>
        ///
        /// </summary>
        public Attachment2(
            global::Anthropic.ExternalKeyAttachmentDiscriminatorType? type,
            global::Anthropic.AttachedAttachment? attached,
            global::Anthropic.UnattachedAttachment? unattached
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
            global::System.Func<global::Anthropic.AttachedAttachment, TResult>? attached = null,
            global::System.Func<global::Anthropic.UnattachedAttachment, TResult>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Attached is { } __value0 && attached != null)
            {
                return attached(__value0);
            }
            else if (Unattached is { } __value1 && unattached != null)
            {
                return unattached(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.AttachedAttachment>? attached = null,

            global::System.Action<global::Anthropic.UnattachedAttachment>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Attached is { } __value0)
            {
                attached?.Invoke(__value0);
            }
            else if (Unattached is { } __value1)
            {
                unattached?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Anthropic.AttachedAttachment>? attached = null,
            global::System.Action<global::Anthropic.UnattachedAttachment>? unattached = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Attached is { } __value0)
            {
                attached?.Invoke(__value0);
            }
            else if (Unattached is { } __value1)
            {
                unattached?.Invoke(__value1);
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
                typeof(global::Anthropic.AttachedAttachment),
                Unattached,
                typeof(global::Anthropic.UnattachedAttachment),
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
        public bool Equals(Attachment2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.AttachedAttachment?>.Default.Equals(Attached, other.Attached) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.UnattachedAttachment?>.Default.Equals(Unattached, other.Unattached)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Attachment2 obj1, Attachment2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Attachment2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Attachment2 obj1, Attachment2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Attachment2 o && Equals(o);
        }
    }
}
