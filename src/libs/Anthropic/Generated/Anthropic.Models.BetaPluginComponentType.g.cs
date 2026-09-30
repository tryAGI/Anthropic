
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The kind of component.
    /// </summary>
    public enum BetaPluginComponentType
    {
        /// <summary>
        ///
        /// </summary>
        Agent,
        /// <summary>
        ///
        /// </summary>
        Cli,
        /// <summary>
        ///
        /// </summary>
        Command,
        /// <summary>
        ///
        /// </summary>
        Hook,
        /// <summary>
        ///
        /// </summary>
        McpServer,
        /// <summary>
        ///
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPluginComponentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPluginComponentType value)
        {
            return value switch
            {
                BetaPluginComponentType.Agent => "agent",
                BetaPluginComponentType.Cli => "cli",
                BetaPluginComponentType.Command => "command",
                BetaPluginComponentType.Hook => "hook",
                BetaPluginComponentType.McpServer => "mcp_server",
                BetaPluginComponentType.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPluginComponentType? ToEnum(string value)
        {
            return value switch
            {
                "agent" => BetaPluginComponentType.Agent,
                "cli" => BetaPluginComponentType.Cli,
                "command" => BetaPluginComponentType.Command,
                "hook" => BetaPluginComponentType.Hook,
                "mcp_server" => BetaPluginComponentType.McpServer,
                "skill" => BetaPluginComponentType.Skill,
                _ => null,
            };
        }
    }
}