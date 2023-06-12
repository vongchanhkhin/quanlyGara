using System;
using QLGR.BusinessLayer;
using System.Windows.Forms;
using System.Security.Principal;

namespace QLGR.Presentation
{
    public partial class frmThayDoiMatKhau : Form
    {
        public static string tenTK;
        FormCollection allForm = Application.OpenForms;

        public frmThayDoiMatKhau()
        {
            InitializeComponent();
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.Equals(txtMatKhauHienThoi.Text, TaiKhoanBLL.MatKhauCu(tenTK).Trim()))
            {
                if (txtMatKhauMoi.Text.Length >= 4 && txtMatKhauMoi.Text.Length <= 20)
                {
                    if (string.Equals(txtMatKhauMoi.Text, txtNhapLaiMKMoi.Text))
                    {
                        try
                        {
                            TaiKhoanBLL.ThayDoiMatKhau(tenTK, txtMatKhauMoi.Text);
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK);
                            txtMatKhauHienThoi.Clear();
                            txtMatKhauMoi.Clear();
                            txtNhapLaiMKMoi.Clear();
                            DangXuat();
                        }
                        catch {; }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu nhập lại không trùng khớp.\nXin nhập lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMatKhauMoi.Clear();
                        txtNhapLaiMKMoi.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu phải từ 4-20 kí tự", "Thông Báo", MessageBoxButtons.OK);
                    txtMatKhauMoi.Clear();
                    txtNhapLaiMKMoi.Clear();
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmThayDoiMatKhau_Load(object sender, EventArgs e)
        {
            //WindowsIdentity currentIdentity = WindowsIdentity.GetCurrent();
            //tenTK = currentIdentity.Name;
        }

        void DangXuat()
        {
            //this.Hide();
            //Form frmMain = new Form();
            //foreach (Form frm in allForm)
            //{
            //    if (frm.Name == "frmMain")
            //    {
            //        //this.Hide();
            //        frm.Hide();
            //        new frmDangNhap().Show();
            //        frm.Close();
            //    }
            //}
            Form frmMain = Application.OpenForms["frmMain"];
            if (frmMain != null)
            {
                frmMain.Close();
            }
            this.Hide();
            new frmDangNhap().ShowDialog();
            this.Close();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhauHienThoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void txtNhapLaiMKMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }
    }
}
