
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// Built-in agent tool identifier.
    /// </summary>
    public enum BetaManagedAgentsAgentToolName
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
    public static class BetaManagedAgentsAgentToolNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaManagedAgentsAgentToolName value)
        {
            return value switch
            {
                BetaManagedAgentsAgentToolName.Bash => "bash",
                BetaManagedAgentsAgentToolName.Edit => "edit",
                BetaManagedAgentsAgentToolName.Glob => "glob",
                BetaManagedAgentsAgentToolName.Grep => "grep",
                BetaManagedAgentsAgentToolName.Read => "read",
                BetaManagedAgentsAgentToolName.WebFetch => "web_fetch",
                BetaManagedAgentsAgentToolName.WebSearch => "web_search",
                BetaManagedAgentsAgentToolName.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaManagedAgentsAgentToolName? ToEnum(string value)
        {
            return value switch
            {
                "bash" => BetaManagedAgentsAgentToolName.Bash,
                "edit" => BetaManagedAgentsAgentToolName.Edit,
                "glob" => BetaManagedAgentsAgentToolName.Glob,
                "grep" => BetaManagedAgentsAgentToolName.Grep,
                "read" => BetaManagedAgentsAgentToolName.Read,
                "web_fetch" => BetaManagedAgentsAgentToolName.WebFetch,
                "web_search" => BetaManagedAgentsAgentToolName.WebSearch,
                "write" => BetaManagedAgentsAgentToolName.Write,
                _ => null,
            };
        }
    }
}