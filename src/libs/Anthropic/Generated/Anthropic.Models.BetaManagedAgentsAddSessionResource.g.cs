#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The added session resource.
    /// </summary>
    public readonly partial struct BetaManagedAgentsAddSessionResource : global::System.IEquatable<BetaManagedAgentsAddSessionResource>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Example: {"type":"file","id":"sesrsc_011CZkZBJq5dWxk9fVLNcPht","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf","created_at":"2026-03-15T10:00:00Z","updated_at":"2026-03-15T10:00:00Z"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileResource? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileResource? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsAddSessionResource(global::Anthropic.BetaManagedAgentsFileResource value) => new BetaManagedAgentsAddSessionResource((global::Anthropic.BetaManagedAgentsFileResource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileResource?(BetaManagedAgentsAddSessionResource @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAddSessionResource(global::Anthropic.BetaManagedAgentsFileResource? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAddSessionResource(
            global::Anthropic.BetaManagedAgentsAddSessionResourceDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsFileResource? file
            )
        {
            Type = type;

            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsFileResource?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsFileResource?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileResource),
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
        public bool Equals(BetaManagedAgentsAddSessionResource other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileResource?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAddSessionResource obj1, BetaManagedAgentsAddSessionResource obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAddSessionResource>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAddSessionResource obj1, BetaManagedAgentsAddSessionResource obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAddSessionResource o && Equals(o);
        }
    }
}
