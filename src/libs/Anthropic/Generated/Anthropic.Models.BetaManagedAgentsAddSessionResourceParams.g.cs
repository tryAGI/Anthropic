#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Request parameters for adding a resource to a session.<br/>
    /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf"}
    /// </summary>
    public readonly partial struct BetaManagedAgentsAddSessionResourceParams : global::System.IEquatable<BetaManagedAgentsAddSessionResourceParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Mount a file uploaded via the Files API into the session.<br/>
        /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileResourceParams? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileResourceParams? File { get; }
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
        public static implicit operator BetaManagedAgentsAddSessionResourceParams(global::Anthropic.BetaManagedAgentsFileResourceParams value) => new BetaManagedAgentsAddSessionResourceParams((global::Anthropic.BetaManagedAgentsFileResourceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileResourceParams?(BetaManagedAgentsAddSessionResourceParams @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAddSessionResourceParams(global::Anthropic.BetaManagedAgentsFileResourceParams? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsAddSessionResourceParams(
            global::Anthropic.BetaManagedAgentsAddSessionResourceParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsFileResourceParams? file
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
            global::System.Func<global::Anthropic.BetaManagedAgentsFileResourceParams?, TResult>? file = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsFileResourceParams?>? file = null,
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
                typeof(global::Anthropic.BetaManagedAgentsFileResourceParams),
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
        public bool Equals(BetaManagedAgentsAddSessionResourceParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileResourceParams?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsAddSessionResourceParams obj1, BetaManagedAgentsAddSessionResourceParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsAddSessionResourceParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsAddSessionResourceParams obj1, BetaManagedAgentsAddSessionResourceParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsAddSessionResourceParams o && Equals(o);
        }
    }
}
