using System.Windows.Forms;

namespace WinFormsApp_TestCombobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.textBox1.Text = ((ComboBox)sender).Text;
        }
    }
}
