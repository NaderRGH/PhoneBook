using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrmEF_DBFirst.ViewLayer.Category;
using WinFrmEF_DBFirst.ViewLayer.Persons;

namespace WinFrmEF_DBFirst
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void personsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerson frm = new frmPerson();
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
