namespace YazilimmProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            //checkBox i�aretli ise
            if (checkBox1.Checked)
            {
                //karakteri g�ster.
                passwordtb.PasswordChar = '\0';
            }
            //de�ilse karakterlerin yerine * koy.
            else
            {
                passwordtb.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTb.Text = "";
            passwordtb.Text = "";
        }
    }
}