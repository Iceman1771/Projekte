namespace KFZProgramm
{
    partial class Haupfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabKunden = new System.Windows.Forms.TabPage();
            this.btnKundesuchen = new System.Windows.Forms.Button();
            this.btnNeuerKunde = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabKunden.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabKunden);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 537);
            this.tabControl1.TabIndex = 1;
            // 
            // tabKunden
            // 
            this.tabKunden.Controls.Add(this.btnKundesuchen);
            this.tabKunden.Controls.Add(this.btnNeuerKunde);
            this.tabKunden.Location = new System.Drawing.Point(4, 22);
            this.tabKunden.Name = "tabKunden";
            this.tabKunden.Padding = new System.Windows.Forms.Padding(3);
            this.tabKunden.Size = new System.Drawing.Size(776, 511);
            this.tabKunden.TabIndex = 0;
            this.tabKunden.Text = "Kunden";
            this.tabKunden.UseVisualStyleBackColor = true;
            // 
            // btnKundesuchen
            // 
            this.btnKundesuchen.Location = new System.Drawing.Point(214, 6);
            this.btnKundesuchen.Name = "btnKundesuchen";
            this.btnKundesuchen.Size = new System.Drawing.Size(134, 23);
            this.btnKundesuchen.TabIndex = 1;
            this.btnKundesuchen.Text = "Kunde suchen";
            this.btnKundesuchen.UseVisualStyleBackColor = true;
            this.btnKundesuchen.Click += new System.EventHandler(this.btnKundesuchen_Click);
            // 
            // btnNeuerKunde
            // 
            this.btnNeuerKunde.Location = new System.Drawing.Point(8, 6);
            this.btnNeuerKunde.Name = "btnNeuerKunde";
            this.btnNeuerKunde.Size = new System.Drawing.Size(185, 23);
            this.btnNeuerKunde.TabIndex = 0;
            this.btnNeuerKunde.Text = "neuen Kunde anlegen";
            this.btnNeuerKunde.UseVisualStyleBackColor = true;
            this.btnNeuerKunde.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(692, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Haupfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Haupfenster";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabKunden.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabKunden;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnKundesuchen;
        private System.Windows.Forms.Button btnNeuerKunde;
    }
}

