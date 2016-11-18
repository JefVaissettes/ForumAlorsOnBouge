using ClassesMetiers;
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
    public partial class frmCreerSujet : Form
    {
        internal Rubric rubric;
        internal Subject subject;

        public frmCreerSujet()
        {
            InitializeComponent();
        }

        private void frmCreerSujet_Load(object sender, EventArgs e)
        {
            if(subject == null)
            {
                txtBxTitreSujet.Text = string.Empty;
                txtBxDescSujet.Text = string.Empty;
                btValider.Text = "Valider l'ajout";
            }
            else
            {
                txtBxTitreSujet.Text = subject.subject_title;
                txtBxDescSujet.Text = subject.subject_description;
                btValider.Text = "Valider la modification";
            }
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if(subject == null)
            {
                if(Outil.AddSujet(Accueil.CurrentUsers.id_users, rubric.id_rubric, txtBxTitreSujet.Text, txtBxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxAddSujetText, Properties.Resources.MsgBoxAddSujetTitre, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurAddSujetText, Properties.Resources.MsgBoxErreurAddSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if(Outil.ModifierSujet(subject.id_subject, subject.subject_title ,subject.subject_description,txtBxTitreSujet.Text, txtBxDescSujet.Text) == 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxEditSujetText, Properties.Resources.MsgBoxEditSujetText, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurEditSujetText, Properties.Resources.MsgBoxErreurEditSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
