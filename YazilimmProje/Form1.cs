using MySql.Data.MySqlClient;
using System.Data;

namespace YazilimmProje
{
    public partial class Form1 : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader MySqlDataReader;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("L�tfen bo� alanlar� doldurun");

            }
            else
            {
                conn.Open();

                string sql = "SELECT * FROM users WHERE UsersName = @username AND UsersPassword = @userpass";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", nameTb.Text);
                cmd.Parameters.AddWithValue("@userpass", passwordtb.Text);
                MySqlDataReader mySqlDataReader = cmd.ExecuteReader();
            if (mySqlDataReader.Read())
                {
                    MessageBox.Show("Giri� Ba�ar�l�");
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatal� bilgi giri�i");
                }
              
            }
           


          
        }

        private void nameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

    
