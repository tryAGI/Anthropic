
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaModelsListLifecycleItem
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        Deprecated,
        /// <summary>
        ///
        /// </summary>
        Retired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelsListLifecycleItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelsListLifecycleItem value)
        {
            return value switch
            {
                BetaModelsListLifecycleItem.Active => "active",
                BetaModelsListLifecycleItem.Deprecated => "deprecated",
                BetaModelsListLifecycleItem.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelsListLifecycleItem? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaModelsListLifecycleItem.Active,
                "deprecated" => BetaModelsListLifecycleItem.Deprecated,
                "retired" => BetaModelsListLifecycleItem.Retired,
                _ => null,
            };
        }
    }
}