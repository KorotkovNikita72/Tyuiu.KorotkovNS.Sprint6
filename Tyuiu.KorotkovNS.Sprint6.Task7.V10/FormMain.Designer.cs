namespace Tyuiu.KorotkovNS.Sprint6.Task7.V10
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
            groupBoxButton_KNS = new GroupBox();
            buttonHelp_KNS = new Button();
            buttonSave_KNS = new Button();
            buttonInput_KNS = new Button();
            buttonOpen_KNS = new Button();
            groupBoxTask_KNS = new GroupBox();
            textBoxTask_KNS = new TextBox();
            groupBoxInput_KNS = new GroupBox();
            dataGridViewInput_KNS = new DataGridView();
            groupBoxConclusion_KNS = new GroupBox();
            dataGridViewOutput_KNS = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogTask = new SaveFileDialog();
            groupBoxButton_KNS.SuspendLayout();
            groupBoxTask_KNS.SuspendLayout();
            groupBoxInput_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KNS).BeginInit();
            groupBoxConclusion_KNS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KNS).BeginInit();
            SuspendLayout();
            // 
            // groupBoxButton_KNS
            // 
            groupBoxButton_KNS.Controls.Add(buttonHelp_KNS);
            groupBoxButton_KNS.Controls.Add(buttonSave_KNS);
            groupBoxButton_KNS.Controls.Add(buttonInput_KNS);
            groupBoxButton_KNS.Controls.Add(buttonOpen_KNS);
            groupBoxButton_KNS.Dock = DockStyle.Top;
            groupBoxButton_KNS.Location = new Point(0, 0);
            groupBoxButton_KNS.Name = "groupBoxButton_KNS";
            groupBoxButton_KNS.Size = new Size(967, 87);
            groupBoxButton_KNS.TabIndex = 0;
            groupBoxButton_KNS.TabStop = false;
            // 
            // buttonHelp_KNS
            // 
            buttonHelp_KNS.FlatStyle = FlatStyle.Flat;
            buttonHelp_KNS.Image = Properties.Resources.help;
            buttonHelp_KNS.Location = new Point(840, 12);
            buttonHelp_KNS.Name = "buttonHelp_KNS";
            buttonHelp_KNS.Size = new Size(121, 69);
            buttonHelp_KNS.TabIndex = 0;
            buttonHelp_KNS.UseVisualStyleBackColor = true;
            buttonHelp_KNS.Click += buttonHelp_KNS_Click;
            // 
            // buttonSave_KNS
            // 
            buttonSave_KNS.FlatStyle = FlatStyle.Flat;
            buttonSave_KNS.Image = Properties.Resources.page_save;
            buttonSave_KNS.Location = new Point(266, 12);
            buttonSave_KNS.Name = "buttonSave_KNS";
            buttonSave_KNS.Size = new Size(121, 69);
            buttonSave_KNS.TabIndex = 0;
            buttonSave_KNS.UseVisualStyleBackColor = true;
            buttonSave_KNS.Click += buttonSave_KNS_Click;
            // 
            // buttonInput_KNS
            // 
            buttonInput_KNS.FlatStyle = FlatStyle.Flat;
            buttonInput_KNS.Image = Properties.Resources.page_go;
            buttonInput_KNS.Location = new Point(139, 12);
            buttonInput_KNS.Name = "buttonInput_KNS";
            buttonInput_KNS.Size = new Size(121, 69);
            buttonInput_KNS.TabIndex = 0;
            buttonInput_KNS.UseVisualStyleBackColor = true;
            buttonInput_KNS.Click += buttonInput_KNS_Click;
            // 
            // buttonOpen_KNS
            // 
            buttonOpen_KNS.FlatStyle = FlatStyle.Flat;
            buttonOpen_KNS.Image = Properties.Resources.folder_page;
            buttonOpen_KNS.Location = new Point(12, 12);
            buttonOpen_KNS.Name = "buttonOpen_KNS";
            buttonOpen_KNS.Size = new Size(121, 69);
            buttonOpen_KNS.TabIndex = 0;
            buttonOpen_KNS.UseVisualStyleBackColor = true;
            buttonOpen_KNS.Click += buttonOpen_KNS_Click;
            // 
            // groupBoxTask_KNS
            // 
            groupBoxTask_KNS.Controls.Add(textBoxTask_KNS);
            groupBoxTask_KNS.Dock = DockStyle.Top;
            groupBoxTask_KNS.Location = new Point(0, 87);
            groupBoxTask_KNS.Name = "groupBoxTask_KNS";
            groupBoxTask_KNS.Size = new Size(967, 116);
            groupBoxTask_KNS.TabIndex = 1;
            groupBoxTask_KNS.TabStop = false;
            groupBoxTask_KNS.Text = "Условие";
            // 
            // textBoxTask_KNS
            // 
            textBoxTask_KNS.Dock = DockStyle.Top;
            textBoxTask_KNS.Location = new Point(3, 23);
            textBoxTask_KNS.Multiline = true;
            textBoxTask_KNS.Name = "textBoxTask_KNS";
            textBoxTask_KNS.ReadOnly = true;
            textBoxTask_KNS.Size = new Size(961, 93);
            textBoxTask_KNS.TabIndex = 0;
            textBoxTask_KNS.Text = resources.GetString("textBoxTask_KNS.Text");
            // 
            // groupBoxInput_KNS
            // 
            groupBoxInput_KNS.Controls.Add(dataGridViewInput_KNS);
            groupBoxInput_KNS.Dock = DockStyle.Left;
            groupBoxInput_KNS.Location = new Point(0, 203);
            groupBoxInput_KNS.Name = "groupBoxInput_KNS";
            groupBoxInput_KNS.Size = new Size(465, 335);
            groupBoxInput_KNS.TabIndex = 2;
            groupBoxInput_KNS.TabStop = false;
            groupBoxInput_KNS.Text = "Ввод";
            // 
            // dataGridViewInput_KNS
            // 
            dataGridViewInput_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput_KNS.Dock = DockStyle.Left;
            dataGridViewInput_KNS.Location = new Point(3, 23);
            dataGridViewInput_KNS.Name = "dataGridViewInput_KNS";
            dataGridViewInput_KNS.RowHeadersWidth = 51;
            dataGridViewInput_KNS.Size = new Size(459, 309);
            dataGridViewInput_KNS.TabIndex = 0;
            // 
            // groupBoxConclusion_KNS
            // 
            groupBoxConclusion_KNS.Controls.Add(dataGridViewOutput_KNS);
            groupBoxConclusion_KNS.Dock = DockStyle.Right;
            groupBoxConclusion_KNS.Location = new Point(499, 203);
            groupBoxConclusion_KNS.Name = "groupBoxConclusion_KNS";
            groupBoxConclusion_KNS.Size = new Size(468, 335);
            groupBoxConclusion_KNS.TabIndex = 3;
            groupBoxConclusion_KNS.TabStop = false;
            groupBoxConclusion_KNS.Text = "Вывод";
            // 
            // dataGridViewOutput_KNS
            // 
            dataGridViewOutput_KNS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_KNS.Dock = DockStyle.Right;
            dataGridViewOutput_KNS.Location = new Point(3, 23);
            dataGridViewOutput_KNS.Name = "dataGridViewOutput_KNS";
            dataGridViewOutput_KNS.RowHeadersWidth = 51;
            dataGridViewOutput_KNS.Size = new Size(462, 309);
            dataGridViewOutput_KNS.TabIndex = 0;
            
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 538);
            Controls.Add(groupBoxConclusion_KNS);
            Controls.Add(groupBoxInput_KNS);
            Controls.Add(groupBoxTask_KNS);
            Controls.Add(groupBoxButton_KNS);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 10 | Коротков Н.С.";
            groupBoxButton_KNS.ResumeLayout(false);
            groupBoxTask_KNS.ResumeLayout(false);
            groupBoxTask_KNS.PerformLayout();
            groupBoxInput_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput_KNS).EndInit();
            groupBoxConclusion_KNS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_KNS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxButton_KNS;
        private GroupBox groupBoxTask_KNS;
        private GroupBox groupBoxInput_KNS;
        private GroupBox groupBoxConclusion_KNS;
        private Button buttonOpen_KNS;
        private TextBox textBoxTask_KNS;
        private Button buttonHelp_KNS;
        private Button buttonSave_KNS;
        private Button buttonInput_KNS;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogTask;
        private DataGridView dataGridViewInput_KNS;
        private DataGridView dataGridViewOutput_KNS;
    }
}
