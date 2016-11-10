namespace FRv1
{
    partial class CreateSujet
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
            this.gBxTitreSujet = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gBxDescription = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btValider = new System.Windows.Forms.Button();
            this.gBxTitreSujet.SuspendLayout();
            this.gBxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBxTitreSujet
            // 
            this.gBxTitreSujet.Controls.Add(this.textBox1);
            this.gBxTitreSujet.Location = new System.Drawing.Point(13, 23);
            this.gBxTitreSujet.Name = "gBxTitreSujet";
            this.gBxTitreSujet.Size = new System.Drawing.Size(366, 76);
            this.gBxTitreSujet.TabIndex = 0;
            this.gBxTitreSujet.TabStop = false;
            this.gBxTitreSujet.Text = "Titre du sujet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 20);
            this.textBox1.TabIndex = 0;
            // 
            // gBxDescription
            // 
            this.gBxDescription.Controls.Add(this.textBox2);
            this.gBxDescription.Location = new System.Drawing.Point(12, 122);
            this.gBxDescription.Name = "gBxDescription";
            this.gBxDescription.Size = new System.Drawing.Size(366, 170);
            this.gBxDescription.TabIndex = 1;
            this.gBxDescription.TabStop = false;
            this.gBxDescription.Text = "Description sujet";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 31);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(337, 133);
            this.textBox2.TabIndex = 0;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(13, 300);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 8;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            // 
            // btValider
            // 
            this.btValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.Location = new System.Drawing.Point(270, 300);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(109, 40);
            this.btValider.TabIndex = 9;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            // 
            // CreateSujet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 352);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.gBxDescription);
            this.Controls.Add(this.gBxTitreSujet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateSujet";
            this.Text = "Alors on bouge !";
            this.gBxTitreSujet.ResumeLayout(false);
            this.gBxTitreSujet.PerformLayout();
            this.gBxDescription.ResumeLayout(false);
            this.gBxDescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBxTitreSujet;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gBxDescription;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btValider;
    }
}