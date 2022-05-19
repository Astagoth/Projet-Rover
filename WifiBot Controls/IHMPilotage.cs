using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Timers;

namespace AppWifiBot_Controls
{
    public partial class IHMPilotage : Form
    {
        UdpClient udpClient;
        string Messages;
        int portServeur = 54000;

        string adresseServeurTCP = "127.0.0.1";
        int portClient = 54000;

        bool val;
        Mutex mutex = new Mutex();
        int vit;

        Byte[] buffer;

        TcpClient ClientSocket;
        NetworkStream FluxDonnees;

        string vitesse;
        string cmdDeplacement;
        string nameCommande;
        string donneesAEnvoyer;
       
        bool isConnected = false;

        string MsgClientUDP = string.Empty;
        static string messageRec = string.Empty;

        Thread thdUDPServer;
        Thread thdMSGClientUDP;
        ServerUDP serverUDP = new ServerUDP(messageRec);
        public IHMPilotage()
        {
            InitializeComponent();

            // ******************************************************** //
            // * Empêche le technicien de faire planter l'application * //
            arrêterToolStripMenuItem.Enabled = false;                   //
            //textBoxAreaConsole.Enabled = false;
            // ******************************************************** //
           

            barVitesse.Value = 2;

            thdUDPServer = new Thread(new

            ThreadStart(serverUDP.serverThread));


            thdUDPServer.Start();

            thdMSGClientUDP = new Thread(new
                ThreadStart(RecupMessClientUDP));

            thdMSGClientUDP.Start();

            
        }

        private void connecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            arrêterToolStripMenuItem.Enabled = true;
            connecToolStripMenuItem.Enabled = false;
            isConnected = ClientTCPConnect();
            if(isConnected == true)
            {
                labelConnect.ForeColor = Color.Green;
                labelConnect.Text = "Connecté au rover !";
            }
            if(isConnected == false)
            {    
                labelConnect.ForeColor = Color.Red;
                labelConnect.Text = "Impossible de se connecter !";
            }

            //thdMSGClientUDP.Start();

            //textBoxAreaConsole.AppendText(serverUDP.GetMSG);

            //RecupMessClientUDP();

        }

        private void arrêterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            arrêterToolStripMenuItem.Enabled = false;
            connecToolStripMenuItem.Enabled = true;

