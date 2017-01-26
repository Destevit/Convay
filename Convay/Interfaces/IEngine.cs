using System;

namespace Convay.Core.Interfaces
{
    /// <summary>
    /// Interfejs silnika gry w życie
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Zlicza żywych sąsiadów punktu
        /// </summary>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>liczba żywych sąsiadów</returns>
        int CountAliveNeighbours(IGrid grid, int xCoordinate, int yCoordinate);

        /// <summary>
        /// Zlicza martwych sąsiadów punktu
        /// </summary>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>liczba martwych sąsiadów</returns>
        int CountDeadNeighbours(IGrid grid, int xCoordinate, int yCoordinate);

        /// <summary>
        /// Wykonuje jeden krok gry
        /// </summary>
        /// <returns>Siatka po wykonaniu kroku</returns>
        IGrid TakeStep(IGrid grid, IRules rules);
    }
}
