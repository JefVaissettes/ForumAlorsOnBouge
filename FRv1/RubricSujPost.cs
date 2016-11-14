using ClassesMetiers;
using FRv1;
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
    public partial class RubricSujPost : Form
    {
        static internal int IsRmodo;
        static internal Utilisateur CurrentUsers;
        static internal bool IsConnected;

        public RubricSujPost()
        {
            InitializeComponent();
        }

        #region Load

        private void RubricSujPost_Load(object sender, EventArgs e)
        {
            displaycbBxRubric(Methodes.Controller.GetAllRubrics());
            displaycbBxSubject(Methodes.Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
            visibiliteModerateur();
        }

        #endregion


        #region Event click

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            using (Identification frmIdentity = new Identification())
            {
                frmIdentity.ShowDialog();
            }
        }

        private void btCreerSujet_Click(object sender, EventArgs e)
        {
            using (CreateSujet frmCreerSujet = new CreateSujet())
            {
                frmCreerSujet.rubric = (Rubric)cbBxRubric.SelectedItem;
                frmCreerSujet.Text = string.Format("Ajouter le sujet dans la rubrique {0}", frmCreerSujet.rubric.rubric_title);
                frmCreerSujet.ShowDialog();
                displaycbBxSubject(Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
            }
        }

        private void btCreerPost_Click(object sender, EventArgs e)
        {
            using (CreerPost frmCreerPost = new CreerPost())
            {
                frmCreerPost.post = (Post)cbBxSubject.SelectedItem;
                frmCreerPost.Text = string.Format("Ajout du post au sujet {0}", frmCreerPost.post.subject_title);
                frmCreerPost.ShowDialog();
                displaydgVPost(Controller.GetAllReponseBySujet((int)cbBxSubject.SelectedValue));
            }
        }

        #endregion


        #region Modérateur

        private void btModifSujet_Click(object sender, EventArgs e)
        {
            using (ModifSujet frmModifSujet = new ModifSujet())
            {
                frmModifSujet.rubric = (Rubric)cbBxRubric.SelectedItem;
                frmModifSujet.subject = (Subject)cbBxSubject.SelectedItem;
                frmModifSujet.Text = string.Format("Modifie le sujet {0} dans la rubrique {1}", frmModifSujet.subject.subject_title, frmModifSujet.subject.subject_description);
                frmModifSujet.ShowDialog();
                displaycbBxSubject(Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue));
            }
        }

        private void btSupSujet_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show( Properties.Resources.MsgBoxDeleteSujetText, Properties.Resources.MsgBoxDeleteSujetTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                if(Controller.DeleteSujet((int)cbBxSubject.SelectedValue) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeleteSujetText, Properties.Resources.MsgBoxErreurDeleteSujetTitre);

                }
                List<Subject> subjects = Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue);
                if(subjects != null)
                {
                    displaycbBxSubject(subjects);
                }
            }
           
        }

        private void btSupPost_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(Properties.Resources.MsgBoxDeletePostText, Properties.Resources.MsgBoxDeletePostTitre, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if(dr == DialogResult.OK)
            {
                if(Controller.DeleteReponse((int)dGVPost.CurrentRow.Cells["ID_POST"].Value) != 1)
                {
                    MessageBox.Show(Properties.Resources.MsgBoxErreurDeletePostText, Properties.Resources.MsgBoxErreurDeletePostTitre);
                }
                List<Post> posts = Controller.GetAllReponseBySujet((int)cbBxSubject.SelectedValue);
                if(posts != null)
                {
                    displaydgVPost(posts);
                }
            }
        }

        #endregion










        

        private void displaycbBxRubric(List<Rubric> rubrics)
        {
            cbBxRubric.ValueMember = "ID_RUBRIC";
            cbBxRubric.DisplayMember = "RUBRIC_TITLE";
            cbBxRubric.DataSource = rubrics;
        }

        private void displaycbBxSubject(List<Subject> subjects)
        {
            cbBxSubject.ValueMember = "ID_SUBJECT";
            cbBxSubject.DisplayMember = "SUBJECT_TITLE";
            cbBxSubject.DataSource = subjects;
            Subject subject = (Subject)cbBxSubject.SelectedItem;
        }

        private void displaydgVPost(List<Post> posts)
        {
            dGVPost.DataSource = posts;
            dGVPost.Columns["ID"].Visible = false;
            dGVPost.Columns["SUJET"].Visible = false;
            dGVPost.Columns["UTILISATEUR"].Visible = false;
        }



        private void cbBxRubric_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Subject> subjects = Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue);
            if (subjects != null)
            {
                displaycbBxRubric(subjects);
            }
        }



        private void cbBxSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (visibiliteSujets())
            {
                Subject subject = (Subject)cbBxSubject.SelectedItem;

                if (visibiliteSujets())
                {
                    List<Post> posts = Controller.GetAllReponseBySujet((int)cbBxSubject.SelectedValue);
                    if (posts != null)
                    {
                        displaydgVPost(posts);
                    }
                }
            }
        }

        private bool visibiliteSujets()
        {
            if (cbBxRubric.SelectedIndex != -1)
            {
                if (Controller.GetSujetsByCategorieID((int)cbBxRubric.SelectedValue) != null)
                {
                    return true;
                }
            }
            return false;
        }

        private void visibiliteModerateur()
        {
            gbxModerator.Visible = RubricSujPost.IsConnected;
            gbxUserLogged.Visible = RubricSujPost.IsConnected;
        }


    }
}
