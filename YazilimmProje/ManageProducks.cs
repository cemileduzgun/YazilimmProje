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
    public partial class ManageProducks : Form
    {


        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        DataTable dt;
        MySqlCommandBuilder MySqlCommandBuilder;
        public ManageProducks()
        {
            InitializeComponent();
        }
        void fillcategory()
        {
            dt = new DataTable();
            MySqlDataReader reader = null;
            adapter = new MySqlDataAdapter("SELECT * FROM categoriess", conn);
            adapter.Fill(dt);
         

            try
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                DataTable dt = new DataTable();
                dt.Columns.Add("categoriesName", typeof(string));

                MySqlCommand cmd = new MySqlCommand("SELECT categoriesName FROM categoriess", conn);
                reader = cmd.ExecuteReader();
                dt.Load(reader);

                combaCatPro.ValueMember = "categoriesName";
                combaCatPro.DataSource = dt;
            }
            finally
            {
                reader?.Close();
                conn.Close();
            }
        }

      

        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select *from product", conn);
            adapter.Fill(dt);
            productData.DataSource = dt;
            conn.Close();
        }
      
        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO product(PorudctID,ProductName ,ProductQty, ProductPrince, Decription, proCat)"+
               "VALUES(@idpro, @proname, @proqty, @proprince, @prodesc,@procat)";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idpro", textProID.Text);
            cmd.Parameters.AddWithValue("@proname", textProName.Text);
            cmd.Parameters.AddWithValue("@proqty", textProQty.Text);
            cmd.Parameters.AddWithValue("@proprince", textProPrince.Text);
            cmd.Parameters.AddWithValue("@prodesc", textProDesc.Text);
            cmd.Parameters.AddWithValue("@procat",combaCatPro.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Product Eklendi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE product " +
                "SET ProductName = @proname, ProductQty = @proqty, ProductPrince = @proprince, Decription = @prodesc, proCat = @procat " +
                "WHERE PorudctID = @idpro";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idpro", textProID.Text);
            cmd.Parameters.AddWithValue("@proname", textProName.Text);
            cmd.Parameters.AddWithValue("@proqty", textProQty.Text);
            cmd.Parameters.AddWithValue("@proprince", textProPrince.Text);
            cmd.Parameters.AddWithValue("@prodesc", textProDesc.Text);
            cmd.Parameters.AddWithValue("@procat", combaCatPro.Text);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            verigetir();
            MessageBox.Show("Product Güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM product WHERE PorudctID =@idpro";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idpro", textProID.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Product Silindi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void ManageProducks_Load(object sender, EventArgs e)
        {
            verigetir();
            fillcategory();

        }

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textProID.Text = productData.CurrentRow.Cells[0].Value.ToString();
            textProName.Text = productData.CurrentRow.Cells[1].Value.ToString();
            textProQty.Text = productData.CurrentRow.Cells[2].Value.ToString();
            textProPrince.Text = productData.CurrentRow.Cells[3].Value.ToString();
            textProDesc.Text = productData.CurrentRow.Cells[4].Value.ToString();
            combaCatPro.Text = productData.CurrentRow.Cells[5].Value.ToString();

        }

        private void combaCatPro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Search_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
