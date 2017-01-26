using Convay.Core.Interfaces;
using System;
using System.Resources;

namespace Convay.Core
{
    /// <summary>
    /// Silnik gry w życie
    /// </summary>
    public class Engine : IEngine
    {
        /// <summary>
        /// Zasób z tekstami wyjątków
        /// </summary>
        protected ResourceManager exceptionResource = new ResourceManager(typeof(ExceptionMessages));

        /// <summary>
        /// Zlicza żywych sąsiadów punktu
        /// </summary>
        /// <param name="grid">siatka do przeliczenia</param>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>liczba żywych sąsiadów</returns>
        virtual public int CountAliveNeighbours(IGrid grid, int xCoordinate, int yCoordinate)
        {
            if (!grid.Exist(xCoordinate, yCoordinate))
                throw new ArgumentOutOfRangeException(exceptionResource.GetString("GridIndexOutOfRange"));

            int count = 0;
            int leftSide = xCoordinate - 1;
            int rightSide = xCoordinate + 1;
            int topSide = yCoordinate - 1;
            int bottomSide = yCoordinate + 1;
            count += Alive(grid, leftSide, topSide);
            count += Alive(grid, xCoordinate, topSide);
            count += Alive(grid, rightSide, topSide);
            count += Alive(grid, leftSide, yCoordinate);
            count += Alive(grid, rightSide, yCoordinate);
            count += Alive(grid, leftSide, bottomSide);
            count += Alive(grid, xCoordinate, bottomSide);
            count += Alive(grid, rightSide, bottomSide);
            return count;
        }

        /// <summary>
        /// Zlicza martwych sąsiadów punktu
        /// </summary>
        /// <param name="grid">siatka do przeliczenia</param>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>liczba martwych sąsiadów</returns>
        virtual public int CountDeadNeighbours(IGrid grid, int xCoordinate, int yCoordinate)
        {
            return 8 - CountAliveNeighbours(grid, xCoordinate, yCoordinate);
        }
        
        /// <summary>
        /// Przeprowadza krok gry w życie
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="gameRules"></param>
        /// <returns></returns>
        virtual public IGrid TakeStep(IGrid grid, IRules gameRules)
        {
            IGrid gridNew = grid.Clone();
            int living;
            for (int i = 0; i < grid.XSize; i++)
            {
                for (int j = 0; j < grid.YSize; j++)
                {
                    living = CountAliveNeighbours(grid, i, j);
                    if (grid[i, j])
                        gridNew[i, j] = gameRules.FulfilLifeRule(living);
                    else
                        gridNew[i, j] = gameRules.FulfilDeadRule(living);
                }
            }
            return gridNew;
        }

        /// <summary>
        /// Sprawdza, czy punkt żyje.
        /// </summary>
        /// <param name="grid">siatka</param>
        /// <param name="x">Współrzędna x</param>
        /// <param name="y">Współrzędna y</param>
        /// <returns>Jeżeli tak, zwraca '1', jeżeli nie lub wykracza poza zakres - zwraca '0'</returns>
        virtual protected int Alive(IGrid grid, int x, int y)
        {
            if (!grid.Exist(x, y))
                return 0;
            else if (grid[x, y])
                return 1;
            else
                return 0;
        }
    }
}
