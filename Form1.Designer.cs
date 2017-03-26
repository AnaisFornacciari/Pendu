namespace pendu
{
    partial class frmPendu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPendu));
            this.pictPendu = new System.Windows.Forms.PictureBox();
            this.btnNouvMot = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.LettresF = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictPendu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictPendu
            // 
            this.pictPendu.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictPendu.Image = ((System.Drawing.Image)(resources.GetObject("pictPendu.Image")));
            this.pictPendu.Location = new System.Drawing.Point(48, 31);
            this.pictPendu.Name = "pictPendu";
            this.pictPendu.Size = new System.Drawing.Size(276, 260);
            this.pictPendu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPendu.TabIndex = 3;
            this.pictPendu.TabStop = false;
            // 
            // btnNouvMot
            // 
            this.btnNouvMot.BackColor = System.Drawing.Color.Transparent;
            this.btnNouvMot.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouvMot.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnNouvMot.Location = new System.Drawing.Point(508, 279);
            this.btnNouvMot.Name = "btnNouvMot";
            this.btnNouvMot.Size = new System.Drawing.Size(99, 45);
            this.btnNouvMot.TabIndex = 12;
            this.btnNouvMot.Text = "&Rejouer";
            this.btnNouvMot.UseVisualStyleBackColor = false;
            this.btnNouvMot.Click += new System.EventHandler(this.btnNouvMot_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(91, 145);
            this.lbl3.MinimumSize = new System.Drawing.Size(90, 37);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(90, 37);
            this.lbl3.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(164, 110);
            this.lbl2.MinimumSize = new System.Drawing.Size(40, 35);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(40, 35);
            this.lbl2.TabIndex = 1;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(175, 145);
            this.lbl5.MinimumSize = new System.Drawing.Size(50, 37);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(50, 37);
            this.lbl5.TabIndex = 4;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(187, 145);
            this.lbl4.MinimumSize = new System.Drawing.Size(90, 37);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(90, 37);
            this.lbl4.TabIndex = 3;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.BackColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(91, 182);
            this.lbl6.MinimumSize = new System.Drawing.Size(90, 37);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(90, 37);
            this.lbl6.TabIndex = 5;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.BackColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(175, 182);
            this.lbl7.MinimumSize = new System.Drawing.Size(90, 37);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(90, 37);
            this.lbl7.TabIndex = 6;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(142, 72);
            this.lbl1.MinimumSize = new System.Drawing.Size(90, 38);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(90, 38);
            this.lbl1.TabIndex = 0;
            // 
            // LettresF
            // 
            this.LettresF.BackColor = System.Drawing.Color.DarkGray;
            this.LettresF.Enabled = false;
            this.LettresF.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LettresF.Location = new System.Drawing.Point(403, 31);
            this.LettresF.Name = "LettresF";
            this.LettresF.Size = new System.Drawing.Size(339, 40);
            this.LettresF.TabIndex = 13;
            this.LettresF.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Lettres fausses";
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LettresF);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnNouvMot);
            this.Controls.Add(this.pictPendu);
            this.Name = "frmPendu";
            this.Text = "Le pendu";
            ((System.ComponentModel.ISupportInitialize)(this.pictPendu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictPendu;
        private System.Windows.Forms.Button btnNouvMot;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.RichTextBox LettresF;
        private System.Windows.Forms.Label label1;
        

    }
}

