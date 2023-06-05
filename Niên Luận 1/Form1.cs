using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niên_Luận_1
{
    public partial class Form1 : Form
    {
        struct doVat
        {
            public string TenDoVat;
            public double TrongLuong;
            public int SoLuong;
            public double GiaTri;
            public double DonGia;
        }
        struct node
        {
            public double TongGiaTri;
            public int ThuTuDoVat;
            public double TrongLuongConLai;
            public double CanTren;
        }
        double TongGiaTriLonNhat = -1;
        readonly List<doVat> dsdv = new List<doVat>();


        List<Thedovat> dstdv = new List<Thedovat>();


        int ttnl = 0;
      


        List<int> dssl = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void layDoVat(Thedovat ID)
        {
            doVat doVatTam = new doVat();

            doVatTam.TenDoVat = ID.layTenDoVat();
            doVatTam.TrongLuong = ID.layTrongLuong();
            doVatTam.GiaTri = ID.layGiaTri();
            doVatTam.DonGia = ID.layGiaTri() / ID.layTrongLuong();
            dsdv.Add(doVatTam);
        }
        private void sapXepTheoDonGia(List<doVat> dsdv)
        {
            doVat doVatTam = new doVat();
            int i, j, n = dsdv.Count;

            for (i = 0; i <= n - 2; i++)
            {
                for (j = n - 1; j >= i + 1; j--)
                {
                    if (dsdv[j].DonGia > dsdv[j - 1].DonGia)
                    {
                        doVatTam = dsdv[j];
                        dsdv[j] = dsdv[j - 1];
                        dsdv[j - 1] = doVatTam;
                    }
                }
            }
        }
        private bool isNodeLa(node node)
        {
            bool isNodeLa;

            if (node.ThuTuDoVat == dsdv.Count)
            {
                isNodeLa = true;
            }
            else
            {
                isNodeLa = false;
            }

            return isNodeLa;
        }

        private void balo(node node)
        {


            if (!isNodeLa(node))
            {
              

                int soNodeCon = (int)(node.TrongLuongConLai / dsdv[node.ThuTuDoVat].TrongLuong);

                for (int i = soNodeCon; i >= 0; i--)
                {
                    dssl.Add(i);
                    node nodeCon = new node();
                    nodeCon.ThuTuDoVat = node.ThuTuDoVat + 1;
                    nodeCon.TrongLuongConLai = node.TrongLuongConLai - (i * dsdv[nodeCon.ThuTuDoVat - 1].TrongLuong);
                    nodeCon.TongGiaTri = node.TongGiaTri + (i * dsdv[nodeCon.ThuTuDoVat - 1].GiaTri);

                    if (!isNodeLa(nodeCon))
                    {
                        nodeCon.CanTren = nodeCon.TongGiaTri + (nodeCon.TrongLuongConLai * dsdv[nodeCon.ThuTuDoVat].DonGia);
                    }

                    if (nodeCon.CanTren <= TongGiaTriLonNhat && !isNodeLa(nodeCon))
                    {
                        break;
                    }

                    else
                    {
                        balo(nodeCon);
                    }
                }
            }

            else
            {
                if (node.TongGiaTri > TongGiaTriLonNhat)
                {
                    TongGiaTriLonNhat = node.TongGiaTri;
                    ttnl += 1;  
                }
            }


        }
        private node taoNodeGoc(double canTrenNodeGoc, int trongLuongConLaiNodeGoc)
        {
            node nodeGoc = new node();

            nodeGoc.TongGiaTri = 0;
            nodeGoc.CanTren = canTrenNodeGoc;
            nodeGoc.TrongLuongConLai = trongLuongConLaiNodeGoc;
            nodeGoc.ThuTuDoVat = 0;

            return nodeGoc;
        }
        private void tinhSoLuongDoVat()
        {
            doVat doVatTam = new doVat();
            int sldv = (int)Nuddv.Value;
            int i = sldv * (ttnl - 1);
            for (int j = 0; j < dsdv.Count; j++)
            {
                doVatTam = dsdv[j];
                doVatTam.SoLuong = dssl[i];
                dsdv[j] = doVatTam;
                i++;
            }
        }
       
        private void BtnXong_Click(object sender, EventArgs e)
        {
            int soLoaiDoVat = (int)Nuddv.Value;
            int trongLuongBalo = (int)Nudtl.Value;


            if (soLoaiDoVat != 0 && trongLuongBalo != 0)
            {

                Nudtl.BackColor = Color.LightGreen;
                Nuddv.BackColor = Color.LightGreen;
               //PnNhap.Enabled = false;
                BtnTinh.Enabled = true;
                Nudtl.ForeColor = Color.Black;
                Nuddv.ForeColor = Color.Black;
                for (int i = 1; i <= soLoaiDoVat; i++)
                {
                    Thedovat ID = new Thedovat();
                    dstdv.Add(ID);
                    PnXuat.Controls.Add(ID);
                }
            }
            else if (soLoaiDoVat == 0 && trongLuongBalo != 0)
            {
                MessageBox.Show("Số loại đồ vật phải khác không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nuddv.BackColor = Color.IndianRed;
                Nudtl.BackColor = Color.LightGreen;
            }
            else if (soLoaiDoVat != 0 && trongLuongBalo == 0)
            {
                MessageBox.Show("Trọng lượng balo phải khác không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nudtl.BackColor = Color.IndianRed;
                Nuddv.BackColor = Color.LightGreen;
            }
            else if (soLoaiDoVat == 0 && trongLuongBalo == 0)
            {
                MessageBox.Show("Số loại đồ vật và trọng lượng balo phải khác không", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nuddv.BackColor = Color.IndianRed;
                Nudtl.BackColor = Color.IndianRed;
            }
        }

        private void BtnTinh_Click(object sender, EventArgs e)
        {
            bool isCoTheDoVatKhongHopLe = false;
            foreach (var item in dstdv)
            {
                if (item.isHopLe() == false)
                {
                    isCoTheDoVatKhongHopLe = true;
                }
            }

            if (isCoTheDoVatKhongHopLe == false)


            {
                //Khai báo node gốc
                node nodeGoc = new node();

                //Lấy dữ liệu từ danh sách thẻ đồ vật đưa vào danh sách đồ vật
                foreach (var item in dstdv)
                {
                    layDoVat(item);
                }
                //Sắp xếp thứ tự đồ vật theo đơn giá giảm dần (đơn giá = giá trị / trọng lượng)
                sapXepTheoDonGia(dsdv);
                //Khởi tạo các giá trị cho node gốc (trọng lượng còn lại, cận trên, tổng giá trị = 0)
                int TrongLuongBalo = (int)Nudtl.Value;
                int trongLuongConLaiNodeGoc = TrongLuongBalo;
                double canTrenNodeGoc = 0;
                //ds đồ vật (cout >0)
                { for (int k = 0; k > dsdv.Count; k++)
                    {
                        if (dsdv[k].TenDoVat != "" && dsdv[k].TenDoVat != null)

                        {
                            canTrenNodeGoc = dsdv[k].DonGia* TrongLuongBalo;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
          
        
              
                nodeGoc = taoNodeGoc(canTrenNodeGoc, trongLuongConLaiNodeGoc);
                //Thực hiện giản thuật tính tổng giá trị lớn nhất của balo
                balo(nodeGoc);

                //Tính số lượng của mỗi đồ vật theo tổng giá trị lớn nhất tìm được
                tinhSoLuongDoVat();

                //Tính tổng trọng lượng của các đồ vật
                double TongTrongLuongDoVat = 0;
                {
                    for (int j = 0; j < dsdv.Count; j++)
                    {
                        if (dsdv[j].TenDoVat != "" && dsdv[j].TenDoVat != null)
                        {

                            TongTrongLuongDoVat += dsdv[j].SoLuong * dsdv[j].TrongLuong;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                //Tính trọng lượng còn lại của balo
                double TrongLuongConLai = TrongLuongBalo - TongTrongLuongDoVat;
                //Khởi tạo bảng kết quả hiển thị tổng giá trị lớn nhất và trọng lượng còn lại
                BangKQ BangKQ = new BangKQ();
                BangKQ.layKetQua(TongGiaTriLonNhat, TrongLuongConLai);
                PnXuat.Controls.Add(BangKQ);
                // đưa IDdovat vào 
                foreach (var item in dstdv)
                {
                        for (int k = 0; k < dsdv.Count; k++)
                    {
                        if (string.Compare(item.layTenDoVat(), dsdv[k].TenDoVat) == 0)
                        {
                            item.layKetQua(dsdv[k].SoLuong);
                        }
                        else if (dsdv[k].TenDoVat == "")
                        {
                            break;
                        }
                    }
                }

               this.BtnTinh.Enabled = false;
            }

            else
            {
                //Thông báo lỗi khi dữ liệu sai
                MessageBox.Show("Dữ liệu không hợp lệ, vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
