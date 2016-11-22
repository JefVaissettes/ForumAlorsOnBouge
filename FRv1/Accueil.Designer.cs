namespace IHMFR
{
    partial class Accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.textSummary = new System.Windows.Forms.TextBox();
            this.btConsul = new System.Windows.Forms.Button();
            this.btQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSummary
            // 
            this.textSummary.AcceptsReturn = true;
            this.textSummary.AcceptsTab = true;
            this.textSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSummary.Location = new System.Drawing.Point(13, 79);
            this.textSummary.Multiline = true;
            this.textSummary.Name = "textSummary";
            this.textSummary.Size = new System.Drawing.Size(830, 108);
            this.textSummary.TabIndex = 0;
            this.textSummary.Text = resources.GetString("textSummary.Text");
            this.textSummary.UseWaitCursor = true;
            // 
            // btConsul
            // 
            this.btConsul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConsul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsul.Location = new System.Drawing.Point(693, 245);
            this.btConsul.Name = "btConsul";
            this.btConsul.Size = new System.Drawing.Size(132, 34);
            this.btConsul.TabIndex = 1;
            this.btConsul.Text = "Consulter le forum";
            this.btConsul.UseVisualStyleBackColor = true;
            this.btConsul.Click += new System.EventHandler(this.btConsul_Click);
            // 
            // btQuitter
            // 
            this.btQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitter.Location = new System.Drawing.Point(37, 245);
            this.btQuitter.Name = "btQuitter";
            this.btQuitter.Size = new System.Drawing.Size(132, 34);
            this.btQuitter.TabIndex = 4;
            this.btQuitter.Text = "Quitter";
            this.btQuitter.UseVisualStyleBackColor = true;
            this.btQuitter.Click += new System.EventHandler(this.btQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Accueil";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(855, 306);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuitter);
            this.Controls.Add(this.btConsul);
            this.Controls.Add(this.textSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Accueil";
            this.Text = "Alors on bouge !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSummary;
        private System.Windows.Forms.Button btConsul;
        private System.Windows.Forms.Button btQuitter;
        private System.Windows.Forms.Label label1;
    }
}

