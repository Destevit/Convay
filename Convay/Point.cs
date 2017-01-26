using Convay.Core.Interfaces;

namespace Convay.Core
{
    /// <summary>
    /// Pojedynczy punkt gry w życie
    /// </summary>
    public class Point : IPoint
    {
        /// <summary>
        /// Ustawienie lub zwrócenie aktualnego stanu
        /// </summary>
        public bool IsAlive
        {
            get; set;
        }

        /// <summary>
        /// Klonowanie punktu
        /// </summary>
        /// <returns>Sklonowany egzemplarz punktu</returns>
        public IPoint Clone()
            => (IPoint)MemberwiseClone();
    }
}
