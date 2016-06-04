using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara_Data;
using Gara_Data.Info;
using Gara_BUS;
using DevComponents.DotNetBar.Controls;
using System.Timers;
using System.Text.RegularExpressions;

namespace GaraVer2
{
    public partial class frmCarReceive : Abstract
    {
        public frmCarReceive()
        {
            InitializeComponent();
            date_TiepNhan_NgayTiepNhan.Format = DateTimePickerFormat.Custom;
            date_TiepNhan_NgayTiepNhan.CustomFormat = "yyyy/MM/dd";
        }

        private void frmCarReceive_Load(object sender, EventArgs e)
        {
            quanlygaraoto1.EnforceConstraints = false;
            dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DanhSachTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
            cbox_TiepNhan_HieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
            cbox_TiepNhan_HieuXe.DisplayMember = "HieuXe";
            cbox_TiepNhan_HieuXe.ValueMember = "HieuXe";
            cbox_TiepNhan_HieuXe.Text = "";
            cbox_TiepNhan_HieuXe.SelectedIndex = 0;
        }

        private void SoXeTiepNhanTrongNgay(string Ngay)
        {

            int count = TiepNhanBUS.TiepNhan_DemDSTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
            if (count >= XeBUS.SoXeSuaChuaTrongNgay())
            {
                MessageBox.Show("Số xe tiếp nhận trong ngày đã đủ");
            }

        }
        private void LoadDSXeSuaTrongNgay(string Ngay)
        {
            try
            {
                dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DanhSachTheoNgay(Ngay);
                SoXeTiepNhanTrongNgay(Ngay);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
            }
        }

        private bool KiemTra()
        {
            if (txt_TiepNhan_MaTiepNhan.Text.Trim().Equals(""))
            {
                MessageBox.Show("Mã tiếp nhận chưa có !!!");
                txt_TiepNhan_TenChuXe.Focus();
                return false;
            }
            if (txt_TiepNhan_TenChuXe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Tên chủ xe chưa có !!!");
                txt_TiepNhan_TenChuXe.Focus();
                return false;
            }
            if (txt_TiepNhan_BienSo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Biển số chưa có !!!");
                txt_TiepNhan_BienSo.Focus();
                return false;
            }
            if (cbox_TiepNhan_HieuXe.Text.Trim().Equals(""))
            {
                MessageBox.Show("Hiệu xe chưa được chọn !!!");
                cbox_TiepNhan_HieuXe.Focus();
                return false;
            }
            if (cbox_TiepNhan_HieuXe.FindStringExact(cbox_TiepNhan_HieuXe.Text) == -1)
            {
                MessageBox.Show("Hiệu xe không có trong gara!!");
                cbox_TiepNhan_HieuXe.Focus();
                return false;
            }
            if (txt_TiepNhan_DiaChi.Text.Trim().Equals(""))
            {
                MessageBox.Show("Địa chỉ chưa có!!!");
                txt_TiepNhan_DiaChi.Focus();
                return false;
            }
            if (txt_TiepNhan_DienThoai.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập số điện thoại!!!");
                txt_TiepNhan_DienThoai.Focus();
                return false;
            }
            if (txt_TiepNhan_Email.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa nhập email !!!");
                txt_TiepNhan_Email.Focus();
                return false;
            }
           
            if (TiepNhanBUS.TiepNhan_DemDSTheoNgay(date_TiepNhan_NgayTiepNhan.Text) >= XeBUS.SoXeSuaChuaTrongNgay())
            {
                MessageBox.Show(string.Format("Số xe đã tiếp nhận đủ {0}chiếc", XeBUS.SoXeSuaChuaTrongNgay()), "Thông báo");
                return false;
            }
            return true;
        }

