using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaraVer2
{
    public partial class frmSaleReport : Abstract
    {
        public frmSaleReport()
        {
            InitializeComponent();
        }

        private void frmSaleReport_Load(object sender, EventArgs e)
        {

        }

        private bool KTNgay()
        {
            if(textbox_BaoCaoDoanhSo_Nam.Text=="" || combobox_BaoCaoDoanhSo_Thang.Text=="")
            {
                if (textbox_BaoCaoDoanhSo_Nam.Text == "")
                    MessageBox.Show("Vui lòng nhập năm!");
                else
                    MessageBox.Show("Vui lòng chọn tháng!");
                return false;
            }
            else if (int.Parse(textbox_BaoCaoDoanhSo_Nam.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Năm lập báo cáo không được lớn hơn năm hiện tại");
                return false;
            }
            else
            {
                if (int.Parse(textbox_BaoCaoDoanhSo_Nam.Text) == DateTime.Now.Year)
                {
                    if (int.Parse(combobox_BaoCaoDoanhSo_Thang.Text) > DateTime.Now.Month)
                    {
                        MessageBox.Show("Tháng lập báo cáo không được lớn hơn tháng hiện tại");
                        return false;
                    }
                    else
                        return true;
                }
                else
                    return true;
            }
        }
        private void btn_BaoCaoDoanhSo_LapBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (KTNgay())
                {
                    int x = int.Parse(combobox_BaoCaoDoanhSo_Thang.Text);
                    int y = int.Parse(textbox_BaoCaoDoanhSo_Nam.Text);
                    this.doanhSoTableAdapter.FillByDate(this.DataSet1.DoanhSo, x, y);
                    this.reportViewer_BaoCaoDoanhSo.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

      
    }
}
