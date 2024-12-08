namespace Tyuiu.KorotkovNS.Sprint6.Task4.V11
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_KNS = new GroupBox();
            buttonHelp_KNS = new Button();
            textBox1 = new TextBox();
            buttonSave_KNS = new Button();
            buttonExecute_KNS = new Button();
            groupBoxZnach_KNS = new GroupBox();
            groupBoxEnd_KNS = new GroupBox();
            textBoxEnd_KNS = new TextBox();
            groupBoxStart_KNS = new GroupBox();
            textBoxStart_KNS = new TextBox();
            chartFunction_KNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxResult_KNS = new GroupBox();
            textBoxResult_KNS = new TextBox();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxZnach_KNS.SuspendLayout();
            groupBoxEnd_KNS.SuspendLayout();
            groupBoxStart_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNS).BeginInit();
            groupBoxResult_KNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(buttonHelp_KNS);
            groupBoxTask_KNS.Controls.Add(textBox1);
            groupBoxTask_KNS.Controls.Add(buttonSave_KNS);
            groupBoxTask_KNS.Controls.Add(buttonExecute_KNS);
            groupBoxTask_KNS.Controls.Add(groupBoxZnach_KNS);
            groupBoxTask_KNS.Dock = DockStyle.Top;
            groupBoxTask_KNS.Location = new Point(0, 0);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(1068, 101);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            groupBoxTask_KNS.Enter += groupBoxTask_KNS_Enter;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.BackColor = Color.FromArgb(255, 255, 128);
            buttonHelp_KNS.Location = new Point(947, 18);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(96, 71);
            buttonHelp_KNS.TabIndex = 4;
            buttonHelp_KNS.Text = "Справка";
            buttonHelp_KNS.UseVisualStyleBackColor = false;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 8F);
            textBox1.Location = new Point(9, 23);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(428, 72);
            textBox1.TabIndex = 3;
            textBox1.Text = "Протабулировать функцию F(x) на заданном диапозоне от -5, до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V11.txt по нажатию кнопки.";
            // 
            // buttonSave_KNS
            // 
            buttonSave_KNS.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_KNS.Location = new Point(845, 18);
            buttonSave_KNS.Name = "buttonSave_KNS";
            buttonSave_KNS.Size = new Size(96, 71);
            buttonSave_KNS.TabIndex = 2;
            buttonSave_KNS.Text = "Сохранить";
            buttonSave_KNS.UseVisualStyleBackColor = false;
            buttonSave_KNS.Click += buttonSave_KNS_Click;
            // 
            // buttonExecute_KNS
            // 
            buttonExecute_KNS.BackColor = Color.FromArgb(0, 192, 0);
            buttonExecute_KNS.Location = new Point(743, 18);
            buttonExecute_KNS.Name = "buttonExecute_KNS";
            buttonExecute_KNS.Size = new Size(96, 71);
            buttonExecute_KNS.TabIndex = 1;
            buttonExecute_KNS.Text = "Выполнить";
            buttonExecute_KNS.UseVisualStyleBackColor = false;
            buttonExecute_KNS.Click += buttonExecute_KNS_Click;
            // 
            // groupBoxZnach_KNS
            // 
            groupBoxZnach_KNS.Controls.Add(groupBoxEnd_KNS);
            groupBoxZnach_KNS.Controls.Add(groupBoxStart_KNS);
            groupBoxZnach_KNS.Location = new Point(443, 0);
            groupBoxZnach_KNS.Name = "groupBoxZnach_KNS";
            groupBoxZnach_KNS.Size = new Size(294, 95);
            groupBoxZnach_KNS.TabIndex = 0;
            groupBoxZnach_KNS.TabStop = false;
            groupBoxZnach_KNS.Text = "Ввод данных";
            // 
            // groupBoxEnd_KNS
            // 
            groupBoxEnd_KNS.Controls.Add(textBoxEnd_KNS);
            groupBoxEnd_KNS.Location = new Point(156, 18);
            groupBoxEnd_KNS.Name = "groupBoxEnd_KNS";
            groupBoxEnd_KNS.Size = new Size(132, 77);
            groupBoxEnd_KNS.TabIndex = 1;
            groupBoxEnd_KNS.TabStop = false;
            groupBoxEnd_KNS.Text = "Конец шага";
            // 
            // textBoxEnd_KNS
            // 
            textBoxEnd_KNS.Location = new Point(6, 35);
            textBoxEnd_KNS.Name = "textBoxEnd_KNS";
            textBoxEnd_KNS.Size = new Size(120, 27);
            textBoxEnd_KNS.TabIndex = 1;
            // 
            // groupBoxStart_KNS
            // 
            groupBoxStart_KNS.Controls.Add(textBoxStart_KNS);
            groupBoxStart_KNS.Location = new Point(6, 18);
            groupBoxStart_KNS.Name = "groupBoxStart_KNS";
            groupBoxStart_KNS.Size = new Size(132, 77);
            groupBoxStart_KNS.TabIndex = 0;
            groupBoxStart_KNS.TabStop = false;
            groupBoxStart_KNS.Text = "Старт шага";
            // 
            // textBoxStart_KNS
            // 
            textBoxStart_KNS.Location = new Point(6, 35);
            textBoxStart_KNS.Name = "textBoxStart_KNS";
            textBoxStart_KNS.Size = new Size(120, 27);
            textBoxStart_KNS.TabIndex = 0;
            // 
            // chartFunction_KNS
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KNS.ChartAreas.Add(chartArea1);
            chartFunction_KNS.Dock = DockStyle.Right;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_KNS.Legends.Add(legend1);
            chartFunction_KNS.Location = new Point(253, 101);
            chartFunction_KNS.Name = "chartFunction_KNS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KNS.Series.Add(series1);
            chartFunction_KNS.Size = new Size(815, 451);
            chartFunction_KNS.TabIndex = 1;
            chartFunction_KNS.Text = "График функции F(x)";
            title1.Name = "TitleF(x)";
            title1.Text = "График функции F(x)";
            chartFunction_KNS.Titles.Add(title1);
            // 
            // groupBoxResult_KNS
            // 
            groupBoxResult_KNS.Controls.Add(textBoxResult_KNS);
            groupBoxResult_KNS.Dock = DockStyle.Left;
            groupBoxResult_KNS.Location = new Point(0, 101);
            groupBoxResult_KNS.Name = "groupBoxResult_KNS";
            groupBoxResult_KNS.Size = new Size(247, 451);
            groupBoxResult_KNS.TabIndex = 2;
            groupBoxResult_KNS.TabStop = false;
            groupBoxResult_KNS.Text = "Вывод";
            // 
            // textBoxResult_KNS
            // 
            textBoxResult_KNS.Dock = DockStyle.Left;
            textBoxResult_KNS.Location = new Point(3, 23);
            textBoxResult_KNS.Multiline = true;
            textBoxResult_KNS.Name = "textBoxResult_KNS";
            textBoxResult_KNS.ReadOnly = true;
            textBoxResult_KNS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KNS.Size = new Size(235, 425);
            textBoxResult_KNS.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 552);
            Controls.Add(groupBoxResult_KNS);
            Controls.Add(chartFunction_KNS);
            Controls.Add(groupBoxTask_KNS);
            MinimumSize = new Size(1086, 599);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 11 | Коротков Н.С.";
            Load += FormMain_Load;
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxZnach_KNS.ResumeLayout(false);
            groupBoxEnd_KNS.ResumeLayout(false);
            groupBoxEnd_KNS.PerformLayout();
            groupBoxStart_KNS.ResumeLayout(false);
            groupBoxStart_KNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KNS).EndInit();
            groupBoxResult_KNS.ResumeLayout(false);
            groupBoxResult_KNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private GroupBox groupBoxZnach_KNS;
        private GroupBox groupBoxEnd_KNS;
        private GroupBox groupBoxStart_KNS;
        private Button buttonExecute_KNS;
        private TextBox textBox1;
        private Button buttonSave_KNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KNS;
        private GroupBox groupBoxResult_KNS;
        private TextBox textBoxResult_KNS;
        private Button buttonHelp_KNS;
        private TextBox textBoxEnd_KNS;
        private TextBox textBoxStart_KNS;
    }
}
