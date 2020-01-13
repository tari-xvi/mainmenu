using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace admincsbaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlOnBtnModel.Height = btnrangking.Height;
            pnlOnBtnModel.Top = btnrangking.Top;
            fristcustomcontrolcs1.BringToFront();
        }

        private void pnlOnBtnModel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnrangking_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnrangking.Height;
            pnlOnBtnModel.Top = btnrangking.Top;
            fristcustomcontrolcs1.BringToFront();
        }

        private void btnBelajartari_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnBelajartari.Height;
            pnlOnBtnModel.Top = btnBelajartari.Top;
            tweetcustomcontrolcs1.BringToFront();
        }

        private void btnJenistari_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnJenistari.Height;
            pnlOnBtnModel.Top = btnJenistari.Top;
            triicustomcontrolcs1.BringToFront();
        }

        private void btnrwd_Click(object sender, EventArgs e)
        {
            pnlOnBtnModel.Height = btnrwd.Height;
            pnlOnBtnModel.Top = btnrwd.Top;
            forecustomcontrolcs1.BringToFront();
        }
    }
}
