
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaWorkspaceGeo
    {
        /// <summary>
        ///
        /// </summary>
        Us,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWorkspaceGeoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWorkspaceGeo value)
        {
            return value switch
            {
                BetaWorkspaceGeo.Us => "us",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWorkspaceGeo? ToEnum(string value)
        {
            return value switch
            {
                "us" => BetaWorkspaceGeo.Us,
                _ => null,
            };
        }
    }
}