
#nullable enable

namespace Anthropic
{
    /// <summary>
    /// The model's current lifecycle stage.<br/>
    /// - `active`: The model is available for use, open to new adopters, and not scheduled for retirement.<br/>
    /// - `deprecated`: The model remains callable for organizations with existing access, but is headed for retirement and closed to new adopters.<br/>
    /// - `retired`: The model is no longer available for use; inference requests naming it fail. It remains in the catalogue as the historical record of its retirement.<br/>
    /// Default Value: active
    /// </summary>
    public enum BetaModelInfoLifecycle
    {
        /// <summary>
        /// The model is available for use, open to new adopters, and not scheduled for retirement.
        /// </summary>
        Active,
        /// <summary>
        /// The model remains callable for organizations with existing access, but is headed for retirement and closed to new adopters.
        /// </summary>
        Deprecated,
        /// <summary>
        /// The model is no longer available for use; inference requests naming it fail. It remains in the catalogue as the historical record of its retirement.
        /// </summary>
        Retired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaModelInfoLifecycleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaModelInfoLifecycle value)
        {
            return value switch
            {
                BetaModelInfoLifecycle.Active => "active",
                BetaModelInfoLifecycle.Deprecated => "deprecated",
                BetaModelInfoLifecycle.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaModelInfoLifecycle? ToEnum(string value)
        {
            return value switch
            {
                "active" => BetaModelInfoLifecycle.Active,
                "deprecated" => BetaModelInfoLifecycle.Deprecated,
                "retired" => BetaModelInfoLifecycle.Retired,
                _ => null,
            };
        }
    }
}