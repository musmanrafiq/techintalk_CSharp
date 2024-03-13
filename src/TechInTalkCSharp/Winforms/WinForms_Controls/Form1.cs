namespace WinForms_Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_click(object sender, EventArgs e)
        {
            var userEmail = this.email_txtbox.Text.ToString();
            clickResult_lbl.Text = userEmail;
        }
    }
}
