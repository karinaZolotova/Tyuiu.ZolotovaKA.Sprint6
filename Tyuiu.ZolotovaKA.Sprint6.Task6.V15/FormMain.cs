using Tyuiu.ZolotovaKA.Sprint6.Task6.V15.Lib;
namespace Tyuiu.ZolotovaKA.Sprint6.Task6.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        string openFilePath;



        private void buttonOpenFile_ZKA_Click(object sender, EventArgs e)
        {
            openFileDialog_ZKA.ShowDialog();
            openFilePath = openFileDialog_ZKA.FileName;
            textBoxInPutData_ZKA.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_ZKA.Text = groupBoxOutPutData_ZKA.Text + " " + openFileDialog_ZKA.FileName;
            buttonDone_ZKA.Enabled = true;
        }



        private void buttonDone_ZKA_Click(object sender, EventArgs e)
        {
            textBoxOutPutData_ZKA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonAbout_ZKA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
