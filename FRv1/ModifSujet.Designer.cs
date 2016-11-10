namespace FRv1
{
    partial class ModifSujet
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
            this.gpBxSujet = new System.Windows.Forms.GroupBox();
            this.gpBxDescSujet = new System.Windows.Forms.GroupBox();
            this.txtBxTitreAncien = new System.Windows.Forms.TextBox();
            this.txtBxNouveauTitre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.gpBxSujet.SuspendLayout();
            this.gpBxDescSujet.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpBxSujet
            // 
            this.gpBxSujet.Controls.Add(this.label2);
            this.gpBxSujet.Controls.Add(this.label1);
            this.gpBxSujet.Controls.Add(this.txtBxNouveauTitre);
            this.gpBxSujet.Controls.Add(this.txtBxTitreAncien);
            this.gpBxSujet.Location = new System.Drawing.Point(18, 19);
            this.gpBxSujet.Name = "gpBxSujet";
            this.gpBxSujet.Size = new System.Drawing.Size(410, 133);
            this.gpBxSujet.TabIndex = 0;
            this.gpBxSujet.TabStop = false;
            this.gpBxSujet.Text = "Titre du sujet";
            // 
            // gpBxDescSujet
            // 
            this.gpBxDescSujet.Controls.Add(this.textBox2);
            this.gpBxDescSujet.Controls.Add(this.textBox1);
            this.gpBxDescSujet.Controls.Add(this.label4);
            this.gpBxDescSujet.Controls.Add(this.label3);
            this.gpBxDescSujet.Location = new System.Drawing.Point(18, 172);
            this.gpBxDescSujet.Name = "gpBxDescSujet";
            this.gpBxDescSujet.Size = new System.Drawing.Size(410, 233);
            this.gpBxDescSujet.TabIndex = 1;
            this.gpBxDescSujet.TabStop = false;
            this.gpBxDescSujet.Text = "Description du sujet";
            // 
            // txtBxTitreAncien
            // 
            this.txtBxTitreAncien.Location = new System.Drawing.Point(14, 42);
            this.txtBxTitreAncien.Name = "txtBxTitreAncien";
            this.txtBxTitreAncien.Size = new System.Drawing.Size(377, 20);
            this.txtBxTitreAncien.TabIndex = 0;
            // 
            // txtBxNouveauTitre
            // 
            this.txtBxNouveauTitre.Location = new System.Drawing.Point(14, 94);
            this.txtBxNouveauTitre.Name = "txtBxNouveauTitre";
            this.txtBxNouveauTitre.Size = new System.Drawing.Size(377, 20);
            this.txtBxNouveauTitre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titre actuel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nouveau titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description actuelle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nouvelle description";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 37);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(377, 81);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(14, 141);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(377, 82);
            this.textBox2.TabIndex = 6;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(18, 411);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 9;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(319, 411);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(109, 40);
            this.btValider.TabIndex = 10;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            // 
            // ModifSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 458);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.gpBxDescSujet);
            this.Controls.Add(this.gpBxSujet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ModifSujet";
            this.Text = "Alors on bouge !";
            this.gpBxSujet.ResumeLayout(false);
            this.gpBxSujet.PerformLayout();
            this.gpBxDescSujet.ResumeLayout(false);
            this.gpBxDescSujet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpBxSujet;
        private System.Windows.Forms.GroupBox gpBxDescSujet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxNouveauTitre;
        private System.Windows.Forms.TextBox txtBxTitreAncien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}