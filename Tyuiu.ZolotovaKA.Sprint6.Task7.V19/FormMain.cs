using Tyuiu.ZolotovaKA.Sprint6.Task7.V19.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task7.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_ZKA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_ZKA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonDone_ZKA_Click(object sender, EventArgs e)
        {
            try
            {
                int[,] arrayValues = new int[rows, columns];
                arrayValues = ds.GetMatrix(openFilePath);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewOut_ZKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }
                buttonSave_ZKA.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные или файл не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_ZKA_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }

        private void textBoxCondition_ZKA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOpen_ZKA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_ZKA.ShowDialog();
            openFilePath = openFileDialogTask_ZKA.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_ZKA.ColumnCount = columns;
            dataGridViewIn_ZKA.RowCount = rows;
            dataGridViewOut_ZKA.ColumnCount = columns;
            dataGridViewOut_ZKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_ZKA.Columns[i].Width = 25;
                dataGridViewOut_ZKA.Columns[i].Width = 25;
            }
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_ZKA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_ZKA.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_ZKA.ColumnCount = 50;
            dataGridViewOut_ZKA.ColumnCount = 50;

            dataGridViewIn_ZKA.RowCount = 50;
            dataGridViewOut_ZKA.RowCount = 50;

            panelTextBoxInput_ZKA.Width = this.Width / 2;
            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_ZKA.Columns[i].Width = 25;
                dataGridViewOut_ZKA.Columns[i].Width = 25;
            }
        }

        private void buttonSave_ZKA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_ZKA.FileName = "OutPutFileTask7V19.csv";
            saveFileDialogMatrix_ZKA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_ZKA.ShowDialog();

            string path = saveFileDialogMatrix_ZKA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOut_ZKA.RowCount;
            int columns = dataGridViewOut_ZKA.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_ZKA.Rows[i].Cells[j].Value.ToString() + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_ZKA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpen_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_ZKA.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_ZKA.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_ZKA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_ZKA_MouseEnter(object sender, EventArgs e)
        {
            toolTipOpen_ZKA.ToolTipTitle = "Справка";
        }
    }
}