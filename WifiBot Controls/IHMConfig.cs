using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace AppWifiBot_Controls
{
    public partial class IHMConfig : Form
    {

        string fileName = "ConfigRovers.xml";
        string currentDirectory;
        string purchaseOrderFilePath;

        double NbConfigsCrees;

        string adresseRov;
        string portRov;
        string nomRov;
        int nAttr = 0;
        XmlDocument rovers;
        XPathDocument xPath;

        public IHMConfig()
        {
            InitializeComponent();

            currentDirectory = Directory.GetCurrentDirectory();

            purchaseOrderFilePath = Directory.GetParent(currentDirectory).ToString();
            purchaseOrderFilePath = Directory.GetParent(purchaseOrderFilePath).ToString();
            purchaseOrderFilePath = Path.Combine(purchaseOrderFilePath, fileName);

            rovers = new XmlDocument();
            
            try
            {
                xPath = new XPathDocument(purchaseOrderFilePath);
                XPathNavigator nav = xPath.CreateNavigator();

                XmlNamespaceManager mgr = new XmlNamespaceManager(nav.NameTable);

                mgr.AddNamespace("x", "BillyRover.com");

                foreach (XPathNavigator node in nav.Select("//x:Rover", mgr))
                {
                    NbConfigsCrees = (double)node.CreateNavigator().Evaluate("count(.//x:name)", mgr);
                }
            }
            catch (Exception err)
            { MessageBox.Show(err.Message); }
        }

        private void retourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNom.Text != "" && textBoxAdresse.Text != "" && textBoxPort.Text != "")
                {
                    nomRov = textBoxNom.Text;
                    adresseRov = textBoxAdresse.Text;
                    portRov = textBoxPort.Text;

                    CreateConfig();
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs !");
                }
            }
            catch(Exception err)
            { MessageBox.Show(err.Message); }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void listBoxRover_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateConfig()
        {
            
        }

        private void DeleteConfig()
        {

        } 
    }
}
