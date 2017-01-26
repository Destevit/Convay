using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convay.Core.Interfaces
{
    public interface IGame
    {
        /// <summary>
        /// Zdarzenie wywoływane po zmianie siatki
        /// </summary>
        event EventHandler<GridChangedEventArgs> GridChanged;

        /// <summary>
        /// Zdarzenie wywoływane po zmianie zasad
        /// </summary>
        event EventHandler<RulesChangedEventArgs> RulesChanged;

        /// <summary>
        /// Zdarzenie wywoływane przy zmianie stanu gry
        /// </summary>
        event EventHandler<bool> GameStateChanged;

        /// <summary>
        /// Właściwość określająca czy gra jest uruchomiona
        /// </summary>
        bool IsRunning { get; }
        
        /// <summary>
        /// Właściwość z zasadami gry
        /// </summary>
        IRules Rules { get; set; }

        /// <summary>
        /// Właściwość z siatką gry
        /// </summary>
        IGrid Grid { get; set; }

        /// <summary>
        /// Właściwość z silnikiem gry
        /// </summary>
        IEngine Engine { get; set; }

        /// <summary>
        /// Interwał pomiędzy krokami gry
        /// </summary>
        TimeSpan Interval { get; set; }

        /// <summary>
        /// Metoda startująca grę
        /// </summary>
        void Start();

        /// <summary>
        /// Metoda zatrzymująca grę
        /// </summary>
        void Stop();

        /// <summary>
        /// Losuje siatkę gry
        /// </summary>
        void Randomize();
    }
}
