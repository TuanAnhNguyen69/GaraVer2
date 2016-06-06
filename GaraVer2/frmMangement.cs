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
using Gara_Data.Info;
using Gara_Data;

namespace GaraVer2
{
    public partial class frmMangement : Form
    {
        public frmMangement()
        {
            InitializeComponent();
            date_VTPT_NgayNhap.Format = DateTimePickerFormat.Custom;
            date_VTPT_NgayNhap.CustomFormat = "yyyy/MM/dd";
        }

        private void frmMangement_Load(object sender, EventArgs e)
        {

            #region Xe
            quanlygaraoto1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanlygaraoto1.sp_Xe_DanhSach' table. You can move, or remove it, as needed.
            this.sp_Xe_DanhSachTableAdapter.Fill(this.quanlygaraoto1.sp_Xe_DanhSach);
            quanlygaraoto1.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'quanlygaraoto1.sp_HieuXe_GetHieuXe' table. You can move, or remove it, as needed.
            this.sp_HieuXe_GetHieuXeTableAdapter.Fill(this.quanlygaraoto1.sp_HieuXe_GetHieuXe);
            label_SoLuongXeToiDa.Text = XeBUS.SoXeSuaChuaTrongNgay().ToString();
            dgv_DanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();

            #endregion

            #region VTPT

            // TODO: This line of code loads data into the 'quanlygaraoto1.CT_PHIEUSUACHUA' table. You can move, or remove it, as needed.
            this.sp_VatTuPhuTung_GetAllTableAdapter.Fill(this.quanlygaraoto1.sp_VatTuPhuTung_GetAll);
            dgv_VTPT_DanhSach.DataSource = PhieuNhapVatTuPhuTungBUS.VatTuPhuTungTheoMaSoPhieu_GetAll();
            cbox_VTPT_MaVTPT.DataSource = VatTuPhuTungBUS.VatTuPhuTung_GetAll();
            cbox_VTPT_MaVTPT.DisplayMember = "mavattuphutung";
            cbox_VTPT_MaVTPT.ValueMember = "DonGia";
            cbox_VTPT_MaVTPT.Text = "";
            txt_VTPT_TenVTPT.Text = "";
            txt_VTPT_DonGia.Text = "";
            #endregion

            #region TienCong
            // TODO: This line of code loads data into the 'quanlygaraoto1.sp_TienCong_GetAll' table. You can move, or remove it, as needed.
            this.sp_TienCong_GetAllTableAdapter.Fill(this.quanlygaraoto1.sp_TienCong_GetAll);
            dgv_TienCong_DanhSach.DataSource = TienCongBUS.TienCong_GetAll();
            #endregion
            
            
        }
        #region Xe_EventHandling
        private void btn_Xe_ThemMoi_Click(object sender, EventArgs e)
        {
            Boolean Exist = false;
            if (txt_Xe_TenHieuXe.Text != "")
            {

                for (int i = 0; i < dgv_DanhSachHieuXe.RowCount - 1; i++)
                    if (txt_Xe_TenHieuXe.Text == dgv_DanhSachHieuXe.Rows[i].Cells[0].Value.ToString())
                    {
                        Exist = true;
                           
                        break;
                    }
                        
                if(Exist)
                {
                    MessageBox.Show("Hiệu xe đã tồn tại!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                        {
                            try
                            {
                                btn_Xe_ThemHieuXe.Enabled = true;
                                HieuXe hx = new HieuXe() { TenHieuXe = txt_Xe_TenHieuXe.Text };
                                HieuXeBUS.HieuXe_Insert(hx);
                                MessageBox.Show("Thêm thành công");
                                dgv_DanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
                                txt_Xe_SoLuongXe.Text = null;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
            }
            else
            {
                MessageBox.Show("Chưa nhập tên hiệu xe!", "Lỗi!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            btn_Xe_ThemHieuXe.Enabled = false;
        }
        private void btn_Xe_XoaHieuXe_Click(object sender, EventArgs e)
        {
            int rowindex = dgv_DanhSachHieuXe.CurrentCell.RowIndex;
            int columnindex = dgv_DanhSachHieuXe.CurrentCell.ColumnIndex;
            
            try
            {
                HieuXe hx = new HieuXe() { TenHieuXe = dgv_DanhSachHieuXe.Rows[rowindex].Cells[columnindex].Value.ToString() };

                if (KiemTraHieuXe(hx.TenHieuXe))
                    MessageBox.Show("Tồn tại xe có hiệu xe này, không thể xóa");
                else
                {
                    HieuXeBUS.HieuXe_Delete(hx);
                    MessageBox.Show("Xóa thành công");
                    dgv_DanhSachHieuXe.DataSource = HieuXeBUS.HieuXe_GetHieuXe();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_Xe_XoaHieuXe.Enabled = false;
            txt_Xe_SoLuongXe.Text = "";
           
        }

        private void txt_Xe_TenHieuXe_TextChange(object sender, EventArgs e)
        {
            if (txt_Xe_TenHieuXe.Text != "")
                btn_Xe_ThemHieuXe.Enabled = true;
            else
                btn_Xe_ThemHieuXe.Enabled = false;
            
        }
        private void dgv_Xe_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_Xe_XoaHieuXe.Enabled = true;
        }

        private void btn_Xe_CapNhat_Click(object sender, EventArgs e)
        {

            ThamSoBUS.ThamSo_Update(int.Parse(txt_Xe_SoLuongXe.Text));
            label_SoLuongXeToiDa.Text = XeBUS.SoXeSuaChuaTrongNgay().ToString();
            MessageBox.Show("Cập nhật số xe sửa chửa tối đa trong ngày thành công!!");
        }

        private void txt_Xe_HieuXe_TextChange(object sender, EventArgs e)
        {
            if (txt_Xe_SoLuongXe.Text != "")
                btn_Xe_CapNhat.Enabled = true;
            else
                btn_Xe_CapNhat.Enabled = false;

        }

        private Boolean KiemTraHieuXe(String CarBrand)
        {
            DataTable CarList = XeBUS.Xe_DanhSach();
            for(int i=0; i< CarList.Rows.Count  ;i++)
            {
                if(CarList.Rows[i].ItemArray[1].Equals(CarBrand))
                {
                    return true;
                }

            }
            return false;
        }
        #endregion
       
        #region VTPT_EventHandling
        private void btn_VTPT_ThemMoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_KiemTra(txt_VTPT_MaPhieu.Text) == 0)
                {
                    VatTuPhuTung vtpt = new VatTuPhuTung();
                    PhieuNhapVatTuPhuTung pnvt = new PhieuNhapVatTuPhuTung();
                    CT_PhieuNhapVatTuPhuTung ctpn = new CT_PhieuNhapVatTuPhuTung();
                    pnvt.SoPhieuNhap = txt_VTPT_MaPhieu.Text;
                    pnvt.NgayNhap = date_VTPT_NgayNhap.Text;
                    vtpt.MaVatTuPhuTung = cbox_VTPT_MaVTPT.Text;
                    vtpt.TenVatTuPhuTung = txt_VTPT_TenVTPT.Text;
                    ctpn.SoPhieuNhap = txt_VTPT_MaPhieu.Text;
                    ctpn.MaVatTuPhuTung = cbox_VTPT_MaVTPT.Text;
                    ctpn.DonGia = double.Parse(txt_VTPT_DonGia.Text);
                    ctpn.SoLuong = int.Parse(txt_VTPT_SoLuong.Text);
                    ctpn.ThanhTien = double.Parse(txt_VTPT_ThanhTien.Text);
                    ctpn.TenVatTuPhuTung = txt_VTPT_TenVTPT.Text;
                    VatTuPhuTungBUS.VatTuPhuTung_Insert(vtpt);
                    PhieuNhapVatTuPhuTungBUS.PhieuNhapVatTuPhuTung_Insert(pnvt);
                    CT_PhieuNhapVatTuPhuTungBUS.CT_PhieuNhapVatTuPhuTung_Insert(ctpn);
                    BaoCaoTon_Insert();
                    MessageBox.Show("Thêm mới phiếu nhập vật tư thành công!");
                    dgv_VTPT_DanhSach.DataSource = PhieuNhapVatTuPhuTungBUS.VatTuPhuTungTheoMaSoPhieu_GetAll();
                    cbox_VTPT_MaVTPT.DataSource = VatTuPhuTungBUS.VatTuPhuTung_GetAll();
                    cbox_VTPT_MaVTPT.DisplayMember = "mavattuphutung";
                    cbox_VTPT_MaVTPT.ValueMember = "DonGia";
                    this.btn_VTPT_LamMoi_Click(sender,e);
                }
                else
                    MessageBox.Show("Phiếu nhập vật tư đã có. Xin nhập phiếu khác !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_VTPT_Xoa.Enabled = false;
            dgv_VTPT_DanhSach.Enabled = true;
        }

        private void TinhThanhTien()
        {
            if (txt_VTPT_SoLuong.Text != "" && txt_VTPT_DonGia.Text != "")
            {
                int soluong = int.Parse(txt_VTPT_SoLuong.Text);
                double dongia = double.Parse(txt_VTPT_DonGia.Text);
                double thanhtien = dongia * soluong;
                txt_VTPT_ThanhTien.Text = thanhtien.ToString();
            }
        }

        private void txt_VTPT_DonGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txt_VTPT_SoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }
        private void txt_VTPT_DonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_VTPT_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
          
           private void dgv_VTPT_DanhSach_Click(object sender, EventArgs e)
           {
               txt_VTPT_MaPhieu.DataBindings.Clear();
               txt_VTPT_MaPhieu.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "SoPhieuNhap");
               cbox_VTPT_MaVTPT.DataBindings.Clear();
               cbox_VTPT_MaVTPT.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "mavattuphutung");
               txt_VTPT_TenVTPT.DataBindings.Clear();
               txt_VTPT_TenVTPT.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "Tenvattuphutung");
               txt_VTPT_DonGia.DataBindings.Clear();
               txt_VTPT_DonGia.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "DonGia");
               txt_VTPT_SoLuong.DataBindings.Clear();
               txt_VTPT_SoLuong.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "SoLuong");
               txt_VTPT_ThanhTien.DataBindings.Clear();
               txt_VTPT_ThanhTien.DataBindings.Add("text", dgv_VTPT_DanhSach.DataSource, "ThanhTien");
               date_VTPT_NgayNhap.Text = dgv_VTPT_DanhSach.CurrentRow.Cells["NgayNhap"].Value.ToString();
           }

