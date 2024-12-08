using Tyuiu.KorotkovNS.Sprint6.Task4.V11.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task4.V11
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

        private void buttonExecute_KNS_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_KNS.Text);
                int EndStep = Convert.ToInt32(textBoxEnd_KNS.Text);



                int len = ds.GetMassFunction(startStep, EndStep).Length; //����� �������

                double[] valueArray;
                valueArray = new double[len]; // ������� � ����������� ����� �������

                valueArray = ds.GetMassFunction(startStep, EndStep);

                this.chartFunction_KNS.ChartAreas[0].AxisX.Title = "��� X";
                this.chartFunction_KNS.ChartAreas[0].AxisY.Title = "��� Y";
                textBoxResult_KNS.Text = "";

                chartFunction_KNS.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KNS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_KNS.AppendText(valueArray[i] + Environment.NewLine);
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
            MessageBox.Show("���� 4 �������� ������� ������ �����-24-1 �������� ������ ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonSave_KNS_Click(object sender, EventArgs e)
        {
            try
            {
                String path = $@"{Directory.GetCurrentDirectory()}\PutPutFileTask4V11.txt";
                File.WriteAllText(path, textBoxResult_KNS.Text);

                DialogResult dialogResult = MessageBox.Show("���� " + path + " �������� �������!\n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

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
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBoxTask_KNS_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
