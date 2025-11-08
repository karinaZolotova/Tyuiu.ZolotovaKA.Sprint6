using Tyuiu.ZolotovaKA.Sprint6.Task3.V20.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task3.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { {25,20,28,2,6},
                                            {19,9,18,-7,24},
                                            {21,16,5,-7,-8},
                                            {30,-13,1,-15,2},
                                            {31,9,-3,-9,-18}};
        private void buttonClick_ZKA_Click(object sender, EventArgs e)
        {
            int[,] array = ds.Calculate(matrix);
            int rows = array.GetLength(0);
            int columns = array.GetLength(1);
            dataGridViewMatrixNew_ZKA.ColumnCount = columns;
            dataGridViewMatrixNew_ZKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrixNew_ZKA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrixNew_ZKA.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            dataGridViewMatixTask_ZKA.ColumnCount = columns;
            dataGridViewMatixTask_ZKA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatixTask_ZKA.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatixTask_ZKA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonSpravka_ZKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСПб-24-1 Золотова К.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
