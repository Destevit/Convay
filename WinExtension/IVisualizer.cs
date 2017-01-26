using Convay.Core;
using Convay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convay.WinExtension
{
    /// <summary>
    /// Interfejs wizualizacji siatki
    /// </summary>
    public interface IVisualizer
    {
        /// <summary>
        /// Konwertuje siatkę na bitmapę
        /// </summary>
        /// <param name="grid">siatka do konwersji</param>
        /// <param name="livingColor">Kolor żywych pikseli</param>
        /// <param name="deadColor">Kolor martwych pikseli</param>
        /// <returns>Siatkę w postaci bitmapy</returns>
        Bitmap ToBitmap(IGrid grid, Color livingColor, Color deadColor);
    }

    /// <summary>
    /// Interfejs wizualizacji siatki z punktem z pamięcią bajtową
    /// </summary>
    public interface IByteVisualizer
    {
        /// <summary>
        /// Konwertuje siatkę na bitmapę
        /// </summary>
        /// <param name="grid">siatka do konwersji</param>
        /// <param name="livingColor">Kolory żywych pikseli</param>
        /// <param name="deadColor">Kolory martwych pikseli</param>
        /// <returns>Siatkę w postaci bitmapy</returns>
        Bitmap ToBitmap(IByteGrid grid, Color[] livingColors, Color[] deadColors);
    }
}
