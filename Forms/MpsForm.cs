using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Mps.Enums;
using Mps.Models;
using Mps.Properties;
using Mps.Services;

namespace Mps.Forms
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class MpsForm : Form
    {
        /// <summary>
        /// Предыдущее значение ячейки перед редактированием
        /// </summary>
        private object _cellOldValue;

        /// <summary>
        /// Название файла
        /// </summary>
        private string _fileName;

        /// <summary>
        /// Генератор псевдослуайный чисел
        /// </summary>
        private readonly Random _random = new Random();

        /// <summary>
        /// Конструктор
        /// </summary>
        public MpsForm()
        {
            try
            {
                // Инициализация компонентов
                InitializeComponent();

                // Установить нумерацию строк
                SetRowNumbers();

                // Установить возможно ли добавление кортежей
                SetAllowToAddRows();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие закрытия формы
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void MpsFormFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Показать сообщение с вопросом
                var result = MessageBox.Show(Resources.ExitQuestionMessage, Resources.ExitCaption,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Если нажато "Да", то выйти
                if (result == DialogResult.Yes)
                {
                    return;
                }

                // Иначе отменить выход
                e.Cancel = true;
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие активации формы
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void MpsFormActivated(object sender, EventArgs e)
        {
            // Отрисовать
            Draw();
        }

        /// <summary>
        /// Событие нажатия на кнопку "Генерировать"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void ButtonGenerateTupplesClick(object sender, EventArgs e)
        {
            try
            {
                // Установить картежи
                SetTupples();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        ///  Событие нажатия на кнопку "Рассчитать"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void ButtonCalculateClick(object sender, EventArgs e)
        {
            try
            {
                // Рассчитать
                Calculate();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие нажатия на кнопку "Очистить"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void ButtonClearClick(object sender, EventArgs e)
        {
            try
            {
                // Очистить таблицу
                tupplesTable.Rows.Clear();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Файл" - "Открыть"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void OpenFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Задать имя файла
                    _fileName = openFileDialog.FileName;

                    // Открыть
                    OpenFile();
                }
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Файл" - "Сохранить"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void SaveFileToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                // Если нет имени файла
                if (string.IsNullOrEmpty(_fileName))
                {
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Задать имя файла
                        _fileName = saveFileDialog.FileName;

                        // Сохранить
                        SaveFile();
                    }
                }
                // Иначе
                else
                {
                    // Сохранить
                    SaveFile();
                }
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Файл" - "Сохранить как..."
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void SaveFileAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Задать имя файла
                    _fileName = saveFileDialog.FileName;

                    // Сохранить
                    SaveFile();
                }
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Файл" - "Выход"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                // Выход
                Close();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Команда" - "Сгенерировать"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void GenerateToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                // Установить картежи
                SetTupples();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Команда" - "Рассчитать"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void CalculateToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                // Рассчитать
                Calculate();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие выбора пункта меню "Команда" - "Очистить"
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void ClearTableToolStripMenuItemClick(object sender, EventArgs e)
        {
            try
            {
                // Очистить таблицу
                tupplesTable.Rows.Clear();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие начала редактирования ячейки
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void TupplesTableCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                // Запомнить старое значение ячейки
                var cell = tupplesTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                _cellOldValue = cell.Value;
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие завершения редактирования содержимого ячейки
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void TupplesTableCellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Текущая ячейка
                var cell = tupplesTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell?.Value == null)
                {
                    return;
                }

                // Значение текущей ячейки
                var stringValue = cell.Value.ToString();

                // Для колонки
                switch ((ColumnIndex)e.ColumnIndex)
                {
                    // Если колонка интенсивностей
                    case ColumnIndex.LamdaColumnIndex:
                    case ColumnIndex.MuColumnIndex:
                        // Попытаться получить значение
                        double outDoubleValue;
                        if (double.TryParse(stringValue, out outDoubleValue))
                        {
                            // Установить значение
                            cell.Value = outDoubleValue;

                            // Отменить ввод отрицательного значения
                            if (outDoubleValue <= 0)
                            {
                                // Показать сообщение об ошибке и установить предыдущее значение ячейки
                                ShowErrorAndSetOldCellValue(cell, Resources.NegativeOrZeroValueEnteredErrorMessage);
                            }

                            var lamdaCell = tupplesTable.Rows[e.RowIndex].Cells[(int) ColumnIndex.LamdaColumnIndex];
                            var muCell = tupplesTable.Rows[e.RowIndex].Cells[(int) ColumnIndex.MuColumnIndex];

                            if (lamdaCell?.Value == null || muCell?.Value == null)
                            {
                                return;
                            }
                            // Попытаться получить измененные значения

                            // Если удалось получить
                            double outLamdaDoubleValue;
                            double outMuDoubleValue;
                            if (double.TryParse(lamdaCell.Value.ToString(), out outLamdaDoubleValue) &&
                                double.TryParse(muCell.Value.ToString(), out outMuDoubleValue))
                            {
                                // Установить значение
                                var omegaCell = tupplesTable.Rows[e.RowIndex].Cells[(int)ColumnIndex.OmegaColumnIndex];
                                omegaCell.Value = Calculator.CalculateOmega(outLamdaDoubleValue, outMuDoubleValue);
                            }
                            // Иначе
                            else
                            {
                                // Показать сообщение об ошибке и установить предыдущее значение ячейки
                                ShowErrorAndSetOldCellValue(cell,
                                    Resources.NotCorrectIntensivityValuesToCalculateErrorMessage);
                            }
                        }
                        else
                        {
                            // Показать сообщение об ошибке и установить предыдущее значение ячейки
                            ShowErrorAndSetOldCellValue(cell, Resources.NotCorrectCellValueErrorMessage);
                        }
                        break;
                    // Если колонка приоритетов
                    case ColumnIndex.KColumnIndex:
                        // Попытаться получить значение
                        int outIntValue;
                        if (int.TryParse(stringValue, out outIntValue))
                        {
                            var ks = new List<int>();

                            // Получить список приоритетов
                            foreach (DataGridViewRow row in tupplesTable.Rows)
                            {
                                // Пропустить пустые ячейки приоритетов
                                var kCell = row.Cells[(int) ColumnIndex.KColumnIndex];
                                int outTempIntValue;
                                if (kCell?.Value == null || !int.TryParse(kCell.Value.ToString(), out outTempIntValue))
                                {
                                    continue;
                                }

                                // Пропустить текущую строку
                                if (e.RowIndex == row.Index)
                                {
                                    continue;
                                }

                                // Добавить в список
                                ks.Add(outTempIntValue);
                            }

                            // Если не было изменений
                            if (_cellOldValue != null && outIntValue == int.Parse(_cellOldValue.ToString()))
                            {
                                return;
                            }

                            // Если уже имеется указанный приоритет
                            if (ks.Contains(outIntValue))
                            {
                                // Показать сообщение об ошибке и установить предыдущее значение ячейки
                                ShowErrorAndSetOldCellValue(cell, Resources.ExistPriorityValueErrorMessage);
                            }
                            else
                            {
                                // Установить значение
                                cell.Value = outIntValue.ToString("D");

                                // Отменить ввод отрицательного значения
                                if (outIntValue <= 0)
                                {
                                    // Показать сообщение об ошибке и установить предыдущее значение ячейки
                                    ShowErrorAndSetOldCellValue(cell, Resources.NegativeOrZeroValueEnteredErrorMessage);
                                }
                            }
                        }
                        else
                        {
                            // Показать сообщение об ошибке и установить предыдущее значение ячейки
                            ShowErrorAndSetOldCellValue(cell, Resources.NotCorrectCellValueErrorMessage);
                        }
                        break;
                }

                SetRowNumbers();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие удаления строки
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void TupplesTableUserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                // Установить нумерацию строк
                SetRowNumbers();

                // Установить возможно ли добавление кортежей
                SetAllowToAddRows();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Событие добавления строки
        /// </summary>
        /// <param name="sender">Отправитель события</param>
        /// <param name="e">Аргументы</param>
        private void TupplesTableUserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                // Установить нумерацию строк
                SetRowNumbers();

                // Установить возможно ли добавление кортежей
                SetAllowToAddRows();
            }
            catch (Exception)
            {
                ShowError(Resources.OcceredUnclownExceptionErrorMessage);
            }
        }

        /// <summary>
        /// Установить картежи
        /// </summary>
        public void SetTupples()
        {
            // Очистить таблицу
            tupplesTable.Rows.Clear();

            // Очистить приоритеты
            Generator.Clear();

            // Количество кортежей
            var tupplesCount = numericUpDownG.Value;

            // Заполнить приоритеты
            Generator.Fill((int) tupplesCount);

            // Рассортировать приоритеты
            if (checkBoxRandomK.Checked)
            {
                Generator.DeSort();
            }

            // Заполнить таблицу картежей
            for (var i = 0; i < tupplesCount; i++)
            {
                var lamdaCurrent = 0.0;
                var muCurrent = 0.0;

                // Если отмечена случайная генерация интенсивностей
                if (checkBoxRandomTupples.Checked)
                {
                    // Генерировать положительное число (0 < число < 10) и округлить до двух знаков после запятой
                    while (lamdaCurrent <= 0)
                    {
                        lamdaCurrent = Math.Round(_random.NextDouble() * _random.Next(10), 2);
                    }

                    // Генерировать положительное число (0 < число < 10) и округлить до двух знаков после запятой
                    while (muCurrent <= 0)
                    {
                        muCurrent = Math.Round(_random.NextDouble() * _random.Next(10), 2);
                    }
                }
                // Иначе
                else
                {
                    // Интенсивность потока задач растёт последовательно на единицу
                    lamdaCurrent = i + 1;

                    // Интенсивность обслуживания равна единице
                    muCurrent = 1;
                }

                // Вычислить значение загрузки процессора
                var omegaCurrent = Calculator.CalculateOmega(lamdaCurrent, muCurrent);

                // Значение приоритета
                var kCurrent = Generator.GetByIndex(i);

                // Добавить кортеж
                tupplesTable.Rows.Add(lamdaCurrent, muCurrent, omegaCurrent, kCurrent);
            }

            // Установить нумерацию строк
            SetRowNumbers();

            // Установить возможно ли добавление кортежей
            SetAllowToAddRows();
        }

        /// <summary>
        /// Установить нумерацию строк
        /// </summary>
        private void SetRowNumbers()
        {
            // Для каждой строки установить индекс + 1
            foreach (DataGridViewRow row in tupplesTable.Rows)
            {
                row.HeaderCell.Value = $"{row.Index + 1}";
            }
        }

        /// <summary>
        /// Установить возможно ли добавление кортежей
        /// </summary>
        private void SetAllowToAddRows()
        {
            // Установить возможно ли редактирование на основе количества строк в таблице
            tupplesTable.AllowUserToAddRows = tupplesTable.RowCount < numericUpDownG.Maximum;
        }

        /// <summary>
        /// Показать сообщение об ошибке и установить предыдущее значение ячейки
        /// </summary>
        /// <param name="cell">Ячейка</param>
        /// <param name="errorMessage">ТекстОшибки</param>
        private void ShowErrorAndSetOldCellValue(DataGridViewCell cell, string errorMessage)
        {
            // Показать сообщение об ошибке
            ShowError(errorMessage);

            // Восстановить значение
            cell.Value = _cellOldValue;
        }

        /// <summary>
        /// Показать сообщение об ошибке
        /// </summary>
        /// <param name="errorMessage">ТекстОшибки</param>
        private static void ShowError(string errorMessage)
        {
            // Показать сообщение об ошибке
            MessageBox.Show(errorMessage, Resources.ErrorCaption, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Получить значения ячеек таблицы
        /// </summary>
        /// <returns>Список строк</returns>
        private List<Row> GetRows()
        {
            return tupplesTable.Rows.Cast<DataGridViewRow>()
                .Select(dataGridViewRow => dataGridViewRow.Cells)
                .Select(cells => new Row
                {
                    Lamda = ParseDoubleFromCell(cells[(int)ColumnIndex.LamdaColumnIndex]),
                    Mu = ParseDoubleFromCell(cells[(int)ColumnIndex.MuColumnIndex]),
                    Omega = ParseDoubleFromCell(cells[(int)ColumnIndex.OmegaColumnIndex]),
                    K = ParseIntFromCell(cells[(int)ColumnIndex.KColumnIndex]),
                    P = ParseDoubleFromCell(cells[(int)ColumnIndex.PColumnIndex]),
                    C = ParseDoubleFromCell(cells[(int)ColumnIndex.CColumnIndex]),
                    A = ParseIntFromCell(cells[(int)ColumnIndex.AColumnIndex])
                })
                .Where(r => r.Lamda > 0 && r.Mu > 0 && r.K > 0)
                .ToList();
        }

        /// <summary>
        /// Установить список строк в таблицу
        /// </summary>
        /// <param name="rows">Строки</param>
        private void SetRows(IEnumerable<Row> rows)
        {
            foreach (var row in rows)
            {
                tupplesTable.Rows.Add(row.Lamda, row.Mu, row.Omega, row.K, row.P, row.C, row.A);
            }
        }

        /// <summary>
        /// Рассчитать
        /// </summary>
        private void Calculate()
        {
            // Получить список строк
            var rows = GetRows();

            // Использовать ли гамма-функцию для расчёта факториала
            var overGammaFunction = checkBoxOverGammaFunction.Checked;

            // Вычислить
            Calculator.Calculate(rows, (int)numericUpDownN.Value, overGammaFunction);

            // Очистить таблицу
            tupplesTable.Rows.Clear();

            // Установить список строк в таблицу
            SetRows(rows);
            
            // Установить нумерацию строк
            SetRowNumbers();

            // Отрисовать
            Draw();
        }

        /// <summary>
        /// Получить вещественное значение из ячейки
        /// </summary>
        /// <param name="cell">Ячейка</param>
        /// <returns>Вещественное значение ячейки</returns>
        private static double ParseDoubleFromCell(DataGridViewCell cell)
        {
            double outValue;
            double.TryParse(cell?.Value?.ToString(), out outValue);
            return outValue;
        }

        /// <summary>
        /// Получить целочисленное значение из ячейки
        /// </summary>
        /// <param name="cell">Ячейка</param>
        /// <returns>Целочисленное значение ячейки</returns>
        private static int ParseIntFromCell(DataGridViewCell cell)
        {
            int outValue;
            int.TryParse(cell?.Value?.ToString(), out outValue);
            return outValue;
        }

        /// <summary>
        /// Сохранить в файл
        /// </summary>
        private void SaveFile()
        {
            // Если есть имя файла
            if (!string.IsNullOrEmpty(_fileName))
            {
                // Модель файла
                var fileModel = new FileModel
                {
                    N = (int)numericUpDownN.Value,
                    IsRandomTupples = checkBoxRandomTupples.Checked,
                    IsRandomPriority = checkBoxRandomK.Checked,
                    UseGammaFunction = checkBoxOverGammaFunction.Checked,
                    Rows = GetRows()
                };

                // Сохранить
                XmlFileManager.Save(fileModel, _fileName);

                MessageBox.Show(Resources.FileSavedSuccessfullyInformationMessage, Resources.SaveFileCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Открыть файл
        /// </summary>
        private void OpenFile()
        {
            // Если есть имя файла
            if (!string.IsNullOrEmpty(_fileName))
            {
                // Модель файла
                var fileModel = XmlFileManager.Open(_fileName);

                // Установить значения настроек
                numericUpDownN.Value = fileModel.N;
                numericUpDownG.Value = fileModel.Rows.Count;
                checkBoxRandomTupples.Checked = fileModel.IsRandomTupples;
                checkBoxRandomK.Checked = fileModel.IsRandomPriority;
                checkBoxOverGammaFunction.Checked = fileModel.UseGammaFunction;
                checkBoxOverGammaFunction.Checked = fileModel.UseGammaFunction;

                // Очистить таблицу
                tupplesTable.Rows.Clear();

                // Установить список строк в таблицу
                SetRows(fileModel.Rows);

                // Установить нумерацию строк
                SetRowNumbers();
            }
        }

        /// <summary>
        /// Нарисовать
        /// </summary>
        public void Draw()
        {
            using (var graphics = pictureBox.CreateGraphics())
            {
                graphics.SmoothingMode = SmoothingMode.HighQuality;

                // Очистить
                graphics.Clear(pictureBox.BackColor);

                // Нарисовать сетку
                DrawGrid(graphics);

                // Нарисовать оси ординат и абцисс
                DrawArrows(graphics);

                // Нарисовать график
                DrawGraphic(graphics);
            }
        }

        /// <summary>
        /// Нарисовать график
        /// </summary>
        /// <param name="graphics">Объект Graphics</param>
        private void DrawGraphic(Graphics graphics)
        {
            // Получить шаги сетки
            var gridSteps = GetSteps();

            // Начало и конец сетки
            var a0K0Point = new PointF(gridSteps.Width, pictureBox.Bottom - pictureBox.Top - gridSteps.Height);
            var aMaxKMaxPoint = new PointF(gridSteps.Width * 20, gridSteps.Height);

            // Точки построения графика
            var graphicPoints = GetPoinsForGraphic();

            if (!graphicPoints.Any())
            {
                return;
            }

            // Самое правое значение по горизонтали
            var maxKValue = graphicPoints.Max(point => point.K);
            if (maxKValue == 0)
            {
                return;
            }

            // Самое верхнее значение по вертикали
            var maxAValue = graphicPoints.Max(point => point.A);
            if (maxAValue == 0)
            {
                return;
            }
            
            // Шаги графика
            var graphicSteps = new SizeF((float) ((aMaxKMaxPoint.X - a0K0Point.X - gridSteps.Width) / maxKValue),
                (float) ((a0K0Point.Y - aMaxKMaxPoint.Y) / maxAValue));

            // Точки рисования
            var points = new List<PointF>();
            foreach (var graphicPoint in graphicPoints)
            {
                points.Add(new PointF(
                    (float) (a0K0Point.X + graphicPoint.K * graphicSteps.Width),
                    (float) (a0K0Point.Y - graphicPoint.A * graphicSteps.Height)));
            }

            using (var pen = new Pen(Color.Red, 1))
            {
                // Округленные начальная и конечная точка
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;

                // Нарисовать линии
                graphics.DrawLines(pen, points
                    .Where(point => !float.IsInfinity(point.X) && !float.IsNaN(point.X)
                        && !float.IsInfinity(point.Y) && !float.IsNaN(point.Y))
                    .ToArray());
            }
        }

        /// <summary>
        /// Нарисовать оси ординат и абцисс
        /// </summary>
        /// <param name="graphics">Объект Graphics</param>
        private void DrawArrows(Graphics graphics)
        {
            // Получить шаги сетки
            var steps = GetSteps();

            // Координаты линий и обозначений
            var arrowStart = new PointF(steps.Width, pictureBox.Bottom - pictureBox.Top - steps.Height);
            var verticalArrowEnd = new PointF(arrowStart.X, steps.Height);
            var horisontalArrowEnd = new PointF(pictureBox.Right - pictureBox.Left - steps.Width, arrowStart.Y);

            var a0K0Point = new PointF(arrowStart.X - 15, arrowStart.Y);
            var aLabelPoint = new PointF(verticalArrowEnd.X - 20, verticalArrowEnd.Y);
            var kLabelPoint = new PointF(horisontalArrowEnd.X - 20, horisontalArrowEnd.Y + 5);

            // Шрифт
            var font = new Font("Arial", 12);

            // Сплошная кисть
            var brush = new SolidBrush(Color.DimGray);

            // Кисть
            using (var grayArrowPen = new Pen(Brushes.DimGray, 2))
            {
                // Стрелка в конце
                grayArrowPen.CustomEndCap = new AdjustableArrowCap(5, 5);

                // Нарисовать
                graphics.DrawLines(grayArrowPen, new[] {arrowStart, verticalArrowEnd});
                graphics.DrawLines(grayArrowPen, new[] {arrowStart, horisontalArrowEnd});
                graphics.DrawString("0", font, brush, a0K0Point);
                graphics.DrawString("A", font, brush, aLabelPoint);
                graphics.DrawString("K", font, brush, kLabelPoint);
            }
        }

        /// <summary>
        /// Нарисовать сетку
        /// </summary>
        /// <param name="graphics">Объект Graphics</param>
        private void DrawGrid(Graphics graphics)
        {
            // Получить шаги сетки
            var steps = GetSteps();

            // Список наборов координат
            var tuples = new List<Tuple<PointF, PointF>>();

            // Нарисовать горизонтальные линии сетки
            for (float i = 0; i < pictureBox.Bottom; i += steps.Height)
            {
                // Вертикальные координаты
                var lineStartPoint = new PointF(0, i);
                var lineEndPoint = new PointF(pictureBox.Right, i);

                // Добавить
                tuples.Add(new Tuple<PointF, PointF>(lineStartPoint, lineEndPoint));
            }

            // Нарисовать вертикальные линии сетки
            for (float i = 0; i < pictureBox.Right; i += steps.Width)
            {
                // Горизонтальные координаты
                var lineStartPoint = new PointF(i, 0);
                var lineEndPoint = new PointF(i, pictureBox.Bottom);

                // Добавить
                tuples.Add(new Tuple<PointF, PointF>(lineStartPoint, lineEndPoint));
            }

            // Кисть
            using (var lightGrayPen = new Pen(Brushes.LightGray, 1))
            {
                foreach (var tuple in tuples)
                {
                    // Нарисовать
                    graphics.DrawLines(lightGrayPen, new[] {tuple.Item1, tuple.Item2});
                }
            }
        }

        /// <summary>
        /// Получить шаги сетки
        /// </summary>
        /// <returns>Размеры шагов сетки</returns>
        private SizeF GetSteps()
        {
            return new SizeF(
                (pictureBox.Right - pictureBox.Left) / (float) 20,
                (pictureBox.Bottom - pictureBox.Top) / (float) 20
            );
        }

        /// <summary>
        /// Получить точки для построения графика
        /// </summary>
        /// <returns>Список точек для построения графика</returns>
        private List<GraphicPoint> GetPoinsForGraphic()
        {
            return tupplesTable.Rows.Cast<DataGridViewRow>()
                .Select(dataGridViewRow => dataGridViewRow.Cells)
                .Select(cells => new GraphicPoint
                {
                    K = ParseDoubleFromCell(cells[(int)ColumnIndex.KColumnIndex]),
                    A = ParseDoubleFromCell(cells[(int)ColumnIndex.AColumnIndex])
                })
                .Where(point => point.K > 0)
                .OrderBy(point => point.K)
                .ToList();
        }
    }
}