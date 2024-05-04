using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlynhanvien
{
    public partial class Form1 : Form
    {
        SqlConnection conn;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(@"Data Source=DESKTOP-7HQBIC8;Initial Catalog=quanlicuahangxedapdien;Integrated Security=True;Encrypt=False");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(conn.State==ConnectionState.Closed)  // trạng thái đóng thì mở nó lên
            {
                conn.Open();
            }
            Loadf();
        }
        private void Loadf()
        {
            SqlCommand cmd = new SqlCommand("select * from nhanvien", conn); // câu truy vấn
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dgv.DataSource = dtb;


        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into ");
        }

        private void bt_timkiem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from nhanvien where manv like N'" + tb_manv.Text + "'",conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtb = new DataTable();
            da.Fill(dtb);
            dgv.DataSource = dtb;
            
        }

    }
}
