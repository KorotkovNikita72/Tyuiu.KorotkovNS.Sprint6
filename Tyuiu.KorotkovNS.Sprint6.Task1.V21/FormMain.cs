using Tyuiu.KorotkovNS.Sprint6.Task1.V21.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task1.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonExecute_KNS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KNS.Text);
                int EndStep = Convert.ToInt32(textBoxEnd_KNS.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, EndStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, EndStep);
                textBoxResult_KNS.Text = "";
                textBoxResult_KNS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_KNS.AppendText("+    X     +    F(x)  +" + Environment.NewLine);
                textBoxResult_KNS.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  | ", startStep, valueArray[i]);
                    textBoxResult_KNS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_KNS.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИСТНб-24-1 Коротков Никита Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBoxResult_KNS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
