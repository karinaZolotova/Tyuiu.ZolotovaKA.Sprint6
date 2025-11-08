using Tyuiu.ZolotovaKA.Sprint6.Task4.V3.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task4.V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_ZKA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_ZKA.Text);
                int stopStep = Convert.ToInt32(textBoxStop_ZKA.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartsin_ZKA.Titles.Add("График функции sin(x)");
                this.chartsin_ZKA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartsin_ZKA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes_ZKA.Text = " ";
                chartsin_ZKA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartsin_ZKA.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_ZKA.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVopros_ZKA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ПКТБ-24-1 Золотова К.А.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSoxr_ZKA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxRes_ZKA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSpravka_ZKA_Click(object sender, EventArgs e)
        {
            // Добавьте код для справки, если необходимо
        }
    }
}