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
using Gara_Data.Info;
using Gara_BUS;
using Gara_Data;

namespace GaraVer2
{
    public partial class frmFixingReceipt : Abstract
    {
        double TienCong_DonGia;
        string Selected_MaSuaChua;
        int CurrentSTT;
        public frmFixingReceipt()
        {
            InitializeComponent();
            date_PhieuSuaChua_NgaySuaChua.Format = DateTimePickerFormat.Custom;
            date_PhieuSuaChua_NgaySuaChua.CustomFormat = "yyyy/MM/dd";
        }

        private void frmFixingReceipt_Load(object sender, EventArgs e)
        {
            dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);


            cbox_PhieuSuaChua_TenVatTu.DataSource = VatTuPhuTungBUS.VatTuPhuTung_GetAll();
            cbox_PhieuSuaChua_TenVatTu.DisplayMember = "TenVatTuPhuTung";
            cbox_PhieuSuaChua_TenVatTu.ValueMember = "TenVatTuPhuTung";

            cbox_PhieuSuaChua_NoiDung.DataSource = TienCongBUS.TienCong_GetAll();
            cbox_PhieuSuaChua_NoiDung.DisplayMember = "NoiDungSuaChua";
            cbox_PhieuSuaChua_NoiDung.ValueMember = "NoiDung";

            cbox_PhieuSuaChua_MaTiepNhan.DataSource = TiepNhanBUS.TiepNhan_GetAll();
            cbox_PhieuSuaChua_MaTiepNhan.DisplayMember = "MaTiepNhan";
            cbox_PhieuSuaChua_MaTiepNhan.ValueMember = "MaTiepNhan";

            label_PhieuSuaChua_SoLuongTon.Text = "";
            txt_PhieuSuaChua_SoLuong.Text = "";
            cbox_PhieuSuaChua_NoiDung.Text = "";
            cbox_PhieuSuaChua_TenVatTu.Text="";
            label_PhieuSuaChua_SoLuongTon.Text = "0";

        }

        private bool KTNhapXuatPhieu()
        {

            if (txt_PhieuSuaChua_MaPhieu.Text == "")
            {
                MessageBox.Show("Không để trống Mã Sửa Chữa");
                txt_PhieuSuaChua_MaPhieu.Focus();
                return false;
            }
            if (cbox_PhieuSuaChua_MaTiepNhan.Text == "")
            {
                MessageBox.Show("Không để trống Mã Tiếp nhận");
                txt_PhieuSuaChua_MaPhieu.Focus();
                return false;
            }
            if (txt_PhieuSuaChua_BienSo.Text == "")
            {
                MessageBox.Show("Không để trống Biển số");
                txt_PhieuSuaChua_MaPhieu.Focus();
                return false;
            }
            if (date_PhieuSuaChua_NgaySuaChua.Text == "")
            {
                MessageBox.Show("Không để trống ngày Sửa Chữa");
                txt_PhieuSuaChua_MaPhieu.Focus();
                return false;
            }

            return true;
        }

        private bool KTChiTietPhieu()
        {

            if (txt_PhieuSuaChua_SoLuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng vật tư");
                txt_PhieuSuaChua_SoLuong.Focus();
                return false;
            }

            return true;
        }