        private void btn_TiepNhan_ThemMoi_Click(object sender, EventArgs e)
        {
            if(KiemTraTiepNhan(txt_TiepNhan_MaTiepNhan.Text))
            {
                MessageBox.Show("Mã tiếp nhận đã tồn tại");
            }
            else
            {
                if (KiemTra())
                {
                    TiepNhan tiepnhan = new TiepNhan();
                    Xe xe = new Xe();
                    try
                    {
                        tiepnhan.MaTiepNhan = txt_TiepNhan_MaTiepNhan.Text;
                        xe.TenChuXe = txt_TiepNhan_TenChuXe.Text;
                        tiepnhan.BienSo = txt_TiepNhan_BienSo.Text;
                        xe.BienSo = txt_TiepNhan_BienSo.Text;
                        xe.DiaChi = txt_TiepNhan_DiaChi.Text;
                        xe.Email = txt_TiepNhan_Email.Text;
                        xe.DienThoai = txt_TiepNhan_DienThoai.Text;
                        xe.HieuXe = cbox_TiepNhan_HieuXe.SelectedValue.ToString();
                        tiepnhan.NgayTiepNhan = date_TiepNhan_NgayTiepNhan.Text;
                        TiepNhanBUS.TiepNhan_Insert(tiepnhan);
                        if (!KiemTraXe(xe))
                            XeBUS.Xe_Insert(xe);
                        else if (!KiemTraChiTietXe(xe))
                            XeBUS.Xe_Update(xe);
                        dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DanhSachTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
                        MessageBox.Show("Nhập thành công !!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Connections.connection.Close();
                    }
                    btn_TiepNhan_Xoa.Enabled = false;
                }
        }
    }

        private void txt_TiepNhan_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DeleteLast(ref TextBoxX txt)
        {
            foreach (char i in txt.Text)
            {
                string j = Convert.ToString(i);
                if (IsNumber(j) == true)
                {
                    MessageBox.Show("Tên không hợp lệ!");
                    txt.Text = txt.Text.Substring(0, txt.TextLength - 1);
                }
            }
        }
        private bool IsNumber(string s)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(s);
        }
        private void txt_TiepNhan_TenChuXe_TextChanged_1(object sender, EventArgs e)
        {
            DeleteLast(ref txt_TiepNhan_TenChuXe);
        }

        private void btn_TiepNhan_LamMoi_Click(object sender, EventArgs e)
        {
            txt_TiepNhan_MaTiepNhan.Text = "";
            txt_TiepNhan_BienSo.Text = "";
            txt_TiepNhan_DiaChi.Text = "";
            txt_TiepNhan_DienThoai.Text = "";
            txt_TiepNhan_Email.Text = "";
            txt_TiepNhan_TenChuXe.Text = "";
            cbox_TiepNhan_HieuXe.SelectedIndex = 0;
            if (TiepNhanBUS.TiepNhan_DemDSTheoNgay(date_TiepNhan_NgayTiepNhan.Text) >= XeBUS.SoXeSuaChuaTrongNgay())
            {
                MessageBox.Show(string.Format("Số xe đã tiếp nhận đủ {0}chiếc", XeBUS.SoXeSuaChuaTrongNgay()), "Thông báo");

            }
            btn_TiepNhan_Xoa.Enabled = false;
        }


        private void btn_TiepNhan_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                TiepNhanBUS.TiepNhan_Delete(txt_TiepNhan_MaTiepNhan.Text);
                dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DemDSTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
                MessageBox.Show("Xóa thành công!!");
                btn_TiepNhan_LamMoi_Click(sender, e);
                date_TiepNhan_NgayTiepNhan_ValueChanged(sender, e);
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa xe đang sửa chữa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btn_TiepNhan_Xoa.Enabled = false;
        }

