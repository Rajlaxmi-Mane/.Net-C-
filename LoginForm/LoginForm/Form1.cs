namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string userName = "maithili@gmail.com";
        string password = "maithili@123";

        private void button1_Click(object sender, EventArgs e)
        {
            if (userName == textBox1.Text && password == textBox2.Text)
            {
                MessageBox.Show("Login Successfull");

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
