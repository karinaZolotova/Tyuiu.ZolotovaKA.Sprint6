namespace Tyuiu.ZolotovaKA.Sprint6.Task0.V10
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
            groupBoxMain_ZKA = new GroupBox();
            textBoxCondition_ZKA = new TextBox();
            pictureBoxTask_ZKA = new PictureBox();
            groupBoxInput_ZKA = new GroupBox();
            labelVarX_ZKA = new Label();
            textBoxVarX_ZKA = new TextBox();
            groupBoxOutput_ZKA = new GroupBox();
            labelResult_ZKA = new Label();
            textBoxResult_ZKA = new TextBox();
            buttonDone_ZKA = new Button();
            buttonHelp_ZKA = new Button();
            groupBoxMain_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ZKA).BeginInit();
            groupBoxInput_ZKA.SuspendLayout();
            groupBoxOutput_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_ZKA
            // 
            groupBoxMain_ZKA.AccessibleName = "Условие";
            groupBoxMain_ZKA.Controls.Add(textBoxCondition_ZKA);
            groupBoxMain_ZKA.Controls.Add(pictureBoxTask_ZKA);
            groupBoxMain_ZKA.Location = new Point(12, 12);
            groupBoxMain_ZKA.Name = "groupBoxMain_ZKA";
            groupBoxMain_ZKA.Size = new Size(661, 255);
            groupBoxMain_ZKA.TabIndex = 0;
            groupBoxMain_ZKA.TabStop = false;
            groupBoxMain_ZKA.Text = "Условие";
            // 
            // textBoxCondition_ZKA
            // 
            textBoxCondition_ZKA.BackColor = SystemColors.Menu;
            textBoxCondition_ZKA.BorderStyle = BorderStyle.None;
            textBoxCondition_ZKA.Location = new Point(6, 22);
            textBoxCondition_ZKA.Multiline = true;
            textBoxCondition_ZKA.Name = "textBoxCondition_ZKA";
            textBoxCondition_ZKA.ReadOnly = true;
            textBoxCondition_ZKA.Size = new Size(320, 229);
            textBoxCondition_ZKA.TabIndex = 1;
            textBoxCondition_ZKA.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxTask_ZKA
            // 
            pictureBoxTask_ZKA.BackgroundImageLayout = ImageLayout.None;
           
            pictureBoxTask_ZKA.Location = new Point(325, 22);
            pictureBoxTask_ZKA.Name = "pictureBoxTask_ZKA";
            pictureBoxTask_ZKA.Size = new Size(330, 34);
            pictureBoxTask_ZKA.TabIndex = 0;
            pictureBoxTask_ZKA.TabStop = false;
            // 
            // groupBoxInput_ZKA
            // 
            groupBoxInput_ZKA.Controls.Add(labelVarX_ZKA);
            groupBoxInput_ZKA.Controls.Add(textBoxVarX_ZKA);
            groupBoxInput_ZKA.Location = new Point(18, 273);
            groupBoxInput_ZKA.Name = "groupBoxInput_ZKA";
            groupBoxInput_ZKA.Size = new Size(214, 85);
            groupBoxInput_ZKA.TabIndex = 1;
            groupBoxInput_ZKA.TabStop = false;
            groupBoxInput_ZKA.Text = "Ввод данных";
            // 
            // labelVarX_ZKA
            // 
            labelVarX_ZKA.AutoSize = true;
            labelVarX_ZKA.Location = new Point(6, 26);
            labelVarX_ZKA.Name = "labelVarX_ZKA";
            labelVarX_ZKA.Size = new Size(150, 15);
            labelVarX_ZKA.TabIndex = 1;
            labelVarX_ZKA.Text = "Введите целое значение X";
            // 
            // textBoxVarX_ZKA
            // 
            textBoxVarX_ZKA.Location = new Point(6, 44);
            textBoxVarX_ZKA.Name = "textBoxVarX_ZKA";
            textBoxVarX_ZKA.Size = new Size(202, 23);
            textBoxVarX_ZKA.TabIndex = 0;
            textBoxVarX_ZKA.KeyPress += textBoxVarX_ZKA_KeyPress;
            // 
            // groupBoxOutput_ZKA
            // 
            groupBoxOutput_ZKA.Controls.Add(labelResult_ZKA);
            groupBoxOutput_ZKA.Controls.Add(textBoxResult_ZKA);
            groupBoxOutput_ZKA.Location = new Point(503, 273);
            groupBoxOutput_ZKA.Name = "groupBoxOutput_ZKA";
            groupBoxOutput_ZKA.Size = new Size(164, 85);
            groupBoxOutput_ZKA.TabIndex = 2;
            groupBoxOutput_ZKA.TabStop = false;
            groupBoxOutput_ZKA.Text = "Вывод данных";
            // 
            // labelResult_ZKA
            // 
            labelResult_ZKA.AutoSize = true;
            labelResult_ZKA.Location = new Point(6, 26);
            labelResult_ZKA.Name = "labelResult_ZKA";
            labelResult_ZKA.Size = new Size(63, 15);
            labelResult_ZKA.TabIndex = 1;
            labelResult_ZKA.Text = "Результат:";
            // 
            // textBoxResult_ZKA
            // 
            textBoxResult_ZKA.BackColor = SystemColors.Control;
            textBoxResult_ZKA.Location = new Point(6, 44);
            textBoxResult_ZKA.Name = "textBoxResult_ZKA";
            textBoxResult_ZKA.ReadOnly = true;
            textBoxResult_ZKA.Size = new Size(152, 23);
            textBoxResult_ZKA.TabIndex = 0;
            textBoxResult_ZKA.TextChanged += textBoxResult_ZKA_TextChanged;
            // 
            // buttonDone_ZKA
            // 
            buttonDone_ZKA.Location = new Point(509, 364);
            buttonDone_ZKA.Name = "buttonDone_ZKA";
            buttonDone_ZKA.Size = new Size(152, 35);
            buttonDone_ZKA.TabIndex = 3;
            buttonDone_ZKA.Text = "Выполнить";
            buttonDone_ZKA.UseVisualStyleBackColor = true;
            buttonDone_ZKA.Click += buttonDone_ZKA_Click;
            // 
            // buttonHelp_ZKA
            // 
            buttonHelp_ZKA.FlatStyle = FlatStyle.Flat;
            buttonHelp_ZKA.Location = new Point(467, 364);
            buttonHelp_ZKA.Name = "buttonHelp_ZKA";
            buttonHelp_ZKA.Size = new Size(36, 35);
            buttonHelp_ZKA.TabIndex = 4;
            buttonHelp_ZKA.Text = "?";
            buttonHelp_ZKA.UseVisualStyleBackColor = true;
            buttonHelp_ZKA.Click += buttonHelp_ZKA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 411);
            Controls.Add(buttonHelp_ZKA);
            Controls.Add(buttonDone_ZKA);
            Controls.Add(groupBoxOutput_ZKA);
            Controls.Add(groupBoxInput_ZKA);
            Controls.Add(groupBoxMain_ZKA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 10 | Золотова К.А.";
            Load += FormMain_Load;
            groupBoxMain_ZKA.ResumeLayout(false);
            groupBoxMain_ZKA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_ZKA).EndInit();
            groupBoxInput_ZKA.ResumeLayout(false);
            groupBoxInput_ZKA.PerformLayout();
            groupBoxOutput_ZKA.ResumeLayout(false);
            groupBoxOutput_ZKA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_ZKA;
        private PictureBox pictureBoxTask_ZKA;
        private GroupBox groupBoxInput_ZKA;
        private GroupBox groupBoxOutput_ZKA;
        private Label labelResult_ZKA;
        private TextBox textBoxResult_ZKA;
        private Button buttonDone_ZKA;
        private TextBox textBoxVarX_ZKA;
        private Label labelVarX_ZKA;
        private Button buttonHelp_ZKA;
        private TextBox textBoxCondition_ZKA;
    }
}