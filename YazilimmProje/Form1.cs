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
            if (nameTb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("Lütfen boþ alanlarý doldurun");

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
                    MessageBox.Show("Giriþ Baþarýlý");
                    HomePage homePage = new HomePage();
                    homePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalý bilgi giriþi");
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

    
