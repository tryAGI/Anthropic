
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum RbacRolePermissionResourceDiscriminatorType
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
    public static class RbacRolePermissionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RbacRolePermissionResourceDiscriminatorType value)
        {
            return value switch
            {
                RbacRolePermissionResourceDiscriminatorType.AllConnectors => "all_connectors",
                RbacRolePermissionResourceDiscriminatorType.Connector => "connector",
                RbacRolePermissionResourceDiscriminatorType.ConnectorScope => "connector_scope",
                RbacRolePermissionResourceDiscriminatorType.ConnectorTool => "connector_tool",
                RbacRolePermissionResourceDiscriminatorType.Organization => "organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RbacRolePermissionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all_connectors" => RbacRolePermissionResourceDiscriminatorType.AllConnectors,
                "connector" => RbacRolePermissionResourceDiscriminatorType.Connector,
                "connector_scope" => RbacRolePermissionResourceDiscriminatorType.ConnectorScope,
                "connector_tool" => RbacRolePermissionResourceDiscriminatorType.ConnectorTool,
                "organization" => RbacRolePermissionResourceDiscriminatorType.Organization,
                _ => null,
            };
        }
    }
}