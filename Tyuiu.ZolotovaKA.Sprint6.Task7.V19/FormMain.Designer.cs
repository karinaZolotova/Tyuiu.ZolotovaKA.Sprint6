namespace Tyuiu.ZolotovaKA.Sprint6.Task7.V19
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
            groupBoxMain_ZKA = new GroupBox();
            textBoxCondition_ZKA = new TextBox();
            buttonDone_ZKA = new Button();
            buttonHelp_ZKA = new Button();
            buttonOpen_ZKA = new Button();
            panelTop_ZKA = new Panel();
            buttonSave_ZKA = new Button();
            groupBoxOutput_ZKA = new GroupBox();
            dataGridViewOut_ZKA = new DataGridView();
            panelTextBoxInput_ZKA = new Panel();
            groupBoxInput_ZKA = new GroupBox();
            dataGridViewIn_ZKA = new DataGridView();
            splitterResult_ZKA = new Splitter();
            panelChartResult_ZKA = new Panel();
            openFileDialogTask_ZKA = new OpenFileDialog();
            toolTipOpen_ZKA = new ToolTip(components);
            saveFileDialogMatrix_ZKA = new SaveFileDialog();
            groupBoxMain_ZKA.SuspendLayout();
            panelTop_ZKA.SuspendLayout();
            groupBoxOutput_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ZKA).BeginInit();
            panelTextBoxInput_ZKA.SuspendLayout();
            groupBoxInput_ZKA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ZKA).BeginInit();
            panelChartResult_ZKA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxMain_ZKA
            // 
            groupBoxMain_ZKA.AccessibleName = "Условие";
            groupBoxMain_ZKA.Controls.Add(textBoxCondition_ZKA);
            groupBoxMain_ZKA.Location = new Point(12, 74);
            groupBoxMain_ZKA.Name = "groupBoxMain_ZKA";
            groupBoxMain_ZKA.Size = new Size(840, 73);
            groupBoxMain_ZKA.TabIndex = 0;
            groupBoxMain_ZKA.TabStop = false;
            groupBoxMain_ZKA.Text = "Условие";
            // 
            // textBoxCondition_ZKA
            // 
            textBoxCondition_ZKA.BackColor = SystemColors.Menu;
            textBoxCondition_ZKA.BorderStyle = BorderStyle.None;
            textBoxCondition_ZKA.Dock = DockStyle.Fill;
            textBoxCondition_ZKA.Location = new Point(3, 19);
            textBoxCondition_ZKA.Multiline = true;
            textBoxCondition_ZKA.Name = "textBoxCondition_ZKA";
            textBoxCondition_ZKA.ReadOnly = true;
            textBoxCondition_ZKA.Size = new Size(834, 51);
            textBoxCondition_ZKA.TabIndex = 1;
            textBoxCondition_ZKA.Text = resources.GetString("textBoxCondition_ZKA.Text");
            textBoxCondition_ZKA.TextChanged += textBoxCondition_ZKA_TextChanged;
            // 
            // buttonDone_ZKA
            // 
            buttonDone_ZKA.BackColor = SystemColors.Menu;
            buttonDone_ZKA.Enabled = false;
            buttonDone_ZKA.Location = new Point(109, 3);
            buttonDone_ZKA.Name = "buttonDone_ZKA";
            buttonDone_ZKA.Size = new Size(99, 71);
            buttonDone_ZKA.TabIndex = 3;
            toolTipOpen_ZKA.SetToolTip(buttonDone_ZKA, "Обрабатывает файл по условию");
            buttonDone_ZKA.UseVisualStyleBackColor = false;
            buttonDone_ZKA.Click += buttonDone_ZKA_Click;
            buttonDone_ZKA.MouseEnter += buttonDone_ZKA_MouseEnter;
            // 
            // buttonHelp_ZKA
            // 
            buttonHelp_ZKA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_ZKA.BackColor = SystemColors.Menu;
       
            buttonHelp_ZKA.Location = new Point(760, 3);
            buttonHelp_ZKA.Name = "buttonHelp_ZKA";
            buttonHelp_ZKA.Size = new Size(92, 71);
            buttonHelp_ZKA.TabIndex = 4;
            toolTipOpen_ZKA.SetToolTip(buttonHelp_ZKA, "Сведения о программе");
            buttonHelp_ZKA.UseVisualStyleBackColor = false;
            buttonHelp_ZKA.Click += buttonHelp_ZKA_Click;
            buttonHelp_ZKA.MouseEnter += buttonHelp_ZKA_MouseEnter;
            // 
            // buttonOpen_ZKA
            // 
            buttonOpen_ZKA.BackColor = SystemColors.Menu;
           
            buttonOpen_ZKA.Location = new Point(3, 3);
            buttonOpen_ZKA.Name = "buttonOpen_ZKA";
            buttonOpen_ZKA.Size = new Size(100, 71);
            buttonOpen_ZKA.TabIndex = 5;
            toolTipOpen_ZKA.SetToolTip(buttonOpen_ZKA, "Выберите нужный файл для обработки\r\n");
            buttonOpen_ZKA.UseVisualStyleBackColor = false;
            buttonOpen_ZKA.Click += buttonOpen_ZKA_Click;
            buttonOpen_ZKA.MouseEnter += buttonOpen_ZKA_MouseEnter;
            // 
            // panelTop_ZKA
            // 
            panelTop_ZKA.Controls.Add(buttonSave_ZKA);
            panelTop_ZKA.Controls.Add(groupBoxMain_ZKA);
            panelTop_ZKA.Controls.Add(buttonHelp_ZKA);
            panelTop_ZKA.Controls.Add(buttonOpen_ZKA);
            panelTop_ZKA.Controls.Add(buttonDone_ZKA);
            panelTop_ZKA.Dock = DockStyle.Top;
            panelTop_ZKA.Location = new Point(0, 0);
            panelTop_ZKA.Name = "panelTop_ZKA";
            panelTop_ZKA.Size = new Size(864, 153);
            panelTop_ZKA.TabIndex = 6;
            // 
            // buttonSave_ZKA
            // 
            buttonSave_ZKA.BackColor = SystemColors.Menu;
            buttonSave_ZKA.Enabled = false;
         
            buttonSave_ZKA.Location = new Point(214, 3);
            buttonSave_ZKA.Name = "buttonSave_ZKA";
            buttonSave_ZKA.Size = new Size(95, 71);
            buttonSave_ZKA.TabIndex = 6;
            toolTipOpen_ZKA.SetToolTip(buttonSave_ZKA, "Выберите место сохранения\r\n");
            buttonSave_ZKA.UseVisualStyleBackColor = false;
            buttonSave_ZKA.Click += buttonSave_ZKA_Click;
            buttonSave_ZKA.MouseEnter += buttonSave_ZKA_MouseEnter;
            // 
            // groupBoxOutput_ZKA
            // 
            groupBoxOutput_ZKA.Controls.Add(dataGridViewOut_ZKA);
            groupBoxOutput_ZKA.Dock = DockStyle.Fill;
            groupBoxOutput_ZKA.Location = new Point(0, 0);
            groupBoxOutput_ZKA.Name = "groupBoxOutput_ZKA";
            groupBoxOutput_ZKA.Size = new Size(441, 408);
            groupBoxOutput_ZKA.TabIndex = 2;
            groupBoxOutput_ZKA.TabStop = false;
            groupBoxOutput_ZKA.Text = "Вывод данных";
            // 
            // dataGridViewOut_ZKA
            // 
            dataGridViewOut_ZKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_ZKA.ColumnHeadersVisible = false;
            dataGridViewOut_ZKA.Dock = DockStyle.Fill;
            dataGridViewOut_ZKA.Location = new Point(3, 19);
            dataGridViewOut_ZKA.Name = "dataGridViewOut_ZKA";
            dataGridViewOut_ZKA.ReadOnly = true;
            dataGridViewOut_ZKA.RowHeadersVisible = false;
            dataGridViewOut_ZKA.Size = new Size(435, 386);
            dataGridViewOut_ZKA.TabIndex = 0;
            // 
            // panelTextBoxInput_ZKA
            // 
            panelTextBoxInput_ZKA.Controls.Add(groupBoxInput_ZKA);
            panelTextBoxInput_ZKA.Dock = DockStyle.Left;
            panelTextBoxInput_ZKA.Location = new Point(0, 153);
            panelTextBoxInput_ZKA.Name = "panelTextBoxInput_ZKA";
            panelTextBoxInput_ZKA.Size = new Size(420, 408);
            panelTextBoxInput_ZKA.TabIndex = 7;
            // 
            // groupBoxInput_ZKA
            // 
            groupBoxInput_ZKA.Controls.Add(dataGridViewIn_ZKA);
            groupBoxInput_ZKA.Dock = DockStyle.Fill;
            groupBoxInput_ZKA.Location = new Point(0, 0);
            groupBoxInput_ZKA.Name = "groupBoxInput_ZKA";
            groupBoxInput_ZKA.Size = new Size(420, 408);
            groupBoxInput_ZKA.TabIndex = 0;
            groupBoxInput_ZKA.TabStop = false;
            groupBoxInput_ZKA.Text = "Ввод данных";
            // 
            // dataGridViewIn_ZKA
            // 
            dataGridViewIn_ZKA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_ZKA.ColumnHeadersVisible = false;
            dataGridViewIn_ZKA.Dock = DockStyle.Fill;
            dataGridViewIn_ZKA.Location = new Point(3, 19);
            dataGridViewIn_ZKA.Name = "dataGridViewIn_ZKA";
            dataGridViewIn_ZKA.ReadOnly = true;
            dataGridViewIn_ZKA.RowHeadersVisible = false;
            dataGridViewIn_ZKA.Size = new Size(414, 386);
            dataGridViewIn_ZKA.TabIndex = 0;
            // 
            // splitterResult_ZKA
            // 
            splitterResult_ZKA.Location = new Point(420, 153);
            splitterResult_ZKA.Name = "splitterResult_ZKA";
            splitterResult_ZKA.Size = new Size(3, 408);
            splitterResult_ZKA.TabIndex = 8;
            splitterResult_ZKA.TabStop = false;
            // 
            // panelChartResult_ZKA
            // 
            panelChartResult_ZKA.Controls.Add(groupBoxOutput_ZKA);
            panelChartResult_ZKA.Dock = DockStyle.Fill;
            panelChartResult_ZKA.Location = new Point(423, 153);
            panelChartResult_ZKA.Name = "panelChartResult_ZKA";
            panelChartResult_ZKA.Size = new Size(441, 408);
            panelChartResult_ZKA.TabIndex = 9;
            // 
            // toolTipOpen_ZKA
            // 
            toolTipOpen_ZKA.IsBalloon = true;
            toolTipOpen_ZKA.ToolTipIcon = ToolTipIcon.Info;
            toolTipOpen_ZKA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 561);
            Controls.Add(panelChartResult_ZKA);
            Controls.Add(splitterResult_ZKA);
            Controls.Add(panelTextBoxInput_ZKA);
            Controls.Add(panelTop_ZKA);
            MinimumSize = new Size(880, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 19 | Золотова К.А.";
            Load += FormMain_Load;
            groupBoxMain_ZKA.ResumeLayout(false);
            groupBoxMain_ZKA.PerformLayout();
            panelTop_ZKA.ResumeLayout(false);
            groupBoxOutput_ZKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_ZKA).EndInit();
            panelTextBoxInput_ZKA.ResumeLayout(false);
            groupBoxInput_ZKA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_ZKA).EndInit();
            panelChartResult_ZKA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxMain_ZKA;
        private Button buttonDone_ZKA;
        private Button buttonHelp_ZKA;
        private TextBox textBoxCondition_ZKA;
        private Button buttonOpen_ZKA;
        private Panel panelTop_ZKA;
        private GroupBox groupBoxOutput_ZKA;
        private Panel panelTextBoxInput_ZKA;
        private Splitter splitterResult_ZKA;
        private Panel panelChartResult_ZKA;
        private GroupBox groupBoxInput_ZKA;
        private OpenFileDialog openFileDialogTask_ZKA;
        private ToolTip toolTipOpen_ZKA;
        private DataGridView dataGridViewOut_ZKA;
        private DataGridView dataGridViewIn_ZKA;
        private Button buttonSave_ZKA;
        private SaveFileDialog saveFileDialogMatrix_ZKA;
    }
}
