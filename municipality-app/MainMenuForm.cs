using MaterialSkin;
using MaterialSkin.Controls;

namespace municipality_app
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

        }

        

        private void materialButton1_Click(object sender, EventArgs e)
        {
            IssueReportForm form = new IssueReportForm();
            form.Show();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon",
                                    "Coming soon",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon",
                                    "Coming soon",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        private void materialFloatingActionButton1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
