using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    [Serializable]

    [DataContract]

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
        [DataMember]
        public int id_subject
        {
            get { return _id_subject; }
            set { _id_subject = value; }
        }

        private string _subject_title;
        /// <summary>
        /// Titre du sujet
        /// </summary>
        [DataMember]
        public string subject_title
        {
            get { return _subject_title; }
            set { _subject_title = value; }
        }

        private string _subject_description;
        /// <summary>
        /// Description du sujet
        /// </summary>
        [DataMember]
        public string subject_description
        {
            get { return _subject_description; }
            set { _subject_description = value; }
        }

        private DateTime _subject_date;
        /// <summary>
        /// Date de création du sujet
        /// </summary>
        [DataMember]
        public DateTime subject_date
        {
            get { return _subject_date; }
            set { _subject_date = value; }
        }

        private List<Post> _Posts;
        /// <summary>
        /// La liste de reponse, concernant un sujet
        /// </summary>
        [DataMember]
        public List<Post> Posts
        {
            get { return _Posts; }
            set { _Posts = value; }
        }

        private Rubric _Rubric;
        /// <summary>
        /// Identifiant de la rubrique
        /// </summary>
        [DataMember]
        public Rubric Rubric
        {
            get { return _Rubric; }
            set { _Rubric = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        private Utilisateur _Utilisateur;

        [DataMember]
        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>
        private string _Auteur;

        [DataMember]
        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un nouveau sujet
        /// </summary>
        /// <param name="id">Identifiant du sujet</param>
        /// <param name="title">Titre du sujet</param>
        /// <param name="description">Description du sujet</param>
        /// <param name="rubric">Identifiant de la rubrique</param>
        public Subject(int id, string title, string description, Rubric rubric)
        {
            id_subject = id;
            subject_title = title;
            subject_description = description;
            Rubric = rubric;
            _Posts = new List<Post>();
            subject_date = DateTime.Now;
        }

        /// <summary>
        /// Constructeur d'un sujet, avec des posts en réponse, on fait appel au constructeur du sujet sans réponse
        /// </summary>
        /// <param name="id_subject">Identifiant du sujet</param>
        /// <param name="subject_title">Titre du sujet</param>
        /// <param name="subject_description">Description du sujet</param>
        /// <param name="id_rubric">Identifiant de la rubrique</param>
        /// <param name="Posts">Post en retour</param>
        public Subject(int id_subject, string subject_title, string subject_description, Rubric rubric, List<Post> Posts) : this(id_subject, subject_title, subject_description, rubric)
        {
            this.Posts = Posts;
        }

        /// <summary>
        /// Constructeur d'un nouveau sujet 
        /// </summary>
        /// <param name="id">Identifiant du sujet</param>
        /// <param name="title">Titre du sujet</param>
        /// <param name="rubric">Identifiant de la rubrique</param>
        public Subject(int id, string title, Rubric rubric)
        {
            this.id_subject = id;
            this.subject_title = title;
            this.Rubric = rubric;
        }

        public Subject(int id, string titre, string description, DateTime date, Utilisateur utilisateur, Rubric rubric) : this(id, titre, description, rubric)
        {
            this.subject_Date = date;
            this.Utilisateur = utilisateur;
            this.Auteur = utilisateur.Login;
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
