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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YazilimmProje
{
    public partial class ManageOrders : Form
    {
        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=inventorymanagemtsystem;uid=root;Pwd='cemileduzgun123..';");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        MySqlCommandBuilder MySqlCommandBuilder;
        DataTable dt;
        public ManageOrders()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


        void fillcategory()
        {
            dt = new DataTable();
            MySqlDataReader reader = null;
            adapter = new MySqlDataAdapter("SELECT * FROM product where ProductQty<5", conn);
            adapter.Fill(dt);
            Orderdata.DataSource = dt;

        }

        private void Orderdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            textCusıd.Text = Orderdata.CurrentRow.Cells[0].Value.ToString();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {

            fillcategory();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int selectedRowIndex = Orderdata.SelectedCells[0].RowIndex;
            int selectedRowID = Convert.ToInt32(Orderdata.Rows[selectedRowIndex].Cells["PorudctID"].Value);

            // Veritabanında stok miktarını 10 artır
            string updateQuery = $"UPDATE product SET ProductQty = ProductQty + 10 WHERE PorudctID = {selectedRowID}";
             cmd = new MySqlCommand(updateQuery, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            // Seçili satırı DataGridView'den sil
            Orderdata.Rows.RemoveAt(selectedRowIndex);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
