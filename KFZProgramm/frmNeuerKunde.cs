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
    public partial class frmNeuerKunde : Form
    {
        public frmNeuerKunde()
        {
            InitializeComponent();
        }

        private void kundenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kundenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kfzDBDataSet);

        }

        private void frmNeuerKunde_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "kfzDBDataSet.Kunden". Sie können sie bei Bedarf verschieben oder entfernen.
            this.kundenTableAdapter.Fill(this.kfzDBDataSet.Kunden);

        }
    }
}
