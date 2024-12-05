using Tyuiu.KorotkovNS.Sprint6.Task0.V20.Lib;
namespace Tyuiu.KorotkovNS.Sprint6.Task0.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOtvet_KNS_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOtvet.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KNS.Text)));
            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_KNS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 0 �������� ������� ������ �����-24-1 �������� ������ ���������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
