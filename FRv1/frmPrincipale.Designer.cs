namespace IHMFR
{
    partial class frmPrincipale
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
            this.tblLPfrmPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.tbLPRubric = new System.Windows.Forms.TableLayoutPanel();
            this.gpBxRubric = new System.Windows.Forms.GroupBox();
            this.lblRubric = new System.Windows.Forms.Label();
            this.cbBxRubric = new System.Windows.Forms.ComboBox();
            this.tbLPUserLogged = new System.Windows.Forms.TableLayoutPanel();
            this.gbxUserLogged = new System.Windows.Forms.GroupBox();
            this.btSeDeconnect = new System.Windows.Forms.Button();
            this.btCreerPost = new System.Windows.Forms.Button();
            this.btCreerSujet = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gpBxSubject = new System.Windows.Forms.GroupBox();
            this.lblSujet = new System.Windows.Forms.Label();
            this.cbBxSubject = new System.Windows.Forms.ComboBox();
            this.gpBxDescSubject = new System.Windows.Forms.GroupBox();
            this.txtDescSujet = new System.Windows.Forms.TextBox();
            this.lbPasDeSujet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.tbLPConnexion = new System.Windows.Forms.TableLayoutPanel();
            this.btConnect = new System.Windows.Forms.Button();
            this.btConnecter = new System.Windows.Forms.Button();
            this.dGVPost = new System.Windows.Forms.DataGridView();
            this.lbPasDePost = new System.Windows.Forms.Label();
            this.tbLPModerator = new System.Windows.Forms.TableLayoutPanel();
            this.gbxModerator = new System.Windows.Forms.GroupBox();
            this.btModifSujet = new System.Windows.Forms.Button();
            this.btSupSujet = new System.Windows.Forms.Button();
            this.btSupPost = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btModifMdp = new System.Windows.Forms.Button();
            this.tblLPfrmPrincipale.SuspendLayout();
            this.tbLPRubric.SuspendLayout();
            this.gpBxRubric.SuspendLayout();
            this.tbLPUserLogged.SuspendLayout();
            this.gbxUserLogged.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gpBxSubject.SuspendLayout();
            this.gpBxDescSubject.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbLPConnexion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVPost)).BeginInit();
            this.tbLPModerator.SuspendLayout();
            this.gbxModerator.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLPfrmPrincipale
            // 
            this.tblLPfrmPrincipale.ColumnCount = 3;
            this.tblLPfrmPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.34F));
            this.tblLPfrmPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.66F));
            this.tblLPfrmPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tblLPfrmPrincipale.Controls.Add(this.tbLPRubric, 0, 0);
            this.tblLPfrmPrincipale.Controls.Add(this.tbLPUserLogged, 1, 3);
            this.tblLPfrmPrincipale.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tblLPfrmPrincipale.Controls.Add(this.panel1, 0, 3);
            this.tblLPfrmPrincipale.Controls.Add(this.tbLPConnexion, 2, 3);
            this.tblLPfrmPrincipale.Controls.Add(this.dGVPost, 1, 2);
            this.tblLPfrmPrincipale.Controls.Add(this.lbPasDePost, 1, 1);
            this.tblLPfrmPrincipale.Controls.Add(this.tbLPModerator, 1, 0);
            this.tblLPfrmPrincipale.Controls.Add(this.panel2, 2, 2);
            this.tblLPfrmPrincipale.Location = new System.Drawing.Point(3, 2);
            this.tblLPfrmPrincipale.Name = "tblLPfrmPrincipale";
            this.tblLPfrmPrincipale.RowCount = 4;
            this.tblLPfrmPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tblLPfrmPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tblLPfrmPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.tblLPfrmPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tblLPfrmPrincipale.Size = new System.Drawing.Size(826, 525);
            this.tblLPfrmPrincipale.TabIndex = 0;
            // 
            // tbLPRubric
            // 
            this.tbLPRubric.ColumnCount = 1;
            this.tbLPRubric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPRubric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPRubric.Controls.Add(this.gpBxRubric, 0, 0);
            this.tbLPRubric.Location = new System.Drawing.Point(3, 3);
            this.tbLPRubric.Name = "tbLPRubric";
            this.tbLPRubric.RowCount = 1;
            this.tbLPRubric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPRubric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tbLPRubric.Size = new System.Drawing.Size(192, 105);
            this.tbLPRubric.TabIndex = 0;
            // 
            // gpBxRubric
            // 
            this.gpBxRubric.Controls.Add(this.lblRubric);
            this.gpBxRubric.Controls.Add(this.cbBxRubric);
            this.gpBxRubric.Location = new System.Drawing.Point(3, 3);
            this.gpBxRubric.Name = "gpBxRubric";
            this.gpBxRubric.Size = new System.Drawing.Size(186, 99);
            this.gpBxRubric.TabIndex = 6;
            this.gpBxRubric.TabStop = false;
            // 
            // lblRubric
            // 
            this.lblRubric.AutoSize = true;
            this.lblRubric.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubric.Location = new System.Drawing.Point(0, 1);
            this.lblRubric.Name = "lblRubric";
            this.lblRubric.Size = new System.Drawing.Size(70, 16);
            this.lblRubric.TabIndex = 4;
            this.lblRubric.Text = "Rubriques";
            // 
            // cbBxRubric
            // 
            this.cbBxRubric.FormattingEnabled = true;
            this.cbBxRubric.Location = new System.Drawing.Point(0, 20);
            this.cbBxRubric.Name = "cbBxRubric";
            this.cbBxRubric.Size = new System.Drawing.Size(185, 21);
            this.cbBxRubric.TabIndex = 3;
            this.cbBxRubric.SelectedIndexChanged += new System.EventHandler(this.cbBxRubric_SelectedIndexChanged);
            // 
            // tbLPUserLogged
            // 
            this.tbLPUserLogged.ColumnCount = 1;
            this.tbLPUserLogged.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPUserLogged.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPUserLogged.Controls.Add(this.gbxUserLogged, 0, 0);
            this.tbLPUserLogged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPUserLogged.Location = new System.Drawing.Point(201, 440);
            this.tbLPUserLogged.Name = "tbLPUserLogged";
            this.tbLPUserLogged.RowCount = 1;
            this.tbLPUserLogged.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPUserLogged.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tbLPUserLogged.Size = new System.Drawing.Size(494, 82);
            this.tbLPUserLogged.TabIndex = 2;
            // 
            // gbxUserLogged
            // 
            this.gbxUserLogged.Controls.Add(this.btSeDeconnect);
            this.gbxUserLogged.Controls.Add(this.btCreerPost);
            this.gbxUserLogged.Controls.Add(this.btCreerSujet);
            this.gbxUserLogged.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxUserLogged.Location = new System.Drawing.Point(3, 3);
            this.gbxUserLogged.Name = "gbxUserLogged";
            this.gbxUserLogged.Size = new System.Drawing.Size(488, 76);
            this.gbxUserLogged.TabIndex = 14;
            this.gbxUserLogged.TabStop = false;
            // 
            // btSeDeconnect
            // 
            this.btSeDeconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeDeconnect.Location = new System.Drawing.Point(341, 18);
            this.btSeDeconnect.Name = "btSeDeconnect";
            this.btSeDeconnect.Size = new System.Drawing.Size(118, 40);
            this.btSeDeconnect.TabIndex = 12;
            this.btSeDeconnect.Text = "Se déconnecter";
            this.btSeDeconnect.UseVisualStyleBackColor = true;
            this.btSeDeconnect.Click += new System.EventHandler(this.btSeDeconnect_Click);
            // 
            // btCreerPost
            // 
            this.btCreerPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreerPost.Location = new System.Drawing.Point(41, 18);
            this.btCreerPost.Name = "btCreerPost";
            this.btCreerPost.Size = new System.Drawing.Size(109, 40);
            this.btCreerPost.TabIndex = 11;
            this.btCreerPost.Text = "Créer post";
            this.btCreerPost.UseVisualStyleBackColor = true;
            this.btCreerPost.Click += new System.EventHandler(this.btCreerPost_Click);
            // 
            // btCreerSujet
            // 
            this.btCreerSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreerSujet.Location = new System.Drawing.Point(185, 18);
            this.btCreerSujet.Name = "btCreerSujet";
            this.btCreerSujet.Size = new System.Drawing.Size(109, 40);
            this.btCreerSujet.TabIndex = 1;
            this.btCreerSujet.Text = "Créer sujet";
            this.btCreerSujet.UseVisualStyleBackColor = true;
            this.btCreerSujet.Click += new System.EventHandler(this.btCreerSujet_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gpBxSubject, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gpBxDescSubject, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbPasDeSujet, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.19838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.80162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 301);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // gpBxSubject
            // 
            this.gpBxSubject.Controls.Add(this.lblSujet);
            this.gpBxSubject.Controls.Add(this.cbBxSubject);
            this.gpBxSubject.Location = new System.Drawing.Point(3, 3);
            this.gpBxSubject.Name = "gpBxSubject";
            this.gpBxSubject.Size = new System.Drawing.Size(185, 65);
            this.gpBxSubject.TabIndex = 7;
            this.gpBxSubject.TabStop = false;
            // 
            // lblSujet
            // 
            this.lblSujet.AutoSize = true;
            this.lblSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSujet.Location = new System.Drawing.Point(0, 0);
            this.lblSujet.Name = "lblSujet";
            this.lblSujet.Size = new System.Drawing.Size(45, 16);
            this.lblSujet.TabIndex = 5;
            this.lblSujet.Text = "Sujets";
            // 
            // cbBxSubject
            // 
            this.cbBxSubject.FormattingEnabled = true;
            this.cbBxSubject.Location = new System.Drawing.Point(0, 19);
            this.cbBxSubject.Name = "cbBxSubject";
            this.cbBxSubject.Size = new System.Drawing.Size(185, 21);
            this.cbBxSubject.TabIndex = 4;
            this.cbBxSubject.SelectedIndexChanged += new System.EventHandler(this.cbBxSubject_SelectedIndexChanged);
            // 
            // gpBxDescSubject
            // 
            this.gpBxDescSubject.Controls.Add(this.txtDescSujet);
            this.gpBxDescSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpBxDescSubject.Location = new System.Drawing.Point(3, 85);
            this.gpBxDescSubject.Name = "gpBxDescSubject";
            this.gpBxDescSubject.Size = new System.Drawing.Size(185, 156);
            this.gpBxDescSubject.TabIndex = 8;
            this.gpBxDescSubject.TabStop = false;
            this.gpBxDescSubject.Text = "Description sujet";
            // 
            // txtDescSujet
            // 
            this.txtDescSujet.Location = new System.Drawing.Point(0, 19);
            this.txtDescSujet.Multiline = true;
            this.txtDescSujet.Name = "txtDescSujet";
            this.txtDescSujet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescSujet.Size = new System.Drawing.Size(185, 130);
            this.txtDescSujet.TabIndex = 0;
            // 
            // lbPasDeSujet
            // 
            this.lbPasDeSujet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPasDeSujet.AutoSize = true;
            this.lbPasDeSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasDeSujet.Location = new System.Drawing.Point(4, 258);
            this.lbPasDeSujet.Name = "lbPasDeSujet";
            this.lbPasDeSujet.Size = new System.Drawing.Size(184, 32);
            this.lbPasDeSujet.TabIndex = 9;
            this.lbPasDeSujet.Text = "La rubrique ne contient aucun sujet, pour le moment.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAnnuler);
            this.panel1.Location = new System.Drawing.Point(3, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 82);
            this.panel1.TabIndex = 5;
            // 
            // btAnnuler
            // 
            this.btAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnnuler.Location = new System.Drawing.Point(40, 21);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(109, 40);
            this.btAnnuler.TabIndex = 8;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // tbLPConnexion
            // 
            this.tbLPConnexion.ColumnCount = 1;
            this.tbLPConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPConnexion.Controls.Add(this.btConnect, 0, 0);
            this.tbLPConnexion.Controls.Add(this.btConnecter, 0, 1);
            this.tbLPConnexion.Location = new System.Drawing.Point(701, 440);
            this.tbLPConnexion.Name = "tbLPConnexion";
            this.tbLPConnexion.RowCount = 2;
            this.tbLPConnexion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPConnexion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tbLPConnexion.Size = new System.Drawing.Size(116, 82);
            this.tbLPConnexion.TabIndex = 1;
            // 
            // btConnect
            // 
            this.btConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnect.Location = new System.Drawing.Point(3, 3);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(110, 1);
            this.btConnect.TabIndex = 15;
            this.btConnect.Text = "Se connecter";
            this.btConnect.UseVisualStyleBackColor = true;
            // 
            // btConnecter
            // 
            this.btConnecter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnecter.Location = new System.Drawing.Point(3, 21);
            this.btConnecter.Name = "btConnecter";
            this.btConnecter.Size = new System.Drawing.Size(110, 40);
            this.btConnecter.TabIndex = 16;
            this.btConnecter.Text = "Se connecter";
            this.btConnecter.UseVisualStyleBackColor = true;
            this.btConnecter.Click += new System.EventHandler(this.btConnecter_Click);
            // 
            // dGVPost
            // 
            this.dGVPost.AllowUserToAddRows = false;
            this.dGVPost.AllowUserToDeleteRows = false;
            this.dGVPost.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGVPost.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dGVPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVPost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVPost.Location = new System.Drawing.Point(201, 133);
            this.dGVPost.Name = "dGVPost";
            this.dGVPost.Size = new System.Drawing.Size(494, 301);
            this.dGVPost.TabIndex = 16;
            this.dGVPost.SelectionChanged += new System.EventHandler(this.dGVPost_SelectionChanged);
            // 
            // lbPasDePost
            // 
            this.lbPasDePost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPasDePost.AutoSize = true;
            this.lbPasDePost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasDePost.Location = new System.Drawing.Point(304, 112);
            this.lbPasDePost.Name = "lbPasDePost";
            this.lbPasDePost.Size = new System.Drawing.Size(287, 16);
            this.lbPasDePost.TabIndex = 17;
            this.lbPasDePost.Text = "Le sujet ne contient aucun post pour le moment.";
            // 
            // tbLPModerator
            // 
            this.tbLPModerator.ColumnCount = 1;
            this.tbLPModerator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPModerator.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbLPModerator.Controls.Add(this.gbxModerator, 0, 0);
            this.tbLPModerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLPModerator.Location = new System.Drawing.Point(201, 3);
            this.tbLPModerator.Name = "tbLPModerator";
            this.tbLPModerator.RowCount = 1;
            this.tbLPModerator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbLPModerator.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tbLPModerator.Size = new System.Drawing.Size(494, 105);
            this.tbLPModerator.TabIndex = 3;
            // 
            // gbxModerator
            // 
            this.gbxModerator.Controls.Add(this.btModifSujet);
            this.gbxModerator.Controls.Add(this.btSupSujet);
            this.gbxModerator.Controls.Add(this.btSupPost);
            this.gbxModerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxModerator.Location = new System.Drawing.Point(3, 3);
            this.gbxModerator.Name = "gbxModerator";
            this.gbxModerator.Size = new System.Drawing.Size(488, 99);
            this.gbxModerator.TabIndex = 13;
            this.gbxModerator.TabStop = false;
            // 
            // btModifSujet
            // 
            this.btModifSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifSujet.Location = new System.Drawing.Point(41, 37);
            this.btModifSujet.Name = "btModifSujet";
            this.btModifSujet.Size = new System.Drawing.Size(109, 40);
            this.btModifSujet.TabIndex = 2;
            this.btModifSujet.Text = "Modifier sujet";
            this.btModifSujet.UseVisualStyleBackColor = true;
            this.btModifSujet.Click += new System.EventHandler(this.btModifSujet_Click);
            // 
            // btSupSujet
            // 
            this.btSupSujet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupSujet.Location = new System.Drawing.Point(185, 37);
            this.btSupSujet.Name = "btSupSujet";
            this.btSupSujet.Size = new System.Drawing.Size(109, 40);
            this.btSupSujet.TabIndex = 8;
            this.btSupSujet.Text = "Supprimer sujet";
            this.btSupSujet.UseVisualStyleBackColor = true;
            this.btSupSujet.Click += new System.EventHandler(this.btSupSujet_Click);
            // 
            // btSupPost
            // 
            this.btSupPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupPost.Location = new System.Drawing.Point(331, 37);
            this.btSupPost.Name = "btSupPost";
            this.btSupPost.Size = new System.Drawing.Size(109, 40);
            this.btSupPost.TabIndex = 10;
            this.btSupPost.Text = "Supprimer post";
            this.btSupPost.UseVisualStyleBackColor = true;
            this.btSupPost.Click += new System.EventHandler(this.btSupPost_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btModifMdp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(701, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 301);
            this.panel2.TabIndex = 18;
            // 
            // btModifMdp
            // 
            this.btModifMdp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModifMdp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModifMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifMdp.Location = new System.Drawing.Point(6, 130);
            this.btModifMdp.Name = "btModifMdp";
            this.btModifMdp.Size = new System.Drawing.Size(110, 40);
            this.btModifMdp.TabIndex = 17;
            this.btModifMdp.Text = "Modif mdp";
            this.btModifMdp.UseVisualStyleBackColor = true;
            this.btModifMdp.Click += new System.EventHandler(this.btModifMdp_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 524);
            this.Controls.Add(this.tblLPfrmPrincipale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipale";
            this.Text = "Alors on bouge !";
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            this.tblLPfrmPrincipale.ResumeLayout(false);
            this.tblLPfrmPrincipale.PerformLayout();
            this.tbLPRubric.ResumeLayout(false);
            this.gpBxRubric.ResumeLayout(false);
            this.gpBxRubric.PerformLayout();
            this.tbLPUserLogged.ResumeLayout(false);
            this.gbxUserLogged.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gpBxSubject.ResumeLayout(false);
            this.gpBxSubject.PerformLayout();
            this.gpBxDescSubject.ResumeLayout(false);
            this.gpBxDescSubject.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tbLPConnexion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVPost)).EndInit();
            this.tbLPModerator.ResumeLayout(false);
            this.gbxModerator.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLPfrmPrincipale;
        private System.Windows.Forms.TableLayoutPanel tbLPRubric;
        private System.Windows.Forms.TableLayoutPanel tbLPConnexion;
        private System.Windows.Forms.TableLayoutPanel tbLPUserLogged;
        private System.Windows.Forms.TableLayoutPanel tbLPModerator;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.GroupBox gbxUserLogged;
        private System.Windows.Forms.Button btCreerPost;
        private System.Windows.Forms.Button btCreerSujet;
        private System.Windows.Forms.GroupBox gbxModerator;
        private System.Windows.Forms.Button btModifSujet;
        private System.Windows.Forms.Button btSupSujet;
        private System.Windows.Forms.Button btSupPost;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.GroupBox gpBxRubric;
        private System.Windows.Forms.Label lblRubric;
        private System.Windows.Forms.ComboBox cbBxRubric;
        private System.Windows.Forms.GroupBox gpBxSubject;
        private System.Windows.Forms.Label lblSujet;
        private System.Windows.Forms.ComboBox cbBxSubject;
        private System.Windows.Forms.GroupBox gpBxDescSubject;
        private System.Windows.Forms.TextBox txtDescSujet;
        private System.Windows.Forms.DataGridView dGVPost;
        private System.Windows.Forms.Label lbPasDeSujet;
        private System.Windows.Forms.Label lbPasDePost;
        private System.Windows.Forms.Button btSeDeconnect;
        private System.Windows.Forms.Button btConnecter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btModifMdp;
    }
}