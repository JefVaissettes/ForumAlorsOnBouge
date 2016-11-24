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
        private int _Id;
        /// <summary>
        /// Identifiant du sujet
        /// </summary>
        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Titre;
        /// <summary>
        /// Titre du sujet
        /// </summary>
        [DataMember]
        public string Titre
        {
            get { return _Titre; }
            set { _Titre = value; }
        }

        private string _Desc;
        /// <summary>
        /// Description du sujet
        /// </summary>
        [DataMember]
        public string Desc
        {
            get { return _Desc; }
            set { _Desc = value; }
        }

        private DateTime _Date;
        /// <summary>
        /// Date de création du sujet
        /// </summary>
        [DataMember]
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
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
            this.Id = id;
            this.Titre = title;
            this.Desc = description;
            this.Rubric = rubric;
            this.Posts = new List<Post>();
            this.Date = DateTime.Now;
        }

        /// <summary>
        /// Constructeur d'un sujet, avec des posts en réponse, on fait appel au constructeur du sujet sans réponse
        /// </summary>
        /// <param name="id_subject">Identifiant du sujet</param>
        /// <param name="subject_title">Titre du sujet</param>
        /// <param name="subject_description">Description du sujet</param>
        /// <param name="id_rubric">Identifiant de la rubrique</param>
        /// <param name="Posts">Post en retour</param>
        public Subject(int id, string title, string description, Rubric rubric, List<Post> Posts) : this(id, title, description, rubric)
        {
            this.Posts = Posts;
        }

     

        /// <summary>
        /// constructeur construit pour l'ajout de l'auteur et de la date du sujet
        /// </summary>
        /// <param name="id"></param>
        /// <param name="titre"></param>
        /// <param name="description"></param>
        /// <param name="date"></param>
        /// <param name="utilisateur"></param>
        /// <param name="rubric"></param>
        public Subject(int id, string titre, string description, DateTime date, Utilisateur utilisateur, Rubric rubric) : this(id, titre, description, rubric)
        {
            this.Date = date;
            this.Utilisateur = utilisateur;
            this.Auteur = utilisateur.Username;
        }


        #endregion

        #region "Methodes"

        public string GetUsername()
        {
            return Utilisateur.Username;
        }

        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
