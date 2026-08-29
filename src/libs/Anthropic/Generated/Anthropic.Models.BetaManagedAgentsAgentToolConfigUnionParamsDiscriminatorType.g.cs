
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType
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
    public static class BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Bash => "bash",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Edit => "edit",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Glob => "glob",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Grep => "grep",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Read => "read",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.WebFetch => "web_fetch",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.WebSearch => "web_search",
                BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Bash,
                "edit" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Edit,
                "glob" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Glob,
                "grep" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Grep,
                "read" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Read,
                "web_fetch" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.WebFetch,
                "web_search" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.WebSearch,
                "write" => BetaManagedAgentsAgentToolConfigUnionParamsDiscriminatorType.Write,
                _ => null,
            };
        }
    }
}