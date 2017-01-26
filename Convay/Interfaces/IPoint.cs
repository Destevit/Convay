namespace Convay.Core.Interfaces
{
    /// <summary>
    /// Interfejs pojedynczego punktu gry w życie
    /// </summary>
    public interface IPoint
    {
        /// <summary>
        /// Ustawienie lub zwrócenie aktualnego stanu
        /// </summary>
        bool IsAlive { get; set; }

        /// <summary>
        /// Klonowanie punktu
        /// </summary>
        /// <returns>Sklonowany egzemplarz punktu</returns>
        IPoint Clone();
    }
}
