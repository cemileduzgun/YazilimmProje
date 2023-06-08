using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YazilimmProje
{
    public partial class ManageUser : Form
   
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public ManageUser()
        {
            InitializeComponent();
        }
        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select *from users", conn);
            adapter.Fill(dt);
            usersData.DataSource = dt;
            conn.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {


            string sql = "INSERT INTO users(idUsers,UsersName,UsersPassword,UsersPhone)"
               + "VALUES(@iduse, @useName,@usePass,@usePhone)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idUse", textUseId.Text);
            cmd.Parameters.AddWithValue("@usename", textUseName.Text);
            cmd.Parameters.AddWithValue("@usepass", textUsePass.Text);
            cmd.Parameters.AddWithValue("@usephone", textUsePhone.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Categoeri Eklendi");
        }



        private void usersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textUseId.Text = usersData.CurrentRow.Cells[0].Value.ToString();
            textUseName.Text = usersData.CurrentRow.Cells[1].Value.ToString();
            textUsePass.Text = usersData.CurrentRow.Cells[2].Value.ToString();
            textUsePhone.Text = usersData.CurrentRow.Cells[3].Value.ToString();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE users " +
               "SET UsersName = @usename, UsersPassword = @usepass, UsersPhone = @usephone " +
               "WHERE idUsers = @idUse";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idUse", textUseId.Text);
            cmd.Parameters.AddWithValue("@usename", textUseName.Text);
            cmd.Parameters.AddWithValue("@usepass", textUsePass.Text);
            cmd.Parameters.AddWithValue("@usephone", textUsePhone.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Category Güncellendi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM users WHERE idUsers =@idUse";
           cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idUse", textUseId.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Categoeri Silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
