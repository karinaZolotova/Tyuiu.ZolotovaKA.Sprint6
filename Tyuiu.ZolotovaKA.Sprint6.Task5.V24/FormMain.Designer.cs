namespace Tyuiu.ZolotovaKA.Sprint6.Task5.V24
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_ZKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonOpen_ZKA = new Button();
            buttonHelp_ZKA = new Button();
            groupBoxTask_ZKA = new GroupBox();
            textBoxTask_ZKA = new TextBox();
            buttonDone_ZKA = new Button();
            panel2 = new Panel();
            groupBoxOutPut_ZKA = new GroupBox();
            dataGridView_ZKA = new DataGridView();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)chart_ZKA).BeginInit();
            panel1.SuspendLayout();
            groupBoxTask_ZKA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_ZKA).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_ZKA
            // 
            chartArea4.Name = "ChartArea1";
            chart_ZKA.ChartAreas.Add(chartArea4);
            chart_ZKA.Location = new Point(9, 11);
            chart_ZKA.Name = "chart_ZKA";
            chart_ZKA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            chart_ZKA.Series.Add(series4);
            chart_ZKA.Size = new Size(612, 295);
            chart_ZKA.TabIndex = 0;
            chart_ZKA.Text = "chart1";
            chart_ZKA.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonOpen_ZKA);
            panel1.Controls.Add(buttonHelp_ZKA);
            panel1.Controls.Add(groupBoxTask_ZKA);
            panel1.Controls.Add(buttonDone_ZKA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 100);
            panel1.TabIndex = 1;
            // 
            // buttonOpen_ZKA
            // 
            buttonOpen_ZKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_ZKA.BackColor = SystemColors.HotTrack;
            buttonOpen_ZKA.Location = new Point(655, 12);
            buttonOpen_ZKA.Name = "buttonOpen_ZKA";
            buttonOpen_ZKA.Size = new Size(81, 82);
            buttonOpen_ZKA.TabIndex = 11;
            buttonOpen_ZKA.Text = "Открыть файл";
            buttonOpen_ZKA.UseVisualStyleBackColor = false;
            buttonOpen_ZKA.Click += buttonOpen_Click;
            // 
            // buttonHelp_ZKA
            // 
            buttonHelp_ZKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZKA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_ZKA.Location = new Point(742, 12);
            buttonHelp_ZKA.Name = "buttonHelp_ZKA";
            buttonHelp_ZKA.Size = new Size(66, 82);
            buttonHelp_ZKA.TabIndex = 10;
            buttonHelp_ZKA.Text = "Справка";
            buttonHelp_ZKA.UseVisualStyleBackColor = false;
            buttonHelp_ZKA.Click += buttonHelp_Click;
            // 
            // groupBoxTask_ZKA
            // 
            groupBoxTask_ZKA.Controls.Add(textBoxTask_ZKA);
            groupBoxTask_ZKA.Location = new Point(3, 3);
            groupBoxTask_ZKA.Name = "groupBoxTask_ZKA";
            groupBoxTask_ZKA.Padding = new Padding(5);
            groupBoxTask_ZKA.Size = new Size(539, 91);
            groupBoxTask_ZKA.TabIndex = 0;
            groupBoxTask_ZKA.TabStop = false;
            groupBoxTask_ZKA.Text = "Условие:";
            // 
            // textBoxTask_ZKA
            // 
            textBoxTask_ZKA.BackColor = Color.White;
            textBoxTask_ZKA.BorderStyle = BorderStyle.None;
            textBoxTask_ZKA.Dock = DockStyle.Fill;
            textBoxTask_ZKA.Location = new Point(5, 21);
            textBoxTask_ZKA.Multiline = true;
            textBoxTask_ZKA.Name = "textBoxTask_ZKA";
            textBoxTask_ZKA.ReadOnly = true;
            textBoxTask_ZKA.Size = new Size(529, 65);
            textBoxTask_ZKA.TabIndex = 0;
            textBoxTask_ZKA.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView все элементы, равные 0. Построить диаграмму по этим значениям.\r\n\r\n\r\n";
            // 
            // buttonDone_ZKA
            // 
            buttonDone_ZKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_ZKA.BackColor = Color.Green;
            buttonDone_ZKA.Location = new Point(548, 12);
            buttonDone_ZKA.Name = "buttonDone_ZKA";
            buttonDone_ZKA.Size = new Size(101, 82);
            buttonDone_ZKA.TabIndex = 9;
            buttonDone_ZKA.Text = "Выполнить";
            buttonDone_ZKA.UseVisualStyleBackColor = false;
            buttonDone_ZKA.Click += buttonDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(groupBoxOutPut_ZKA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 311);
            panel2.TabIndex = 2;
            // 
            // groupBoxOutPut_ZKA
            // 
            groupBoxOutPut_ZKA.BackColor = Color.White;
            groupBoxOutPut_ZKA.Controls.Add(dataGridView_ZKA);
            groupBoxOutPut_ZKA.Dock = DockStyle.Fill;
            groupBoxOutPut_ZKA.Location = new Point(0, 0);
            groupBoxOutPut_ZKA.Name = "groupBoxOutPut_ZKA";
            groupBoxOutPut_ZKA.Padding = new Padding(5);
            groupBoxOutPut_ZKA.Size = new Size(200, 311);
            groupBoxOutPut_ZKA.TabIndex = 0;
            groupBoxOutPut_ZKA.TabStop = false;
            groupBoxOutPut_ZKA.Text = "Вывод данных:";
            // 
            // dataGridView_ZKA
            // 
            dataGridView_ZKA.AllowUserToAddRows = false;
            dataGridView_ZKA.AllowUserToDeleteRows = false;
            dataGridView_ZKA.AllowUserToResizeColumns = false;
            dataGridView_ZKA.AllowUserToResizeRows = false;
            dataGridView_ZKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_ZKA.ColumnHeadersVisible = false;
            dataGridView_ZKA.Dock = DockStyle.Fill;
            dataGridView_ZKA.Location = new Point(5, 21);
            dataGridView_ZKA.Name = "dataGridView_ZKA";
            dataGridView_ZKA.ReadOnly = true;
            dataGridView_ZKA.RowHeadersVisible = false;
            dataGridView_ZKA.Size = new Size(190, 285);
            dataGridView_ZKA.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_ZKA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 311);
            panel3.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(840, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 24 | Золотова К.А. ";
            ((System.ComponentModel.ISupportInitialize)chart_ZKA).EndInit();
            panel1.ResumeLayout(false);
            groupBoxTask_ZKA.ResumeLayout(false);
            groupBoxTask_ZKA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_ZKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_ZKA).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ZKA;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_ZKA;
        private GroupBox groupBoxOutPut_ZKA;
        private TextBox textBoxTask_ZKA;
        private Button buttonHelp_ZKA;
        private Button buttonDone_ZKA;
        private Button buttonOpen_ZKA;
        private DataGridView dataGridView_ZKA;
    }
}
