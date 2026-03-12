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

namespace Quanlybanhangmini
{
    public partial class Form1 : Form
    {
        string sql = "Data Source=LAPTOP-OFAAGIK4\\SQLEXPRESS;Initial Catalog=QLBHMN;Integrated Security=True;";
        SqlConnection cnn;
        SqlDataAdapter adt = new SqlDataAdapter();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            cnn = new SqlConnection(sql);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {

            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();

                }
                string sql = "select * from dangnhap where tk= @tk and mk = @mk ";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@tk", tbtk.Text);
                cmd.Parameters.AddWithValue("@mk", tbmk.Text);
                adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Form f2 = new Form2();
                    f2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đăng nhập thất bại" + ex.Message);
            }
            finally
            {
                cnn.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(sql);
        }

        private void bttao_Click(object sender, EventArgs e)
        {
            try
            {
                if (cnn.State == ConnectionState.Closed)
                {
                    cnn.Open();
                }
                string sql = "insert into dangnhap (tk,mk) values (@tk,@mk)";
                cmd = new SqlCommand(sql, cnn);
                cmd.Parameters.AddWithValue("@tk", tbtk.Text);
                cmd.Parameters.AddWithValue("@mk", tbmk.Text);
                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Bạn đã tạo tài khoản thành công");
                    //data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Tạo tài khoản không thành công" + ex.Message);

            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
