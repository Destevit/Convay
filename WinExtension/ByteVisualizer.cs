using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Convay.Core;
using System.Drawing.Imaging;
using Convay.Core.Interfaces;

namespace Convay.WinExtension
{
    /// <summary>
    /// Wizualizator siatki z punktem o pamięci bajtowej
    /// </summary>
    public class ByteVisualizer : IByteVisualizer
    {
        /// <summary>
        /// Konwertuje siatkę na bitmapę
        /// </summary>
        /// <param name="grid">siatka do konwersji</param>
        /// <param name="livingColor">Kolory żywych pikseli</param>
        /// <param name="deadColor">Kolory martwych pikseli</param>
        /// <returns>Siatkę w postaci bitmapy</returns>
        public Bitmap ToBitmap(IByteGrid grid, Color[] livingColors, Color[] deadColors)
        {
            if (livingColors.Length < 8 || livingColors.Length < 8)
            {
                throw new ArgumentException("Tablica kolorów musi zawierać przynajmniej 8 kolorów!");
            }
            int width = grid.XSize;
            int height = grid.YSize;
            Bitmap bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb);
            BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, width, height),
                    ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);

            int pixelSize = 4;
            int highestLevel;
            int conditionNumber;
            Color[] conditionColor;

            unsafe
            {
                for (int y = 0; y < height; y++)
                {
                    byte* row = null;
                    row = (byte*)bmpData.Scan0 + (y * bmpData.Stride);

                    for (int x = 0; x < width; x++)
                    {
                        highestLevel = 0;
                        if (grid[x, y])
                        {
                            conditionNumber = 1;
                            conditionColor = livingColors;
                        }
                        else
                        {
                            conditionNumber = 0;
                            conditionColor = deadColors;
                        }
                        byte stateByte = grid.GetPoint(x, y);
                        while (stateByte % 2 == conditionNumber)
                        {
                            stateByte = (byte)(stateByte >> 1);
                            highestLevel++;
                            if (highestLevel == 8)
                                break;
                        }
                        Color colorToSet = conditionColor[--highestLevel];
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
