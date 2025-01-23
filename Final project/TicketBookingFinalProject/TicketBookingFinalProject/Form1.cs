namespace TicketBookingFinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            ActionOnSignIn actionOnSignIn = new ActionOnSignIn();
            actionOnSignIn.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            ActionOnSignUp actionOnSignUp = new ActionOnSignUp();
            actionOnSignUp.Show();
        }
    }
}
