
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaExternalStorageStatusDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Available,
        /// <summary>
        ///
        /// </summary>
        Draining,
        /// <summary>
        ///
        /// </summary>
        PendingConfiguration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaExternalStorageStatusDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaExternalStorageStatusDiscriminatorType value)
        {
            return value switch
            {
                BetaExternalStorageStatusDiscriminatorType.Active => "active",
                BetaExternalStorageStatusDiscriminatorType.Available => "available",
                BetaExternalStorageStatusDiscriminatorType.Draining => "draining",
                BetaExternalStorageStatusDiscriminatorType.PendingConfiguration => "pending_configuration",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaExternalStorageStatusDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaExternalStorageStatusDiscriminatorType.Active,
                "available" => BetaExternalStorageStatusDiscriminatorType.Available,
                "draining" => BetaExternalStorageStatusDiscriminatorType.Draining,
                "pending_configuration" => BetaExternalStorageStatusDiscriminatorType.PendingConfiguration,
                _ => null,
            };
        }
    }
}