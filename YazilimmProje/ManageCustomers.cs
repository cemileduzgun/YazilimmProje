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

namespace YazilimmProje
{
    public partial class ManageCustomers : Form
    {

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCusID.Text = customerData.CurrentRow.Cells[0].Value.ToString();
            textCusName.Text = customerData.CurrentRow.Cells[1].Value.ToString();
            textCusPhone.Text = customerData.CurrentRow.Cells[2].Value.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select *from customer", conn);
            adapter.Fill(dt);
            customerData.DataSource = dt;
            conn.Close();
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO customer(idCustomer,customerName,customerPhone)"
               + "VALUES(@idcus , @cusname, @cusPhone)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcus", textCusID.Text);
            cmd.Parameters.AddWithValue("@cusname", textCusName.Text);
            cmd.Parameters.AddWithValue("@cusPhone", textCusPhone.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("MüŞteri Eklendi");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage= new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE customer " +
                "SET customerName = @cusName, customerPhone = @cusPhone " +
                "WHERE idCustomer = @idcus";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcus", textCusID.Text);
            cmd.Parameters.AddWithValue("@cusName", textCusName.Text);
            cmd.Parameters.AddWithValue("@cusPhone", textCusPhone.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Müşteri Güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM customer WHERE idcustomer =@idcus";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcus", textCusID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Mişteri Silindi");
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            verigetir();
        }
    }
}
