namespace MonAppli
{
    partial class FListe
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_saisie = new System.Windows.Forms.TextBox();
            this.lb_liste = new System.Windows.Forms.ListBox();
            this.bt_ajout = new System.Windows.Forms.Button();
            this.bt_supp = new System.Windows.Forms.Button();
            this.bt_droite = new System.Windows.Forms.Button();
            this.bt_gauche = new System.Windows.Forms.Button();
            this.lb_liste2 = new System.Windows.Forms.ListBox();
            this.tb_saisie2 = new System.Windows.Forms.TextBox();
            this.bt_ajout2 = new System.Windows.Forms.Button();
            this.bt_supp2 = new System.Windows.Forms.Button();
            this.bt_quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("MS Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(165, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Un petit exo sympa...";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_saisie
            // 
            this.tb_saisie.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_saisie.Location = new System.Drawing.Point(88, 280);
            this.tb_saisie.Name = "tb_saisie";
            this.tb_saisie.Size = new System.Drawing.Size(142, 20);
            this.tb_saisie.TabIndex = 1;
            this.tb_saisie.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lb_liste
            // 
            this.lb_liste.FormattingEnabled = true;
            this.lb_liste.Location = new System.Drawing.Point(88, 153);
            this.lb_liste.Name = "lb_liste";
            this.lb_liste.Size = new System.Drawing.Size(142, 121);
            this.lb_liste.TabIndex = 2;
            this.lb_liste.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_ajout
            // 
            this.bt_ajout.Location = new System.Drawing.Point(88, 306);
            this.bt_ajout.Name = "bt_ajout";
            this.bt_ajout.Size = new System.Drawing.Size(75, 23);
            this.bt_ajout.TabIndex = 3;
            this.bt_ajout.Text = "+";
            this.bt_ajout.UseVisualStyleBackColor = true;
            this.bt_ajout.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_supp
            // 
            this.bt_supp.Location = new System.Drawing.Point(158, 306);
            this.bt_supp.Name = "bt_supp";
            this.bt_supp.Size = new System.Drawing.Size(72, 23);
            this.bt_supp.TabIndex = 4;
            this.bt_supp.Text = "-";
            this.bt_supp.UseVisualStyleBackColor = true;
            this.bt_supp.Click += new System.EventHandler(this.bt_supp_Click);
            // 
            // bt_droite
            // 
            this.bt_droite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_droite.Location = new System.Drawing.Point(290, 199);
            this.bt_droite.Name = "bt_droite";
            this.bt_droite.Size = new System.Drawing.Size(75, 23);
            this.bt_droite.TabIndex = 5;
            this.bt_droite.Text = ">>";
            this.bt_droite.UseVisualStyleBackColor = true;
            this.bt_droite.Click += new System.EventHandler(this.bt_droite_Click);
            // 
            // bt_gauche
            // 
            this.bt_gauche.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bt_gauche.Location = new System.Drawing.Point(290, 228);
            this.bt_gauche.Name = "bt_gauche";
            this.bt_gauche.Size = new System.Drawing.Size(75, 23);
            this.bt_gauche.TabIndex = 6;
            this.bt_gauche.Text = "<<";
            this.bt_gauche.UseVisualStyleBackColor = true;
            this.bt_gauche.Click += new System.EventHandler(this.bt_gauche_Click);
            // 
            // lb_liste2
            // 
            this.lb_liste2.FormattingEnabled = true;
            this.lb_liste2.Location = new System.Drawing.Point(417, 153);
            this.lb_liste2.Name = "lb_liste2";
            this.lb_liste2.Size = new System.Drawing.Size(142, 121);
            this.lb_liste2.TabIndex = 7;
            this.lb_liste2.SelectedIndexChanged += new System.EventHandler(this.lb_liste2_SelectedIndexChanged);
            // 
            // tb_saisie2
            // 
            this.tb_saisie2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_saisie2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_saisie2.Location = new System.Drawing.Point(417, 280);
            this.tb_saisie2.Name = "tb_saisie2";
            this.tb_saisie2.Size = new System.Drawing.Size(142, 20);
            this.tb_saisie2.TabIndex = 8;
            this.tb_saisie2.TextChanged += new System.EventHandler(this.tb_saisie2_TextChanged);
            // 
            // bt_ajout2
            // 
            this.bt_ajout2.Location = new System.Drawing.Point(417, 306);
            this.bt_ajout2.Name = "bt_ajout2";
            this.bt_ajout2.Size = new System.Drawing.Size(75, 23);
            this.bt_ajout2.TabIndex = 9;
            this.bt_ajout2.Text = "+";
            this.bt_ajout2.UseVisualStyleBackColor = true;
            this.bt_ajout2.Click += new System.EventHandler(this.bt_ajout2_Click);
            // 
            // bt_supp2
            // 
            this.bt_supp2.Location = new System.Drawing.Point(487, 306);
            this.bt_supp2.Name = "bt_supp2";
            this.bt_supp2.Size = new System.Drawing.Size(72, 23);
            this.bt_supp2.TabIndex = 10;
            this.bt_supp2.Text = "-";
            this.bt_supp2.UseVisualStyleBackColor = true;
            this.bt_supp2.Click += new System.EventHandler(this.bt_supp2_Click);
            // 
            // bt_quitter
            // 
            this.bt_quitter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bt_quitter.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bt_quitter.Location = new System.Drawing.Point(290, 347);
            this.bt_quitter.Name = "bt_quitter";
            this.bt_quitter.Size = new System.Drawing.Size(75, 23);
            this.bt_quitter.TabIndex = 11;
            this.bt_quitter.Text = "Quitter";
            this.bt_quitter.UseVisualStyleBackColor = false;
            this.bt_quitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // FListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_quitter);
            this.Controls.Add(this.bt_supp2);
            this.Controls.Add(this.bt_ajout2);
            this.Controls.Add(this.tb_saisie2);
            this.Controls.Add(this.lb_liste2);
            this.Controls.Add(this.bt_gauche);
            this.Controls.Add(this.bt_droite);
            this.Controls.Add(this.bt_supp);
            this.Controls.Add(this.bt_ajout);
            this.Controls.Add(this.lb_liste);
            this.Controls.Add(this.tb_saisie);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "FListe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FListe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_saisie;
        private System.Windows.Forms.ListBox lb_liste;
        private System.Windows.Forms.Button bt_ajout;
        private System.Windows.Forms.Button bt_supp;
        private System.Windows.Forms.Button bt_droite;
        private System.Windows.Forms.Button bt_gauche;
        private System.Windows.Forms.ListBox lb_liste2;
        private System.Windows.Forms.TextBox tb_saisie2;
        private System.Windows.Forms.Button bt_ajout2;
        private System.Windows.Forms.Button bt_supp2;
        private System.Windows.Forms.Button bt_quitter;
    }
}

