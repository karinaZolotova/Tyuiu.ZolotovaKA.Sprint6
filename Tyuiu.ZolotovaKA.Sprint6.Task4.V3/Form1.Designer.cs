using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.ZolotovaKA.Sprint6.Task4.V3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUsl_ZKA = new GroupBox();
            labelUsl_ZKA = new Label();
            groupBoxVV_ZKA = new GroupBox();
            textBoxStop_ZKA = new TextBox();
            textBoxStart_ZKA = new TextBox();
            labelЫStop_ZKA = new Label();
            labelStart_ZKA = new Label();
            buttonDone_ZKA = new Button();
            buttonSoxr_ZKA = new Button();
            buttonSpravka_ZKA = new Button();
            groupBoxVivod_ZKA = new GroupBox();
            textBoxRes_ZKA = new TextBox();
            label1 = new Label();
            chartsin_ZKA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUsl_ZKA.SuspendLayout();
            groupBoxVV_ZKA.SuspendLayout();
            groupBoxVivod_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_ZKA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUsl_ZKA
            // 
            groupBoxUsl_ZKA.Controls.Add(labelUsl_ZKA);
            groupBoxUsl_ZKA.Location = new Point(12, 3);
            groupBoxUsl_ZKA.Name = "groupBoxUsl_ZKA";
            groupBoxUsl_ZKA.Size = new Size(303, 135);
            groupBoxUsl_ZKA.TabIndex = 0;
            groupBoxUsl_ZKA.TabStop = false;
            groupBoxUsl_ZKA.Text = "Условие";
            // 
            // labelUsl_ZKA
            // 
            labelUsl_ZKA.AutoSize = true;
            labelUsl_ZKA.Location = new Point(6, 23);
            labelUsl_ZKA.Name = "labelUsl_ZKA";
            labelUsl_ZKA.Size = new Size(294, 100);
            labelUsl_ZKA.TabIndex = 0;
            labelUsl_ZKA.Text = "Протабулировать функцию sin(x) \r\nна заданном диапозоне от -5 до 5.\r\nРезультат вывести в textBook, построить \r\nграфик функции и сохранить в файл\r\nOutPutFileTask.txt по нажатию кнопки\r\n";
            // 
            // groupBoxVV_ZKA
            // 
            groupBoxVV_ZKA.Controls.Add(textBoxStop_ZKA);
            groupBoxVV_ZKA.Controls.Add(textBoxStart_ZKA);
            groupBoxVV_ZKA.Controls.Add(labelЫStop_ZKA);
            groupBoxVV_ZKA.Controls.Add(labelStart_ZKA);
            groupBoxVV_ZKA.Location = new Point(333, 12);
            groupBoxVV_ZKA.Name = "groupBoxVV_ZKA";
            groupBoxVV_ZKA.Size = new Size(201, 126);
            groupBoxVV_ZKA.TabIndex = 1;
            groupBoxVV_ZKA.TabStop = false;
            groupBoxVV_ZKA.Text = "Ввод данных";
            // 
            // textBoxStop_ZKA
            // 
            textBoxStop_ZKA.Location = new Point(102, 55);
            textBoxStop_ZKA.Name = "textBoxStop_ZKA";
            textBoxStop_ZKA.Size = new Size(66, 27);
            textBoxStop_ZKA.TabIndex = 3;
            // 
            // textBoxStart_ZKA
            // 
            textBoxStart_ZKA.Location = new Point(16, 55);
            textBoxStart_ZKA.Name = "textBoxStart_ZKA";
            textBoxStart_ZKA.Size = new Size(66, 27);
            textBoxStart_ZKA.TabIndex = 2;
            // 
            // labelЫStop_ZKA
            // 
            labelЫStop_ZKA.AutoSize = true;
            labelЫStop_ZKA.Location = new Point(97, 32);
            labelЫStop_ZKA.Name = "labelЫStop_ZKA";
            labelЫStop_ZKA.Size = new Size(91, 20);
            labelЫStop_ZKA.TabIndex = 1;
            labelЫStop_ZKA.Text = "Конец шага";
            // 
            // labelStart_ZKA
            // 
            labelStart_ZKA.AutoSize = true;
            labelStart_ZKA.Location = new Point(6, 32);
            labelStart_ZKA.Name = "labelStart_ZKA";
            labelStart_ZKA.Size = new Size(85, 20);
            labelStart_ZKA.TabIndex = 0;
            labelStart_ZKA.Text = "Старт шага";
            // 
            // buttonDone_ZKA
            // 
            buttonDone_ZKA.BackColor = SystemColors.ActiveCaption;
            buttonDone_ZKA.Location = new Point(540, 24);
            buttonDone_ZKA.Name = "buttonDone_ZKA";
            buttonDone_ZKA.Size = new Size(104, 112);
            buttonDone_ZKA.TabIndex = 2;
            buttonDone_ZKA.Text = "Выполнить";
            buttonDone_ZKA.UseVisualStyleBackColor = false;
            buttonDone_ZKA.Click += buttonDone_ZKA_Click;
            // 
            // buttonSoxr_ZKA
            // 
            buttonSoxr_ZKA.BackColor = SystemColors.HotTrack;
            buttonSoxr_ZKA.Location = new Point(650, 24);
            buttonSoxr_ZKA.Name = "buttonSoxr_ZKA";
            buttonSoxr_ZKA.Size = new Size(102, 112);
            buttonSoxr_ZKA.TabIndex = 3;
            buttonSoxr_ZKA.Text = "Сохранить";
            buttonSoxr_ZKA.UseVisualStyleBackColor = false;
            buttonSoxr_ZKA.Click += buttonSoxr_ZKA_Click;
            // 
            // buttonSpravka_ZKA
            // 
            buttonSpravka_ZKA.BackColor = SystemColors.Desktop;
            buttonSpravka_ZKA.Location = new Point(853, 24);
            buttonSpravka_ZKA.Name = "buttonSpravka_ZKA";
            buttonSpravka_ZKA.Size = new Size(94, 112);
            buttonSpravka_ZKA.TabIndex = 4;
            buttonSpravka_ZKA.Text = "Справка";
            buttonSpravka_ZKA.UseVisualStyleBackColor = false;
            buttonSpravka_ZKA.Click += buttonSpravka_ZKA_Click;
            // 
            // groupBoxVivod_ZKA
            // 
            groupBoxVivod_ZKA.Controls.Add(textBoxRes_ZKA);
            groupBoxVivod_ZKA.Controls.Add(label1);
            groupBoxVivod_ZKA.Location = new Point(12, 144);
            groupBoxVivod_ZKA.Name = "groupBoxVivod_ZKA";
            groupBoxVivod_ZKA.Size = new Size(250, 412);
            groupBoxVivod_ZKA.TabIndex = 5;
            groupBoxVivod_ZKA.TabStop = false;
            groupBoxVivod_ZKA.Text = "Вывод";
            // 
            // textBoxRes_ZKA
            // 
            textBoxRes_ZKA.Location = new Point(6, 31);
            textBoxRes_ZKA.Multiline = true;
            textBoxRes_ZKA.Name = "textBoxRes_ZKA";
            textBoxRes_ZKA.ScrollBars = ScrollBars.Vertical;
            textBoxRes_ZKA.Size = new Size(238, 375);
            textBoxRes_ZKA.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 34);
            label1.Name = "label1";
            label1.Size = new Size(9, 340);
            label1.TabIndex = 0;
            label1.Text = "\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n";
            // 
            // chartsin_ZKA
            // 
            chartArea1.Name = "ChartArea1";
            chartsin_ZKA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartsin_ZKA.Legends.Add(legend1);
            chartsin_ZKA.Location = new Point(268, 153);
            chartsin_ZKA.Name = "chartsin_ZKA";
            chartsin_ZKA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartsin_ZKA.Series.Add(series1);
            chartsin_ZKA.Size = new Size(773, 403);
            chartsin_ZKA.TabIndex = 6;
            chartsin_ZKA.Text = "chartsin_ZKA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 568);
            Controls.Add(chartsin_ZKA);
            Controls.Add(groupBoxVivod_ZKA);
            Controls.Add(buttonSpravka_ZKA);
            Controls.Add(buttonSoxr_ZKA);
            Controls.Add(buttonDone_ZKA);
            Controls.Add(groupBoxVV_ZKA);
            Controls.Add(groupBoxUsl_ZKA);
            Name = "Form1";
            Text = "Спринт 6|Таск 4|Вариант 3|Золотова К.А.";
            groupBoxUsl_ZKA.ResumeLayout(false);
            groupBoxUsl_ZKA.PerformLayout();
            groupBoxVV_ZKA.ResumeLayout(false);
            groupBoxVV_ZKA.PerformLayout();
            groupBoxVivod_ZKA.ResumeLayout(false);
            groupBoxVivod_ZKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartsin_ZKA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUsl_ZKA;
        private Label labelUsl_ZKA;
        private GroupBox groupBoxVV_ZKA;
        private TextBox textBoxStop_ZKA;
        private TextBox textBoxStart_ZKA;
        private Label labelЫStop_ZKA;
        private Label labelStart_ZKA;
        private Button buttonDone_ZKA;
        private Button buttonSoxr_ZKA;
        private Button buttonSpravka_ZKA;
        private GroupBox groupBoxVivod_ZKA;
        private Label label1;
        private TextBox textBoxRes_ZKA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartsin_ZKA;
    }
}
