using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convay.Core.Interfaces
{
    /// <summary>
    /// Interfejs siatki gry w życie
    /// </summary>
    public interface IGrid
    {
        /// <summary>
        /// Określa czy punkt jest żywy
        /// </summary>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>true gdy żywy, false gdy martwy</returns>
        bool this[int xCoordinate, int yCoordinate] { get; set; }

        /// <summary>
        /// Zwraca szerokość siatki
        /// </summary>
        int XSize { get; }

        /// <summary>
        /// Zwraca wysokość siatki
        /// </summary>
        int YSize { get; }

        /// <summary>
        /// Zwraca kopię siatki
        /// </summary>
        /// <returns>kopia siatki</returns>
        IGrid Clone();

        /// <summary>
        /// Określa czy punkt o danych współrzędnych istnieje
        /// </summary>
        /// <param name="xCoordinate">Współrzędna X</param>
        /// <param name="yCoordinate">Współrzędna Y</param>
        /// <returns></returns>
        bool Exist(int xCoordinate, int yCoordinate);

        /// <summary>
        /// Inicjalizuje siatkę o zadanej wielkości
        /// </summary>
        /// <param name="xSize">Szerokość siatki</param>
        /// <param name="ySize">Wysokość sitaki</param>
        void Initialize(int xSize, int ySize);

        /// <summary>
        /// Losuje punkty siatki
        /// </summary>
        void Randomize();
    }
}
