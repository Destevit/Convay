using System.Drawing;
using Convay.Core.Interfaces;
using System.Drawing.Imaging;

namespace Convay.WinExtension
{
    /// <summary>
    /// Wizualizator siatki z kodem zarządzanym
    /// </summary>
    public class SafeVisualizer : IVisualizer
    {
        /// <summary>
        /// Konwertuje siatkę na bitmapę
        /// </summary>
        /// <param name="grid">siatka do konwersji</param>
        /// <param name="livingColor">Kolor żywych pikseli</param>
        /// <param name="deadColor">Kolor martwych pikseli</param>
        /// <returns>Siatkę w postaci bitmapy</returns>
        public Bitmap ToBitmap(IGrid grid, Color livingColor, Color deadColor)
        {
            int width = grid.XSize;
            int height = grid.YSize;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Color colorToSet;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (grid[x, y])
                        colorToSet = livingColor;
                    else
                        colorToSet = deadColor;
                    bitmap.SetPixel(x, y, colorToSet);
                }
            }
            return bitmap;
        }
    }
}
