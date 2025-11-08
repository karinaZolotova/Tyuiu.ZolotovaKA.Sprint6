using Tyuiu.ZolotovaKA.Sprint6.Task1.V12.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task1.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_ZKA_Click(object sender, EventArgs e)
        {
            //DataService ds = new DataService();
            try
            {
                int startValue = Convert.ToInt32(textBoxStartStep_ZKA.Text);
                int stopValue = Convert.ToInt32(textBoxStopStep_ZKA.Text);
                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);

                textBoxResult_ZKA.Text = "";
                textBoxResult_ZKA.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_ZKA.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_ZKA.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1,6:f2}  |", startValue, valueArray[i]);
                    textBoxResult_ZKA.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_ZKA.AppendText("+----------+----------+");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_ZKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСПб-24-1 Золотова К.А.", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStarStep_ZKA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
