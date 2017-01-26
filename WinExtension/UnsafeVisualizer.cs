using System.Drawing;
using Convay.Core.Interfaces;
using System.Drawing.Imaging;

namespace Convay.WinExtension
{
    /// <summary>
    /// Wizualizator wykorzystujący kod niezarządazny, operuje na wskaźnikach
    /// </summary>
    public class UnsafeVisualizer : IVisualizer
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
            int pixelSize = 4;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            Color colorToSet;
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
            unsafe
            {
                for (int y = 0; y < height; y++)
                {
                    byte* row = null;
                    row = (byte*)bmpData.Scan0 + (y * bmpData.Stride);
                    for (int x = 0; x < width; x++)
                    {
                        if (grid[x, y])
                            colorToSet = livingColor;
                        else
                            colorToSet = deadColor;
                        row[x * pixelSize] = colorToSet.B;
                        row[x * pixelSize + 1] = colorToSet.G;
                        row[x * pixelSize + 2] = colorToSet.R;
                        row[x * pixelSize + 3] = colorToSet.A;
                    }
                }
            }
            bitmap.UnlockBits(bmpData);
            return bitmap;
        }
    }
}
