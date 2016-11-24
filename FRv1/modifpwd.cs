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
    public partial class modifpwd : Form
    {
        public modifpwd()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            btValider.Visible = false;
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxConfirmChangementPasswordText, Properties.Resources.MsgBoxConfirmChangementPasswordTitre, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes && (txtNewPwd.TextLength != txtConfirmNewPwd.TextLength) || !(string.IsNullOrWhiteSpace(txtNewPwd.Text) || string.IsNullOrWhiteSpace(txtConfirmNewPwd.Text)))
            {
                Outil.ModifierPassword(Accueil.CurrentUsers.Id, txtNewPwd.Text);
                btValider.Visible = true;
                this.Close();
            }

        }

        private void txtNewPwd_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtNewPwd.Text) || string.IsNullOrWhiteSpace(txtConfirmNewPwd.Text)) && txtNewPwd.Text == txtConfirmNewPwd.Text;
        }

        private void txtConfirmNewPwd_TextChanged(object sender, EventArgs e)
        {
            btValider.Enabled = !(string.IsNullOrWhiteSpace(txtNewPwd.Text) || string.IsNullOrWhiteSpace(txtConfirmNewPwd.Text)) && txtNewPwd.Text == txtConfirmNewPwd.Text;
        }
    }
}
