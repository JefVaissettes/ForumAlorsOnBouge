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

namespace FRv1
{
    public partial class RubricSujPost : Form
    {
        public RubricSujPost()
        {
            InitializeComponent();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RubricSujPost_Load(object sender, EventArgs e)
        {
            displaycbBxRubric(Methodes.Controller.GetAllRubrics());
            //displaycbBxSubject(Methodes.Methodes.GetSujetsByCategorie((int)cbBxRubric.SelectedValue));
        }


        private void displaycbBxRubric(List<Rubric> rubrics)
        {
            cbBxRubric.ValueMember = "ID_RUBRIC";
            cbBxRubric.DisplayMember = "RUBRIC_TITLE";
            cbBxRubric.DataSource = rubrics;
        }

        //private void displaycbBxSubject(List<Subject> subjects)
        //{
        //    cbBxSubject.ValueMember = "ID_SUBJECT";
        //    cbBxSubject.DisplayMember = "SUBJECT_TITLE";
        //    cbBxSubject.DataSource = subjects;
        //    Subject subject = (Subject)cbBxSubject.SelectedItem;
        //}
    }
}
