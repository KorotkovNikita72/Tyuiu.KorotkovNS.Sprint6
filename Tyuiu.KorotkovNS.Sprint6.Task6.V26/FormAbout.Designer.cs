namespace Tyuiu.KorotkovNS.Sprint6.Task6.V26
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KNS = new PictureBox();
            textBoxInfo_KNS = new TextBox();
            buttonOk_KNS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KNS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KNS
            // 
            pictureBoxAvatar_KNS.Image = Properties.Resources.dwdwdwdwd;
            pictureBoxAvatar_KNS.Location = new Point(12, 12);
            pictureBoxAvatar_KNS.Name = "pictureBoxAvatar_KNS";
            pictureBoxAvatar_KNS.Size = new Size(184, 242);
            pictureBoxAvatar_KNS.TabIndex = 0;
            pictureBoxAvatar_KNS.TabStop = false;
            // 
            // textBoxInfo_KNS
            // 
            textBoxInfo_KNS.Location = new Point(224, 12);
            textBoxInfo_KNS.Multiline = true;
            textBoxInfo_KNS.Name = "textBoxInfo_KNS";
            textBoxInfo_KNS.ReadOnly = true;
            textBoxInfo_KNS.Size = new Size(456, 197);
            textBoxInfo_KNS.TabIndex = 1;
            textBoxInfo_KNS.Text = resources.GetString("textBoxInfo_KNS.Text");
            // 
            // buttonOk_KNS
            // 
            buttonOk_KNS.Location = new Point(563, 215);
            buttonOk_KNS.Name = "buttonOk_KNS";
            buttonOk_KNS.Size = new Size(117, 39);
            buttonOk_KNS.TabIndex = 2;
            buttonOk_KNS.Text = "ОК";
            buttonOk_KNS.UseVisualStyleBackColor = true;
            buttonOk_KNS.Click += buttonOk_KNS_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 266);
            Controls.Add(buttonOk_KNS);
            Controls.Add(textBoxInfo_KNS);
            Controls.Add(pictureBoxAvatar_KNS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MaximumSize = new Size(725, 313);
            MinimizeBox = false;
            MinimumSize = new Size(725, 313);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KNS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KNS;
        private TextBox textBoxInfo_KNS;
        private Button buttonOk_KNS;
    }
}