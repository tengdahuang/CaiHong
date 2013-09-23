using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ChildCafe.Dal;
using Lephone.Data;

namespace ChildCafe
{
    public partial class FrmSupplyChainPos : XSolo.BaseForm.FrmBCommonBlank
    {
        private long PosId;

        public FrmSupplyChainPos()
        {
            InitializeComponent();
        }

        private void FrmSupplyChainPos_Load(object sender, EventArgs e)
        {
            SupplyChainPos fscp = SupplyChainPos.New;
            fscp.SerialNo = "20130923001";

        }

        private void FrmSupplyChainPos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }


    }
}
