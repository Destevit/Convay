using Convay.Core.Interfaces;
using System;
using System.Resources;
using System.Text;

namespace Convay.Core
{
    /// <summary>
    /// Siatka gry w życie oparta na tablicy
    /// </summary>
    /// <typeparam name="T">Typ punktów używany w tablicy</typeparam>
    public abstract class ArrayGrid<T> : IGrid
    {
        /// <summary>
        /// Zasób z tekstami wyjątków
        /// </summary>
        protected ResourceManager exceptionResource = new ResourceManager(typeof(ExceptionMessages));

        /// <summary>
        /// Generator liczb pseudolosowych
        /// </summary>
        protected Random randomGenerator = new Random();

        /// <summary>
        /// Tablica punktów T
        /// </summary>
        protected T[,] pointArray;

        /// <summary>
        /// Konstruuje siatkę o zadanej wielkości
        /// </summary>
        /// <param name="xSize">Szerokość</param>
        /// <param name="ySize">Wysokość</param>
        public ArrayGrid(int xSize, int ySize)
        {
            Initialize(xSize, ySize);
        }

        /// <summary>
        /// Umożliwia dostęp do punktu o zadanych współrzędnych
        /// </summary>
        /// <param name="x">Współrzędna X</param>
        /// <param name="y">Współrzędna Y</param>
        /// <returns>Referencja danego punktu</returns>
        public virtual T GetPoint(int x, int y)
        {
            if (Exist(x, y))
            {
                return pointArray[x, y];
            }
            else
            {
                throw newArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Określa czy punkt jest żywy
        /// </summary>
        /// <param name="xCoordinate">Współrzędna x</param>
        /// <param name="yCoordinate">Współrzędna y</param>
        /// <returns>true gdy żywy, false gdy martwy</returns>
        public abstract bool this[int xCoordinate, int yCoordinate] { get; set; }

        /// <summary>
        /// Zwraca szerokość siatki
        /// </summary>
        public virtual int XSize => pointArray.GetLength(0);

        /// <summary>
        /// Zwraca wysokość siatki
        /// </summary>
        public virtual int YSize => pointArray.GetLength(1);

        /// <summary>
        /// Zwraca kopię siatki
        /// </summary>
        /// <returns>kopia siatki</returns>
        public abstract IGrid Clone();

        /// <summary>
        /// Określa istnienie punktu o zadanych współrzędnych w siatce
        /// </summary>
        /// <param name="xCoordinate">Współrzędna X</param>
        /// <param name="yCoordinate">Współrzędna Y</param>
        /// <returns>true gdy istnieje, false w przeciwnym wypadku</returns>
        public virtual bool Exist(int xCoordinate, int yCoordinate)
            => xCoordinate >= 0 && yCoordinate >= 0 && xCoordinate < XSize && yCoordinate < YSize;

        /// <summary>
        /// Ustawia pustą siatkę o zadanej wielkości
        /// </summary>
        /// <param name="xSize">Szerokość</param>
        /// <param name="ySize">Wysokość</param>
        public abstract void Initialize(int xSize, int ySize);

        /// <summary>
        /// Konwertuje siatkę na string, gdzie elementy żywe i martwe oznaczone są odpowiednio znakiem FULLBLOCK lub spacji
        /// </summary>
        /// <returns>siatka w postaci stringu</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < YSize; j++)
            {
                for (int i = 0; i < XSize; i++)
                {
                    if (this[i, j])
                    {
                        sb.Append('█');
                    }
                    else
                    {
                        sb.Append(' ');
                    }
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// Losuje punkty siatki
        /// </summary>
        public virtual void Randomize()
        {
            for (int i = 0; i < XSize; i++)
            {
                for (int j = 0; j < YSize; j++)
                {
                    this[i, j] = Convert.ToBoolean(randomGenerator.Next(0, 2));
                }
            }
        }

        /// <summary>
        /// Zwraca wyjątek z wiadomością o przekroczeniu wymiarów siatki
        /// </summary>
        /// <returns>referencja nowoutworzonego wyjątku</returns>
        protected ArgumentOutOfRangeException newArgumentOutOfRangeException()
        {
            return new ArgumentOutOfRangeException(
                exceptionResource.GetString("GridIndexOutOfRange")
                );
        }
    }
}
