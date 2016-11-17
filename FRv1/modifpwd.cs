using DAO;
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
            Accueil.CurrentUsers = UtilisateurDAO.GetLoginPassword(txtLogin.Text, txtPwd.Text);
            if (Accueil.CurrentUsers != null)
            {
                Accueil.IsConnected = true;
                Accueil.IsRmodo = Accueil.CurrentUsers.role;
                this.Close();
            }
            else
            {
                Accueil.IsConnected = false;
                MessageBox.Show("Votre Login ou votre mot de passe sont incorrect!", "Veuillez saisir vos identifiants svp", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
