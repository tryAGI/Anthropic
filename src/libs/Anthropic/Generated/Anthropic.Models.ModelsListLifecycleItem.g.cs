
#nullable enable

namespace Anthropic
{
    /// <summary>
    ///
    /// </summary>
    public enum ModelsListLifecycleItem
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
    public static class ModelsListLifecycleItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsListLifecycleItem value)
        {
            return value switch
            {
                ModelsListLifecycleItem.Active => "active",
                ModelsListLifecycleItem.Deprecated => "deprecated",
                ModelsListLifecycleItem.Retired => "retired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsListLifecycleItem? ToEnum(string value)
        {
            return value switch
            {
                "active" => ModelsListLifecycleItem.Active,
                "deprecated" => ModelsListLifecycleItem.Deprecated,
                "retired" => ModelsListLifecycleItem.Retired,
                _ => null,
            };
        }
    }
}