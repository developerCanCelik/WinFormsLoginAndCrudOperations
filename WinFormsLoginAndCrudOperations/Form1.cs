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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM tblUser where usr=@user AND psw=@pass";
            con = new SqlConnection("server=DESKTOP-G46VU0J; Initial Catalog=tblUser; Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
           
            cmd.Parameters.AddWithValue("@user", txt_kname.Text);
            cmd.Parameters.AddWithValue("@pass", txt_kpass.Text);

            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())

            {
                Form2 frm = new Form2();
                frm.Admin = txt_kname.Text;
                frm.Show();
                this.Hide();
            }

            else
            {

                MessageBox.Show("Kullanıcı Adınızı ve Şifrenizi Kontrol Ediniz");

            }

            con.Close();
        }
    }
}
