using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLoginAndCrudOperations
{   
    public partial class Form2 : Form
    {
        public string Admin = string.Empty;
        int sayi;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        SqlDataAdapter da;


        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_kname.Text = Admin;
            sayi = 0;
            GetData();
        }
        private void GetData()
        {

            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=NTier; Integrated Security=True");
            da = new SqlDataAdapter("SELECT * FROM Products", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Products");
            data_grid_view.DataSource = ds.Tables["Products"];
            con.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=NTier; Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into Products(ProductName,Stock,CategoryID) values (" + txt_urun.Text + ",'" + txt_stok.Text + "','" + txt_kategori.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            GetData();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (data_grid_view.SelectedRows.Count > 0)
            {
                
                con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=NTier; Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Products WHERE ProductName=" + data_grid_view.CurrentRow.Cells[1].Value.ToString();
                cmd.ExecuteNonQuery();
                con.Close();
                data_grid_view.Rows.RemoveAt(data_grid_view.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (sayi == 0)
            {
                if (data_grid_view.SelectedRows.Count > 0)
                {
                    btn_update.Text = "GÜNCELLE";
                    txt_urun.Text = data_grid_view.CurrentRow.Cells[1].Value.ToString();
                    txt_stok.Text = data_grid_view.CurrentRow.Cells[2].Value.ToString();
                    txt_kategori.Text = data_grid_view.CurrentRow.Cells[3].Value.ToString();
                    sayi++;
                }
                else
                {
                    MessageBox.Show("Güncellemek için veri seçin");
                }
            }
            else
            {
                con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=NTier; Integrated Security=True");
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Products SET ProductName = @name, Stock = @stock, CategoryID = @category Where ProductID = "
                    + data_grid_view.CurrentRow.Cells[0].Value.ToString(); ;
                cmd.Parameters.AddWithValue("@name", txt_urun.Text);
                cmd.Parameters.AddWithValue("@stock", txt_stok.Text);
                cmd.Parameters.AddWithValue("@category", txt_kategori.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                GetData();
                btn_update.Text = "SEÇ";
                sayi = 0;
            }
        }
    }
}


