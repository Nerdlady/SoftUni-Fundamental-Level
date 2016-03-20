namespace MassEffect.Interfaces
{
    using System.Collections.Generic;

    using MassEffect.GameObjects.Enhancements;

    /// <summary>
    /// The Enhanceable interface.
    /// </summary>
    public interface IEnhanceable
    {
        /// <summary>
        /// Gets the enhancements.
        /// </summary>
        IEnumerable<Enhancement> Enhancements { get; }

        /// <summary>
        /// Add the enhancement.
        /// </summary>
        /// <param name="enhancement">The enhancement.</param>
        void AddEnhancement(Enhancement enhancement);
    }
}