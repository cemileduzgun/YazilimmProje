using MySql.Data.MySqlClient;
using System.Data;

namespace YazilimmProje
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
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

            //checkBox iþaretli ise
            if (checkBox1.Checked)
            {
                //karakteri göster.
                passwordtb.PasswordChar = '\0';
            }
            //deðilse karakterlerin yerine * koy.
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO Admin(username,password)"
                + "VALUES(@useradmin , @userpass)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@useradmin", nameTb.Text);
            cmd.Parameters.AddWithValue("@userpass", passwordtb.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("GÝRÝÞ BAÞARILI");



            HomePage homePage =new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}