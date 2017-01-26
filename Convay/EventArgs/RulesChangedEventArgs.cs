using Convay.Core.Interfaces;
using System;

namespace Convay.Core
{
    public class RulesChangedEventArgs : EventArgs
    {
        public RulesChangedEventArgs(IRules newRules)
        {
            NewRules = newRules;
        }

        public IRules NewRules { get; private set; }
    }
}
