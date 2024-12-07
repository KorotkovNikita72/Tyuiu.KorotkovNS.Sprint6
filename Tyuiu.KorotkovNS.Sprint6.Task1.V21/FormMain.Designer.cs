namespace Tyuiu.KorotkovNS.Sprint6.Task1.V21
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
            groupBoxTask_KNS = new GroupBox();
            textBoxTask_KNS = new TextBox();
            groupBoxZnach_KNS = new GroupBox();
            groupBoxEnd_KNS = new GroupBox();
            textBoxEnd_KNS = new TextBox();
            groupBoxStart_KNS = new GroupBox();
            textBoxStart_KNS = new TextBox();
            groupBoxResult_KNS = new GroupBox();
            textBoxResult_KNS = new TextBox();
            buttonHelp_KNS = new Button();
            buttonExecute_KNS = new Button();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxZnach_KNS.SuspendLayout();
            groupBoxEnd_KNS.SuspendLayout();
            groupBoxStart_KNS.SuspendLayout();
            groupBoxResult_KNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Location = new Point(12, 12);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(417, 243);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            groupBoxTask_KNS.Enter += groupBox1_Enter;
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Location = new Point(6, 26);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(405, 211);
            textBoxTask_KNS.TabIndex = 0;
            textBoxTask_KNS.Text = "Протабулировать значение функции F(x) на заданном диапозоне. Результат вывести в виде таблицы.";
            // 
            // groupBoxZnach_KNS
            // 
            groupBoxZnach_KNS.Controls.Add(groupBoxEnd_KNS);
            groupBoxZnach_KNS.Controls.Add(groupBoxStart_KNS);
            groupBoxZnach_KNS.Location = new Point(12, 313);
            groupBoxZnach_KNS.Name = "groupBoxZnach_KNS";
            groupBoxZnach_KNS.Size = new Size(368, 125);
            groupBoxZnach_KNS.TabIndex = 1;
            groupBoxZnach_KNS.TabStop = false;
            groupBoxZnach_KNS.Text = "Ввод данных";
            // 
            // groupBoxEnd_KNS
            // 
            groupBoxEnd_KNS.Controls.Add(textBoxEnd_KNS);
            groupBoxEnd_KNS.Location = new Point(191, 26);
            groupBoxEnd_KNS.Name = "groupBoxEnd_KNS";
            groupBoxEnd_KNS.Size = new Size(179, 93);
            groupBoxEnd_KNS.TabIndex = 1;
            groupBoxEnd_KNS.TabStop = false;
            groupBoxEnd_KNS.Text = "Конец шага";
            // 
            // textBoxEnd_KNS
            // 
            textBoxEnd_KNS.Location = new Point(6, 43);
            textBoxEnd_KNS.Name = "textBoxEnd_KNS";
            textBoxEnd_KNS.Size = new Size(167, 27);
            textBoxEnd_KNS.TabIndex = 1;
            // 
            // groupBoxStart_KNS
            // 
            groupBoxStart_KNS.Controls.Add(textBoxStart_KNS);
            groupBoxStart_KNS.Location = new Point(6, 26);
            groupBoxStart_KNS.Name = "groupBoxStart_KNS";
            groupBoxStart_KNS.Size = new Size(179, 93);
            groupBoxStart_KNS.TabIndex = 0;
            groupBoxStart_KNS.TabStop = false;
            groupBoxStart_KNS.Text = "Старт шага";
            // 
            // textBoxStart_KNS
            // 
            textBoxStart_KNS.Location = new Point(6, 43);
            textBoxStart_KNS.Name = "textBoxStart_KNS";
            textBoxStart_KNS.Size = new Size(167, 27);
            textBoxStart_KNS.TabIndex = 0;
            // 
            // groupBoxResult_KNS
            // 
            groupBoxResult_KNS.Controls.Add(textBoxResult_KNS);
            groupBoxResult_KNS.Location = new Point(492, 12);
            groupBoxResult_KNS.Name = "groupBoxResult_KNS";
            groupBoxResult_KNS.Size = new Size(296, 420);
            groupBoxResult_KNS.TabIndex = 2;
            groupBoxResult_KNS.TabStop = false;
            groupBoxResult_KNS.Text = "Вывод данных. Результат";
            // 
            // textBoxResult_KNS
            // 
            textBoxResult_KNS.Font = new Font("Consolas", 10F);
            textBoxResult_KNS.Location = new Point(6, 26);
            textBoxResult_KNS.Multiline = true;
            textBoxResult_KNS.Name = "textBoxResult_KNS";
            textBoxResult_KNS.ReadOnly = true;
            textBoxResult_KNS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KNS.Size = new Size(284, 388);
            textBoxResult_KNS.TabIndex = 0;
            textBoxResult_KNS.TextChanged += textBoxResult_KNS_TextChanged;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.BackColor = SystemColors.Highlight;
            buttonHelp_KNS.Location = new Point(388, 275);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(89, 73);
            buttonHelp_KNS.TabIndex = 3;
            buttonHelp_KNS.Text = "Справка";
            buttonHelp_KNS.UseVisualStyleBackColor = false;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // buttonExecute_KNS
            // 
            buttonExecute_KNS.BackColor = Color.FromArgb(0, 192, 0);
            buttonExecute_KNS.Location = new Point(382, 354);
            buttonExecute_KNS.Name = "buttonExecute_KNS";
            buttonExecute_KNS.Size = new Size(104, 73);
            buttonExecute_KNS.TabIndex = 4;
            buttonExecute_KNS.Text = "Выполнить";
            buttonExecute_KNS.UseVisualStyleBackColor = false;
            buttonExecute_KNS.Click += buttonExecute_KNS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExecute_KNS);
            Controls.Add(buttonHelp_KNS);
            Controls.Add(groupBoxResult_KNS);
            Controls.Add(groupBoxZnach_KNS);
            Controls.Add(groupBoxTask_KNS);
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
            groupBoxResult_KNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private TextBox textBoxTask_KNS;
        private GroupBox groupBoxZnach_KNS;
        private GroupBox groupBoxEnd_KNS;
        private GroupBox groupBoxStart_KNS;
        private TextBox textBoxEnd_KNS;
        private TextBox textBoxStart_KNS;
        private GroupBox groupBoxResult_KNS;
        private TextBox textBoxResult_KNS;
        private Button buttonHelp_KNS;
        private Button buttonExecute_KNS;
    }
}
