namespace Tyuiu.ZolotovaKA.Sprint6.Task6.V15
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
            this.textBoxAbout_ZKA = new System.Windows.Forms.TextBox();
            this.buttonOk_ZKA = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_ZKA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZKA)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAbout_ZKA
            // 
            this.textBoxAbout_ZKA.Location = new System.Drawing.Point(233, 33);
            this.textBoxAbout_ZKA.Multiline = true;
            this.textBoxAbout_ZKA.Name = "textBoxAbout_ZKA";
            this.textBoxAbout_ZKA.ReadOnly = true;
            this.textBoxAbout_ZKA.Size = new System.Drawing.Size(555, 263);
            this.textBoxAbout_ZKA.TabIndex = 0;
            this.textBoxAbout_ZKA.Text = resources.GetString("textBoxAbout_ZKA.Text");
            // 
            // buttonOk_ZKA
            // 
            this.buttonOk_ZKA.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonOk_ZKA.Location = new System.Drawing.Point(647, 319);
            this.buttonOk_ZKA.Name = "buttonOk_ZKA";
            this.buttonOk_ZKA.Size = new System.Drawing.Size(130, 47);
            this.buttonOk_ZKA.TabIndex = 1;
            this.buttonOk_ZKA.Text = "Ок";
            this.buttonOk_ZKA.UseVisualStyleBackColor = false;
            this.buttonOk_ZKA.Click += new System.EventHandler(this.buttonOk_ZKA_Click);
            // 
            // pictureBoxAvatar_ZKA
            // 
            
            this.pictureBoxAvatar_ZKA.Location = new System.Drawing.Point(12, 59);
            this.pictureBoxAvatar_ZKA.Name = "pictureBoxAvatar_ZKA";
            this.pictureBoxAvatar_ZKA.Size = new System.Drawing.Size(197, 216);
            this.pictureBoxAvatar_ZKA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_ZKA.TabIndex = 2;
            this.pictureBoxAvatar_ZKA.TabStop = false;
       
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 378);
            this.Controls.Add(this.pictureBoxAvatar_ZKA);
            this.Controls.Add(this.buttonOk_ZKA);
            this.Controls.Add(this.textBoxAbout_ZKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_ZKA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAbout_ZKA;
        private System.Windows.Forms.Button buttonOk_ZKA;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_ZKA;
    }
}
