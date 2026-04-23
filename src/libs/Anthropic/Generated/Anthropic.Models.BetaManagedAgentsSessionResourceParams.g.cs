#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Union of resources that can be mounted into a session.<br/>
    /// Example: {"type":"file","file_id":"file_011CNha8iCJcU1wXNR6q4V8w","mount_path":"/uploads/receipt.pdf"}
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionResourceParams : global::System.IEquatable<BetaManagedAgentsSessionResourceParams>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? Type { get; }

        /// <summary>
        /// Mount a GitHub repository into the session's container.<br/>
        /// Example: {"type":"github_repository","url":"https://github.com/example-org/example-repo","authorization_token":"ghp_exampletoken"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? GithubRepository { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? GithubRepository { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepository))]
#endif
        public bool IsGithubRepository => GithubRepository != null;

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
        /// Parameters for attaching a memory store to an agent session.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? MemoryStore { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? MemoryStore { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MemoryStore))]
#endif
        public bool IsMemoryStore => MemoryStore != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams value) => new BetaManagedAgentsSessionResourceParams((global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams?(BetaManagedAgentsSessionResourceParams @this) => @this.GithubRepository;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? value)
        {
            GithubRepository = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsFileResourceParams value) => new BetaManagedAgentsSessionResourceParams((global::Anthropic.BetaManagedAgentsFileResourceParams?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileResourceParams?(BetaManagedAgentsSessionResourceParams @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsFileResourceParams? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam value) => new BetaManagedAgentsSessionResourceParams((global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam?(BetaManagedAgentsSessionResourceParams @this) => @this.MemoryStore;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceParams(global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? value)
        {
            MemoryStore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceParams(
            global::Anthropic.BetaManagedAgentsSessionResourceParamsDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams? githubRepository,
            global::Anthropic.BetaManagedAgentsFileResourceParams? file,
            global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam? memoryStore
            )
        {
            Type = type;

            GithubRepository = githubRepository;
            File = file;
            MemoryStore = memoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MemoryStore as object ??
            File as object ??
            GithubRepository as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GithubRepository?.ToString() ??
            File?.ToString() ??
            MemoryStore?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGithubRepository && !IsFile && !IsMemoryStore || !IsGithubRepository && IsFile && !IsMemoryStore || !IsGithubRepository && !IsFile && IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams?, TResult>? githubRepository = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileResourceParams?, TResult>? file = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam?, TResult>? memoryStore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepository && githubRepository != null)
            {
                return githubRepository(GithubRepository!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }
            else if (IsMemoryStore && memoryStore != null)
            {
                return memoryStore(MemoryStore!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams?>? githubRepository = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileResourceParams?>? file = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam?>? memoryStore = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGithubRepository)
            {
                githubRepository?.Invoke(GithubRepository!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
            else if (IsMemoryStore)
            {
                memoryStore?.Invoke(MemoryStore!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GithubRepository,
                typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams),
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileResourceParams),
                MemoryStore,
                typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam),
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
        public bool Equals(BetaManagedAgentsSessionResourceParams other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceParams?>.Default.Equals(GithubRepository, other.GithubRepository) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileResourceParams?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryStoreResourceParam?>.Default.Equals(MemoryStore, other.MemoryStore) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionResourceParams obj1, BetaManagedAgentsSessionResourceParams obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionResourceParams>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionResourceParams obj1, BetaManagedAgentsSessionResourceParams obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionResourceParams o && Equals(o);
        }
    }
}
