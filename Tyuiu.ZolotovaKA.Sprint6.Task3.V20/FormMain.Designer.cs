namespace Tyuiu.ZolotovaKA.Sprint6.Task3.V20
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
            this.dataGridViewMatixTask_ZKA = new System.Windows.Forms.DataGridView();
            this.textBoxСondition_ZKA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_ZKA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrixNew_ZKA = new System.Windows.Forms.DataGridView();
            this.buttonSpravka_ZKA = new System.Windows.Forms.Button();
            this.buttonClick_ZKA = new System.Windows.Forms.Button();
            this.groupBoxTask_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_ZKA)).BeginInit();
            this.groupBoxResult_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_ZKA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZKA
            // 
            this.groupBoxTask_ZKA.Controls.Add(this.dataGridViewMatixTask_ZKA);
            this.groupBoxTask_ZKA.Controls.Add(this.textBoxСondition_ZKA);
            this.groupBoxTask_ZKA.Location = new System.Drawing.Point(14, 13);
            this.groupBoxTask_ZKA.Name = "groupBoxTask_ZKA";
            this.groupBoxTask_ZKA.Size = new System.Drawing.Size(522, 319);
            this.groupBoxTask_ZKA.TabIndex = 0;
            this.groupBoxTask_ZKA.TabStop = false;
            this.groupBoxTask_ZKA.Text = "Условие";
            // 
            // dataGridViewMatixTask_ZKA
            // 
            this.dataGridViewMatixTask_ZKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatixTask_ZKA.ColumnHeadersVisible = false;
            this.dataGridViewMatixTask_ZKA.Location = new System.Drawing.Point(276, 23);
            this.dataGridViewMatixTask_ZKA.Name = "dataGridViewMatixTask_ZKA";
            this.dataGridViewMatixTask_ZKA.ReadOnly = true;
            this.dataGridViewMatixTask_ZKA.RowHeadersVisible = false;
            this.dataGridViewMatixTask_ZKA.Size = new System.Drawing.Size(240, 161);
            this.dataGridViewMatixTask_ZKA.TabIndex = 1;
            // 
            // textBoxСondition_ZKA
            // 
            this.textBoxСondition_ZKA.Location = new System.Drawing.Point(6, 19);
            this.textBoxСondition_ZKA.Multiline = true;
            this.textBoxСondition_ZKA.Name = "textBoxСondition_ZKA";
            this.textBoxСondition_ZKA.ReadOnly = true;
            this.textBoxСondition_ZKA.Size = new System.Drawing.Size(263, 294);
            this.textBoxСondition_ZKA.TabIndex = 0;
            this.textBoxСondition_ZKA.Text = "Дана матрица 5 на 5\r\n25  20  28  2    6\r\n19   9  18  -7  24\r\n21  16   5  -7  -8\r\n" +
    "30 -13  1  -15  2\r\n31   9  -3  -9 -18\r\nВыполнить сортировку по возрастанию в пер" +
    "вом столбце.\r\n";
            // 
            // groupBoxResult_ZKA
            // 
            this.groupBoxResult_ZKA.Controls.Add(this.dataGridViewMatrixNew_ZKA);
            this.groupBoxResult_ZKA.Location = new System.Drawing.Point(536, 13);
            this.groupBoxResult_ZKA.Name = "groupBoxResult_ZKA";
            this.groupBoxResult_ZKA.Size = new System.Drawing.Size(262, 190);
            this.groupBoxResult_ZKA.TabIndex = 1;
            this.groupBoxResult_ZKA.TabStop = false;
            this.groupBoxResult_ZKA.Text = "Вывод данных";
            // 
            // dataGridViewMatrixNew_ZKA
            // 
            this.dataGridViewMatrixNew_ZKA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrixNew_ZKA.ColumnHeadersVisible = false;
            this.dataGridViewMatrixNew_ZKA.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewMatrixNew_ZKA.Name = "dataGridViewMatrixNew_ZKA";
            this.dataGridViewMatrixNew_ZKA.ReadOnly = true;
            this.dataGridViewMatrixNew_ZKA.RowHeadersVisible = false;
            this.dataGridViewMatrixNew_ZKA.Size = new System.Drawing.Size(240, 160);
            this.dataGridViewMatrixNew_ZKA.TabIndex = 0;
            // 
            // buttonSpravka_ZKA
            // 
            this.buttonSpravka_ZKA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpravka_ZKA.Location = new System.Drawing.Point(542, 295);
            this.buttonSpravka_ZKA.Name = "buttonSpravka_ZKA";
            this.buttonSpravka_ZKA.Size = new System.Drawing.Size(41, 37);
            this.buttonSpravka_ZKA.TabIndex = 2;
            this.buttonSpravka_ZKA.Text = "?";
            this.buttonSpravka_ZKA.UseVisualStyleBackColor = true;
            this.buttonSpravka_ZKA.Click += new System.EventHandler(this.buttonSpravka_ZKA_Click);
            // 
            // buttonClick_ZKA
            // 
            this.buttonClick_ZKA.Location = new System.Drawing.Point(711, 295);
            this.buttonClick_ZKA.Name = "buttonClick_ZKA";
            this.buttonClick_ZKA.Size = new System.Drawing.Size(87, 37);
            this.buttonClick_ZKA.TabIndex = 3;
            this.buttonClick_ZKA.Text = "Выполнить";
            this.buttonClick_ZKA.UseVisualStyleBackColor = true;
            this.buttonClick_ZKA.Click += new System.EventHandler(this.buttonClick_ZKA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 338);
            this.Controls.Add(this.buttonClick_ZKA);
            this.Controls.Add(this.buttonSpravka_ZKA);
            this.Controls.Add(this.groupBoxResult_ZKA);
            this.Controls.Add(this.groupBoxTask_ZKA);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 1 | Золотова К.А";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ZKA.ResumeLayout(false);
            this.groupBoxTask_ZKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatixTask_ZKA)).EndInit();
            this.groupBoxResult_ZKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixNew_ZKA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZKA;
        private System.Windows.Forms.TextBox textBoxСondition_ZKA;
        private System.Windows.Forms.DataGridView dataGridViewMatixTask_ZKA;
        private System.Windows.Forms.GroupBox groupBoxResult_ZKA;
        private System.Windows.Forms.DataGridView dataGridViewMatrixNew_ZKA;
        private System.Windows.Forms.Button buttonSpravka_ZKA;
        private System.Windows.Forms.Button buttonClick_ZKA;
    }
}
