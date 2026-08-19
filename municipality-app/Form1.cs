using MaterialSkin;
using MaterialSkin.Controls;

namespace municipality_app
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            ServiceRequestForm form = new ServiceRequestForm();
            form.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

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
    }
}
