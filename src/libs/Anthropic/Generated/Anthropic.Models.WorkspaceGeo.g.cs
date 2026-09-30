
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum WorkspaceGeo
    {
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkspaceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkspaceGeo value)
        {
            return value switch
            {
                WorkspaceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkspaceGeo? ToEnum(string value)
        {
            return value switch
            {
                "us" => WorkspaceGeo.Us,
                _ => null,
            };
        }
    }
}