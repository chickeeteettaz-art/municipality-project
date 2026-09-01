using MaterialSkin;
using MaterialSkin.Controls;
using muni_class_library;

namespace municipality_app
{
    public partial class AnnouncementWindow : MaterialForm
    {
        List<Announcement> _announcements;

        public AnnouncementWindow()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            
            _announcements = new List<Announcement>();
            for (int i = 0; i < 10; i++)
            {
                Announcement an = new Announcement();
                an.AnnouncematId = i;
                an.Title = $"Announcement {i}";
                an.AnnouncementDate = DateTime.UtcNow;
                an.Description = $"Announcement {i} Description";
                _announcements.Add(an);

                ListViewItem item = new ListViewItem(an.AnnouncematId.ToString());
                item.SubItems.Add(an.Title);
                item.SubItems.Add(an.Description);
                item.SubItems.Add(an.AnnouncementDate.ToString());
                item.SubItems.Add(an.Location);
                listView1.Items.Add(item);

            }

            eventCategoryComboBox.Items.Add("All");
            eventCategoryComboBox.Items.Add("Meetings");
            eventCategoryComboBox.Items.Add("Awareness Events");
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AnnouncementWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
