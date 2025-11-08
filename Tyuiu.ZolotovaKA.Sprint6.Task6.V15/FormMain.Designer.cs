namespace Tyuiu.ZolotovaKA.Sprint6.Task6.V15
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox_ZKA = new System.Windows.Forms.GroupBox();
            this.buttonAbout_ZKA = new System.Windows.Forms.Button();
            this.buttonDone_ZKA = new System.Windows.Forms.Button();
            this.buttonOpenFile_ZKA = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxTask_ZKA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_ZKA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxOutPutData_ZKA = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_ZKA = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxResult_ZKA = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_ZKA = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.openFileDialog_ZKA = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_ZKA.SuspendLayout();
            this.groupBoxTask_ZKA.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxOutPutData_ZKA.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxResult_ZKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_ZKA
            // 
            this.groupBox_ZKA.Controls.Add(this.buttonAbout_ZKA);
            this.groupBox_ZKA.Controls.Add(this.buttonDone_ZKA);
            this.groupBox_ZKA.Controls.Add(this.buttonOpenFile_ZKA);
            this.groupBox_ZKA.Location = new System.Drawing.Point(0, 0);
            this.groupBox_ZKA.Name = "groupBox_ZKA";
            this.groupBox_ZKA.Size = new System.Drawing.Size(1673, 111);
            this.groupBox_ZKA.TabIndex = 0;
            this.groupBox_ZKA.TabStop = false;
            // 
            // buttonAbout_ZKA
            // 
           
            this.buttonAbout_ZKA.Location = new System.Drawing.Point(1536, 12);
            this.buttonAbout_ZKA.Name = "buttonAbout_ZKA";
            this.buttonAbout_ZKA.Size = new System.Drawing.Size(131, 93);
            this.buttonAbout_ZKA.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonAbout_ZKA, "Сведения о программе");
            this.buttonAbout_ZKA.UseVisualStyleBackColor = true;
            this.buttonAbout_ZKA.Click += new System.EventHandler(this.buttonAbout_ZKA_Click);
            // 
            // buttonDone_ZKA
            // 
            
            this.buttonDone_ZKA.Location = new System.Drawing.Point(172, 12);
            this.buttonDone_ZKA.Name = "buttonDone_ZKA";
            this.buttonDone_ZKA.Size = new System.Drawing.Size(138, 93);
            this.buttonDone_ZKA.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonDone_ZKA, "Происходит поиск в файле ");
            this.buttonDone_ZKA.UseVisualStyleBackColor = true;
            this.buttonDone_ZKA.Click += new System.EventHandler(this.buttonDone_ZKA_Click);
            // 
            // buttonOpenFile_ZKA
            // 
            
            this.buttonOpenFile_ZKA.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_ZKA.Name = "buttonOpenFile_ZKA";
            this.buttonOpenFile_ZKA.Size = new System.Drawing.Size(137, 93);
            this.buttonOpenFile_ZKA.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonOpenFile_ZKA, "Открыть файл\r\nВыбрать нужный файл для обработки\r\n");
            this.buttonOpenFile_ZKA.UseVisualStyleBackColor = true;
            this.buttonOpenFile_ZKA.Click += new System.EventHandler(this.buttonOpenFile_ZKA_Click);
            // 
            // groupBoxTask_ZKA
            // 
            this.groupBoxTask_ZKA.Controls.Add(this.textBoxTask_ZKA);
            this.groupBoxTask_ZKA.Location = new System.Drawing.Point(12, 117);
            this.groupBoxTask_ZKA.Name = "groupBoxTask_ZKA";
            this.groupBoxTask_ZKA.Size = new System.Drawing.Size(1655, 136);
            this.groupBoxTask_ZKA.TabIndex = 3;
            this.groupBoxTask_ZKA.TabStop = false;
            this.groupBoxTask_ZKA.Text = "Условие";
            // 
            // textBoxTask_ZKA
            // 
            this.textBoxTask_ZKA.Location = new System.Drawing.Point(6, 30);
            this.textBoxTask_ZKA.Multiline = true;
            this.textBoxTask_ZKA.Name = "textBoxTask_ZKA";
            this.textBoxTask_ZKA.ReadOnly = true;
            this.textBoxTask_ZKA.Size = new System.Drawing.Size(1629, 100);
            this.textBoxTask_ZKA.TabIndex = 2;
            this.textBoxTask_ZKA.Text = resources.GetString("textBoxTask_ZKA.Text");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxOutPutData_ZKA);
            this.panel1.Location = new System.Drawing.Point(12, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 507);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxOutPutData_ZKA
            // 
            this.groupBoxOutPutData_ZKA.Controls.Add(this.textBoxInPutData_ZKA);
            this.groupBoxOutPutData_ZKA.Location = new System.Drawing.Point(16, 16);
            this.groupBoxOutPutData_ZKA.Name = "groupBoxOutPutData_ZKA";
            this.groupBoxOutPutData_ZKA.Size = new System.Drawing.Size(784, 488);
            this.groupBoxOutPutData_ZKA.TabIndex = 1;
            this.groupBoxOutPutData_ZKA.TabStop = false;
            this.groupBoxOutPutData_ZKA.Text = "Ввод";
            // 
            // textBoxInPutData_ZKA
            // 
            this.textBoxInPutData_ZKA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxInPutData_ZKA.Location = new System.Drawing.Point(6, 46);
            this.textBoxInPutData_ZKA.Multiline = true;
            this.textBoxInPutData_ZKA.Name = "textBoxInPutData_ZKA";
            this.textBoxInPutData_ZKA.ReadOnly = true;
            this.textBoxInPutData_ZKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_ZKA.Size = new System.Drawing.Size(772, 436);
            this.textBoxInPutData_ZKA.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxResult_ZKA);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Location = new System.Drawing.Point(833, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 507);
            this.panel2.TabIndex = 0;
            // 
            // groupBoxResult_ZKA
            // 
            this.groupBoxResult_ZKA.Controls.Add(this.textBoxOutPutData_ZKA);
            this.groupBoxResult_ZKA.Location = new System.Drawing.Point(3, 16);
            this.groupBoxResult_ZKA.Name = "groupBoxResult_ZKA";
            this.groupBoxResult_ZKA.Size = new System.Drawing.Size(831, 472);
            this.groupBoxResult_ZKA.TabIndex = 0;
            this.groupBoxResult_ZKA.TabStop = false;
            this.groupBoxResult_ZKA.Text = "Вывод";
            // 
            // textBoxOutPutData_ZKA
            // 
            this.textBoxOutPutData_ZKA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxOutPutData_ZKA.Location = new System.Drawing.Point(6, 46);
            this.textBoxOutPutData_ZKA.Multiline = true;
            this.textBoxOutPutData_ZKA.Name = "textBoxOutPutData_ZKA";
            this.textBoxOutPutData_ZKA.ReadOnly = true;
            this.textBoxOutPutData_ZKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_ZKA.Size = new System.Drawing.Size(825, 426);
            this.textBoxOutPutData_ZKA.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 507);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // openFileDialog_ZKA
            // 
            this.openFileDialog_ZKA.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 778);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxTask_ZKA);
            this.Controls.Add(this.groupBox_ZKA);
            this.MinimumSize = new System.Drawing.Size(1711, 849);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 6 | Вариант 15 | Золотова К.А";
            this.groupBox_ZKA.ResumeLayout(false);
            this.groupBoxTask_ZKA.ResumeLayout(false);
            this.groupBoxTask_ZKA.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxOutPutData_ZKA.ResumeLayout(false);
            this.groupBoxOutPutData_ZKA.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxResult_ZKA.ResumeLayout(false);
            this.groupBoxResult_ZKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_ZKA;
        private System.Windows.Forms.Button buttonAbout_ZKA;
        private System.Windows.Forms.Button buttonDone_ZKA;
        private System.Windows.Forms.Button buttonOpenFile_ZKA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxTask_ZKA;
        private System.Windows.Forms.TextBox textBoxTask_ZKA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_ZKA;
        private System.Windows.Forms.TextBox textBoxInPutData_ZKA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxResult_ZKA;
        private System.Windows.Forms.TextBox textBoxOutPutData_ZKA;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ZKA;
    }
}
