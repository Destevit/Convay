using Convay.Core.Interfaces;
using System;

namespace Convay.Core
{
    public class GridChangedEventArgs : EventArgs
    {
        public GridChangedEventArgs(IGrid grid, IRules rules)
        {
            Grid = grid;
            Rules = rules;
        }

        public IGrid Grid { get; private set; }

        public IRules Rules { get; set; }
    }
}
