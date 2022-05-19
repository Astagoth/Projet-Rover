namespace AppWifiBot_Controls
{
    partial class IHMMenuAuto
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
            this.retourAuModeDeContrôleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonSuivi_Auto = new System.Windows.Forms.Button();
            this.buttonCR_Auto = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.retourAuModeDeContrôleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // retourAuModeDeContrôleToolStripMenuItem
            // 
            this.retourAuModeDeContrôleToolStripMenuItem.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retourAuModeDeContrôleToolStripMenuItem.Name = "retourAuModeDeContrôleToolStripMenuItem";
            this.retourAuModeDeContrôleToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.retourAuModeDeContrôleToolStripMenuItem.Text = "Retour au mode de contrôle";
            this.retourAuModeDeContrôleToolStripMenuItem.Click += new System.EventHandler(this.retourAuModeDeContrôleToolStripMenuItem_Click);
            // 
            // buttonSuivi_Auto
            // 
            this.buttonSuivi_Auto.Location = new System.Drawing.Point(105, 48);
            this.buttonSuivi_Auto.Name = "buttonSuivi_Auto";
            this.buttonSuivi_Auto.Size = new System.Drawing.Size(133, 63);
            this.buttonSuivi_Auto.TabIndex = 1;
            this.buttonSuivi_Auto.Text = "Suivi de Billy";
            this.buttonSuivi_Auto.UseVisualStyleBackColor = true;
            this.buttonSuivi_Auto.Click += new System.EventHandler(this.buttonSuivi_Auto_Click);
            // 
            // buttonCR_Auto
            // 
            this.buttonCR_Auto.Location = new System.Drawing.Point(105, 145);
            this.buttonCR_Auto.Name = "buttonCR_Auto";
            this.buttonCR_Auto.Size = new System.Drawing.Size(133, 63);
            this.buttonCR_Auto.TabIndex = 2;
            this.buttonCR_Auto.Text = "Compte Rendu";
            this.buttonCR_Auto.UseVisualStyleBackColor = true;
            this.buttonCR_Auto.Click += new System.EventHandler(this.buttonCR_Auto_Click);
            // 
            // IHMMenuAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 235);
            this.Controls.Add(this.buttonCR_Auto);
            this.Controls.Add(this.buttonSuivi_Auto);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "IHMMenuAuto";
            this.Text = "IHMMenuAuto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem retourAuModeDeContrôleToolStripMenuItem;
        private System.Windows.Forms.Button buttonSuivi_Auto;
        private System.Windows.Forms.Button buttonCR_Auto;
    }
}