using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFZProgramm
{
    public partial class Haupfenster : Form
    {
        public Haupfenster()
        {
            InitializeComponent();
        }

        private void btnKundesuchen_Click(object sender, EventArgs e)
        {
            frmKundensuche form = new frmKundensuche();
            form.Show(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNeuerKunde form = new frmNeuerKunde();
            form.Show();
        }
    }
}
