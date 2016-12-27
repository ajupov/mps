using System;

namespace Mps.Models
{
    /// <summary>
    /// Строка таблицы
    /// </summary>
    [Serializable]
    public class Row
    {
        /// <summary>
        /// Лямда
        /// </summary>
        public double Lamda { get; set; }

        /// <summary>
        /// Мю
        /// </summary>
        public double Mu { get; set; }

        /// <summary>
        /// Омега
        /// </summary>
        public double Omega { get; set; }

        /// <summary>
        /// K
        /// </summary>
        public int K { get; set; }

        /// <summary>
        /// P
        /// </summary>
        public double P { get; set; }

        /// <summary>
        /// C
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// A
        /// </summary>
        public int A { get; set; }
    }
}