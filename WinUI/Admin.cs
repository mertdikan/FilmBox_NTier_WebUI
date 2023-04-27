using BLL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        TablolarRepository tr = new TablolarRepository();
        private void Admin_Load(object sender, EventArgs e)
        {
            Tablolar.Items.Add(tr.GetAll());
        }

        private void btnTabloyaGit_Click(object sender, EventArgs e)
        {

        }
    }
}
