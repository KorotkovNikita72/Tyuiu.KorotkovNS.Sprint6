using Tyuiu.KorotkovNS.Sprint6.Task6.V26.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task6.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_KNS_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KNS.ShowDialog();
            openFilePath = openFileDialogTask_KNS.FileName;
            textBoxInput_KNS.Text = File.ReadAllText(openFilePath);
            groupBoxConclusion_KNS.Text = groupBoxConclusion_KNS.Text + " " + openFileDialogTask_KNS.FileName;
            buttonSave_KNS.Enabled = true;
        }

        private void buttonSave_KNS_Click(object sender, EventArgs e)
        {
            textBoxConclusion_KNS.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KNS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
