using Convay.Core.Interfaces;
using System.Threading.Tasks;

namespace Convay.Core
{
    /// <summary>
    /// Silnik gry w życie pracujący na wielu wątkach
    /// </summary>
    public class ParallelEngine : Engine
    {
        /// <summary>
        /// Wykonuje równolegle jeden krok gry
        /// </summary>
        /// <param name="grid">Początkowa siatka</param>
        /// <param name="gameRules">Zasady według których ma być liczona gra</param>
        /// <returns>Nowa siatka</returns>
        public override IGrid TakeStep(IGrid grid, IRules gameRules)
        {
            IGrid gridNew = grid.Clone();
            Parallel.For(0, grid.XSize, i => {
                for (int j = 0; j < grid.YSize; j++)
                {
                    int living = CountAliveNeighbours(grid, i, j);
                    if (grid[i, j])
                        gridNew[i, j] = gameRules.FulfilLifeRule(living);
                    else
                        gridNew[i, j] = gameRules.FulfilDeadRule(living);
                }
            });
            return gridNew;
        }
    }
}
