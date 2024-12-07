using Tyuiu.KorotkovNS.Sprint6.Task2.V29.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task2.V29
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
        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            buttonExecute_KNS.BackColor = Color.Red;
        }
        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            buttonExecute_KNS.BackColor = Color.Green;
        }
        private void buttonDone_MouseDown(object sender, EventArgs e)
        {
            buttonExecute_KNS.BackColor = Color.Blue;
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

                this.chartFunction_KNS.Titles.Add("������ ������� F(x)");

                this.chartFunction_KNS.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_KNS.ChartAreas[0].AxisY.Title = "��� Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KNS.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_KNS.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 2 �������� ������� ������ �����-24-1 �������� ������ ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void dataGridViewFunction_KNS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
