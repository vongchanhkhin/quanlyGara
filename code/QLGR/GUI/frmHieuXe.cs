using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLGR.BusinessLayer;
using DevComponents.DotNetBar;

namespace QLGR.Presentation
{
    public partial class frmHieuXe : Form
    {
        DevComponents.DotNetBar.TabControl tabControl;
        TabItem tab;

        public frmHieuXe(DevComponents.DotNetBar.TabControl _tabControl, TabItem _tab)
        {
            InitializeComponent();
            tabControl = _tabControl;
            tab = _tab;
        }

        private void frmHieuXe_Load(object sender, EventArgs e)
        {
            GetListHieuXe();
            GetListSuaHieuXe();
        }

        private void GetListHieuXe()
        {
            cboHieuXe.DataSource = HieuXeBLL.GetHieuXe();
            cboHieuXe.DisplayMember = "HIEUXE";
            cboHieuXe.ValueMember = "HIEUXE";
            cboHieuXe.Text = "";
        }
        private void GetListSuaHieuXe()
        {
            cboSuaHieuXe.DataSource = HieuXeBLL.GetHieuXe();
            cboSuaHieuXe.DisplayMember = "HIEUXE";
            cboSuaHieuXe.ValueMember = "HIEUXE";
            cboSuaHieuXe.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (HieuXeBLL.ThemHieuXe(txtHieuXe.Text))
                    MessageBox.Show("Thêm hiệu xe thành công.", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Hiệu xe đã tồn tại.", "Thông báo", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (HieuXeBLL.XoaHieuXe(cboHieuXe.Text))
                    MessageBox.Show("Xe đã xóa thành công", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Không thể xóa hiệu xe vì có xe thuộc hiệu xe này trong xưởng", "Thông báo");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            tabControl.Tabs.Remove(tab);
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHieuXe_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboHieuXe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (HieuXeBLL.SuaHieuXe(cboSuaHieuXe.Text, txtSuaHieuXe.Text))
                    MessageBox.Show("Hiệu xe cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Không thể cập nhật hiệu xe vì không có hiệu xe này trong xưởng", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}
