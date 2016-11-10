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
            using (Accueil frmAccueil = new Accueil())
            {
                this.Close();
            }
        }

        private void btModifPwd_Click(object sender, EventArgs e)
        {
            using (modifpwd frmModifpwd = new modifpwd())
            {
                frmModifpwd.ShowDialog();
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            using (RubricSujPost frmMain = new RubricSujPost())
            {
                frmMain.ShowDialog();
            }
        }
    }
}
