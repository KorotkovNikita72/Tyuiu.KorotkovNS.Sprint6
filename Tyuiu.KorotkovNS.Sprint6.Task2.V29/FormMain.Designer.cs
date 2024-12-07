namespace Tyuiu.KorotkovNS.Sprint6.Task2.V29
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KNS = new GroupBox();
            textBoxTask_KNS = new TextBox();
            groupBoxZnach_KNS = new GroupBox();
            groupBoxEnd_KNS = new GroupBox();
            textBoxEnd_KNS = new TextBox();
            groupBoxStart_KNS = new GroupBox();
            textBoxStart_KNS = new TextBox();
            buttonHelp_KNS = new Button();
            buttonExecute_KNS = new Button();
            groupBoxResult_KNS = new GroupBox();
            chartFunction_KNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_KNS = new DataGridView();
            ColumnX_KNS = new DataGridViewTextBoxColumn();
            ColumnFX_KNS = new DataGridViewTextBoxColumn();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxZnach_KNS.SuspendLayout();
            groupBoxEnd_KNS.SuspendLayout();
            groupBoxStart_KNS.SuspendLayout();
            groupBoxResult_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Location = new Point(10, 9);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(489, 213);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Location = new Point(9, 27);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(474, 180);
            textBoxTask_KNS.TabIndex = 0;
            textBoxTask_KNS.Text = "Протабулировать функцию F(x) на заданном диапозоне. Результат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxZnach_KNS
            // 
            groupBoxZnach_KNS.Controls.Add(groupBoxEnd_KNS);
            groupBoxZnach_KNS.Controls.Add(groupBoxStart_KNS);
            groupBoxZnach_KNS.Location = new Point(12, 222);
            groupBoxZnach_KNS.Name = "groupBoxZnach_KNS";
            groupBoxZnach_KNS.Size = new Size(302, 83);
            groupBoxZnach_KNS.TabIndex = 1;
            groupBoxZnach_KNS.TabStop = false;
            groupBoxZnach_KNS.Text = "Ввод данных";
            // 
            // groupBoxEnd_KNS
            // 
            groupBoxEnd_KNS.Controls.Add(textBoxEnd_KNS);
            groupBoxEnd_KNS.Location = new Point(154, 19);
            groupBoxEnd_KNS.Name = "groupBoxEnd_KNS";
            groupBoxEnd_KNS.Size = new Size(141, 64);
            groupBoxEnd_KNS.TabIndex = 1;
            groupBoxEnd_KNS.TabStop = false;
            groupBoxEnd_KNS.Text = "Конец шага";
            // 
            // textBoxEnd_KNS
            // 
            textBoxEnd_KNS.Location = new Point(6, 26);
            textBoxEnd_KNS.Name = "textBoxEnd_KNS";
            textBoxEnd_KNS.Size = new Size(129, 27);
            textBoxEnd_KNS.TabIndex = 1;
            // 
            // groupBoxStart_KNS
            // 
            groupBoxStart_KNS.Controls.Add(textBoxStart_KNS);
            groupBoxStart_KNS.Location = new Point(7, 19);
            groupBoxStart_KNS.Name = "groupBoxStart_KNS";
            groupBoxStart_KNS.Size = new Size(141, 64);
            groupBoxStart_KNS.TabIndex = 0;
            groupBoxStart_KNS.TabStop = false;
            groupBoxStart_KNS.Text = "Старт шага";
            // 
            // textBoxStart_KNS
            // 
            textBoxStart_KNS.Location = new Point(6, 26);
            textBoxStart_KNS.Name = "textBoxStart_KNS";
            textBoxStart_KNS.Size = new Size(129, 27);
            textBoxStart_KNS.TabIndex = 0;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_KNS.Location = new Point(320, 228);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(87, 77);
            buttonHelp_KNS.TabIndex = 2;
            buttonHelp_KNS.Text = "Справка";
            buttonHelp_KNS.UseVisualStyleBackColor = false;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // buttonExecute_KNS
            // 
            buttonExecute_KNS.BackColor = Color.FromArgb(0, 192, 0);
            buttonExecute_KNS.Location = new Point(413, 228);
            buttonExecute_KNS.Name = "buttonExecute_KNS";
            buttonExecute_KNS.Size = new Size(96, 77);
            buttonExecute_KNS.TabIndex = 3;
            buttonExecute_KNS.Text = "Выполнить";
            buttonExecute_KNS.UseVisualStyleBackColor = false;
            buttonExecute_KNS.Click += buttonExecute_KNS_Click;
            // 
            // groupBoxResult_KNS
            // 
            groupBoxResult_KNS.Controls.Add(chartFunction_KNS);
            groupBoxResult_KNS.Controls.Add(dataGridViewFunction_KNS);
            groupBoxResult_KNS.Location = new Point(539, 9);
            groupBoxResult_KNS.Name = "groupBoxResult_KNS";
            groupBoxResult_KNS.Size = new Size(488, 341);
            groupBoxResult_KNS.TabIndex = 4;
            groupBoxResult_KNS.TabStop = false;
            groupBoxResult_KNS.Text = "Вывод данных. Результат";
            // 
            // chartFunction_KNS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KNS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KNS.Legends.Add(legend1);
            chartFunction_KNS.Location = new Point(165, 27);
            chartFunction_KNS.Name = "chartFunction_KNS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KNS.Series.Add(series1);
            chartFunction_KNS.Size = new Size(317, 309);
            chartFunction_KNS.TabIndex = 1;
            chartFunction_KNS.Text = "chartFunction";
            // 
            // dataGridViewFunction_KNS
            // 
            dataGridViewFunction_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KNS.Columns.AddRange(new DataGridViewColumn[] { ColumnX_KNS, ColumnFX_KNS });
            dataGridViewFunction_KNS.Location = new Point(6, 27);
            dataGridViewFunction_KNS.Name = "dataGridViewFunction_KNS";
            dataGridViewFunction_KNS.RowHeadersVisible = false;
            dataGridViewFunction_KNS.RowHeadersWidth = 60;
            dataGridViewFunction_KNS.Size = new Size(153, 305);
            dataGridViewFunction_KNS.TabIndex = 0;
            dataGridViewFunction_KNS.CellContentClick += dataGridViewFunction_KNS_CellContentClick;
            // 
            // ColumnX_KNS
            // 
            ColumnX_KNS.HeaderText = "X";
            ColumnX_KNS.MinimumWidth = 6;
            ColumnX_KNS.Name = "ColumnX_KNS";
            ColumnX_KNS.Width = 50;
            // 
            // ColumnFX_KNS
            // 
            ColumnFX_KNS.HeaderText = "F(x)";
            ColumnFX_KNS.MinimumWidth = 6;
            ColumnFX_KNS.Name = "ColumnFX_KNS";
            ColumnFX_KNS.Width = 60;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 353);
            Controls.Add(groupBoxResult_KNS);
            Controls.Add(buttonExecute_KNS);
            Controls.Add(buttonHelp_KNS);
            Controls.Add(groupBoxZnach_KNS);
            Controls.Add(groupBoxTask_KNS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 21 | Коротков Н.С.";
            Load += FormMain_Load;
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxZnach_KNS.ResumeLayout(false);
            groupBoxEnd_KNS.ResumeLayout(false);
            groupBoxEnd_KNS.PerformLayout();
            groupBoxStart_KNS.ResumeLayout(false);
            groupBoxStart_KNS.PerformLayout();
            groupBoxResult_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private TextBox textBoxTask_KNS;
        private GroupBox groupBoxZnach_KNS;
        private GroupBox groupBoxStart_KNS;
        private GroupBox groupBoxEnd_KNS;
        private TextBox textBoxEnd_KNS;
        private TextBox textBoxStart_KNS;
        private Button buttonHelp_KNS;
        private Button buttonExecute_KNS;
        private GroupBox groupBoxResult_KNS;
        private DataGridView dataGridViewFunction_KNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNS;
        private DataGridViewTextBoxColumn ColumnX_KNS;
        private DataGridViewTextBoxColumn ColumnFX_KNS;
    }
}
