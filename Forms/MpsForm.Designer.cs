namespace Mps.Forms
{
    partial class MpsForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MpsForm));
            this.labelN = new System.Windows.Forms.Label();
            this.tupplesTable = new System.Windows.Forms.DataGridView();
            this.lamda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.omega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTupples = new System.Windows.Forms.GroupBox();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.groupBoxCalculate = new System.Windows.Forms.GroupBox();
            this.sumLabel = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.checkBoxOverGammaFunction = new System.Windows.Forms.CheckBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxChart = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tupplesTable)).BeginInit();
            this.groupBoxTupples.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            this.groupBoxCalculate.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(6, 37);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(150, 13);
            this.labelN.TabIndex = 0;
            this.labelN.Text = "Количество процессоров, n:";
            // 
            // tupplesTable
            // 
            this.tupplesTable.AllowUserToResizeColumns = false;
            this.tupplesTable.AllowUserToResizeRows = false;
            this.tupplesTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.tupplesTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tupplesTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tupplesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tupplesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tupplesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lamda,
            this.mu,
            this.omega,
            this.k,
            this.p,
            this.c,
            this.a});
            this.tupplesTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tupplesTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.tupplesTable.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.tupplesTable.Location = new System.Drawing.Point(3, 16);
            this.tupplesTable.Name = "tupplesTable";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tupplesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.tupplesTable.RowHeadersWidth = 60;
            this.tupplesTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tupplesTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tupplesTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tupplesTable.Size = new System.Drawing.Size(681, 303);
            this.tupplesTable.TabIndex = 2;
            this.tupplesTable.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.TupplesTableCellBeginEdit);
            this.tupplesTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TupplesTableCellEndEdit);
            this.tupplesTable.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.TupplesTableUserAddedRow);
            this.tupplesTable.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.TupplesTableUserDeletedRow);
            // 
            // lamda
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N8";
            this.lamda.DefaultCellStyle = dataGridViewCellStyle2;
            this.lamda.HeaderText = "Интенсивность входного потока, λ";
            this.lamda.MaxInputLength = 16;
            this.lamda.Name = "lamda";
            this.lamda.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.lamda.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mu
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N8";
            this.mu.DefaultCellStyle = dataGridViewCellStyle3;
            this.mu.HeaderText = "Интенсивность обслуживания, μ";
            this.mu.MaxInputLength = 16;
            this.mu.Name = "mu";
            this.mu.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.mu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mu.Width = 90;
            // 
            // omega
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Format = "N8";
            dataGridViewCellStyle4.NullValue = null;
            this.omega.DefaultCellStyle = dataGridViewCellStyle4;
            this.omega.HeaderText = "Число занятых процессоров, ω";
            this.omega.MaxInputLength = 16;
            this.omega.Name = "omega";
            this.omega.ReadOnly = true;
            this.omega.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.omega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.omega.Width = 90;
            // 
            // k
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "D";
            this.k.DefaultCellStyle = dataGridViewCellStyle5;
            this.k.HeaderText = "Приоритет, k";
            this.k.MaxInputLength = 16;
            this.k.Name = "k";
            this.k.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.k.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.k.Width = 70;
            // 
            // p
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.Format = "N8";
            dataGridViewCellStyle6.NullValue = null;
            this.p.DefaultCellStyle = dataGridViewCellStyle6;
            this.p.HeaderText = "Вероятность приостановки обслуживания, P";
            this.p.MaxInputLength = 16;
            this.p.Name = "p";
            this.p.ReadOnly = true;
            this.p.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.p.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.p.Width = 90;
            // 
            // c
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.Format = "N8";
            dataGridViewCellStyle7.NullValue = null;
            this.c.DefaultCellStyle = dataGridViewCellStyle7;
            this.c.HeaderText = "Среднее число процессоров, C";
            this.c.MaxInputLength = 16;
            this.c.Name = "c";
            this.c.ReadOnly = true;
            this.c.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.c.Width = 90;
            // 
            // a
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Format = "N8";
            dataGridViewCellStyle8.NullValue = null;
            this.a.DefaultCellStyle = dataGridViewCellStyle8;
            this.a.HeaderText = "Пропускная способность, A";
            this.a.MaxInputLength = 16;
            this.a.Name = "a";
            this.a.ReadOnly = true;
            this.a.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.a.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.a.Width = 90;
            // 
            // groupBoxTupples
            // 
            this.groupBoxTupples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTupples.Controls.Add(this.tupplesTable);
            this.groupBoxTupples.Location = new System.Drawing.Point(12, 129);
            this.groupBoxTupples.Name = "groupBoxTupples";
            this.groupBoxTupples.Size = new System.Drawing.Size(687, 322);
            this.groupBoxTupples.TabIndex = 8;
            this.groupBoxTupples.TabStop = false;
            this.groupBoxTupples.Text = "Наборы";
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(162, 33);
            this.numericUpDownN.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDownN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDownN.Size = new System.Drawing.Size(59, 20);
            this.numericUpDownN.TabIndex = 7;
            this.numericUpDownN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownN.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // groupBoxCalculate
            // 
            this.groupBoxCalculate.Controls.Add(this.sumLabel);
            this.groupBoxCalculate.Controls.Add(this.buttonClear);
            this.groupBoxCalculate.Controls.Add(this.checkBoxOverGammaFunction);
            this.groupBoxCalculate.Controls.Add(this.buttonCalculate);
            this.groupBoxCalculate.Controls.Add(this.labelN);
            this.groupBoxCalculate.Controls.Add(this.numericUpDownN);
            this.groupBoxCalculate.Location = new System.Drawing.Point(12, 29);
            this.groupBoxCalculate.Name = "groupBoxCalculate";
            this.groupBoxCalculate.Size = new System.Drawing.Size(687, 94);
            this.groupBoxCalculate.TabIndex = 10;
            this.groupBoxCalculate.TabStop = false;
            this.groupBoxCalculate.Text = "Рассчёт";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Location = new System.Drawing.Point(90, 64);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(0, 13);
            this.sumLabel.TabIndex = 17;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 58);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 15;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClearClick);
            // 
            // checkBoxOverGammaFunction
            // 
            this.checkBoxOverGammaFunction.AutoSize = true;
            this.checkBoxOverGammaFunction.Location = new System.Drawing.Point(9, 16);
            this.checkBoxOverGammaFunction.Name = "checkBoxOverGammaFunction";
            this.checkBoxOverGammaFunction.Size = new System.Drawing.Size(311, 17);
            this.checkBoxOverGammaFunction.TabIndex = 14;
            this.checkBoxOverGammaFunction.Text = "Использовать гамма-функцию для расчёта факториала";
            this.checkBoxOverGammaFunction.UseVisualStyleBackColor = true;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(227, 32);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(86, 23);
            this.buttonCalculate.TabIndex = 12;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.ButtonCalculateClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.saveFileAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.openFileToolStripMenuItem.Text = "Открыть";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItemClick);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.saveFileToolStripMenuItem.Text = "Сохранить";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItemClick);
            // 
            // saveFileAsToolStripMenuItem
            // 
            this.saveFileAsToolStripMenuItem.Name = "saveFileAsToolStripMenuItem";
            this.saveFileAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.saveFileAsToolStripMenuItem.Text = "Сохранить как...";
            this.saveFileAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(231, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // commandToolStripMenuItem
            // 
            this.commandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculateToolStripMenuItem,
            this.clearTableToolStripMenuItem});
            this.commandToolStripMenuItem.Name = "commandToolStripMenuItem";
            this.commandToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.commandToolStripMenuItem.Text = "Команда";
            // 
            // calculateToolStripMenuItem
            // 
            this.calculateToolStripMenuItem.Name = "calculateToolStripMenuItem";
            this.calculateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.calculateToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.calculateToolStripMenuItem.Text = "Рассчитать";
            this.calculateToolStripMenuItem.Click += new System.EventHandler(this.CalculateToolStripMenuItemClick);
            // 
            // clearTableToolStripMenuItem
            // 
            this.clearTableToolStripMenuItem.Name = "clearTableToolStripMenuItem";
            this.clearTableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.clearTableToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.clearTableToolStripMenuItem.Text = "Очистить";
            this.clearTableToolStripMenuItem.Click += new System.EventHandler(this.ClearTableToolStripMenuItemClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "xml";
            this.openFileDialog.Filter = "Файлы расчётов МПС (*.xml)|*.xml";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "xml";
            this.saveFileDialog.FileName = "Файл расчёта МПС";
            this.saveFileDialog.Filter = "Файлы рассчётов МПС (*.xml)|*.xml";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 16);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(400, 400);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // groupBoxChart
            // 
            this.groupBoxChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxChart.Controls.Add(this.pictureBox);
            this.groupBoxChart.Location = new System.Drawing.Point(705, 29);
            this.groupBoxChart.Name = "groupBoxChart";
            this.groupBoxChart.Size = new System.Drawing.Size(406, 419);
            this.groupBoxChart.TabIndex = 13;
            this.groupBoxChart.TabStop = false;
            this.groupBoxChart.Text = "График";
            // 
            // MpsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 463);
            this.Controls.Add(this.groupBoxChart);
            this.Controls.Add(this.groupBoxCalculate);
            this.Controls.Add(this.groupBoxTupples);
            this.Controls.Add(this.menuStrip);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1140, 502);
            this.Name = "MpsForm";
            this.Text = "Расчёт модели МПС";
            this.Activated += new System.EventHandler(this.MpsFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MpsFormFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tupplesTable)).EndInit();
            this.groupBoxTupples.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            this.groupBoxCalculate.ResumeLayout(false);
            this.groupBoxCalculate.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxChart.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.DataGridView tupplesTable;
        private System.Windows.Forms.GroupBox groupBoxTupples;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.GroupBox groupBoxCalculate;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxOverGammaFunction;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox groupBoxChart;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn lamda;
        private System.Windows.Forms.DataGridViewTextBoxColumn mu;
        private System.Windows.Forms.DataGridViewTextBoxColumn omega;
        private System.Windows.Forms.DataGridViewTextBoxColumn k;
        private System.Windows.Forms.DataGridViewTextBoxColumn p;
        private System.Windows.Forms.DataGridViewTextBoxColumn c;
        private System.Windows.Forms.DataGridViewTextBoxColumn a;
    }
}

