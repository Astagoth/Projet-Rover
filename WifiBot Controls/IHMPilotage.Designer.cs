namespace AppWifiBot_Controls
{
    partial class IHMPilotage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.retourAuMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrêterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGauche = new System.Windows.Forms.Button();
            this.buttonDroite = new System.Windows.Forms.Button();
            this.buttonReculer = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.barVitesse = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelConnect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelCap4 = new System.Windows.Forms.Label();
            this.labelCap3 = new System.Windows.Forms.Label();
            this.labelCap2 = new System.Windows.Forms.Label();
            this.labelCap1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barVitesse)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourAuMenuToolStripMenuItem,
            this.arrêterToolStripMenuItem,
            this.connecToolStripMenuItem,
            this.configToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retourAuMenuToolStripMenuItem
            // 
            this.retourAuMenuToolStripMenuItem.Name = "retourAuMenuToolStripMenuItem";
            this.retourAuMenuToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.retourAuMenuToolStripMenuItem.Text = "Retour au menu";
            this.retourAuMenuToolStripMenuItem.Click += new System.EventHandler(this.retourAuMenuToolStripMenuItem_Click);
            // 
            // arrêterToolStripMenuItem
            // 
            this.arrêterToolStripMenuItem.Name = "arrêterToolStripMenuItem";
            this.arrêterToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.arrêterToolStripMenuItem.Text = "Arrêter";
            this.arrêterToolStripMenuItem.Click += new System.EventHandler(this.arrêterToolStripMenuItem_Click);
            // 
            // connecToolStripMenuItem
            // 
            this.connecToolStripMenuItem.Name = "connecToolStripMenuItem";
            this.connecToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.connecToolStripMenuItem.Text = "Connecter";
            this.connecToolStripMenuItem.Click += new System.EventHandler(this.connecToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGauche);
            this.groupBox1.Controls.Add(this.buttonDroite);
            this.groupBox1.Controls.Add(this.buttonReculer);
            this.groupBox1.Controls.Add(this.buttonUp);
            this.groupBox1.Location = new System.Drawing.Point(416, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 237);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Palette de pilotage";
            // 
            // buttonGauche
            // 
            this.buttonGauche.Location = new System.Drawing.Point(17, 110);
            this.buttonGauche.Name = "buttonGauche";
            this.buttonGauche.Size = new System.Drawing.Size(89, 46);
            this.buttonGauche.TabIndex = 9;
            this.buttonGauche.Text = "Gauche";
            this.buttonGauche.UseVisualStyleBackColor = true;
            this.buttonGauche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonGauche_MouseDown);
            this.buttonGauche.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonGauche_MouseUp);
            // 
            // buttonDroite
            // 
            this.buttonDroite.Location = new System.Drawing.Point(207, 110);
            this.buttonDroite.Name = "buttonDroite";
            this.buttonDroite.Size = new System.Drawing.Size(89, 46);
            this.buttonDroite.TabIndex = 8;
            this.buttonDroite.Text = "Droite";
            this.buttonDroite.UseVisualStyleBackColor = true;
            this.buttonDroite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDroite_MouseDown);
            this.buttonDroite.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonDroite_MouseUp);
            // 
            // buttonReculer
            // 
            this.buttonReculer.Location = new System.Drawing.Point(112, 162);
            this.buttonReculer.Name = "buttonReculer";
            this.buttonReculer.Size = new System.Drawing.Size(89, 46);
            this.buttonReculer.TabIndex = 7;
            this.buttonReculer.Text = "Reculer";
            this.buttonReculer.UseVisualStyleBackColor = true;
            this.buttonReculer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonReculer_MouseDown);
            this.buttonReculer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonReculer_MouseUp);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(112, 56);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(89, 46);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.Text = "Avancer";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseDown);
            this.buttonUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonUp_MouseUp);
            // 
            // barVitesse
            // 
            this.barVitesse.LargeChange = 1;
            this.barVitesse.Location = new System.Drawing.Point(783, 126);
            this.barVitesse.Maximum = 3;
            this.barVitesse.Minimum = 1;
            this.barVitesse.Name = "barVitesse";
            this.barVitesse.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.barVitesse.Size = new System.Drawing.Size(56, 237);
            this.barVitesse.TabIndex = 3;
            this.barVitesse.Value = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(835, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rapide";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(835, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Normal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(835, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Lent";
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.Location = new System.Drawing.Point(523, 68);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(133, 25);
            this.labelConnect.TabIndex = 7;
            this.labelConnect.Text = "Non connecté";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rover :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelCap4);
            this.groupBox2.Controls.Add(this.labelCap3);
            this.groupBox2.Controls.Add(this.labelCap2);
            this.groupBox2.Controls.Add(this.labelCap1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(23, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 304);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Capteurs";
            // 
            // labelCap4
            // 
            this.labelCap4.AutoSize = true;
            this.labelCap4.Location = new System.Drawing.Point(106, 277);
            this.labelCap4.Name = "labelCap4";
            this.labelCap4.Size = new System.Drawing.Size(0, 17);
            this.labelCap4.TabIndex = 7;
            // 
            // labelCap3
            // 
            this.labelCap3.AutoSize = true;
            this.labelCap3.Location = new System.Drawing.Point(106, 192);
            this.labelCap3.Name = "labelCap3";
            this.labelCap3.Size = new System.Drawing.Size(0, 17);
            this.labelCap3.TabIndex = 6;
            // 
            // labelCap2
            // 
            this.labelCap2.AutoSize = true;
            this.labelCap2.Location = new System.Drawing.Point(106, 123);
            this.labelCap2.Name = "labelCap2";
            this.labelCap2.Size = new System.Drawing.Size(0, 17);
            this.labelCap2.TabIndex = 5;
            // 
            // labelCap1
            // 
            this.labelCap1.AutoSize = true;
            this.labelCap1.Location = new System.Drawing.Point(106, 58);
            this.labelCap1.Name = "labelCap1";
            this.labelCap1.Size = new System.Drawing.Size(0, 17);
            this.labelCap1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Capteur 4 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Capteur 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Capteur 2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Capteur 1 :";
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.configToolStripMenuItem.Text = "Config...";
            this.configToolStripMenuItem.Click += new System.EventHandler(this.configToolStripMenuItem_Click);
            // 
            // IHMPilotage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barVitesse);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IHMPilotage";
            this.Text = "IHMPilotage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IHMPilotage_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barVitesse)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retourAuMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrêterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connecToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar barVitesse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonReculer;
        private System.Windows.Forms.Button buttonGauche;
        private System.Windows.Forms.Button buttonDroite;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelCap4;
        private System.Windows.Forms.Label labelCap3;
        private System.Windows.Forms.Label labelCap2;
        private System.Windows.Forms.Label labelCap1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
    }
}