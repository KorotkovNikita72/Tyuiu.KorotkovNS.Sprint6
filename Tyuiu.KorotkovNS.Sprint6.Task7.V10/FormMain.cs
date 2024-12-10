using Tyuiu.KorotkovNS.Sprint6.Task7.V10.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task7.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogTask.Filter = "��������, ����������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;
        DataService ds = new DataService();
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            //���������� �� ������
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            //���������� ���-�� ����� � ��������
            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            //�������� ������ ������
            int[,] arrayValues = new int[rows, colums];
            
            //����������� ������ �������
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput_KNS.ColumnCount = 50;
            dataGridViewOutput_KNS.ColumnCount = 50;

            dataGridViewInput_KNS.RowCount = 50;
            dataGridViewOutput_KNS.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput_KNS.Columns[i].Width = 25;
                dataGridViewOutput_KNS.Columns[i].Width = 25;
            }
        }

        private void buttonOpen_KNS_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInput_KNS.ColumnCount = colums;
            dataGridViewInput_KNS.RowCount = rows;
            dataGridViewOutput_KNS.ColumnCount = colums;
            dataGridViewOutput_KNS.RowCount = rows;

            //������ ������ �������� dataGridViewInInput
            for (int i = 0; i < colums; i++)
            {
                dataGridViewInput_KNS.Columns[i].Width = 50;
                dataGridViewInput_KNS.Columns[i].Width = 50;
            }
            //���������� ������ � dataGridViewInput
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInput_KNS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonInput_KNS.Enabled = true;
        }
        private void buttonInput_KNS_Click(object sender, EventArgs e)
        {
            //���������� �������
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);
            
            //���������� ������ � dataGridViewOutput
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutput_KNS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_KNS.Enabled = true;
        }
        private void buttonSave_KNS_Click(object sender, EventArgs e)
        {
            saveFileDialogTask.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogTask.ShowDialog();

            string path = saveFileDialogTask.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput_KNS.RowCount; //���-�� �����
            int columns = dataGridViewOutput_KNS.ColumnCount; //���-�� ��������

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutput_KNS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutput_KNS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
        private void buttonOpen_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "������� ����";
        }

        private void buttonInput_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "���������";
        }

        private void buttonSave_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "��������� � ����";
        }

        private void buttonHelp_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "�������";
        }
        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
