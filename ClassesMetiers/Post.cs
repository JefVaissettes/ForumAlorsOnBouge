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

        private int _id_post;
        /// <summary>
        /// Identifiant du post
        /// </summary>
        public int id_post
        {
            get { return _id_post; }
            set { _id_post = value; }
        }

        private string _post_content;
        /// <summary>
        /// Contenu du post
        /// </summary>
        public string post_content
        {
            get { return _post_content; }
            set { _post_content = value; }
        }

        private DateTime _post_date;
        /// <summary>
        /// Date de création du post
        /// </summary>
        public DateTime post_date
        {
            get { return _post_date; }
            set { _post_date = value; }
        }

        private int _id_users;
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        public int id_users
        {
            get { return _id_users; }
            set { _id_users = value; }
        }

        private string _username;
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

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

        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur de la reponse 
        /// </summary>
        /// <param name="id_post">L'identifiant du post</param>
        /// <param name="post_content">Le texte du post</param>
        /// <param name="post_date">Date de création du post</param>
        /// <param name="id_users">L'identifiant de l'utilisateur</param>
        /// <param name="username">Le nom de l'utilisateur</param>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <param name="subject_title">Le titre du sujet</param>

        public Post(int id_post, string post_content, DateTime post_date, int id_users, string username, int id_subject, string subject_title)
        {
            this.id_post = id_post;
            this.post_content = post_content;
            this.post_date = post_date;
            this.id_users = id_users;
            this.username = username;
            this.id_subject = id_subject;
            this.subject_title = subject_title;
        }

        /// <summary>
        /// Constructeur de la reponse sans username ni titre sujet
        /// </summary>
        /// <param name="id_post">L'identifiant du post</param>
        /// <param name="post_content">Le texte du post</param>
        /// <param name="post_date">Date de création du post</param>
        /// <param name="id_users">L'identifiant de l'utilisateur</param>
        /// <param name="id_subject">L'identifiant du sujet</param>

        public Post(int id_post, string post_content, DateTime post_date, int id_users, int id_subject)
        {
            this.id_post = id_post;
            this.post_content = post_content;
            this.post_date = post_date;
            this.id_users = id_users;
            this.id_subject = id_subject;
        }

        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthode permet de reccupèré le nom de l'utilisateur 
        /// </summary>
        /// <returns>Le login (nom de l'utilisateur)</returns>
        public string GetUsername()
        {
            return username;
        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }
}
