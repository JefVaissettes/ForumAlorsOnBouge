namespace IHMFR
{
    partial class RubricSujPost
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
            this.dGVPSubject = new System.Windows.Forms.DataGridView();
            this.btCreerSujet = new System.Windows.Forms.Button();
            this.btModifSujet = new System.Windows.Forms.Button();
            this.cbBxRubric = new System.Windows.Forms.ComboBox();
            this.cbBxSubject = new System.Windows.Forms.ComboBox();
            this.gpBxRubric = new System.Windows.Forms.GroupBox();
            this.lblRubric = new System.Windows.Forms.Label();
            this.gpBxSubject = new System.Windows.Forms.GroupBox();
            this.lblSujet = new System.Windows.Forms.Label();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.btSupSujet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSupPost = new System.Windows.Forms.Button();
            this.btCreerPost = new System.Windows.Forms.Button();
            this.gbxModerator = new System.Windows.Forms.GroupBox();
            this.gbxUserLogged = new System.Windows.Forms.GroupBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.dGVPost = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPSubject)).BeginInit();
            this.gpBxRubric.SuspendLayout();
            this.gpBxSubject.SuspendLayout();
            this.gbxModerator.SuspendLayout();
            this.gbxUserLogged.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPost)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVPSubject
            // 
            this.dGVPSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPSubject.Location = new System.Drawing.Point(12, 48);
            this.dGVPSubject.Name = "dGVPSubject";
            this.dGVPSubject.Size = new System.Drawing.Size(636, 170);
            this.dGVPSubject.TabIndex = 0;
            // 
            // btCreerSujet
            // 
            this.btCreerSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreerSujet.Location = new System.Drawing.Point(129, 8);
            this.btCreerSujet.Name = "btCreerSujet";
            this.btCreerSujet.Size = new System.Drawing.Size(109, 40);
            this.btCreerSujet.TabIndex = 1;
            this.btCreerSujet.Text = "Créer sujet";
            this.btCreerSujet.UseVisualStyleBackColor = true;
            this.btCreerSujet.Click += new System.EventHandler(this.btCreerSujet_Click);
            // 
            // btModifSujet
            // 
            this.btModifSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifSujet.Location = new System.Drawing.Point(20, 19);
            this.btModifSujet.Name = "btModifSujet";
            this.btModifSujet.Size = new System.Drawing.Size(109, 40);
            this.btModifSujet.TabIndex = 2;
            this.btModifSujet.Text = "Modifier sujet";
            this.btModifSujet.UseVisualStyleBackColor = true;
            this.btModifSujet.Click += new System.EventHandler(this.btModifSujet_Click);
            // 
            // cbBxRubric
            // 
            this.cbBxRubric.FormattingEnabled = true;
            this.cbBxRubric.Location = new System.Drawing.Point(8, 28);
            this.cbBxRubric.Name = "cbBxRubric";
            this.cbBxRubric.Size = new System.Drawing.Size(121, 21);
            this.cbBxRubric.TabIndex = 3;
            this.cbBxRubric.SelectedIndexChanged += new System.EventHandler(this.cbBxRubric_SelectedIndexChanged);
            // 
            // cbBxSubject
            // 
            this.cbBxSubject.FormattingEnabled = true;
            this.cbBxSubject.Location = new System.Drawing.Point(10, 35);
            this.cbBxSubject.Name = "cbBxSubject";
            this.cbBxSubject.Size = new System.Drawing.Size(121, 21);
            this.cbBxSubject.TabIndex = 4;
            this.cbBxSubject.SelectedIndexChanged += new System.EventHandler(this.cbBxSubject_SelectedIndexChanged);
            // 
            // gpBxRubric
            // 
            this.gpBxRubric.Controls.Add(this.lblRubric);
            this.gpBxRubric.Controls.Add(this.cbBxRubric);
            this.gpBxRubric.Location = new System.Drawing.Point(669, 48);
            this.gpBxRubric.Name = "gpBxRubric";
            this.gpBxRubric.Size = new System.Drawing.Size(137, 81);
            this.gpBxRubric.TabIndex = 5;
            this.gpBxRubric.TabStop = false;
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubric.Location = new System.Drawing.Point(6, 11);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(70, 16);
            this.lblRubric.TabIndex = 4;
            this.lblRubric.Text = "Rubriques";
            // 
            // gpBxSubject
            // 
            this.gpBxSubject.Controls.Add(this.lblSujet);
            this.gpBxSubject.Controls.Add(this.cbBxSubject);
            this.gpBxSubject.Location = new System.Drawing.Point(669, 162);
            this.gpBxSubject.Name = "gpBxSubject";
            this.gpBxSubject.Size = new System.Drawing.Size(137, 78);
            this.gpBxSubject.TabIndex = 6;
            this.gpBxSubject.TabStop = false;
            // 
            // lblSujet
            // 
            this.lblSujet.AutoSize = true;
            this.lblSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSujet.Location = new System.Drawing.Point(8, 16);
            this.lblSujet.Name = "lblSujet";
            this.lblSujet.Size = new System.Drawing.Size(45, 16);
            this.lblSujet.TabIndex = 5;
            this.lblSujet.Text = "Sujets";
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(12, 426);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 7;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // btSupSujet
            // 
            this.btSupSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupSujet.Location = new System.Drawing.Point(20, 80);
            this.btSupSujet.Name = "btSupSujet";
            this.btSupSujet.Size = new System.Drawing.Size(109, 40);
            this.btSupSujet.TabIndex = 8;
            this.btSupSujet.Text = "Supprimer sujet";
            this.btSupSujet.UseVisualStyleBackColor = true;
            this.btSupSujet.Click += new System.EventHandler(this.btSupSujet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rubriques...sujets...posts...";
            // 
            // btSupPost
            // 
            this.btSupPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupPost.Location = new System.Drawing.Point(22, 140);
            this.btSupPost.Name = "btSupPost";
            this.btSupPost.Size = new System.Drawing.Size(109, 40);
            this.btSupPost.TabIndex = 10;
            this.btSupPost.Text = "Supprimer post";
            this.btSupPost.UseVisualStyleBackColor = true;
            // 
            // btCreerPost
            // 
            this.btCreerPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreerPost.Location = new System.Drawing.Point(6, 8);
            this.btCreerPost.Name = "btCreerPost";
            this.btCreerPost.Size = new System.Drawing.Size(109, 40);
            this.btCreerPost.TabIndex = 11;
            this.btCreerPost.Text = "Créer post";
            this.btCreerPost.UseVisualStyleBackColor = true;
            this.btCreerPost.Click += new System.EventHandler(this.btCreerPost_Click);
            // 
            // gbxModerator
            // 
            this.gbxModerator.Controls.Add(this.btModifSujet);
            this.gbxModerator.Controls.Add(this.btSupSujet);
            this.gbxModerator.Controls.Add(this.btSupPost);
            this.gbxModerator.Location = new System.Drawing.Point(669, 286);
            this.gbxModerator.Name = "gbxModerator";
            this.gbxModerator.Size = new System.Drawing.Size(137, 186);
            this.gbxModerator.TabIndex = 12;
            this.gbxModerator.TabStop = false;
            // 
            // gbxUserLogged
            // 
            this.gbxUserLogged.Controls.Add(this.btCreerPost);
            this.gbxUserLogged.Controls.Add(this.btCreerSujet);
            this.gbxUserLogged.Location = new System.Drawing.Point(411, 419);
            this.gbxUserLogged.Name = "gbxUserLogged";
            this.gbxUserLogged.Size = new System.Drawing.Size(244, 53);
            this.gbxUserLogged.TabIndex = 13;
            this.gbxUserLogged.TabStop = false;
            // 
            // btConnect
            // 
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(204, 426);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(132, 40);
            this.btConnect.TabIndex = 14;
            this.btConnect.Text = "Se connecter";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // dGVPost
            // 
            this.dGVPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPost.Location = new System.Drawing.Point(13, 236);
            this.dGVPost.Name = "dGVPost";
            this.dGVPost.Size = new System.Drawing.Size(636, 170);
            this.dGVPost.TabIndex = 15;
            // 
            // RubricSujPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.dGVPost);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.gbxUserLogged);
            this.Controls.Add(this.gbxModerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.gpBxSubject);
            this.Controls.Add(this.gpBxRubric);
            this.Controls.Add(this.dGVPSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RubricSujPost";
            this.Text = "Alors on bouge !";
            this.Load += new System.EventHandler(this.RubricSujPost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPSubject)).EndInit();
            this.gpBxRubric.ResumeLayout(false);
            this.gpBxRubric.PerformLayout();
            this.gpBxSubject.ResumeLayout(false);
            this.gpBxSubject.PerformLayout();
            this.gbxModerator.ResumeLayout(false);
            this.gbxUserLogged.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVPSubject;
        private System.Windows.Forms.Button btCreerSujet;
        private System.Windows.Forms.Button btModifSujet;
        private System.Windows.Forms.ComboBox cbBxRubric;
        private System.Windows.Forms.ComboBox cbBxSubject;
        private System.Windows.Forms.GroupBox gpBxRubric;
        private System.Windows.Forms.Label lblRubric;
        private System.Windows.Forms.GroupBox gpBxSubject;
        private System.Windows.Forms.Label lblSujet;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Button btSupSujet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSupPost;
        private System.Windows.Forms.Button btCreerPost;
        private System.Windows.Forms.GroupBox gbxModerator;
        private System.Windows.Forms.GroupBox gbxUserLogged;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.DataGridView dGVPost;
    }
}