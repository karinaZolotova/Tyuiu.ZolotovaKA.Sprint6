using Tyuiu.ZolotovaKA.Sprint6.Task5.V24.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task5.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        //string path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());
        string path = Path.Combine(@"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\Tyuiu.SaigafarovBI.Sprint6.Task5.V24\bin\Debug\net8.0-windows\InPutFileTask5.txt");

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView_ZKA.ColumnCount = 2;
            dataGridView_ZKA.Columns[0].Width = 20;
            dataGridView_ZKA.Columns[1].Width = 50;

            chart_ZKA.ChartAreas[0].AxisX.Title = "Ось X";
            chart_ZKA.ChartAreas[0].AxisY.Title = "Ось Y";
            chart_ZKA.Series[0].Points.Clear();

            double[] valueArray = new double[dataService.Lenght];

            valueArray = dataService.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_ZKA.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_ZKA.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнила студентка группы ИСПб-24-1 Золотова К.А.", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonOpen_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

    }
}
