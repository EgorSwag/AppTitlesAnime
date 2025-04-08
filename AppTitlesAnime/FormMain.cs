namespace AppTitlesAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void BtnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formListTypes = new FormListTypes();
            formListTypes.Show();
        }
    }
}
