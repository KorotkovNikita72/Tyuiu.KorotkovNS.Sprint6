namespace Tyuiu.KorotkovNS.Sprint6.Task0.V20
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
            textBoxTask_KNS = new TextBox();
            pictureBoxFormula_KNS = new PictureBox();
            groupBoxVar_KNS = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxVarX_KNS = new TextBox();
            groupBoxButton_KNS = new GroupBox();
            buttonHelp = new Button();
            buttonOtvet_KNS = new Button();
            textBoxOtvet = new TextBox();
            groupBoxTask_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KNS).BeginInit();
            groupBoxVar_KNS.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxButton_KNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Location = new Point(21, 26);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(456, 192);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Location = new Point(0, 26);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(506, 166);
            textBoxTask_KNS.TabIndex = 1;
            textBoxTask_KNS.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula_KNS
            // 
            pictureBoxFormula_KNS.Image = (Image)resources.GetObject("pictureBoxFormula_KNS.Image");
            pictureBoxFormula_KNS.Location = new Point(485, 36);
            pictureBoxFormula_KNS.Name = "pictureBoxFormula_KNS";
            pictureBoxFormula_KNS.Size = new Size(303, 162);
            pictureBoxFormula_KNS.TabIndex = 2;
            pictureBoxFormula_KNS.TabStop = false;
            pictureBoxFormula_KNS.Click += pictureBoxFormula_KNS_Click;
            // 
            // groupBoxVar_KNS
            // 
            groupBoxVar_KNS.Controls.Add(groupBox1);
            groupBoxVar_KNS.Location = new Point(21, 296);
            groupBoxVar_KNS.Name = "groupBoxVar_KNS";
            groupBoxVar_KNS.Size = new Size(432, 142);
            groupBoxVar_KNS.TabIndex = 3;
            groupBoxVar_KNS.TabStop = false;
            groupBoxVar_KNS.Text = "Ввод данных";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxVarX_KNS);
            groupBox1.Location = new Point(91, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 87);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Переменная X:";
            // 
            // textBoxVarX_KNS
            // 
            textBoxVarX_KNS.Location = new Point(59, 41);
            textBoxVarX_KNS.Name = "textBoxVarX_KNS";
            textBoxVarX_KNS.Size = new Size(125, 27);
            textBoxVarX_KNS.TabIndex = 0;
            textBoxVarX_KNS.KeyPress += textBoxVarX_KNS_KeyPress;
            // 
            // groupBoxButton_KNS
            // 
            groupBoxButton_KNS.Controls.Add(buttonHelp);
            groupBoxButton_KNS.Controls.Add(buttonOtvet_KNS);
            groupBoxButton_KNS.Controls.Add(textBoxOtvet);
            groupBoxButton_KNS.Location = new Point(518, 296);
            groupBoxButton_KNS.Name = "groupBoxButton_KNS";
            groupBoxButton_KNS.Size = new Size(247, 129);
            groupBoxButton_KNS.TabIndex = 4;
            groupBoxButton_KNS.TabStop = false;
            groupBoxButton_KNS.Text = "Вывод данных";
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(5, 80);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(49, 49);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonOtvet_KNS
            // 
            buttonOtvet_KNS.Location = new Point(60, 80);
            buttonOtvet_KNS.Name = "buttonOtvet_KNS";
            buttonOtvet_KNS.Size = new Size(129, 43);
            buttonOtvet_KNS.TabIndex = 1;
            buttonOtvet_KNS.Text = "Вычислить";
            buttonOtvet_KNS.UseVisualStyleBackColor = true;
            buttonOtvet_KNS.Click += buttonOtvet_KNS_Click;
            // 
            // textBoxOtvet
            // 
            textBoxOtvet.Location = new Point(60, 42);
            textBoxOtvet.Name = "textBoxOtvet";
            textBoxOtvet.ReadOnly = true;
            textBoxOtvet.Size = new Size(130, 27);
            textBoxOtvet.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxButton_KNS);
            Controls.Add(groupBoxVar_KNS);
            Controls.Add(pictureBoxFormula_KNS);
            Controls.Add(groupBoxTask_KNS);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 20 | Коротков Н.С.";
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KNS).EndInit();
            groupBoxVar_KNS.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxButton_KNS.ResumeLayout(false);
            groupBoxButton_KNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private TextBox textBoxTask_KNS;
        private PictureBox pictureBoxFormula_KNS;
        private GroupBox groupBoxVar_KNS;
        private TextBox textBoxVarX_KNS;
        private GroupBox groupBoxButton_KNS;
        private TextBox textBoxOtvet;
        private Button buttonOtvet_KNS;
        private GroupBox groupBox1;
        private Button buttonHelp;
    }
}
