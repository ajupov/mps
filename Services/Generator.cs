using System;
using System.Collections.Generic;
using System.Linq;

namespace Mps.Services
{
    /// <summary>
    /// Генератор приоритетов
    /// </summary>
    public static class Generator
    {
        /// <summary>
        /// Генератор псевдослуайный чисел
        /// </summary>
        private static readonly Random Random = new Random();

        /// <summary>
        /// Список приоритетов для генерации
        /// </summary>
        private static List<int> _ks = new List<int>();

        /// <summary>
        /// Заполнить приоритеты
        /// </summary>
        /// <param name="count"></param>
        public static void Fill(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _ks.Add(i + 1);
            }
        }

        /// <summary>
        /// Очистить приоритеты
        /// </summary>
        public static void Clear()
        {
            _ks.Clear();
        }

        /// <summary>
        /// Десортировать приоритеты
        /// </summary>
        public static void DeSort()
        {
            _ks = _ks.OrderBy(kCurrent => Random.Next()).ToList();
        }

        /// <summary>
        /// Вернуть элемент по индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        /// <returns>Элемент</returns>
        public static int GetByIndex(int index)
        {
            return _ks[index];
        }
    }
}