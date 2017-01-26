using Convay.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convay.Core
{
    /// <summary>
    /// Serializuje pliki do formatu .glg - siatka zapisana jako ciąg bitów
    /// </summary>
    public class GridSerializer : IGridSerializer
    {
        /// <summary>
        /// Ładuje ze strumienia
        /// </summary>
        /// <param name="stream">strumień do ładowania</param>
        /// <param name="grid">wczytana siatka</param>
        public void LoadFromStream(Stream stream, IGrid grid)
        {
            BinaryReader reader = new BinaryReader(stream);
            int xSize = reader.ReadInt32();
            int ySize = reader.ReadInt32();
            int counter = 0;
            if (xSize == 0 && ySize == 0)
            {
                return;
            }
            grid.Initialize(xSize, ySize);
            byte readByte = reader.ReadByte();
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    if (counter == 8)
                    {
                        readByte = reader.ReadByte();
                        counter = 0;
                    }
                    grid[i, j] = ((readByte & 128) == 128);
                    readByte = (byte)(readByte << 1);
                    counter++;
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
            BinaryWriter writer = new BinaryWriter(stream);
            int counter = 0;
            byte byteToWrite = 0;
            int xSize = grid.XSize;
            int ySize = grid.YSize;
            writer.Write(xSize);
            writer.Write(ySize);
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    byteToWrite = (byte)(byteToWrite << 1);
                    if (grid[i, j])
                    {
                        byteToWrite++;
                    }
                    counter++;
                    if (counter == 8)
                    {
                        counter = 0;
                        writer.Write(byteToWrite);
                        byteToWrite = 0;
                    }
                }
            }
            while (counter > 0)
            {
                byteToWrite = (byte)(byteToWrite << 1);
                counter++;
                if (counter == 8)
                {
                    counter = 0;
                    writer.Write(byteToWrite);
                    byteToWrite = 0;
                }
            }
        }
    }
}
