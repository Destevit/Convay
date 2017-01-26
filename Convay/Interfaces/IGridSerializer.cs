using System.IO;

namespace Convay.Core.Interfaces
{
    public interface IGridSerializer
    {
        /// <summary>
        /// Zapisuje siatkę do strumienia
        /// </summary>
        /// <param name="grid">siatka do zapisu</param>
        /// <param name="stream">strumień do zapisu</param>
        void SaveToStream(IGrid grid, Stream stream);

        /// <summary>
        /// Ładuje siatkę ze strumienia
        /// </summary>
        /// <param name="stream">strumień do czytania</param>
        /// <param name="grid">załadowana siatka</param>
        void LoadFromStream(Stream stream, IGrid grid);
    }
}