            StopClientTCP();
        }

        private void retourAuMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                udpClient.Close();
            }
            catch(Exception err) { }
            
            Close();
        }

        private bool ClientTCPConnect()
        {
            bool connected = false;
            try
            {
                ClientSocket = new TcpClient();
                connected = true;
                ClientSocket.Connect(adresseServeurTCP, portClient);

                return connected;
            }
            catch (Exception e)
            {
                connected = false;
                return connected;
            }
        }

        private void StopClientTCP()
        {
            ClientSocket.Close();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            IHMConfig pageConf = new IHMConfig();

            DialogResult dialogConf = pageConf.ShowDialog();

            if (dialogConf == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void IHMPilotage_FormClosing(object sender, FormClosingEventArgs e)
        {
           thdUDPServer.Interrupt();
        }

        private void buttonUp_MouseDown(object sender, MouseEventArgs e)
        {
            Button butActivated = sender as Button;

            nameCommande = butActivated.Text;

            buttonGauche.Enabled = false;
            buttonDroite.Enabled = false;
            buttonReculer.Enabled = false;
            vit = barVitesse.Value;

            CalculDeplacements(nameCommande, vit);

            EnvoieDonnees();
            
        }

        private void buttonUp_MouseUp(object sender, MouseEventArgs e)
        {
            buttonGauche.Enabled = true;
            buttonDroite.Enabled = true;
            buttonReculer.Enabled = true;
        }
 

        private void buttonGauche_MouseDown(object sender, MouseEventArgs e)
        {
            Button butActivated = sender as Button;

            nameCommande = butActivated.Text;
            vit = barVitesse.Value;

            buttonUp.Enabled = false;
            buttonDroite.Enabled = false;
            buttonReculer.Enabled = false;

            CalculDeplacements(nameCommande, vit);
            EnvoieDonnees();
        }

        private void buttonGauche_MouseUp(object sender, MouseEventArgs e)
        {

            buttonUp.Enabled = true;
            buttonDroite.Enabled = true;
            buttonReculer.Enabled = true;
        }

        private void buttonDroite_MouseDown(object sender, MouseEventArgs e)
        {
            Button butActivated = sender as Button;

            nameCommande = butActivated.Text;
            vit = barVitesse.Value;

            buttonUp.Enabled = false;
            buttonGauche.Enabled = false;
            buttonReculer.Enabled = false;

            CalculDeplacements(nameCommande, vit);
            EnvoieDonnees();
        }

        private void buttonDroite_MouseUp(object sender, MouseEventArgs e)
        {

            buttonUp.Enabled = true;
            buttonGauche.Enabled = true;
            buttonReculer.Enabled = true;
        }

        private void buttonReculer_MouseDown(object sender, MouseEventArgs e)
        {
            Button butActivated = sender as Button;

            nameCommande = butActivated.Text;
            vit = barVitesse.Value;

            buttonUp.Enabled = false;
            buttonGauche.Enabled = false;
            buttonDroite.Enabled = false;

            CalculDeplacements(nameCommande, vit);
            EnvoieDonnees();
        }

        private void buttonReculer_MouseUp(object sender, MouseEventArgs e)
        {
            buttonUp.Enabled = true;
            buttonGauche.Enabled = true;
            buttonDroite.Enabled = true;
        }

        private void EnvoieDonnees()
        {
            donneesAEnvoyer = vitesse + cmdDeplacement;
            for(int i = 0; i < 5; i++)
            {
                FluxDonnees = ClientSocket.GetStream();
                Byte[] Move;


                switch (donneesAEnvoyer)
                {
                    case "NA":
                        try
                        {
                            Move = new Byte[2] { 0x4e, 0x41 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                           
                        }
                        break;
                    case "LA":
                        try
                        {
                            Move = new Byte[2] { 0x4c, 0x41 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "RA":
                        try
                        {
                            Move = new Byte[2] { 0x52, 0x41 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "NR":
                        try
                        {
                            Move = new Byte[2] { 0x4e, 0x52 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);

                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "LR":
                        try
                        {
                            Move = new Byte[2] { 0x4c, 0x52 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "RR":
                        try
                        {
                            Move = new Byte[2] { 0x52, 0x52 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "ND":
                        try
                        {
                            Move = new Byte[2] { 0x4e, 0x44 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "LD":
                        try
                        {
                            Move = new Byte[2] { 0x4c, 0x44 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "RD":
                        try
                        {
                            Move = new Byte[2] { 0x52, 0x44 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                           
                        }
                        break;
                    case "NG":
                        try
                        {
                            Move = new Byte[2] { 0x4e, 0x47 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "LG":
                        try
                        {
                            Move = new Byte[2] { 0x4c, 0x47 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                    case "RG":
                        try
                        {
                            Move = new Byte[2] { 0x52, 0x47 };
                            FluxDonnees.Write(Move, 0, 2);
                            Thread.Sleep(250);
                        }
                        catch (Exception e)
                        {
                            
                        }
                        break;
                }
            }
        }

        private void CalculDeplacements(string cmd, int speed)
        {
            switch (speed)
            {
                case 1:
                    vitesse = "L";
                    break;
                case 2:
                    vitesse = "N";
                    break;
                case 3:
                    vitesse = "R";
                    break;
            }

            switch (nameCommande)
            {
                case "Avancer":
                    cmdDeplacement = "A";
                    break;

                case "Reculer":
                    cmdDeplacement = "R";
                    break;

                case "Droite":
                    cmdDeplacement = "D";
                    break;

                case "Gauche":
                    cmdDeplacement = "G";
                    break;
            }
        }

        private void RecupMessClientUDP()
        {
            float Prem;
            float Deux;
            float Trois;
            float Quatre;
            object[] args = new object[1];           
            while (true)
            {
                MsgClientUDP = serverUDP.GetMSG;

                try
                {
                    string Test = MsgClientUDP;

                    char[] Separator = new char[] { '/' };
                    string[] cap1;


                    cap1 = Test.Split(Separator, 4,StringSplitOptions.None);

                    Prem = float.Parse(cap1[0]);
                    Deux = float.Parse(cap1[1]);
                    Trois = float.Parse(cap1[2]);
                    Quatre = float.Parse(cap1[3]);

                    cap1[0] = cap1[0] + " %";
                    cap1[1] = cap1[1] + " %";
                    cap1[2] = cap1[2] + " %";
                    cap1[3] = cap1[3] + " %";

                    if(Prem < 40.00)
                    {
                        labelCap1.ForeColor = Color.Red;
                    }
                    if (Prem > 40.00 && Prem < 60.00)
                    {
                        labelCap1.ForeColor = Color.Orange;
                    }
                    if (Prem > 60.00)
                    {
                        labelCap1.ForeColor = Color.Green;
                    }

                    if (Deux < 40.00)
                    {
                        labelCap2.ForeColor = Color.Red;
                    }
                    if (Deux > 40.00 && Prem < 60.00)
                    {
                        labelCap2.ForeColor = Color.Orange;
                    }
                    if (Deux > 60.00)
                    {
                        labelCap2.ForeColor = Color.Green;
                    }

                    if (Trois < 40.00)
                    {
                        labelCap3.ForeColor = Color.Red;
                    }
                    if (Trois > 40.00 && Prem < 60.00)
                    {
                        labelCap3.ForeColor = Color.Orange;
                    }
                    if (Trois > 60.00)
                    {
                        labelCap3.ForeColor = Color.Green;
                    }

                    if (Quatre < 40.00)
                    {
                        labelCap4.ForeColor = Color.Red;
                    }
                    if (Quatre > 40.00 && Prem < 60.00)
                    {
                        labelCap4.ForeColor = Color.Orange;
                    }
                    if (Quatre > 60.00)
                    {
                        labelCap4.ForeColor = Color.Green;
                    }


                    labelCap1.Invoke((MethodInvoker)delegate {
                        labelCap1.Text = cap1[0];
                    });
                    labelCap2.Invoke((MethodInvoker)delegate {
                        labelCap2.Text = cap1[1];
                    });
                    labelCap3.Invoke((MethodInvoker)delegate {
                        labelCap3.Text = cap1[2];
                    });
                    labelCap4.Invoke((MethodInvoker)delegate {
                        labelCap4.Text = cap1[3];
                    });
                    
                    
                    
                    /*string Resultat = "Capteur 1 : " + cap1[0] + "\nCapteur 2 : " + cap1[1]  + "\nCapteur 3 : " + cap1[2] + "\nCapteur 4 : " + cap1[3];
                    textBoxAreaConsole.Invoke((MethodInvoker)delegate {
                        textBoxAreaConsole.Text = Resultat + "\n\n\n";
                    });*/

                    Thread.Sleep(500);
                }
                catch(Exception e)
                {
                    
                }
            }
        }


    }

    public class ServerUDP
    {
        string msg;
        public ServerUDP(string messageR)
        {
            msg = messageR;

        }
        public void serverThread()
        {
            try { 
            UdpClient udpClient = new UdpClient(53000);

                while (true)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);

                    string returnData = Encoding.ASCII.GetString(receiveBytes);

                    msg = returnData.ToString();
                    //MessageBox.Show(msg);
                }
            }catch(Exception e)
            { }
        }

        public string GetMSG
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
