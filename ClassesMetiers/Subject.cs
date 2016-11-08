using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// La classe Subject, permet de voir tous les sujets d'une rubrique
    /// Permet de voir les posts, concernant un sujet
    /// Elle comporte un identifiant, titre du sujet, la description, la rubrique et les posts
    /// </summary>
    
    public class Subject
    {
        private int _id_subject;
        /// <summary>
        /// Identifiant du sujet
        /// </summary>
        public int id_subject
        {
            get { return _id_subject; }
            set { _id_subject = value; }
        }

        private string _subject_title;
        /// <summary>
        /// Titre du sujet
        /// </summary>
        public string subject_title
        {
            get { return _subject_title; }
            set { _subject_title = value; }
        }

        private string _subject_description;
        /// <summary>
        /// Description du sujet
        /// </summary>
        public string subject_description
        {
            get { return _subject_description; }
            set { _subject_description = value; }
        }

        private DateTime _subject_date;
        /// <summary>
        /// Date de création du sujet
        /// </summary>
        public DateTime subject_date
        {
            get { return _subject_date; }
            set { _subject_date = value; }
        }

        private List<Post> _Posts;
        /// <summary>
        /// La liste de reponse, concernant un sujet
        /// </summary>
        public List<Post> Reponses
        {
            get { return _Posts; }
            set { _Posts = value; }
        }

        private int _id_rubric;
        /// <summary>
        /// Identifiant de la rubrique
        /// </summary>
        public int id_rubric
        {
            get { return _id_rubric; }
            set { _id_rubric = value; }
        }

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un nouveau sujet
        /// </summary>
        /// <param name="id_subject">Identifiant du sujet</param>
        /// <param name="subject_title">Titre du sujet</param>
        /// <param name="subject_description">Description du sujet</param>
        /// <param name="id_rubric">Identifiant de la rubrique</param>
        public Subject(int id_subject, string subject_title, string subject_description, int id_rubric)
        {
            this.id_subject = id_subject;
            this.subject_title = subject_title;
            this.subject_description = subject_description;
            this.id_rubric = id_rubric;
            this._Posts = new List<Post>();
            this.subject_date = DateTime.Now;
        }

        /// <summary>
        /// Constructeur d'un sujet, avec des posts en réponse, on fait appel au constructeur du sujet sans réponse
        /// </summary>
        /// <param name="id_subject">Identifiant du sujet</param>
        /// <param name="subject_title">Titre du sujet</param>
        /// <param name="subject_description">Description du sujet</param>
        /// <param name="id_rubric">Identifiant de la rubrique</param>
        /// <param name="Posts">Post en retour</param>
        public Subject(int id_subject, string subject_title, string subject_description, int id_rubric, List<Post> Posts) : this(id_subject, subject_title, subject_description, id_rubric)
        {
            _Posts = Posts;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
