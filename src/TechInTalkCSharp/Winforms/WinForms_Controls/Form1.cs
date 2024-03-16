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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var capsLockStatus = IsKeyLocked(Keys.CapsLock);
            clickResult_lbl.Text = capsLockStatus ? "Caps On" : "";
        }
    }
}
