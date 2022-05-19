using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWifiBot_Controls
{
    public partial class IHMMenuManu : Form
    {
        public IHMMenuManu()
        {
            InitializeComponent();
        }

        private void retourAuModeDeContrôleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPilotage_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            IHMPilotage pagePilotage = new IHMPilotage();

            DialogResult dialogPilotage = pagePilotage.ShowDialog();

            if(dialogPilotage == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void buttonCR_Manu_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            IHMFicheIntervention pageCompteRendu = new IHMFicheIntervention();

            DialogResult dialogPageCR = pageCompteRendu.ShowDialog();

            if(dialogPageCR == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}
