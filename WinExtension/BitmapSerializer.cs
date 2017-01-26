using Convay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Convay.WinExtension
{
    /// <summary>
    /// Serializuje pliki do formatu bitmapy
    /// </summary>
    public class BitmapSerializer : IGridSerializer
    {
        IVisualizer visualizer;
        /// <summary>
        /// Konstruuje obiekt
        /// </summary>
        /// <param name="visualizer">Instacja wizualizatora siatki</param>
        public BitmapSerializer(IVisualizer visualizer)
        {
            this.visualizer = visualizer;
        }

        /// <summary>
        /// Ładuje ze strumienia
        /// </summary>
        /// <param name="stream">strumień do ładowania</param>
        /// <param name="grid">wczytana siatka</param>
        public void LoadFromStream(Stream stream, IGrid grid)
        {
            Bitmap image = new Bitmap(Image.FromStream(stream));
            int width = image.Width;
            int height = image.Height;
            grid.Initialize(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (image.GetPixel(i, j).GetBrightness() > 0.5f)
                    {
                        grid[i, j] = false;
                    }
                    else
                    {
                        grid[i, j] = true;
                    }
                }
            }
        }

        /// <summary>
        /// Zapisuje do strumienia
        /// </summary>
        /// <param name="grid">siatka do zapisania</param>
        /// <param name="stream">strumień do zapisania</param>
        public void SaveToStream(IGrid grid, Stream stream)
        {
            Bitmap bmp;
            bmp = visualizer.ToBitmap(grid, Color.Black, Color.White);
            bmp.Save(stream, ImageFormat.Bmp);
        }
    }
}
