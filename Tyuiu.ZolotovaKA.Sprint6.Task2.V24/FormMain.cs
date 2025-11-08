using Tyuiu.ZolotovaKA.Sprint6.Task2.V24.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task2.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonResult_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStart.Text);
                int stopValue = Convert.ToInt32(textBoxEnd.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);


                this.chartResult.Titles.Add("График функции sin(x)+(cos(x)+1)/(2-x)+2x");

                this.chartResult.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));
                    this.chartResult.Series[0].Points.AddXY(startValue, valueArray[i]);
                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Упс! Вы ввели неправильные данные, попробуйте снова!", "Что-то пошло не так...", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСПБ-24-1 Золотов К.А.", "Сообщение", MessageBoxButtons.OK);
        }
    }
}