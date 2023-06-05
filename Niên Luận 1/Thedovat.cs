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
    public partial class Thedovat : UserControl
    {
        static int soThe = 0;
        private int idThe;
        public Thedovat()
        {
            InitializeComponent();
            idThe = soThe;
            soThe++;
            dsten.Add("");
        }
        static List<string> dsten = new List<string>();
        public string layTenDoVat()
        {
            string TenDoVat;

            TenDoVat = Texdv.Text;

            return TenDoVat;
        }

        public double layTrongLuong()
        {
            double trongLuong;

            trongLuong = Convert.ToDouble(Textl.Text);

            return trongLuong;
        }
        public double layGiaTri()
        {
            double giaTri;

            giaTri = Convert.ToDouble(Texgt.Text);

            return giaTri;
        }
        public void layKetQua(int ketQua)
        {
            Lbsl.Text = ketQua.ToString();
        }


        public bool isHopLe()
        {
            bool hopLe = false;
            bool isRong;
            double trongLuong;
            double giaTri;
            bool trongLuongHopLe;
            bool giaTriHopLe;

            trongLuongHopLe = double.TryParse(Textl.Text, out trongLuong);
            giaTriHopLe = double.TryParse(Texgt.Text, out giaTri);
            trongLuongHopLe = double.TryParse(Textl.Text, out trongLuong);
            giaTriHopLe = double.TryParse(Texgt.Text, out giaTri);
            if (Texdv.Text == "" || Textl.Text == "" || Texgt.Text == "")
            {
                isRong = true;
            }
            else
            {
                isRong = false;
            }
            if (isRong == false && trongLuongHopLe != false && giaTriHopLe != false
                && trongLuong > 0 && giaTri > 0 && LbThedv.Visible == false)
            {
                hopLe = true;
            }

            if (hopLe == false)
            {
                panel1.BackColor = Color.IndianRed;
            }
            else
            {
                panel1.BackColor = Color.ForestGreen;
            }

            return hopLe;
        }
    
        private void Texdv_Leave(object sender, EventArgs e)
        {
            string TenDoVat = Texdv.Text;
            if (TenDoVat != "" && dsten.Contains(TenDoVat) == false)
            {
                dsten[idThe] = TenDoVat;
                LbThedv.Visible = false;
            }
            else if (TenDoVat != "" && dsten.Contains(TenDoVat) == true && TenDoVat != dsten[idThe])
            {
                LbThedv.Visible = true;
            }
        }
    }
}
