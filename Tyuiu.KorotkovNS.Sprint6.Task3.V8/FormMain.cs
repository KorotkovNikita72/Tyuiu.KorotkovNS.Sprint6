using System.Drawing.Drawing2D;
using Tyuiu.KorotkovNS.Sprint6.Task3.V8.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task3.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -10, 10, -7, 19, 6 },
                                          { 15, -13, -19, 9, 1 },
                                         { -20, -15, -6, 8, -4 },
                                           { 10, 18, -5, 9, -6 },
                                          { 16, -10, 4, 15, 16 }, };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_KNS.ColumnCount = columns;
            dataGridViewMatrix_KNS.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KNS.Columns[i].Width = 100; //ширина столбоцов
            }
            
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KNS.Rows[i].Cells[j].Value = Convert.ToInt32(mtrx[i, j]);
                }
            }
        }
        private void buttonExecute_KNS_Click(object sender, EventArgs e)
        {
            int[,] res = ds.Calculate(mtrx);
            int rows = res.GetUpperBound(0) + 1;
            int columns = res.Length / rows;
            dataGridViewMatrix_KNS.ColumnCount = columns;
            dataGridViewMatrix_KNS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KNS.Columns[i].Width = 30;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KNS.Rows[i].Cells[j].Value = Convert.ToString(res[i, j]);
                }
            }
        }
        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-24-1 Коротков Никита Сергеевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