           private void btn_VTPT_LamMoi_Click(object sender, EventArgs e)
           {
               txt_VTPT_MaPhieu.Text = "";
               cbox_VTPT_MaVTPT.Text = "";
               txt_VTPT_TenVTPT.Clear();
               txt_VTPT_DonGia.Clear();
               txt_VTPT_SoLuong.Clear();
               txt_VTPT_ThanhTien.Clear();
               dgv_VTPT_DanhSach.Enabled = false;
               txt_VTPT_TenVTPT.ReadOnly = false;
               btn_VTPT_Xoa.Enabled = false;
           }
           private void btn_VTPT_Xoa_Click(object sender, EventArgs e)
           {
               try
               {
                   CT_PhieuNhapVatTuPhuTungBUS.CT_PhieuNhapVatTuPhuTung_Delete(txt_VTPT_MaPhieu.Text, cbox_VTPT_MaVTPT.Text);
                   dgv_VTPT_DanhSach.DataSource = PhieuNhapVatTuPhuTungBUS.VatTuPhuTungTheoMaSoPhieu_GetAll();
                   MessageBox.Show("Đã Xóa ");

               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               txt_VTPT_MaPhieu.Text = "";
               cbox_VTPT_MaVTPT.Text = "";
               txt_VTPT_TenVTPT.Clear();
               txt_VTPT_DonGia.Clear();
               txt_VTPT_SoLuong.Clear();
               txt_VTPT_ThanhTien.Clear();
               btn_VTPT_Xoa.Enabled = false;
           }

           private void cbox_VTPT_MaVTPT_SelectedIndexChanged(object sender, EventArgs e)
           {
               txt_VTPT_DonGia.Text = cbox_VTPT_MaVTPT.SelectedValue.ToString();
               txt_VTPT_TenVTPT.Text = VatTuPhuTungBUS.VatTuPhuTung_GetTenVatTu(cbox_VTPT_MaVTPT.Text);
           }

           private void dgv_VTPT_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               btn_VTPT_Xoa.Enabled = true;
           }

