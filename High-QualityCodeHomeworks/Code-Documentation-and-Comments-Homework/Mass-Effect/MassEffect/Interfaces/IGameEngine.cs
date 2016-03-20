namespace MassEffect.Interfaces
{
    using System.Collections.Generic;

    using MassEffect.Engine.Factories;
    using MassEffect.GameObjects;

    /// <summary>
    /// The Game Engine interface
    /// </summary>
    public interface IGameEngine
    {
        /// <summary>
        /// Gets the ship factory.
        /// </summary>
        ShipFactory ShipFactory { get; }

        /// <summary>
        /// Gets the enhancement factory.
        /// </summary>
        EnhancementFactory EnhancementFactory { get; }

        /// <summary>
        /// Gets the starships.
        /// </summary>
        IList<IStarship> Starships { get; }

        /// <summary>
        /// Gets the galaxy.
        /// </summary>
        Galaxy Galaxy { get; }

        /// <summary>
        /// Gets the Command Manager.
        /// </summary>
        ICommandManager CommandManager { get; }

        /// <summary>
        /// Gets or sets a value indicating whether is running.
        /// </summary>
        bool IsRunning { get; set; }

        /// <summary>
        /// The run.
        /// </summary>
        void Run();
    }
}