namespace Tyuiu.KorotkovNS.Sprint6.Task6.V26
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_KNS = new GroupBox();
            textBoxTask_KNS = new TextBox();
            groupBoxButton_KNS = new GroupBox();
            buttonHelp_KNS = new Button();
            buttonSave_KNS = new Button();
            buttonOpen_KNS = new Button();
            groupBoxInput_KNS = new GroupBox();
            textBoxInput_KNS = new TextBox();
            groupBoxConclusion_KNS = new GroupBox();
            textBoxConclusion_KNS = new TextBox();
            openFileDialogTask_KNS = new OpenFileDialog();
            toolTip_KNS = new ToolTip(components);
            groupBoxTask_KNS.SuspendLayout();
            groupBoxButton_KNS.SuspendLayout();
            groupBoxInput_KNS.SuspendLayout();
            groupBoxConclusion_KNS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Dock = DockStyle.Top;
            groupBoxTask_KNS.Location = new Point(0, 0);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(800, 85);
            groupBoxTask_KNS.TabIndex = 0;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Dock = DockStyle.Top;
            textBoxTask_KNS.Font = new Font("Segoe UI", 9F);
            textBoxTask_KNS.Location = new Point(3, 23);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(794, 66);
            textBoxTask_KNS.TabIndex = 0;
            textBoxTask_KNS.Text = resources.GetString("textBoxTask_KNS.Text");
            // 
            // groupBoxButton_KNS
            // 
            groupBoxButton_KNS.Controls.Add(buttonHelp_KNS);
            groupBoxButton_KNS.Controls.Add(buttonSave_KNS);
            groupBoxButton_KNS.Controls.Add(buttonOpen_KNS);
            groupBoxButton_KNS.Dock = DockStyle.Top;
            groupBoxButton_KNS.Location = new Point(0, 85);
            groupBoxButton_KNS.Name = "groupBoxButton_KNS";
            groupBoxButton_KNS.Size = new Size(800, 77);
            groupBoxButton_KNS.TabIndex = 1;
            groupBoxButton_KNS.TabStop = false;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            buttonHelp_KNS.Location = new Point(657, 16);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(113, 55);
            buttonHelp_KNS.TabIndex = 0;
            buttonHelp_KNS.Text = "?";
            toolTip_KNS.SetToolTip(buttonHelp_KNS, "Сведение о приложение\r\n\r\n");
            buttonHelp_KNS.UseVisualStyleBackColor = true;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // buttonSave_KNS
            // 
            buttonSave_KNS.Image = Properties.Resources.ффффффффффффф;
            buttonSave_KNS.Location = new Point(125, 16);
            buttonSave_KNS.Name = "buttonSave_KNS";
            buttonSave_KNS.Size = new Size(113, 55);
            buttonSave_KNS.TabIndex = 0;
            buttonSave_KNS.UseVisualStyleBackColor = true;
            buttonSave_KNS.Click += buttonSave_KNS_Click;
            // 
            // buttonOpen_KNS
            // 
            buttonOpen_KNS.Image = Properties.Resources.sdsdsdsds;
            buttonOpen_KNS.Location = new Point(6, 16);
            buttonOpen_KNS.Name = "buttonOpen_KNS";
            buttonOpen_KNS.Size = new Size(113, 55);
            buttonOpen_KNS.TabIndex = 0;
            toolTip_KNS.SetToolTip(buttonOpen_KNS, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpen_KNS.UseVisualStyleBackColor = true;
            buttonOpen_KNS.Click += buttonOpen_KNS_Click;
            // 
            // groupBoxInput_KNS
            // 
            groupBoxInput_KNS.Controls.Add(textBoxInput_KNS);
            groupBoxInput_KNS.Dock = DockStyle.Left;
            groupBoxInput_KNS.Location = new Point(0, 162);
            groupBoxInput_KNS.Name = "groupBoxInput_KNS";
            groupBoxInput_KNS.Size = new Size(366, 288);
            groupBoxInput_KNS.TabIndex = 2;
            groupBoxInput_KNS.TabStop = false;
            groupBoxInput_KNS.Text = "Ввод";
            // 
            // textBoxInput_KNS
            // 
            textBoxInput_KNS.Dock = DockStyle.Left;
            textBoxInput_KNS.Location = new Point(3, 23);
            textBoxInput_KNS.Multiline = true;
            textBoxInput_KNS.Name = "textBoxInput_KNS";
            textBoxInput_KNS.ScrollBars = ScrollBars.Vertical;
            textBoxInput_KNS.Size = new Size(354, 262);
            textBoxInput_KNS.TabIndex = 0;
            // 
            // groupBoxConclusion_KNS
            // 
            groupBoxConclusion_KNS.Controls.Add(textBoxConclusion_KNS);
            groupBoxConclusion_KNS.Dock = DockStyle.Right;
            groupBoxConclusion_KNS.Location = new Point(434, 162);
            groupBoxConclusion_KNS.Name = "groupBoxConclusion_KNS";
            groupBoxConclusion_KNS.Size = new Size(366, 288);
            groupBoxConclusion_KNS.TabIndex = 2;
            groupBoxConclusion_KNS.TabStop = false;
            groupBoxConclusion_KNS.Text = "Вывод";
            // 
            // textBoxConclusion_KNS
            // 
            textBoxConclusion_KNS.Dock = DockStyle.Right;
            textBoxConclusion_KNS.Location = new Point(9, 23);
            textBoxConclusion_KNS.Multiline = true;
            textBoxConclusion_KNS.Name = "textBoxConclusion_KNS";
            textBoxConclusion_KNS.ScrollBars = ScrollBars.Vertical;
            textBoxConclusion_KNS.Size = new Size(354, 262);
            textBoxConclusion_KNS.TabIndex = 0;
            // 
            // openFileDialogTask_KNS
            // 
            openFileDialogTask_KNS.FileName = "openFileDialog1";
            // 
            // toolTip_KNS
            // 
            toolTip_KNS.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KNS.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxConclusion_KNS);
            Controls.Add(groupBoxInput_KNS);
            Controls.Add(groupBoxButton_KNS);
            Controls.Add(groupBoxTask_KNS);
            MinimumSize = new Size(818, 497);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 26 | Коротков Н.С.";
            Load += FormMain_Load;
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxButton_KNS.ResumeLayout(false);
            groupBoxInput_KNS.ResumeLayout(false);
            groupBoxInput_KNS.PerformLayout();
            groupBoxConclusion_KNS.ResumeLayout(false);
            groupBoxConclusion_KNS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KNS;
        private TextBox textBoxTask_KNS;
        private GroupBox groupBoxButton_KNS;
        private Button buttonHelp_KNS;
        private Button buttonSave_KNS;
        private Button buttonOpen_KNS;
        private GroupBox groupBoxInput_KNS;
        private TextBox textBoxInput_KNS;
        private GroupBox groupBoxConclusion_KNS;
        private TextBox textBoxConclusion_KNS;
        private ToolTip toolTip_KNS;
        private OpenFileDialog openFileDialogTask_KNS;
    }
}
