
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
    public enum ModelInfoLifecycle
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
    public static class ModelInfoLifecycleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelInfoLifecycle value)
        {
            return value switch
            {
                ModelInfoLifecycle.Active => "active",
                ModelInfoLifecycle.Deprecated => "deprecated",
                ModelInfoLifecycle.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelInfoLifecycle? ToEnum(string value)
        {
            return value switch
            {
                "active" => ModelInfoLifecycle.Active,
                "deprecated" => ModelInfoLifecycle.Deprecated,
                "retired" => ModelInfoLifecycle.Retired,
                _ => null,
            };
        }
    }
}