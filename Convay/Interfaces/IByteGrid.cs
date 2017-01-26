using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convay.Core.Interfaces
{
    public interface IByteGrid : IGrid
    {
        byte GetPoint(int x, int y);
    }
}
