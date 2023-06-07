using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace YazilimmProje
{
   
    public partial class ManageCategorıes : Form
    {

        MySqlConnection conn =new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;
        public ManageCategorıes()
        {
            InitializeComponent();
        }
        void verigetir()
        {
            dt = new DataTable();
            conn.Open();
            adapter = new MySqlDataAdapter("select *from categoriess", conn);
            adapter.Fill(dt);
            categoriesData.DataSource= dt;  
            conn.Close();
        }
      
        private void ManageCategorıes_Load(object sender, EventArgs e)
        {
            verigetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void categoriesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCatID.Text = categoriesData.CurrentRow.Cells[0].Value.ToString();
            textCatName.Text=categoriesData.CurrentRow.Cells[1].Value.ToString();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO categoriess(idcategoriess,categoriesName)"
                + "VALUES(@idcat , @catname)";
            cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@idcat",textCatID.Text);
            cmd.Parameters.AddWithValue("@catname",textCatName.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            verigetir();
            MessageBox.Show("Categoeri Eklendi");

        }
    }
}
