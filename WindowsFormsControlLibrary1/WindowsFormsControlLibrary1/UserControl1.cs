using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class frmMain: UserControl
    {
        public frmMain()
        {
            InitializeComponent();
            pnlOnBtnModel.Height = btnModelTari.Height;
            pnlOnBtnModel.Top = btnModelTari.Top;
            firstCustomContol1.BringToFront();
        }
                      
        private void btnModelTari_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnModelTari.Height;
            pnlOnBtnModel.Top = btnModelTari.Top;
            firstCustomContol1.BringToFront();            

        }

        
        private void btnRecord_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnRecord.Height;
            pnlOnBtnModel.Top = btnRecord.Top;
            mySecondControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnTrain.Height;
            pnlOnBtnModel.Top = btnTrain.Top;
            mytwetControl1.BringToFront();
        }

        private void mytwetControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
