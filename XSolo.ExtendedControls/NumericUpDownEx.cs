using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XSolo.ExtendedControls
{
    public partial class NumericUpDownEx : NumericUpDown
    {
        public NumericUpDownEx()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.Select(0, this.ToString().Length);

        }
    }
}
