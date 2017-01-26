using System;
using Convay.Core.Interfaces;

namespace Convay.Core
{
    /// <summary>
    /// Siatka gry w życie oparta na bajtach
    /// </summary>
    public class ByteGrid : ArrayGrid<byte>, IByteGrid
    {

        /// <summary>
        /// Konstruuje siatkę o zadanej wielkości
        /// </summary>
        /// <param name="xSize">Szerokość</param>
        /// <param name="ySize">Wysokość</param>
        public ByteGrid(int xSize, int ySize)
            : base(xSize, ySize)
        { }

        /// <summary>
        /// Określa czy punkt jest żywy
        /// </summary>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>true gdy żywy, false gdy martwy</returns>
        public override bool this[int x, int y]
        {
            get
            {
                return (pointArray[x, y] & 1) != 0;
            }
            set
            {
                pointArray[x, y] = (byte)(pointArray[x, y] << 1);
                if (value)
                    pointArray[x, y]++;
            }
        }

        /// <summary>
        /// Zwraca kopię siatki
        /// </summary>
        /// <returns>kopia siatki</returns>
        public override IGrid Clone()
        {
            ByteGrid clone = new ByteGrid(XSize, YSize);
            for (int i = 0; i < XSize; i++)
            {
                for (int j = 0; j < YSize; j++)
                {
                    clone.pointArray[i, j] = pointArray[i, j];
                }
            }
            return clone;
        }

        /// <summary>
        /// Ustawia pustą siatkę o zadanej wielkości
        /// </summary>
        /// <param name="xSize">Szerokość</param>
        /// <param name="ySize">Wysokość</param>
        public override void Initialize(int xSize, int ySize)
        {
            pointArray = new byte[xSize, ySize];
        }
    }
}
