using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;


namespace English_Learning_Management_System.Screens
{
    public partial class frmLFFirstLoad : Form
    {
        Form frmMain;
        public frmLFFirstLoad()
        {
            InitializeComponent();
            clsLib.ChangeFormProperties(this, Convert.ToInt16(this.Width), Convert.ToInt16(this.Height));
            frmMain = new frmMainScreen(this);
            frmMain.Opacity = 0.0;
            this.ShowInTaskbar = false;
            frmMain.Show();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0.0)
                this.Opacity = 100.0;

            circularProgressBar1.MaximumValue += 5;
            if (circularProgressBar1.MaximumValue == 100)
            {
                timer1.Stop();
                this.Hide();
                frmMain.Opacity = 100.0;
            }
        }

        private void frm_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    } 
}