        private bool KTMaSuaChua(string masuachua)
        {
            bool kt = true;
            try
            {
                SqlDataReader dr = PhieuSuaChuaBUS.PhieuSuaChua_KTMaSuaChua();
                while (dr.Read())
                {
                    string msc = "";
                    msc = dr[0].ToString();
                    if (msc == masuachua)
                    {
                        kt = false;

                        return kt;
                    }
                    else if (msc != masuachua)
                    {
                        kt = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connections.connection.Close();
            }

            return kt;
        }

        private bool KTnoidungsuachua(string msc, string noidung)
        {
            bool kt = false;
            if (CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_KiemTra(msc, noidung).Rows.Count == 0)
            {
                kt = true;
                Connections.connection.Close();
            }
            else
            {
                kt = false;
            }
            return kt;
        }

        private void DoanhSo_Insert()
        {
            DateTime NgaySua = new DateTime();
            NgaySua = Convert.ToDateTime(date_PhieuSuaChua_NgaySuaChua.Text);
            int year = NgaySua.Year;
            int month = NgaySua.Month;
            double SumAll = 0;
            DataTable dt = BaoCaoDoanhSoBUS.BaoCaoDoanhSo_GetDuLieu(month, year);
            foreach (DataRow r in dt.Rows)
            {
                SumAll += double.Parse(r["TongTien"].ToString());
            }
            BaoCaoDoanhSoBUS.BaoCaoDoanhSo_Insert(month, year, SumAll);
        }
        private void CT_DoanhSo_Insert()
        {
            DateTime NgaySua = new DateTime();
            NgaySua = Convert.ToDateTime(date_PhieuSuaChua_NgaySuaChua.Text);
            int year = NgaySua.Year;
            int month = NgaySua.Month;
            double SumAll = 0;
            DataTable dt = BaoCaoDoanhSoBUS.BaoCaoDoanhSo_GetDuLieu(month, year);
            foreach (DataRow r in dt.Rows)
            {
                SumAll += double.Parse(r["TongTien"].ToString());
            }
            foreach (DataRow r in dt.Rows)
            {
                float TiLe = ((float.Parse(r["TongTien"].ToString())) * 100 / ((float)SumAll));
                string HieuXe = r["HieuXe"].ToString();
                int SoLuotSua = int.Parse(r["SoLuotSua"].ToString());
                double TongTien = double.Parse(r["TongTien"].ToString());
                CT_BaoCaoDoanhSoBUS.CT_BaoCaoDoanhSo_Insert(month, year, HieuXe, SoLuotSua, TongTien, TiLe);
            }


        }

        private void CT_DoanhSo_Update()
        {
            DateTime NgaySua = new DateTime();
            NgaySua = Convert.ToDateTime(date_PhieuSuaChua_NgaySuaChua.Text);
            int year = NgaySua.Year;
            int month = NgaySua.Month;
            double SumAll = 0;
            DataTable dt = BaoCaoDoanhSoBUS.BaoCaoDoanhSo_GetDuLieu(month, year);
            foreach (DataRow r in dt.Rows)
            {
                SumAll += double.Parse(r["TongTien"].ToString());
            }
            foreach (DataRow r in dt.Rows)
            {
                float TiLe = ((float.Parse(r["TongTien"].ToString())) * 100 / ((float)SumAll));
                string HieuXe = r["HieuXe"].ToString();
                int SoLuotSua = int.Parse(r["SoLuotSua"].ToString());
                double TongTien = double.Parse(r["TongTien"].ToString());
                CT_BaoCaoDoanhSoBUS.CT_BaoCaoDoanhSo_Update(month, year, HieuXe, SoLuotSua, TongTien, TiLe);
            }


        }
        public void LoadSoxe(TextBox t1)
        {
            t1.Text = txt_PhieuSuaChua_BienSo.Text;

        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            try
            {
                    if (KTMaSuaChua(txt_PhieuSuaChua_MaPhieu.Text))

                        {
                            if (KTNhapXuatPhieu())
                            {
                                PhieuSuaChua psc = new PhieuSuaChua();
                                psc.MaTiepNhan = cbox_PhieuSuaChua_MaTiepNhan.Text;
                                psc.MaPhieuSuaChua = txt_PhieuSuaChua_MaPhieu.Text;
                                psc.NgaySuaChua = date_PhieuSuaChua_NgaySuaChua.Text;
                                psc.BienSo = txt_PhieuSuaChua_BienSo.Text;
                                PhieuSuaChuaBUS.PhieuSuaChua_Insert(psc);
                                MessageBox.Show("Lập phiếu thành công!");
                                dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
                                DoanhSo_Insert();
                            }

                    else
                        MessageBox.Show("Mã sửa chữa đã có");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
               Connections.connection.Close();
            }
     
        }

        private void btn_PhieuSuaChua_Them_Click(object sender, EventArgs e)
        {
            try 
            {
                if(KTChiTietPhieu())
                {
                    CT_PhieuSuaChua ct = new CT_PhieuSuaChua();
                    ct.MaPhieuSuaChua = Selected_MaSuaChua;
                    ct.NoiDungSuaChua = cbox_PhieuSuaChua_NoiDung.Text;
                    ct.TienCong = TienCongBUS.TienCong_GetByNoiDung(cbox_PhieuSuaChua_NoiDung.Text);
                    ct.TenVatTuPhuTung = cbox_PhieuSuaChua_TenVatTu.Text;
                    ct.DonGia = VatTuPhuTungBUS.VatTuPhuTung_GetDonGia(cbox_PhieuSuaChua_TenVatTu.Text);
                    ct.SoLuong = int.Parse(txt_PhieuSuaChua_SoLuong.Text);
                    ct.ThanhTien = TinhTien(ct);
                    CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Insert(ct);
                    dgv_PhieuSuaChua_ChiTiet.DataSource = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetByMaSuaChua(ct.MaPhieuSuaChua);
                    dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
                    label_PhieuSuaChua_SoLuongTon.Text = Convert.ToString(VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbox_PhieuSuaChua_TenVatTu.Text));
                    CT_DoanhSo_Insert();
                    DoanhSo_Insert();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connections.connection.Close();
            }
        }

        private double TinhTien(CT_PhieuSuaChua ct)
        {
            double thanhtien = ct.DonGia * ct.SoLuong + ct.TienCong;
            return thanhtien;
        }
        private void txt_PhieuSuaChua_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //private void btnIn_Click(object sender, EventArgs e)
        //{
        //    frmReportPhieuSuaChua frm = new frmReportPhieuSuaChua(txt_PhieuSuaChua_BienSo.Text);
        //    frm.Show();
        //    btnIn.Enabled = false;
        //    btnXoa.Enabled = false;
        //}

        private bool KiemTraSoLuongTon()
        {
            bool kt = false;
            if (txt_PhieuSuaChua_SoLuong.Text != "")
            {
                int sl = int.Parse(txt_PhieuSuaChua_SoLuong.Text);
                int slt = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbox_PhieuSuaChua_TenVatTu.Text);
                if (sl <= slt)
                    kt = true;
                else
                {
                    kt = false;
                    MessageBox.Show("Số lượng phải nhỏ hơn số lượng vật tư phụ tùng tồn trong kho", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_PhieuSuaChua_SoLuong.Clear();
                    txt_PhieuSuaChua_SoLuong.Focus();
                }

            }
            return kt;
        }

      
        private BindingManagerBase bmb;

        private void dgv_PhieuSuaChua_DanhSach_Click(object sender, EventArgs e)
        {
            txt_PhieuSuaChua_MaPhieu.DataBindings.Clear();
            txt_PhieuSuaChua_MaPhieu.DataBindings.Add("text", dgv_PhieuSuaChua_DanhSach.DataSource, "MaPhieuSuaChua");
            Selected_MaSuaChua = txt_PhieuSuaChua_MaPhieu.Text;
            cbox_PhieuSuaChua_MaTiepNhan.DataBindings.Clear();
            cbox_PhieuSuaChua_MaTiepNhan.DataBindings.Add("text", dgv_PhieuSuaChua_DanhSach.DataSource, "MaTiepNhan");
            txt_PhieuSuaChua_BienSo.DataBindings.Clear();
            txt_PhieuSuaChua_BienSo.DataBindings.Add("text", dgv_PhieuSuaChua_DanhSach.DataSource, "BienSo");
            bmb = BindingContext["MaPhieuSuaChua"];
            dgv_PhieuSuaChua_ChiTiet.DataSource = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetByMaSuaChua(Selected_MaSuaChua);
        }

        private void cbox_PhieuSuaChua_MaTiepNhan_TextChanged(object sender, EventArgs e)
        {
            txt_PhieuSuaChua_BienSo.Text = TiepNhanBUS.TiepNhan_GetBienSo(cbox_PhieuSuaChua_MaTiepNhan.Text);
        }

        private void cbox_PhieuSuaChua_TenVatTu_TextChanged(object sender, EventArgs e)
        {
                int x = VatTuPhuTungBUS.VatTuPhuTung_GetSoLuongTon(cbox_PhieuSuaChua_TenVatTu.Text);
                label_PhieuSuaChua_SoLuongTon.Text = x.ToString();
        }

        private void cbox_PhieuSuaChua_NoiDung_TextChanged(object sender, EventArgs e)
        {
            if (!cbox_PhieuSuaChua_NoiDung.Text.Equals(""))
                TienCong_DonGia = TienCongBUS.TienCong_GetByNoiDung(cbox_PhieuSuaChua_NoiDung.Text);
        }



        private void dgv_PhieuSuaChua_DanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_PhieuSuaChua_Xoa1.Enabled = true;
            //btnIn.Enabled = true;

        }

        private void date_PhieuSuaChua_NgaySuaChua_ValueChanged(object sender, EventArgs e)
        {
            dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
        }

        private void btn_PhieuSuaChua_CapNhat2_Click(object sender, EventArgs e)
        {
             try 
            {
                if(KTChiTietPhieu())
                {
                    CT_PhieuSuaChua ct = new CT_PhieuSuaChua();
                    ct.STT = CurrentSTT;
                    ct.MaPhieuSuaChua = Selected_MaSuaChua;
                    ct.NoiDungSuaChua = cbox_PhieuSuaChua_NoiDung.Text;
                    ct.TienCong = TienCongBUS.TienCong_GetByNoiDung(cbox_PhieuSuaChua_NoiDung.Text);
                    ct.TenVatTuPhuTung = cbox_PhieuSuaChua_TenVatTu.Text;
                    ct.DonGia = VatTuPhuTungBUS.VatTuPhuTung_GetDonGia(cbox_PhieuSuaChua_TenVatTu.Text);
                    ct.SoLuong = int.Parse(txt_PhieuSuaChua_SoLuong.Text);
                    ct.ThanhTien = TinhTien(ct);
                    CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Update(ct);
                    dgv_PhieuSuaChua_ChiTiet.DataSource = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetByMaSuaChua(ct.MaPhieuSuaChua);
                    dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
                    CT_DoanhSo_Update();
                    DoanhSo_Insert();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Connections.connection.Close();
            }
        }

        private void dgv_PhieuSuaChua_ChiTiet_Click(object sender, EventArgs e)
        {
            cbox_PhieuSuaChua_NoiDung.DataBindings.Clear();
            cbox_PhieuSuaChua_NoiDung.DataBindings.Add("text", dgv_PhieuSuaChua_ChiTiet.DataSource, "NoiDungSuaChua");
            cbox_PhieuSuaChua_TenVatTu.DataBindings.Clear();
            cbox_PhieuSuaChua_TenVatTu.DataBindings.Add("text", dgv_PhieuSuaChua_ChiTiet.DataSource, "TenVatTuPhuTung");
            txt_PhieuSuaChua_SoLuong.DataBindings.Clear();
            txt_PhieuSuaChua_SoLuong.DataBindings.Add("text", dgv_PhieuSuaChua_ChiTiet.DataSource, "SoLuong");
            if(dgv_PhieuSuaChua_ChiTiet.Rows.Count>0)
                CurrentSTT = int.Parse(dgv_PhieuSuaChua_ChiTiet.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_PhieuSuaChua_Xoa2_Click(object sender, EventArgs e)
        {
            try
            {
                CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_Delete(Selected_MaSuaChua, CurrentSTT);
                dgv_PhieuSuaChua_ChiTiet.DataSource = CT_PhieuSuaChuaBUS.CT_PhieuSuaChua_GetByMaSuaChua(Selected_MaSuaChua);
                dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
                MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CT_DoanhSo_Update();
                DoanhSo_Insert();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_PhieuSuaChua_Xoa2.Enabled = false;
            btn_PhieuSuaChua_CapNhat2.Enabled = false;
        }

        private void dgv_PhieuSuaChua_ChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_PhieuSuaChua_Xoa2.Enabled = true;
            btn_PhieuSuaChua_CapNhat2.Enabled = true;
        }

        private void btn_PhieuSuaChua_LamMoi2_Click(object sender, EventArgs e)
        {
            cbox_PhieuSuaChua_NoiDung.Text = "";
            cbox_PhieuSuaChua_TenVatTu.Text = "";
            txt_PhieuSuaChua_SoLuong.Text = "";
            label_PhieuSuaChua_SoLuongTon.Text = "";
        }

        private void btn_PhieuSuaChua_LamMoi1_Click(object sender, EventArgs e)
        {
            txt_PhieuSuaChua_MaPhieu.Text = "";
            cbox_PhieuSuaChua_MaTiepNhan.Text = "";
            txt_PhieuSuaChua_BienSo.Text = "";
            date_PhieuSuaChua_NgaySuaChua.Value = DateTime.Now;
            dgv_PhieuSuaChua_ChiTiet.DataSource = null;
        }

        private void btn_PhieuSuaChua_Xoa1_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuSuaChuaBUS.PhieuSuaChua_Delete(txt_PhieuSuaChua_MaPhieu.Text);
                dgv_PhieuSuaChua_DanhSach.DataSource = PhieuSuaChuaBUS.PhieuSuaChua_GetByDay(date_PhieuSuaChua_NgaySuaChua.Text);
                MessageBox.Show("Xóa thành công!", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_PhieuSuaChua_Xoa1.Enabled = false;            
        }

        private void dgv_PhieuSuaChua_DanhSach_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btn_PhieuSuaChua_Xoa1.Enabled = true;
        }
    }
}
