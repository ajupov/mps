using System;
using System.Windows.Forms;
using Mps.Forms;

namespace Mps
{
    /// <summary>
    /// Основной класс приложения
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // Включить визуальные стили
            Application.EnableVisualStyles();

            // Установить совместимое отображение текста
            Application.SetCompatibleTextRenderingDefault(false);

            // Запустить форму
            Application.Run(new MpsForm());
        }
    }
}