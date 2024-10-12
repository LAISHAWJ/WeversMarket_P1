namespace WeversMarket_1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void BtNext_Click(object sender, EventArgs e)
        {
            PrincipalMenu principalMenu = new PrincipalMenu();
            this.Hide();
            principalMenu.Show();
        }
    }
}
