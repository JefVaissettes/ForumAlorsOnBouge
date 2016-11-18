using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    public class Post
    {

        #region "Property et attributs"

        /// <summary>
        /// L'identifiant de la reponse
        /// </summary>
        private int _Id;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Le texte de la reponse
        /// </summary>
        private string _PostContent;

        public string PostContent
        {
            get { return _PostContent; }
            set { _PostContent = value; }
        }

        /// <summary>
        ///Le sujet auquel appartient la reponse
        /// </summary>
        private Subject _Sujet;

        public Subject Sujet
        {
            get { return _Sujet; }
            set { _Sujet = value; }
        }

        /// <summary>
        /// La date de creation de la reponse
        /// </summary>
        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }

        /// <summary>
        /// L'utilisateur qui a crée et posté la reponse
        /// </summary>
        private Utilisateur _Utilisateur;

        public Utilisateur Utilisateur
        {
            get { return _Utilisateur; }
            set { _Utilisateur = value; }
        }

        /// <summary>
        /// L'auteur de la reponse
        /// </summary>
        private string _Auteur;

        public string Auteur
        {
            get { return _Auteur; }
            set { _Auteur = value; }
        }

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur de la reponse
        /// </summary>
        /// <param name="id">L'identifiant de la reponse</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <param name="date">La date de création </param>
        /// <param name="utilisateur">L'utilisateur qui a crée et posté la reponse</param>
        /// <param name="sujet">Le sujet auquel appartient la reponse</param>
        public Post(int id, string texte, DateTime date, Subject sujet, Utilisateur utilisateur)
        {
            this.Id = id;
            this.PostContent = texte;
            this.Date = date;
            this.Auteur = utilisateur.username;
            this.Sujet = sujet;
            this.Utilisateur = utilisateur;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        public Post(int id, string text)
        {
            this.Id = id;
            this.PostContent = text;
        }

        ///// <summary>
        ///// Constructeur de la reponse 
        ///// </summary>
        ///// <param name="id_post">L'identifiant du post</param>
        ///// <param name="post_content">Le texte du post</param>
        ///// <param name="post_date">Date de création du post</param>
        ///// <param name="id_users">L'identifiant de l'utilisateur</param>
        ///// <param name="username">Le nom de l'utilisateur</param>
        ///// <param name="id_subject">L'identifiant du sujet</param>
        ///// <param name="subject_title">Le titre du sujet</param>

        //public Post(int id_post, string post_content, DateTime post_date, Utilisateur user,  Subject sujet, string subject_title)
        //{
        //    _id_post = id_post;
        //    _post_content = post_content;
        //    _post_date = post_date;
        //    _NomAuteur = user.username;
        //    _Subject = sujet;
        //    _User = user;
        //    _subject_title = subject_title;
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="id_post"></param>
        ///// <param name="post_content"></param>
        ///// <param name="post_date"></param>
        ///// <param name="user"></param>
        ///// <param name="sujet"></param>
        //public Post(int id_post, string post_content, DateTime post_date, Utilisateur user, Subject sujet)
        //{
        //    _id_post = id_post;
        //    _post_content = post_content;
        //    _post_date = post_date;
        //    _NomAuteur = user.username;
        //    _Subject = sujet;
        //    _User = user;

        //}



        //public Post(int id_post, string post_content, DateTime post_date, int id_users, int id_subject)
        //{
        //    this.id_post = id_post;
        //    this.post_content = post_content;
        //    this.post_date = post_date;
        //    this.id_users = id_users;
        //    this.id_subject = id_subject;
        //}

        //public Post(int id_post, string post_content)
        //{
        //    _id_post = id_post;
        //    _post_content = post_content;
        //}

        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode permet de reccupèré le nom de l'utilisateur 
        /// </summary>
        /// <returns>Username (nom de l'utilisateur)</returns>
        public string GetUsername()
        {
            return Utilisateur.username;
        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
