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
    public partial class IhmPrincipale : Form
    {
        public IhmPrincipale()
        {
            InitializeComponent();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            IHMMenuAuto PageMenuAuto = new IHMMenuAuto();

            DialogResult dialogPageMenuAuto = PageMenuAuto.ShowDialog();

            

            if(dialogPageMenuAuto == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void buttonManuel_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            IHMMenuManu PageMenuManu = new IHMMenuManu();

            DialogResult dialogPageMenuManu = PageMenuManu.ShowDialog();           

            if (dialogPageMenuManu == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}
