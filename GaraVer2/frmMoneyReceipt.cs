using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara_BUS;
using Gara_Data.DAL;
using Gara_Data.Info;
namespace GaraVer2
{
    public partial class frmMoneyReceipt : Abstract
    {
        public frmMoneyReceipt()
        {
            InitializeComponent();
            date_PhieuThuTien_NgayThuTien.Format = DateTimePickerFormat.Custom;
            date_PhieuThuTien_NgayThuTien.CustomFormat = "yyyy/MM/dd";
        }

        private void frmMoneyReceipt_Load(object sender, EventArgs e)
        {
            

            dgv_PhieuThuTien_DanhSach.DataSource = PhieuThuTienBUS.PhieuThuTien_GetByDay(date_PhieuThuTien_NgayThuTien.Text);

            cbox_PhieuThuTien_MaTiepNhan.DataSource = TiepNhanBUS.TiepNhan_GetAll();
            cbox_PhieuThuTien_MaTiepNhan.DisplayMember = "MaTiepNhan";
            cbox_PhieuThuTien_MaTiepNhan.ValueMember = "MaTiepNhan";
            this.rpv_PhieuThuTien.RefreshReport();
        }

        private void cbox_PhieuThuTien_MaTiepNhan_TextChanged(object sender, EventArgs e)
        {
            if (!(cbox_PhieuThuTien_MaTiepNhan.Text == ""))
            {
                txt_PhieuThuTien_BienSo.Text = TiepNhanBUS.TiepNhan_GetBienSo(cbox_PhieuThuTien_MaTiepNhan.Text);
                txt_PhieuThuTien_TienNo.Text = Convert.ToString(XeBUS.Xe_GetTienNo(txt_PhieuThuTien_BienSo.Text));
            }
            else
            {
                txt_PhieuThuTien_TienNo.Text = "";
                txt_PhieuThuTien_BienSo.Text = "";
            }

        }

        private void date_PhieuThuTien_NgayThuTien_ValueChanged(object sender, EventArgs e)
        {
            dgv_PhieuThuTien_DanhSach.DataSource = PhieuThuTienBUS.PhieuThuTien_GetByDay(date_PhieuThuTien_NgayThuTien.Text);
        }

        private void dgv_PhieuThuTien_DanhSach_Click(object sender, EventArgs e)
        {
            txt_PhieuThuTien_MaPhieuThu.DataBindings.Clear();
            txt_PhieuThuTien_MaPhieuThu.DataBindings.Add("text", dgv_PhieuThuTien_DanhSach.DataSource, "MaPhieuThuTien");
            cbox_PhieuThuTien_MaTiepNhan.DataBindings.Clear();
            cbox_PhieuThuTien_MaTiepNhan.DataBindings.Add("text", dgv_PhieuThuTien_DanhSach.DataSource, "MaTiepNhan");
            txt_PhieuThuTien_SoTienThu.DataBindings.Clear();
            txt_PhieuThuTien_SoTienThu.DataBindings.Add("text", dgv_PhieuThuTien_DanhSach.DataSource, "SoTienThu");
            // TODO: This line of code loads data into the 'DataSet1.PhieuThuTien' table. You can move, or remove it, as needed.
            this.PhieuThuTienTableAdapter.Fill(this.DataSet1.PhieuThuTien,txt_PhieuThuTien_MaPhieuThu.Text);
            this.rpv_PhieuThuTien.RefreshReport();
        }

        private bool KTNhapXuat()
        {
            if (txt_PhieuThuTien_MaPhieuThu.Text == "")
            {
                MessageBox.Show("Chưa có mã phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PhieuThuTien_MaPhieuThu.Focus();
                return false;
            }
            if (cbox_PhieuThuTien_MaTiepNhan.Text== "")
            {
               MessageBox.Show("Chưa có mã phiếu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txt_PhieuThuTien_MaPhieuThu.Focus();
               return false;
            }
            if (txt_PhieuThuTien_SoTienThu.Text == "")
            {
                MessageBox.Show("Chưa nhập số tiền thu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_PhieuThuTien_SoTienThu.Focus();
                return false;
            }
            if (double.Parse(txt_PhieuThuTien_SoTienThu.Text) > double.Parse(txt_PhieuThuTien_TienNo.Text))
            {
                MessageBox.Show("Số tiền thu phải nhỏ hơn số tiền nợ");
                txt_PhieuThuTien_SoTienThu.Focus();
                return false;
            }
            return true;
        }

        private bool KTMaPhieu(string MaPhieu)
        {
            DataTable DanhSachMaPhieu = PhieuThuTienBUS.PhieuThuTien_GetAll();
            for (int index = 0; index < DanhSachMaPhieu.Rows.Count;index++ )
            {
                string MaKT=DanhSachMaPhieu.Rows[index].ItemArray[0].ToString();
                if(MaKT.Trim().Equals(MaPhieu.Trim()))
                {
                    MessageBox.Show("Mã phiếu đã tồn tại!");
                    return true;
                }
            }
            return false;
        }
        private void dgv_PhieuThuTien_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_PhieuThuTien_Xoa.Enabled = true;
        }

        private void btn_PhieuSuaChua_LamMoi_Click(object sender, EventArgs e)
        {
            txt_PhieuThuTien_MaPhieuThu.Text = "";
            txt_PhieuThuTien_SoTienThu.Text = "";
            cbox_PhieuThuTien_MaTiepNhan.Text = "";
        }

        private void btn_PhieuThuTien_LapPhieu_Click(object sender, EventArgs e)
        {
            if(KTNhapXuat() && !KTMaPhieu(txt_PhieuThuTien_MaPhieuThu.Text))
            {
                try
                {
                    PhieuThuTien pt = new PhieuThuTien();
                    pt.MaPhieuThuTien = txt_PhieuThuTien_MaPhieuThu.Text;
                    pt.MaTiepNhan = cbox_PhieuThuTien_MaTiepNhan.Text;
                    pt.NgayThuTien = date_PhieuThuTien_NgayThuTien.Text;
                    pt.BienSo = txt_PhieuThuTien_BienSo.Text;
                    pt.SoTienThu = double.Parse(txt_PhieuThuTien_SoTienThu.Text);
                    PhieuThuTienBUS.PhieuThuTien_Insert(pt);
                    MessageBox.Show("Lập phiếu thành công!!");
                    cbox_PhieuThuTien_MaTiepNhan.DataSource = TiepNhanBUS.TiepNhan_GetAll();
                    dgv_PhieuThuTien_DanhSach.DataSource = PhieuThuTienBUS.PhieuThuTien_GetByDay(date_PhieuThuTien_NgayThuTien.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_PhieuThuTien_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuThuTienBUS.PhieuThuTien_DeleteByMaPhieuThu(txt_PhieuThuTien_MaPhieuThu.Text);
                dgv_PhieuThuTien_DanhSach.DataSource = PhieuThuTienBUS.PhieuThuTien_GetByDay(date_PhieuThuTien_NgayThuTien.Text);
                btn_PhieuThuTien_Xoa.Enabled = false;
                MessageBox.Show("Xóa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
