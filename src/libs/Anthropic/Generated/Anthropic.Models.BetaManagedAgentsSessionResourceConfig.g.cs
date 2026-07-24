#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Anthropic
{
    /// <summary>
    /// A configured session resource. Echoes the input minus write-only credentials.
    /// </summary>
    public readonly partial struct BetaManagedAgentsSessionResourceConfig : global::System.IEquatable<BetaManagedAgentsSessionResourceConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// A GitHub repository mounted into each session's container. The authorization token is write-only and never returned.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? GithubRepository { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? GithubRepository { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GithubRepository))]
#endif
        public bool IsGithubRepository => GithubRepository != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGithubRepository(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? value)
        {
            value = GithubRepository;
            return IsGithubRepository;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig PickGithubRepository() => IsGithubRepository
            ? GithubRepository!
            : throw new global::System.InvalidOperationException($"Expected union variant 'GithubRepository' but the value was {ToString()}.");

        /// <summary>
        /// A file mounted into each session's container.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? File { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsFileResourceConfig? File { get; }
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
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsFileResourceConfig? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsFileResourceConfig PickFile() => IsFile
            ? File!
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

        /// <summary>
        /// A memory store attached to each session created from this deployment.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? MemoryStore { get; init; }
#else
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? MemoryStore { get; }
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
        public bool TryPickMemoryStore(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? value)
        {
            value = MemoryStore;
            return IsMemoryStore;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig PickMemoryStore() => IsMemoryStore
            ? MemoryStore!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MemoryStore' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig value) => new BetaManagedAgentsSessionResourceConfig((global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig?(BetaManagedAgentsSessionResourceConfig @this) => @this.GithubRepository;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? value)
        {
            GithubRepository = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionResourceConfig FromGithubRepository(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? value) => new BetaManagedAgentsSessionResourceConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsFileResourceConfig value) => new BetaManagedAgentsSessionResourceConfig((global::Anthropic.BetaManagedAgentsFileResourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsFileResourceConfig?(BetaManagedAgentsSessionResourceConfig @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsFileResourceConfig? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionResourceConfig FromFile(global::Anthropic.BetaManagedAgentsFileResourceConfig? value) => new BetaManagedAgentsSessionResourceConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig value) => new BetaManagedAgentsSessionResourceConfig((global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig?(BetaManagedAgentsSessionResourceConfig @this) => @this.MemoryStore;

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceConfig(global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? value)
        {
            MemoryStore = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static BetaManagedAgentsSessionResourceConfig FromMemoryStore(global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? value) => new BetaManagedAgentsSessionResourceConfig(value);

        /// <summary>
        /// 
        /// </summary>
        public BetaManagedAgentsSessionResourceConfig(
            global::Anthropic.BetaManagedAgentsSessionResourceConfigDiscriminatorType? type,
            global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig? githubRepository,
            global::Anthropic.BetaManagedAgentsFileResourceConfig? file,
            global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig? memoryStore
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
            global::System.Func<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig, TResult>? githubRepository = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsFileResourceConfig, TResult>? file = null,
            global::System.Func<global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig, TResult>? memoryStore = null,
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
            global::System.Action<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig>? githubRepository = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsFileResourceConfig>? file = null,

            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig>? memoryStore = null,
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
        public void Switch(
            global::System.Action<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig>? githubRepository = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsFileResourceConfig>? file = null,
            global::System.Action<global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig>? memoryStore = null,
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
                typeof(global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig),
                File,
                typeof(global::Anthropic.BetaManagedAgentsFileResourceConfig),
                MemoryStore,
                typeof(global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig),
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
        public bool Equals(BetaManagedAgentsSessionResourceConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsGitHubRepositoryResourceConfig?>.Default.Equals(GithubRepository, other.GithubRepository) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsFileResourceConfig?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::Anthropic.BetaManagedAgentsMemoryStoreResourceConfig?>.Default.Equals(MemoryStore, other.MemoryStore) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BetaManagedAgentsSessionResourceConfig obj1, BetaManagedAgentsSessionResourceConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BetaManagedAgentsSessionResourceConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BetaManagedAgentsSessionResourceConfig obj1, BetaManagedAgentsSessionResourceConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BetaManagedAgentsSessionResourceConfig o && Equals(o);
        }
    }
}
