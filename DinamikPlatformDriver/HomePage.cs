using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikPlatformDriver
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnOrdered_Click(object sender, EventArgs e)
        {
            Form ordered=new FormOrdered();
            FormOpen(ref ordered);
        }

        private void btnEasyTilt_Click(object sender, EventArgs e)
        {
            Form easyTilt = new FormEasyTilt();
            FormOpen(ref easyTilt);
        }

        private void btnWobbleTilt_Click(object sender, EventArgs e)
        {
            Form wobbleTilt=new FormWobbleTilt();
            FormOpen(ref wobbleTilt);
        }

        private void btnButterfly_Click(object sender, EventArgs e)
        {
            Form butterfly=new FormButterfly();
            FormOpen(ref butterfly);
        }

        private void btnEasyShift_Click(object sender, EventArgs e)
        {
            Form easyShift=new FormEasyShift();
            FormOpen(ref easyShift);
        }

        private void btnEasyRotation_Click(object sender, EventArgs e)
        {
            Form easyRotation=new FormEasyRotation();
            FormOpen(ref easyRotation);
        }

        private void btnSimpleElevated_Click(object sender, EventArgs e)
        {
            Form simpleElevatedTilt=new FormSimpleElevatedTilt();
            FormOpen(ref simpleElevatedTilt);
        }

        private void btnSimpleElevated2_Click(object sender, EventArgs e)
        {
            Form twoStageElevated = new FormTwoStageElevatedTilt();
            FormOpen(ref twoStageElevated);
        }

        private void btnComplexElevated_Click(object sender, EventArgs e)
        {
            Form complexElevated = new FormComplexElevatedTilt();
            FormOpen(ref complexElevated);
        }

        void FormOpen(ref Form form)
        {
            Form f = form;
            foreach (Form mdiChild in MdiChildren)
            {
                if (mdiChild.Text == f.Text)
                {
                    mdiChild.BringToFront();
                    return;
                }
            }

            f.MdiParent = this;
            f.Show();
        }
    }
}
