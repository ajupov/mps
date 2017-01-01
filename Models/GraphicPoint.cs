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
        public double K { get; set; }

        /// <summary>
        /// Пропускная способность
        /// </summary>
        public double A { get; set; }
    }
}