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
    public partial class BangKQ : UserControl
    {
        public BangKQ()
        {
            InitializeComponent();
        }
        public void layKetQua(double TongGiaTriLonNhat, double TrongLuongConLai)
        {
            Lbgtcl.Text = TongGiaTriLonNhat.ToString();
            Lbtlcl.Text = TrongLuongConLai.ToString();
        }
    }
}
