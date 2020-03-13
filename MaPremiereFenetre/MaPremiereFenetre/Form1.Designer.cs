namespace MaPremiereFenetre
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
            this.btn_TraduireClick = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.rbAllemand = new System.Windows.Forms.RadioButton();
            this.rbAnglais = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEspagnol = new System.Windows.Forms.RadioButton();
            this.rbTurc = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_TraduireClick
            // 
            this.btn_TraduireClick.Location = new System.Drawing.Point(154, 159);
            this.btn_TraduireClick.Name = "btn_TraduireClick";
            this.btn_TraduireClick.Size = new System.Drawing.Size(75, 23);
            this.btn_TraduireClick.TabIndex = 0;
            this.btn_TraduireClick.Text = "Traduction";
            this.btn_TraduireClick.UseVisualStyleBackColor = true;
            this.btn_TraduireClick.Click += new System.EventHandler(this.btn_TraduireClick_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(48, 162);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 1;
            this.tbNom.TextChanged += new System.EventHandler(this.tbNom_TextChanged);
            // 
            // rbAllemand
            // 
            this.rbAllemand.AutoSize = true;
            this.rbAllemand.Location = new System.Drawing.Point(18, 31);
            this.rbAllemand.Name = "rbAllemand";
            this.rbAllemand.Size = new System.Drawing.Size(68, 17);
            this.rbAllemand.TabIndex = 2;
            this.rbAllemand.TabStop = true;
            this.rbAllemand.Text = "Allemand";
            this.rbAllemand.UseVisualStyleBackColor = true;
            this.rbAllemand.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbAnglais
            // 
            this.rbAnglais.AutoSize = true;
            this.rbAnglais.Location = new System.Drawing.Point(18, 54);
            this.rbAnglais.Name = "rbAnglais";
            this.rbAnglais.Size = new System.Drawing.Size(59, 17);
            this.rbAnglais.TabIndex = 3;
            this.rbAnglais.TabStop = true;
            this.rbAnglais.Text = "Anglais";
            this.rbAnglais.UseVisualStyleBackColor = true;
            this.rbAnglais.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTurc);
            this.groupBox1.Controls.Add(this.tbEspagnol);
            this.groupBox1.Controls.Add(this.rbAllemand);
            this.groupBox1.Controls.Add(this.rbAnglais);
            this.groupBox1.Location = new System.Drawing.Point(48, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Langues";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Entrez votre prénom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbEspagnol
            // 
            this.tbEspagnol.AutoSize = true;
            this.tbEspagnol.Location = new System.Drawing.Point(18, 74);
            this.tbEspagnol.Name = "tbEspagnol";
            this.tbEspagnol.Size = new System.Drawing.Size(69, 17);
            this.tbEspagnol.TabIndex = 4;
            this.tbEspagnol.TabStop = true;
            this.tbEspagnol.Text = "Espagnol";
            this.tbEspagnol.UseVisualStyleBackColor = true;
            this.tbEspagnol.CheckedChanged += new System.EventHandler(this.tbEspagnol_CheckedChanged);
            // 
            // rbTurc
            // 
            this.rbTurc.AutoSize = true;
            this.rbTurc.Location = new System.Drawing.Point(18, 95);
            this.rbTurc.Name = "rbTurc";
            this.rbTurc.Size = new System.Drawing.Size(47, 17);
            this.rbTurc.TabIndex = 5;
            this.rbTurc.TabStop = true;
            this.rbTurc.Text = "Turc";
            this.rbTurc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btn_TraduireClick);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TraduireClick;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.RadioButton rbAllemand;
        private System.Windows.Forms.RadioButton rbAnglais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton tbEspagnol;
        private System.Windows.Forms.RadioButton rbTurc;
    }
}

