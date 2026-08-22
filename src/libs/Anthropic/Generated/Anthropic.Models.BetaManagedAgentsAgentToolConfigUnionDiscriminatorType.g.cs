
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaManagedAgentsAgentToolConfigUnionDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Bash,
        /// <summary>
        /// 
        /// </summary>
        Edit,
        /// <summary>
        /// 
        /// </summary>
        Glob,
        /// <summary>
        /// 
        /// </summary>
        Grep,
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        WebFetch,
        /// <summary>
        /// 
        /// </summary>
        WebSearch,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaManagedAgentsAgentToolConfigUnionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolConfigUnionDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Bash => "bash",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Edit => "edit",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Glob => "glob",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Grep => "grep",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Read => "read",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.WebFetch => "web_fetch",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.WebSearch => "web_search",
                BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Bash,
                "edit" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Edit,
                "glob" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Glob,
                "grep" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Grep,
                "read" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Read,
                "web_fetch" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.WebFetch,
                "web_search" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.WebSearch,
                "write" => BetaManagedAgentsAgentToolConfigUnionDiscriminatorType.Write,
                _ => null,
            };
        }
    }
}