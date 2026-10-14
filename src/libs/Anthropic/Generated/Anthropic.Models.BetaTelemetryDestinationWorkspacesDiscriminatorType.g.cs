
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationWorkspacesDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Exclude,
        /// <summary>
        ///
        /// </summary>
        Include,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTelemetryDestinationWorkspacesDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationWorkspacesDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationWorkspacesDiscriminatorType.All => "all",
                BetaTelemetryDestinationWorkspacesDiscriminatorType.Exclude => "exclude",
                BetaTelemetryDestinationWorkspacesDiscriminatorType.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationWorkspacesDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaTelemetryDestinationWorkspacesDiscriminatorType.All,
                "exclude" => BetaTelemetryDestinationWorkspacesDiscriminatorType.Exclude,
                "include" => BetaTelemetryDestinationWorkspacesDiscriminatorType.Include,
                _ => null,
            };
        }
    }
}