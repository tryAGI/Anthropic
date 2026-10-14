
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaTelemetryDestinationWorkspacesParamsDiscriminatorType
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
    public static class BetaTelemetryDestinationWorkspacesParamsDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTelemetryDestinationWorkspacesParamsDiscriminatorType value)
        {
            return value switch
            {
                BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.All => "all",
                BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Exclude => "exclude",
                BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Include => "include",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTelemetryDestinationWorkspacesParamsDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "all" => BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.All,
                "exclude" => BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Exclude,
                "include" => BetaTelemetryDestinationWorkspacesParamsDiscriminatorType.Include,
                _ => null,
            };
        }
    }
}