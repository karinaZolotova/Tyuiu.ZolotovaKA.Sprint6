namespace Tyuiu.ZolotovaKA.Sprint6.Task1.V12
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
            this.groupBoxTask_ZKA = new System.Windows.Forms.GroupBox();
            this.groupBoxInPutData_ZKA = new System.Windows.Forms.GroupBox();
            this.groupBoxOutPutData_ZKA = new System.Windows.Forms.GroupBox();
            this.buttonSpravka_ZKA = new System.Windows.Forms.Button();
            this.buttonDone_ZKA = new System.Windows.Forms.Button();
            this.textBoxTask_ZKA = new System.Windows.Forms.TextBox();
            this.labelStart_ZKA = new System.Windows.Forms.Label();
            this.labelRes_ZKA = new System.Windows.Forms.Label();
            this.textBoxStartStep_ZKA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_ZKA = new System.Windows.Forms.TextBox();
            this.labelStop_ZKA = new System.Windows.Forms.Label();
            this.textBoxResult_ZKA = new System.Windows.Forms.TextBox();
            this.groupBoxTask_ZKA.SuspendLayout();
            this.groupBoxInPutData_ZKA.SuspendLayout();
            this.groupBoxOutPutData_ZKA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZKA
            // 
            this.groupBoxTask_ZKA.Controls.Add(this.textBoxTask_ZKA);
            this.groupBoxTask_ZKA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZKA.Name = "groupBoxTask_ZKA";
            this.groupBoxTask_ZKA.Size = new System.Drawing.Size(490, 218);
            this.groupBoxTask_ZKA.TabIndex = 0;
            this.groupBoxTask_ZKA.TabStop = false;
            this.groupBoxTask_ZKA.Text = "Условие";
            // 
            // groupBoxInPutData_ZKA
            // 
            this.groupBoxInPutData_ZKA.Controls.Add(this.labelStop_ZKA);
            this.groupBoxInPutData_ZKA.Controls.Add(this.textBoxStopStep_ZKA);
            this.groupBoxInPutData_ZKA.Controls.Add(this.textBoxStartStep_ZKA);
            this.groupBoxInPutData_ZKA.Controls.Add(this.labelStart_ZKA);
            this.groupBoxInPutData_ZKA.Location = new System.Drawing.Point(12, 236);
            this.groupBoxInPutData_ZKA.Name = "groupBoxInPutData_ZKA";
            this.groupBoxInPutData_ZKA.Size = new System.Drawing.Size(258, 68);
            this.groupBoxInPutData_ZKA.TabIndex = 1;
            this.groupBoxInPutData_ZKA.TabStop = false;
            this.groupBoxInPutData_ZKA.Text = "Ввод данных";
            // 
            // groupBoxOutPutData_ZKA
            // 
            this.groupBoxOutPutData_ZKA.Controls.Add(this.textBoxResult_ZKA);
            this.groupBoxOutPutData_ZKA.Controls.Add(this.labelRes_ZKA);
            this.groupBoxOutPutData_ZKA.Location = new System.Drawing.Point(508, 12);
            this.groupBoxOutPutData_ZKA.Name = "groupBoxOutPutData_ZKA";
            this.groupBoxOutPutData_ZKA.Size = new System.Drawing.Size(200, 292);
            this.groupBoxOutPutData_ZKA.TabIndex = 2;
            this.groupBoxOutPutData_ZKA.TabStop = false;
            this.groupBoxOutPutData_ZKA.Text = "Вывод данных";
            // 
            // buttonSpravka_ZKA
            // 
            this.buttonSpravka_ZKA.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSpravka_ZKA.Location = new System.Drawing.Point(276, 236);
            this.buttonSpravka_ZKA.Name = "buttonSpravka_ZKA";
            this.buttonSpravka_ZKA.Size = new System.Drawing.Size(85, 68);
            this.buttonSpravka_ZKA.TabIndex = 3;
            this.buttonSpravka_ZKA.Text = "Справка";
            this.buttonSpravka_ZKA.UseVisualStyleBackColor = false;
            this.buttonSpravka_ZKA.Click += new System.EventHandler(this.buttonSpravka_ZKA_Click);
            // 
            // buttonDone_ZKA
            // 
            this.buttonDone_ZKA.BackColor = System.Drawing.Color.Green;
            this.buttonDone_ZKA.Location = new System.Drawing.Point(367, 236);
            this.buttonDone_ZKA.Name = "buttonDone_ZKA";
            this.buttonDone_ZKA.Size = new System.Drawing.Size(135, 68);
            this.buttonDone_ZKA.TabIndex = 4;
            this.buttonDone_ZKA.Text = "Выполнить";
            this.buttonDone_ZKA.UseVisualStyleBackColor = false;
            this.buttonDone_ZKA.Click += new System.EventHandler(this.buttonDone_ZKA_Click);
            // 
            // textBoxTask_ZKA
            // 
            this.textBoxTask_ZKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_ZKA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_ZKA.Multiline = true;
            this.textBoxTask_ZKA.Name = "textBoxTask_ZKA";
            this.textBoxTask_ZKA.ReadOnly = true;
            this.textBoxTask_ZKA.Size = new System.Drawing.Size(477, 192);
            this.textBoxTask_ZKA.TabIndex = 0;
            this.textBoxTask_ZKA.Text = "Протабулировать функцию sin(x) + (cos(x) + 1)/(2 - x) + 2 * x на заданном диапозо" +
            "не.\r\nРезультат вывести в виде таблицы.";
            // 
            // labelStart_ZKA
            // 
            this.labelStart_ZKA.AutoSize = true;
            this.labelStart_ZKA.Location = new System.Drawing.Point(6, 16);
            this.labelStart_ZKA.Name = "labelStart_ZKA";
            this.labelStart_ZKA.Size = new System.Drawing.Size(67, 13);
            this.labelStart_ZKA.TabIndex = 0;
            this.labelStart_ZKA.Text = "Старт шага:";
            // 
            // labelRes_ZKA
            // 
            this.labelRes_ZKA.AutoSize = true;
            this.labelRes_ZKA.Location = new System.Drawing.Point(6, 16);
            this.labelRes_ZKA.Name = "labelRes_ZKA";
            this.labelRes_ZKA.Size = new System.Drawing.Size(62, 13);
            this.labelRes_ZKA.TabIndex = 0;
            this.labelRes_ZKA.Text = "Результат:";
            // 
            // textBoxStartStep_ZKA
            // 
            this.textBoxStartStep_ZKA.Location = new System.Drawing.Point(9, 32);
            this.textBoxStartStep_ZKA.Name = "textBoxStartStep_ZKA";
            this.textBoxStartStep_ZKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartStep_ZKA.TabIndex = 1;
            this.textBoxStartStep_ZKA.TextChanged += new System.EventHandler(this.textBoxStarStep_ZKA_TextChanged);
            // 
            // textBoxStopStep_ZKA
            // 
            this.textBoxStopStep_ZKA.Location = new System.Drawing.Point(132, 32);
            this.textBoxStopStep_ZKA.Name = "textBoxStopStep_ZKA";
            this.textBoxStopStep_ZKA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopStep_ZKA.TabIndex = 2;
            // 
            // labelStop_ZKA
            // 
            this.labelStop_ZKA.AutoSize = true;
            this.labelStop_ZKA.Location = new System.Drawing.Point(129, 16);
            this.labelStop_ZKA.Name = "labelStop_ZKA";
            this.labelStop_ZKA.Size = new System.Drawing.Size(69, 13);
            this.labelStop_ZKA.TabIndex = 3;
            this.labelStop_ZKA.Text = "Конец шага:";
            // 
            // textBoxResult_ZKA
            // 
            this.textBoxResult_ZKA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_ZKA.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBoxResult_ZKA.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult_ZKA.Multiline = true;
            this.textBoxResult_ZKA.Name = "textBoxResult_ZKA";
            this.textBoxResult_ZKA.ReadOnly = true;
            this.textBoxResult_ZKA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_ZKA.Size = new System.Drawing.Size(188, 254);
            this.textBoxResult_ZKA.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 316);
            this.Controls.Add(this.buttonDone_ZKA);
            this.Controls.Add(this.buttonSpravka_ZKA);
            this.Controls.Add(this.groupBoxOutPutData_ZKA);
            this.Controls.Add(this.groupBoxInPutData_ZKA);
            this.Controls.Add(this.groupBoxTask_ZKA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 12 | Золотова К.А.";
            this.groupBoxTask_ZKA.ResumeLayout(false);
            this.groupBoxTask_ZKA.PerformLayout();
            this.groupBoxInPutData_ZKA.ResumeLayout(false);
            this.groupBoxInPutData_ZKA.PerformLayout();
            this.groupBoxOutPutData_ZKA.ResumeLayout(false);
            this.groupBoxOutPutData_ZKA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZKA;
        private System.Windows.Forms.TextBox textBoxTask_ZKA;
        private System.Windows.Forms.GroupBox groupBoxInPutData_ZKA;
        private System.Windows.Forms.Label labelStop_ZKA;
        private System.Windows.Forms.TextBox textBoxStopStep_ZKA;
        private System.Windows.Forms.TextBox textBoxStartStep_ZKA;
        private System.Windows.Forms.Label labelStart_ZKA;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_ZKA;
        private System.Windows.Forms.Label labelRes_ZKA;
        private System.Windows.Forms.Button buttonSpravka_ZKA;
        private System.Windows.Forms.Button buttonDone_ZKA;
        private System.Windows.Forms.TextBox textBoxResult_ZKA;
    }
}