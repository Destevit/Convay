using Convay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convay.Core
{
    /// <summary>
    /// Generyczna siatka gry w życie
    /// </summary>
    /// <typeparam name="T">Typ punktów używany przez siatkę</typeparam>
    public class GenericGrid<T> : ArrayGrid<T> where T : IPoint, new()
    {
        public GenericGrid(int xSize, int ySize) : base(xSize, ySize)
        {
        }

        public override bool this[int xCoordinate, int yCoordinate]
        {
            get
            {
                if (!Exist(xCoordinate, yCoordinate))
                    throw newArgumentOutOfRangeException();
                return pointArray[xCoordinate, yCoordinate].IsAlive;
            }
            set
            {
                if (!Exist(xCoordinate, yCoordinate))
                    throw newArgumentOutOfRangeException();
                pointArray[xCoordinate, yCoordinate].IsAlive = value;
            }
        }

        public override IGrid Clone()
        {
            int xSize = XSize;
            int ySize = YSize;
            GenericGrid<T> clonedGrid = new GenericGrid<T>(xSize, ySize);
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    clonedGrid.pointArray[i, j] = (T)pointArray[i, j].Clone();
                }
            }
            return clonedGrid;
        }

        public override void Initialize(int xSize, int ySize)
        {
            pointArray = new T[xSize, ySize];
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    pointArray[i, j] = new T();
                }
            }
        }
    }
}