           private void BaoCaoTon_Insert()
           {
               BaoCaoTon BaoCao = new BaoCaoTon();
               BaoCao.TenVatTuPhuTung = txt_VTPT_TenVTPT.Text;
               BaoCao.PhatSinh = int.Parse(txt_VTPT_SoLuong.Text);
               BaoCaoTonBUS.BaoCaoTon_Insert(BaoCao, date_VTPT_NgayNhap.Text);
           }
        #endregion

        #region TienCong_EventHanding

           private void btn_TienCong_Them_Click(object sender, EventArgs e)
           {
               if (KiemTraTonTaiTienCong(txt_TienCong_NoiDung.Text))
               {
                   MessageBox.Show("Tiền công đã có, vui lòng nhập tiền công khác!");
               }
               else
               {
                   try
                   {
                       TienCong tc = new TienCong();
                       tc.NoiDung = txt_TienCong_NoiDung.Text;
                       tc.GiaTienCong = double.Parse(txt_TienCong_DonGia.Text);
                       TienCongBUS.TienCong_Insert(tc);
                       MessageBox.Show("Thêm thành công!!!");
                       dgv_TienCong_DanhSach.DataSource = TienCongBUS.TienCong_GetAll();
                       txt_TienCong_NoiDung.Clear();
                       txt_TienCong_DonGia.Clear();
                       
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
                   btn_TienCong_Xoa.Enabled = false;
               }
           }

           private void btn_TienCong_CapNhat_Click(object sender, EventArgs e)
           {
               try
               {
                   TienCong tc = new TienCong();
                   tc.NoiDung = txt_TienCong_NoiDung.Text;
                   tc.GiaTienCong = double.Parse(txt_TienCong_DonGia.Text);
                   TienCongBUS.TienCong_Update(tc);
                   MessageBox.Show("Sửa thành công!!!");
                   dgv_TienCong_DanhSach.DataSource = TienCongBUS.TienCong_GetAll();
                   txt_TienCong_NoiDung.Clear();
                   txt_TienCong_DonGia.Clear();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
               btn_TienCong_Xoa.Enabled = false;
           }

           private void btn_TienCong_Xoa_Click(object sender, EventArgs e)
           {

               if (KiemTraTienCong(txt_TienCong_NoiDung.Text))
               {
                   MessageBox.Show("Tồn tại phiếu sửa chữa hoặc vật tư có liên quan, không thể xóa");
               }
               else
               {
                   try
                   {
                       TienCong tc = new TienCong();
                       tc.NoiDung = txt_TienCong_NoiDung.Text;
                       TienCongBUS.TienCong_Delete(tc);
                       MessageBox.Show("Xóa thành công!!!");
                       dgv_TienCong_DanhSach.DataSource = TienCongBUS.TienCong_GetAll();
                       txt_TienCong_NoiDung.Clear();
                       txt_TienCong_DonGia.Clear();
                   }
                   catch (Exception ex)
                   {
                       MessageBox.Show(ex.Message);
                   }
                   btn_TienCong_Xoa.Enabled = false;
               }
           }

           private void dgv_TienCong_DanhSach_Click(object sender, EventArgs e)
           {
               try
               {
                   txt_TienCong_DonGia.DataBindings.Clear();
                   txt_TienCong_DonGia.DataBindings.Add("text", dgv_TienCong_DanhSach.DataSource, "DonGia");
                   txt_TienCong_NoiDung.DataBindings.Clear();
                   txt_TienCong_NoiDung.DataBindings.Add("text", dgv_TienCong_DanhSach.DataSource, "NoiDung");
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }
           }

           private void txt_TienCong_DonGia_KeyPress(object sender, KeyPressEventArgs e)
           {
               if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
               {
                   e.Handled = true;
               }
           }

           private void dgv_TienCong_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
           {
               btn_TienCong_Xoa.Enabled = true;
           }

           private void btn_TienCong_LamMoi_Click(object sender, EventArgs e)
           {
               txt_TienCong_NoiDung.Text = "";
               txt_TienCong_DonGia.Text = "";
               btn_TienCong_Xoa.Enabled = false;
           }

           private Boolean KiemTraTienCong(String NoiDung)
           {
               DataTable NoiDungSua = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetAll();
               for (int i = 0; i < NoiDungSua.Rows.Count; i++)
               {
                   if (NoiDungSua.Rows[i].ItemArray[2].Equals(NoiDung))
                   {
                       return true;
                   }

               }
               return false;
           }
           private Boolean KiemTraTonTaiTienCong(String NoiDung)
           {
               DataTable NoiDungSua = TienCongBUS.TienCong_GetAll();
               for (int i = 0; i < NoiDungSua.Rows.Count; i++)
               {
                   if (NoiDungSua.Rows[i].ItemArray[0].Equals(NoiDung))
                   {
                       return true;
                   }

               }
               return false;
           }

          
        #endregion

    }
}
