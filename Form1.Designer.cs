namespace Vue
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.débiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.découvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lMontant = new System.Windows.Forms.Label();
            this.tMontant = new System.Windows.Forms.TextBox();
            this.bValider = new System.Windows.Forms.Button();
            this.lMessage = new System.Windows.Forms.Label();
            this.lIndiquer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationsToolStripMenuItem,
            this.modificationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1935, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operationsToolStripMenuItem
            // 
            this.operationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créditerToolStripMenuItem,
            this.débiterToolStripMenuItem});
            this.operationsToolStripMenuItem.Name = "operationsToolStripMenuItem";
            this.operationsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.operationsToolStripMenuItem.Text = "Operations";
            // 
            // créditerToolStripMenuItem
            // 
            this.créditerToolStripMenuItem.Name = "créditerToolStripMenuItem";
            this.créditerToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.créditerToolStripMenuItem.Text = "Créditer";
            this.créditerToolStripMenuItem.Click += new System.EventHandler(this.créditerToolStripMenuItem_Click);
            // 
            // débiterToolStripMenuItem
            // 
            this.débiterToolStripMenuItem.Name = "débiterToolStripMenuItem";
            this.débiterToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.débiterToolStripMenuItem.Text = "Débiter";
            this.débiterToolStripMenuItem.Click += new System.EventHandler(this.débiterToolStripMenuItem_Click);
            // 
            // modificationsToolStripMenuItem
            // 
            this.modificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.découvertToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.modificationsToolStripMenuItem.Name = "modificationsToolStripMenuItem";
            this.modificationsToolStripMenuItem.Size = new System.Drawing.Size(136, 29);
            this.modificationsToolStripMenuItem.Text = "Modifications";
            // 
            // découvertToolStripMenuItem
            // 
            this.découvertToolStripMenuItem.Name = "découvertToolStripMenuItem";
            this.découvertToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.découvertToolStripMenuItem.Text = "Découvert";
            this.découvertToolStripMenuItem.Click += new System.EventHandler(this.découvertToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(195, 34);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1935, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(445, 140);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1411, 420);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comptes Clients";
            // 
            // lMontant
            // 
            this.lMontant.AutoEllipsis = true;
            this.lMontant.AutoSize = true;
            this.lMontant.Location = new System.Drawing.Point(441, 615);
            this.lMontant.Name = "lMontant";
            this.lMontant.Size = new System.Drawing.Size(80, 20);
            this.lMontant.TabIndex = 4;
            this.lMontant.Text = "Montant : ";
            // 
            // tMontant
            // 
            this.tMontant.Location = new System.Drawing.Point(584, 612);
            this.tMontant.Name = "tMontant";
            this.tMontant.Size = new System.Drawing.Size(199, 26);
            this.tMontant.TabIndex = 5;
            this.tMontant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMontant_KeyPress);
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(833, 595);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(273, 60);
            this.bValider.TabIndex = 6;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // lMessage
            // 
            this.lMessage.AutoSize = true;
            this.lMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMessage.ForeColor = System.Drawing.Color.Red;
            this.lMessage.Location = new System.Drawing.Point(9, 229);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(430, 29);
            this.lMessage.TabIndex = 7;
            this.lMessage.Text = "Veuillez Selectionner un compte. Merci";
            this.lMessage.Visible = false;
            // 
            // lIndiquer
            // 
            this.lIndiquer.AutoSize = true;
            this.lIndiquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIndiquer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lIndiquer.Location = new System.Drawing.Point(114, 615);
            this.lIndiquer.Name = "lIndiquer";
            this.lIndiquer.Size = new System.Drawing.Size(209, 25);
            this.lIndiquer.TabIndex = 8;
            this.lIndiquer.Text = "Indiquez un montant à ";
            this.lIndiquer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1935, 733);
            this.Controls.Add(this.lIndiquer);
            this.Controls.Add(this.lMessage);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.tMontant);
            this.Controls.Add(this.lMontant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem débiterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem découvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lMontant;
        private System.Windows.Forms.TextBox tMontant;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lIndiquer;
    }
}

