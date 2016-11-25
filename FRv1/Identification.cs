﻿using ClassesMetiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IHMFR
{
    public partial class Identification : Form
    {
        
        public Identification()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {            
                this.Close();            
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Accueil.CurrentUsers = Outil.GetLoginPassword(txtLogin.Text, txtPwd.Text);
            if (Accueil.CurrentUsers != null)
            {
                Accueil.IsConnected = true;
                Accueil.IsRmodo = Accueil.CurrentUsers.IsRmod;
                this.Close();

            }
            else
            {
                Accueil.IsConnected = false;
                MessageBox.Show("Votre Login ou votre mot de passe sont incorrect!", "Veuillez saisir vos identifiants svp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}
