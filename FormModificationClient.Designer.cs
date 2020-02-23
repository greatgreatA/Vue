namespace Vue
{
    partial class FormModificationClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumeClient = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxAdresse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bModifValidee = new System.Windows.Forms.Button();
            this.bModifAnnulee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero Client :";
            // 
            // textBoxNumeClient
            // 
            this.textBoxNumeClient.Enabled = false;
            this.textBoxNumeClient.Location = new System.Drawing.Point(174, 65);
            this.textBoxNumeClient.Name = "textBoxNumeClient";
            this.textBoxNumeClient.Size = new System.Drawing.Size(364, 26);
            this.textBoxNumeClient.TabIndex = 1;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(174, 125);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(364, 26);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(174, 185);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(364, 26);
            this.textBoxPrenom.TabIndex = 3;
            // 
            // textBoxAdresse
            // 
            this.textBoxAdresse.Location = new System.Drawing.Point(174, 245);
            this.textBoxAdresse.Name = "textBoxAdresse";
            this.textBoxAdresse.Size = new System.Drawing.Size(364, 26);
            this.textBoxAdresse.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prénom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse :";
            // 
            // bModifValidee
            // 
            this.bModifValidee.Location = new System.Drawing.Point(174, 320);
            this.bModifValidee.Name = "bModifValidee";
            this.bModifValidee.Size = new System.Drawing.Size(168, 57);
            this.bModifValidee.TabIndex = 8;
            this.bModifValidee.Text = "Valider";
            this.bModifValidee.UseVisualStyleBackColor = true;
            this.bModifValidee.Click += new System.EventHandler(this.bModifValidee_Click);
            // 
            // bModifAnnulee
            // 
            this.bModifAnnulee.Location = new System.Drawing.Point(370, 320);
            this.bModifAnnulee.Name = "bModifAnnulee";
            this.bModifAnnulee.Size = new System.Drawing.Size(168, 57);
            this.bModifAnnulee.TabIndex = 9;
            this.bModifAnnulee.Text = "Annuler";
            this.bModifAnnulee.UseVisualStyleBackColor = true;
            this.bModifAnnulee.Click += new System.EventHandler(this.bModifAnnulee_Click);
            // 
            // FormModificationClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 430);
            this.Controls.Add(this.bModifAnnulee);
            this.Controls.Add(this.bModifValidee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdresse);
            this.Controls.Add(this.textBoxPrenom);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.textBoxNumeClient);
            this.Controls.Add(this.label1);
            this.Name = "FormModificationClient";
            this.Text = "FormModificationClient";
            this.Load += new System.EventHandler(this.FormModificationClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumeClient;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxAdresse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bModifValidee;
        private System.Windows.Forms.Button bModifAnnulee;
    }
}