        private void dgv_TiepNhan_DanhSach_Click(object sender, EventArgs e)
        {
            txt_TiepNhan_MaTiepNhan.DataBindings.Clear();
            txt_TiepNhan_MaTiepNhan.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "MaTiepNhan");
            txt_TiepNhan_BienSo.DataBindings.Clear();
            txt_TiepNhan_BienSo.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "BienSo");
            txt_TiepNhan_TenChuXe.DataBindings.Clear();
            txt_TiepNhan_TenChuXe.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "TenChuXe");
            txt_TiepNhan_DiaChi.DataBindings.Clear();
            txt_TiepNhan_DiaChi.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "DiaChi");
            txt_TiepNhan_DienThoai.DataBindings.Clear();
            txt_TiepNhan_DienThoai.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "DienThoai");
            txt_TiepNhan_Email.DataBindings.Clear();
            txt_TiepNhan_Email.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "Email");
            cbox_TiepNhan_HieuXe.DataBindings.Clear();
            cbox_TiepNhan_HieuXe.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "HieuXe");
            date_TiepNhan_NgayTiepNhan.DataBindings.Clear();
            date_TiepNhan_NgayTiepNhan.DataBindings.Add("text", dgv_TiepNhan_DanhSach.DataSource, "NgayTiepNhan");
            bmb = BindingContext["BienSo"];
            btn_TiepNhan_ThemMoi.Enabled = true;
            btn_TiepNhan_Xoa.Enabled = true;
        }
        private BindingManagerBase bmb;

        private void dgv_TiepNhan_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_TiepNhan_Xoa.Enabled = true;
        }

        private bool KiemTraXe(Xe data)
        {
            DataTable XeList = new DataTable();
            XeList = XeBUS.Xe_DanhSach();
            for(int i=0;i< XeList.Rows.Count;i++)
            {
                string x = XeList.Rows[i].ItemArray[0].ToString();
                if(x.Trim().Equals(data.BienSo))
                {
                    return true;
                }
            }
            return false;
        }

        private bool KiemTraChiTietXe(Xe data)
        {
            DataTable XeList = new DataTable();
            XeList = XeBUS.Xe_DanhSach();
            for (int i = 0; i < XeList.Rows.Count; i++)
            {
                if(XeList.Rows[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }

        private void date_TiepNhan_NgayTiepNhan_ValueChanged(object sender, EventArgs e)
        {
            dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DanhSachTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
        }
        
        private bool KiemTraTiepNhan(string MaTiepNhan)
        {
            DataTable TiepNhanList = new DataTable();
            TiepNhanList = TiepNhanBUS.TiepNhan_GetAll();
            for (int i = 0; i < TiepNhanList.Rows.Count; i++)
            {
                string x = TiepNhanList.Rows[i].ItemArray[0].ToString();
                if (x.Trim().Equals(MaTiepNhan))
                {
                    return true;
                }
            }
            return false;
        }

        private void btn_TiepNhan_CapNhat_Click(object sender, EventArgs e)
        {

                TiepNhan tiepnhan = new TiepNhan();
                Xe xe = new Xe();
                try
                {
                    tiepnhan.MaTiepNhan = txt_TiepNhan_MaTiepNhan.Text;
                    xe.TenChuXe = txt_TiepNhan_TenChuXe.Text;
                    tiepnhan.BienSo = txt_TiepNhan_BienSo.Text;
                    xe.BienSo = txt_TiepNhan_BienSo.Text;
                    xe.DiaChi = txt_TiepNhan_DiaChi.Text;
                    xe.Email = txt_TiepNhan_Email.Text;
                    xe.DienThoai = txt_TiepNhan_DienThoai.Text;
                    xe.HieuXe = cbox_TiepNhan_HieuXe.SelectedValue.ToString();
                    tiepnhan.NgayTiepNhan = date_TiepNhan_NgayTiepNhan.Text;
                TiepNhanBUS.TiepNhan_Update(tiepnhan,xe);
                dgv_TiepNhan_DanhSach.DataSource = TiepNhanBUS.TiepNhan_DemDSTheoNgay(date_TiepNhan_NgayTiepNhan.Text);
                MessageBox.Show("Cập nhật thành công!!");
                btn_TiepNhan_LamMoi_Click(sender, e);
                date_TiepNhan_NgayTiepNhan_ValueChanged(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể xóa xe đang sửa chữa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btn_TiepNhan_Xoa.Enabled = false;
        }
        
    }
}
