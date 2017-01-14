using System;
using System.Collections.Generic;
using System.Linq;
using Mps.Models;

namespace Mps.Services
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public static class Calculator
    {
        /// <summary>
        /// Рассчитать значение загрузки процессора
        /// </summary>
        /// <param name="lamdaCurrent">Интенсивность потока задач</param>
        /// <param name="muCurrent">Интенсивность обслуживания</param>
        /// <returns>Значение загрузки процессора</returns>
        public static double CalculateOmega(double lamdaCurrent, double muCurrent)
        {
            // Делить без округления
            return lamdaCurrent / muCurrent;
        }

        /// <summary>
        /// Рассчитать
        /// </summary>
        /// <param name="rows">Строки</param>
        /// <param name="n">Количество процессоров</param>
        /// <param name="overGammaFunction">Использовать гамма-функцию</param>
        public static void Calculate(List<Row> rows, int n, bool overGammaFunction = false)
        {
            // Для всех строк
            for (var counter = 0; counter < rows.Count; counter++)
            {
                // Текущая строка
                var row = rows[counter];

                // Омега
                var omega = CalculateOmega(row.Lamda, row.Mu);

                // Значение C предыдущих строк
                double prevC = 0;
                for (var i = 0; i < counter ; i++)
                {
                    prevC += rows[i].C;
                }

                // N - C
                var nMisusPrevC = n - prevC;

                // Числитель
                var numerator = Math.Pow(omega, nMisusPrevC);

                // Левая часть знаменателя
                var denominatorLeftPart = GetFactorial(nMisusPrevC, overGammaFunction);

                // Правая часть знаменателя
                var denominatorRightPart = GetDenominatorRightPart(nMisusPrevC, omega);

                // Знаменатель
                var denominator = denominatorLeftPart * denominatorRightPart;

                // Значение P
                row.P = numerator / denominator;

                // Установка значений с учетом превышения 1 на текущем шаге
                if (rows.Sum(r => r.P) >= 1)
                {
                    row.P = 0;
                    row.C = 0;
                    row.A = 0;
                }
                else
                {
                    // Значение С
                    row.C = omega * (1 - row.P);

                    // Значение A
                    row.A = (1 - row.P) * row.Lamda;
                }
            }
        }

        /// <summary>
        /// Получить правую часть знаменателя
        /// </summary>
        /// <param name="nMisusPrevC">N - C предыдущей строки</param>
        /// <param name="omega">Омега</param>
        /// <param name="overGammaFunction">Использовать гамма-функцию для рассчёта факториала</param>
        /// <returns>Правая часть знаменателя</returns>
        private static double GetDenominatorRightPart(double nMisusPrevC, double omega, bool overGammaFunction = false)
        {
            var result = 0.0;

            // Если не число или число в обстях бесконечных чисел, вернуть 0.0
            if (double.IsNaN(nMisusPrevC) || double.IsNegativeInfinity(nMisusPrevC) || double.IsPositiveInfinity(nMisusPrevC))
            {
                return result;
            }

            // Для N - C предыдущей строки сложить
            for (var i = 0; i <= Math.Ceiling(nMisusPrevC); i++)
            {
                // Числитель
                var stepResultNumerator = Math.Pow(omega, i);

                // Знаменатель
                var stepResultDenominator = GetFactorial(i, overGammaFunction);

                //Результат
                var stepResult = stepResultNumerator / stepResultDenominator;

                // Добавить в накапливающую переменную
                result += stepResult;
            }

            return result;
        }

        /// <summary>
        /// Вычислить факториал
        /// </summary>
        /// <param name="number">Число, для которого необходимо вычислить факториал</param>
        /// <param name="overGammaFunction">Использовать гамма-функцию для рассчёта факториала</param>
        /// <returns>Факториал числа</returns>
        private static double GetFactorial(double number, bool overGammaFunction)
        {
            // Если не число или число в обстях бесконечных чисел, вернуть 1.0
            if (double.IsNaN(number) || double.IsNegativeInfinity(number) || double.IsPositiveInfinity(number) ||
                Math.Abs(number - 1) < double.Epsilon || Math.Abs(number) < double.Epsilon)
            {
                return 1;
            }

            // Если без использования гамма-функции
            if (!overGammaFunction)
            {
                // Целоисленное значение
                var numberInt = (int)Math.Round(number);

                // Математики так решили
                if (numberInt == 0 || numberInt == 1 || numberInt < 0)
                {
                    return 1;
                }

                // Вычислить циклиески
                var sum = 1;
                for (var i = numberInt; i != 0; i--)
                {
                    sum *= i;
                }

                return sum;
            }

            // Иначе вычислить с использованием гамма-функции
            return Gamma(number + 1);
        }

        /// <summary>
        /// Гамма-функция
        /// </summary>
        /// <param name="x">Число, для которого необходио вычислить факториал</param>
        /// <returns>Факториал числа</returns>
        public static double Gamma(double x)
        {
            if (x <= 0.0)
            {
                return 0;
            }

            // Константа Эйлера для гаммы
            const double gamma = 0.577215664901532860606512090; // Euler's gamma constant

            // Если стремится к нулю
            if (Math.Abs(x) < double.Epsilon)
            {
                return 1.0 / (x * (1.0 + gamma * x));
            }

            // Расчет к точкам приближения между (1, 2)
            double z;
            if (x < 12.0)
            {
                var y = x;
                var n = 0;
                var argWasLessThanOne = y < 1.0;

                // Аргумент меньше 1
                if (argWasLessThanOne)
                {
                    y += 1.0;
                }
                // Иначе
                else
                {
                    n = (int)Math.Floor(y) - 1;
                    y -= n;
                }

                // Коэффициенты числителя аппроксимации для(1, 2)
                double[] p =
                {
                    -1.71618513886549492533811E+0,
                     2.47656508055759199108314E+1,
                    -3.79804256470945635097577E+2,
                     6.29331155312818442661052E+2,
                     8.66966202790413211295064E+2,
                    -3.14512729688483675254357E+4,
                    -3.61444134186911729807069E+4,
                     6.64561438202405440627855E+4
                };

                // Коэффициенты знаменателя аппроксимации для(1, 2)
                double[] q =
                {
                    -3.08402300119738975254353E+1,
                     3.15350626979604161529144E+2,
                    -1.01515636749021914166146E+3,
                    -3.10777167157231109440444E+3,
                     2.25381184209801510330112E+4,
                     4.75584627752788110767815E+3,
                    -1.34659959864969306392456E+5,
                    -1.15132259675553483497211E+5
                };

                var num = 0.0;
                var den = 1.0;
                int i;

                z = y - 1;
                for (i = 0; i < 8; i++)
                {
                    num = (num + p[i]) * z;
                    den = den * z + q[i];
                }
                var result = num / den + 1.0;

                // Применить коррекцию, если аргумент не был первоначально в (1, 2)
                if (argWasLessThanOne)
                {
                    result /= (y - 1.0);
                }
                else
                {
                    for (i = 0; i < n; i++)
                    {
                        result *= y++;
                    }
                }

                return result;
            }

            // Ниже вычисления логарифма от гамма-фунции
            if (x > 171.624)
            {
                return double.PositiveInfinity;
            }

            if (x <= 0.0)
            {
                return 0;
            }

            if (x < 12.0)
            {
                return Math.Log(Math.Abs(Gamma(x)));
            }

            double[] c =
            {
                1.0/12.0,
                -1.0/360.0,
                1.0/1260.0,
                -1.0/1680.0,
                1.0/1188.0,
                -691.0/360360.0,
                1.0/156.0,
                -3617.0/122400.0
            };

            z = 1.0 / (x * x);
            var sum = c[7];

            for (var i = 6; i >= 0; i--)
            {
                sum *= z;
                sum += c[i];
            }

            var series = sum / x;

            const double halfLogTwoPi = 0.91893853320467274178032973640562;
            var logGamma = (x - 0.5) * Math.Log(x) - x + halfLogTwoPi + series;
            return Math.Exp(logGamma);
        }
    }
}