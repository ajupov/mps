using System;
using System.Collections.Generic;

namespace Mps.Models
{
    /// <summary>
    /// Класс для работы с файлом
    /// </summary>
    [Serializable]
    public class FileModel
    {
        /// <summary>
        /// Количество процессоров
        /// </summary>
        public int N { get; set; }

        /// <summary>
        /// Установлена ли галочка генерации псевдослучайных наборов
        /// </summary>
        public bool IsRandomTupples { get; set; }

        /// <summary>
        /// Установлена ли галочка генерации псевдослучайных приоритетов
        /// </summary>
        public bool IsRandomPriority { get; set; }

        /// <summary>
        /// Установлена ли галочка использования гамма-функции при расчёте факториала
        /// </summary>
        public bool UseGammaFunction { get; set; }

        /// <summary>
        /// Строки
        /// </summary>
        public List<Row> Rows { get; set; }
    }
}