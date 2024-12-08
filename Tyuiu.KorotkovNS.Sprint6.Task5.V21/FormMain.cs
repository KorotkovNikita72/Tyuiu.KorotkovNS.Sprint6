using Tyuiu.KorotkovNS.Sprint6.Task5.V21.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\DataSprint6\InPutDataFileTask5V21.txt";
        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonExecute_KNS_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KNS.ColumnCount = 2;
            dataGridViewNums_KNS.Columns[0].Width = 40;
            dataGridViewNums_KNS.Columns[1].Width = 50;

            this.chartGraffic_KNS.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartGraffic_KNS.ChartAreas[0].AxisY.Title = "Ось Y";

            chartGraffic_KNS.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_KNS.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartGraffic_KNS.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpen_KNS_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-24-1 Коротков Никита Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
