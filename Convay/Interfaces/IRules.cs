using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Convay.Core.Interfaces
{
    /// <summary>
    /// Interfejs zasad gry w życie
    /// </summary>
    public interface IRules
    {
        /// <summary>
        /// Sprawdza czy spełnia zasady dla żywych punktów
        /// </summary>
        /// <param name="livingNumber">liczba żywych sąsiadów</param>
        /// <returns>true jeśli spełnia zasady, false w przeciwnym wypadku</returns>
        bool FulfilLifeRule(int livingNumber);

        /// <summary>
        /// Sprawdza czy spełnia zasady dla martwych punktów
        /// </summary>
        /// <param name="livingNumber">liczba żywych sąsiadów</param>
        /// <returns>true jeśli spełnia zasady, false w przeciwnym wypadku</returns>
        bool FulfilDeadRule(int livingNumber);

        /// <summary>
        /// Zwraca string w formacie "a/b", gdzie: a - zasady dla żywych, b - zasady dla martwych
        /// </summary>
        /// <returns>zasady w postaci stringu</returns>
        string ToStringFormat();
    }
}
