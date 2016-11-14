using ClassesMetiers;
using Methodes;
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
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
        }


        private void displaycbBxRubric(List<Rubric> rubrics)
        {
            cbBxRubric.ValueMember = "ID_RUBRIC";
            cbBxRubric.DisplayMember = "RUBRIC_TITLE";
            cbBxRubric.DataSource = rubrics;
        }
    }
}
