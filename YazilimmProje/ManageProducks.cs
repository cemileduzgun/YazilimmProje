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
        DataTable dt;
        public ManageProducks()
        {
            InitializeComponent();
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
            string sql = "INSERT INTO product(ProductID, ProductName, ProductQty, ProductPrince, Decription) " +
               "VALUES(@idpro, @proname, @proqty, @proprince, @prodesc )";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idpro", textProID.Text);
            cmd.Parameters.AddWithValue("@proname", textProName.Text);
            cmd.Parameters.AddWithValue("@proqty", textProQty.Text);
            cmd.Parameters.AddWithValue("@proprince", textProPrince.Text);
            cmd.Parameters.AddWithValue("@prodesc", textProDesc.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Product Eklendi");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "UPDATE product " +
              "SET ProductName = @proname,ProductQty=@proqty,ProductPrince=@proprince,Decription=@prodesc" +
              "WHERE ProductID =@idpro";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idpro", textProID.Text);
            cmd.Parameters.AddWithValue("@proname", textProName.Text);
            cmd.Parameters.AddWithValue("@proqty", textProQty.Text);
            cmd.Parameters.AddWithValue("@proprince", textProPrince.Text);
            cmd.Parameters.AddWithValue("@prodesc", textProDesc.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Categoeri Güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string sql = "DELETE FROM product WHERE ProductID =@idpro";

            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcat", textProID.Text);
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
        }

        private void productData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textProID.Text = productData.CurrentRow.Cells[0].Value.ToString();
            textProName.Text = productData.CurrentRow.Cells[1].Value.ToString();
            textProQty.Text = productData.CurrentRow.Cells[2].Value.ToString();
            textProPrince.Text = productData.CurrentRow.Cells[3].Value.ToString();
            textProDesc.Text = productData.CurrentRow.Cells[4].Value.ToString();
            
        }
    }

}
