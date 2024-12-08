
namespace Tyuiu.KorotkovNS.Sprint6.Task3.V8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_KNS = new GroupBox();
            buttoneExecute_KNS = new Button();
            groupBoxResultOtvet_KNS = new GroupBox();
            dataGridViewMatrix_KNS = new DataGridView();
            buttonHelp_KNS = new Button();
            textBox1 = new TextBox();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxResultOtvet_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(buttoneExecute_KNS);
            groupBoxTask_KNS.Controls.Add(groupBoxResultOtvet_KNS);
            groupBoxTask_KNS.Controls.Add(buttonHelp_KNS);
            groupBoxTask_KNS.Controls.Add(textBox1);
            groupBoxTask_KNS.Location = new Point(12, 12);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(536, 426);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // buttoneExecute_KNS
            // 
            buttoneExecute_KNS.Location = new Point(375, 319);
            buttoneExecute_KNS.Name = "buttoneExecute_KNS";
            buttoneExecute_KNS.Size = new Size(146, 69);
            buttoneExecute_KNS.TabIndex = 3;
            buttoneExecute_KNS.Text = "Выполнить";
            buttoneExecute_KNS.UseVisualStyleBackColor = true;
            buttoneExecute_KNS.Click += buttonExecute_KNS_Click;
            // 
            // groupBoxResultOtvet_KNS
            // 
            groupBoxResultOtvet_KNS.Controls.Add(dataGridViewMatrix_KNS);
            groupBoxResultOtvet_KNS.Location = new Point(264, 0);
            groupBoxResultOtvet_KNS.Name = "groupBoxResultOtvet_KNS";
            groupBoxResultOtvet_KNS.Size = new Size(272, 293);
            groupBoxResultOtvet_KNS.TabIndex = 0;
            groupBoxResultOtvet_KNS.TabStop = false;
            groupBoxResultOtvet_KNS.Text = "Результат";
            // 
            // dataGridViewMatrix_KNS
            // 
            dataGridViewMatrix_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_KNS.Location = new Point(0, 26);
            dataGridViewMatrix_KNS.Name = "dataGridViewMatrix_KNS";
            dataGridViewMatrix_KNS.RowHeadersWidth = 51;
            dataGridViewMatrix_KNS.Size = new Size(272, 267);
            dataGridViewMatrix_KNS.TabIndex = 2;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.Font = new Font("Segoe UI", 15F);
            buttonHelp_KNS.Location = new Point(264, 319);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(86, 69);
            buttonHelp_KNS.TabIndex = 1;
            buttonHelp_KNS.Text = "?";
            buttonHelp_KNS.UseVisualStyleBackColor = true;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(252, 267);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 450);
            Controls.Add(groupBoxTask_KNS);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 8 | Коротков Н.С.";
            Load += FormMain_Load;
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxResultOtvet_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KNS).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBoxTask_KNS;
        private TextBox textBox1;
        private GroupBox groupBoxResultOtvet_KNS;
        private DataGridView dataGridViewMatrix_KNS;
        private Button buttoneExecute_KNS;
        private Button buttonHelp_KNS;
    }
}
