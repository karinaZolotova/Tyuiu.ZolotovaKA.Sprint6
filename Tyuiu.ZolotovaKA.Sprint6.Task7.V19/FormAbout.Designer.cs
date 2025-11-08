namespace Tyuiu.ZolotovaKA.Sprint6.Task7.V19
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
            pictureBoxIcon_ZKA = new PictureBox();
            buttonOK_ZKA = new Button();
            labelAbout_ZKA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_ZKA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxIcon_ZKA
            // 
      
            pictureBoxIcon_ZKA.Location = new Point(12, 13);
            pictureBoxIcon_ZKA.Name = "pictureBoxIcon_ZKA";
            pictureBoxIcon_ZKA.Size = new Size(180, 180);
            pictureBoxIcon_ZKA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIcon_ZKA.TabIndex = 0;
            pictureBoxIcon_ZKA.TabStop = false;
            // 
            // buttonOK_ZKA
            // 
            buttonOK_ZKA.Location = new Point(431, 169);
            buttonOK_ZKA.Name = "buttonOK_ZKA";
            buttonOK_ZKA.Size = new Size(75, 23);
            buttonOK_ZKA.TabIndex = 2;
            buttonOK_ZKA.Text = "ОК";
            buttonOK_ZKA.UseVisualStyleBackColor = true;
            buttonOK_ZKA.Click += buttonOK_ZKA_Click;
            // 
            // labelAbout_ZKA
            // 
            labelAbout_ZKA.AutoSize = true;
            labelAbout_ZKA.Location = new Point(203, 13);
            labelAbout_ZKA.Name = "labelAbout_ZKA";
            labelAbout_ZKA.Size = new Size(303, 135);
            labelAbout_ZKA.TabIndex = 3;
            labelAbout_ZKA.Text = resources.GetString("labelAbout_ZKA.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 204);
            Controls.Add(labelAbout_ZKA);
            Controls.Add(buttonOK_ZKA);
            Controls.Add(pictureBoxIcon_ZKA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon_ZKA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxIcon_ZKA;
        private Button buttonOK_ZKA;
        private Label labelAbout_ZKA;
    }
}
