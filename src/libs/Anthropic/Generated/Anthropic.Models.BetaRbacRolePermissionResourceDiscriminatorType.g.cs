
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaRbacRolePermissionResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AllConnectors,
        /// <summary>
        ///
        /// </summary>
        Connector,
        /// <summary>
        ///
        /// </summary>
        ConnectorScope,
        /// <summary>
        ///
        /// </summary>
        ConnectorTool,
        /// <summary>
        ///
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRbacRolePermissionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRbacRolePermissionResourceDiscriminatorType value)
        {
            return value switch
            {
                BetaRbacRolePermissionResourceDiscriminatorType.AllConnectors => "all_connectors",
                BetaRbacRolePermissionResourceDiscriminatorType.Connector => "connector",
                BetaRbacRolePermissionResourceDiscriminatorType.ConnectorScope => "connector_scope",
                BetaRbacRolePermissionResourceDiscriminatorType.ConnectorTool => "connector_tool",
                BetaRbacRolePermissionResourceDiscriminatorType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRbacRolePermissionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all_connectors" => BetaRbacRolePermissionResourceDiscriminatorType.AllConnectors,
                "connector" => BetaRbacRolePermissionResourceDiscriminatorType.Connector,
                "connector_scope" => BetaRbacRolePermissionResourceDiscriminatorType.ConnectorScope,
                "connector_tool" => BetaRbacRolePermissionResourceDiscriminatorType.ConnectorTool,
                "organization" => BetaRbacRolePermissionResourceDiscriminatorType.Organization,
                _ => null,
            };
        }
    }
}