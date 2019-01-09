using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void breederToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBreeder br = new frmBreeder();
            br.ShowDialog();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingT t = new frmSettingT();
            t.ShowDialog();
        }

        private void dogOwnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDogOwner d = new frmDogOwner();
            d.ShowDialog();
        }

        private void dogToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDog d = new frmDog();
            d.ShowDialog();
        }

        private void litterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLitter l = new frmLitter();
            l.ShowDialog();
        }
    }
}
