namespace Mps.Models
{
    /// <summary>
    /// Точка на графике
    /// </summary>
    public class GraphicPoint
    {
        /// <summary>
        /// Приоритет
        /// </summary>
        public int K { get; set; }

        /// <summary>
        /// Пропускная способность
        /// </summary>
        public int A { get; set; }
    }
}