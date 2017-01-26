using Convay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;

namespace Convay.Core
{
    /// <summary>
    /// Zasady gry oparte na standardowym zapisie w ciągu znaków
    /// </summary>
    public class StringRules : IRules
    {
        /// <summary>
        /// Zasób z tekstami wyjątków
        /// </summary>
        protected ResourceManager exceptionResource = new ResourceManager(typeof(ExceptionMessages));

        /// <summary>
        /// Pola przechowujące reguły gry
        /// </summary>
        private List<int> lifeRules, deadRules;

        /// <summary>
        /// Przyjmuje zasady gry w postaci stringu o następującym formacie:
        ///     "a/b", gdzie:
        /// 
        /// a - zasady dla żywych komórek,
        /// b - zasady dla martwych komórek
        /// </summary>
        /// <param name="rules"></param>
        public StringRules(string rules)
        {
            string[] rulesArray = rules.Split('/');
            if (rulesArray.Length != 2)
                throw newBadRulesFormatException();
            lifeRules = parseRules(rulesArray[0]);
            deadRules = parseRules(rulesArray[1]);
        }

        /// <summary>
        /// Sprawdza czy spełnia zasady dla żywych punktów
        /// </summary>
        /// <param name="livingNumber">liczba żywych sąsiadów</param>
        /// <returns>true jeśli spełnia zasady, false w przeciwnym wypadku</returns>
        public bool FulfilDeadRule(int livingNumber)
        {
            return deadRules.Contains(livingNumber);
        }

        /// <summary>
        /// Sprawdza czy spełnia zasady dla martwych punktów
        /// </summary>
        /// <param name="livingNumber">liczba żywych sąsiadów</param>
        /// <returns>true jeśli spełnia zasady, false w przeciwnym wypadku</returns>
        public bool FulfilLifeRule(int livingNumber)
        {
            return lifeRules.Contains(livingNumber);
        }

        /// <summary>
        /// Parsuje zasady w stringu
        /// </summary>
        /// <param name="rules">ciąg cyfr w stringu</param>
        /// <returns>Cyfry jako lista liczb całkowitych</returns>
        private List<int> parseRules(string rules)
        {
            var intRules = new List<int>(rules.Length);
            foreach (char rule in rules)
            {
                int intRule;
                bool parsed = int.TryParse(rule.ToString(), out intRule);
                if (!parsed)
                    throw newBadRulesFormatException();
                intRules.Add(intRule);
            }
            return intRules;
        }

        /// <summary>
        /// Tworzy wyjątek rzucany w przypadku błędnego formatu zasad
        /// </summary>
        /// <returns>Nowy wyjątek błednego formatu zasad</returns>
        private Exception newBadRulesFormatException()
        {
            return new ArgumentException(exceptionResource.GetString("BadRulesFormat"));
        }

        /// <summary>
        /// Zwraca string w formacie "a/b", gdzie: a - zasady dla żywych, b - zasady dla martwych
        /// </summary>
        /// <returns>zasady w postaci stringu</returns>
        public string ToStringFormat()
        {
            string rules = "";
            foreach (int rule in lifeRules)
            {
                rules += rule.ToString();
            }
            rules += '/';
            foreach (int rule in deadRules)
            {
                rules += rule.ToString();
            }
            return rules;
        }
    }
}
