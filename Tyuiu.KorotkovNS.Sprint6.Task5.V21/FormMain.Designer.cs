namespace Tyuiu.KorotkovNS.Sprint6.Task5.V21
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
            buttonHelp_KNS = new Button();
            buttonOpen_KNS = new Button();
            buttonExecute_KNS = new Button();
            button1 = new Button();
            textBoxTask_KNS = new TextBox();
            groupBoxResult_KNS = new GroupBox();
            dataGridViewNums_KNS = new DataGridView();
            chartGraffic_KNS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxResult_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KNS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGraffic_KNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(buttonHelp_KNS);
            groupBoxTask_KNS.Controls.Add(buttonOpen_KNS);
            groupBoxTask_KNS.Controls.Add(buttonExecute_KNS);
            groupBoxTask_KNS.Controls.Add(button1);
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Dock = DockStyle.Top;
            groupBoxTask_KNS.Location = new Point(0, 0);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(1026, 98);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.BackColor = Color.FromArgb(255, 255, 128);
            buttonHelp_KNS.Location = new Point(858, 17);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(142, 75);
            buttonHelp_KNS.TabIndex = 2;
            buttonHelp_KNS.Text = "Справка";
            buttonHelp_KNS.UseVisualStyleBackColor = false;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // buttonOpen_KNS
            // 
            buttonOpen_KNS.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpen_KNS.Location = new Point(710, 17);
            buttonOpen_KNS.Name = "buttonOpen_KNS";
            buttonOpen_KNS.Size = new Size(142, 75);
            buttonOpen_KNS.TabIndex = 2;
            buttonOpen_KNS.Text = "Открыть файл";
            buttonOpen_KNS.UseVisualStyleBackColor = false;
            buttonOpen_KNS.Click += buttonOpen_KNS_Click;
            // 
            // buttonExecute_KNS
            // 
            buttonExecute_KNS.BackColor = Color.FromArgb(0, 192, 0);
            buttonExecute_KNS.Location = new Point(562, 17);
            buttonExecute_KNS.Name = "buttonExecute_KNS";
            buttonExecute_KNS.Size = new Size(142, 75);
            buttonExecute_KNS.TabIndex = 2;
            buttonExecute_KNS.Text = "Выполнить";
            buttonExecute_KNS.UseVisualStyleBackColor = false;
            buttonExecute_KNS.Click += buttonExecute_KNS_Click;
            // 
            // button1
            // 
            button1.Location = new Point(81, 143);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Location = new Point(6, 17);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(538, 75);
            textBoxTask_KNS.TabIndex = 0;
            textBoxTask_KNS.Text = "Прочитать данные из файла InPutFileTask5V21.txt. Вывести в dataGridView. Дан список из 20 чисел. Вывести все числа, кратные 3. Построить диаграмму по этим значениям.";
            // 
            // groupBoxResult_KNS
            // 
            groupBoxResult_KNS.Controls.Add(dataGridViewNums_KNS);
            groupBoxResult_KNS.Dock = DockStyle.Left;
            groupBoxResult_KNS.Location = new Point(0, 98);
            groupBoxResult_KNS.Name = "groupBoxResult_KNS";
            groupBoxResult_KNS.Size = new Size(250, 442);
            groupBoxResult_KNS.TabIndex = 1;
            groupBoxResult_KNS.TabStop = false;
            groupBoxResult_KNS.Text = "Вывод данных";
            // 
            // dataGridViewNums_KNS
            // 
            dataGridViewNums_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KNS.Dock = DockStyle.Left;
            dataGridViewNums_KNS.Location = new Point(3, 23);
            dataGridViewNums_KNS.Name = "dataGridViewNums_KNS";
            dataGridViewNums_KNS.RowHeadersWidth = 51;
            dataGridViewNums_KNS.ScrollBars = ScrollBars.Vertical;
            dataGridViewNums_KNS.Size = new Size(238, 416);
            dataGridViewNums_KNS.TabIndex = 0;
            // 
            // chartGraffic_KNS
            // 
            chartArea1.Name = "ChartArea1";
            chartGraffic_KNS.ChartAreas.Add(chartArea1);
            chartGraffic_KNS.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartGraffic_KNS.Legends.Add(legend1);
            chartGraffic_KNS.Location = new Point(250, 98);
            chartGraffic_KNS.Name = "chartGraffic_KNS";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartGraffic_KNS.Series.Add(series1);
            chartGraffic_KNS.Size = new Size(776, 442);
            chartGraffic_KNS.TabIndex = 2;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 540);
            Controls.Add(chartGraffic_KNS);
            Controls.Add(groupBoxResult_KNS);
            Controls.Add(groupBoxTask_KNS);
            MinimumSize = new Size(1044, 587);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 21 | Коротков Н.С.";
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxResult_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KNS).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGraffic_KNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private Button buttonHelp_KNS;
        private Button buttonOpen_KNS;
        private Button buttonExecute_KNS;
        private Button button1;
        private TextBox textBoxTask_KNS;
        private GroupBox groupBoxResult_KNS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraffic_KNS;
        private DataGridView dataGridViewNums_KNS;
    }
}
