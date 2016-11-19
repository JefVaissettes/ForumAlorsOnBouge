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
    /// La classe Users permet à un utilisateur de s'identifier avec 
    /// son username (nom) et son mot de passe
    /// </summary>
    
    public class Utilisateur
    {
        #region "Property et attributs"

        private int _id_utilisateur;
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        [DataMember]
        public int id_utilisateur
        {
            get { return _id_utilisateur; }
            set { _id_utilisateur = value; }
        }

        private string _username;
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        [DataMember]
        public string username
        {
            get { return _username; }
            set { _username = value; }
        }

        private string _password;
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        [DataMember]
        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;
        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        [DataMember]
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private bool _role;
        /// <summary>
        /// Numéro de role de l'utilisateur
        /// 0 = userlogged, 1 = moderator, 2 = administrator
        /// </summary>
        [DataMember]
        public bool role
        {
            get { return _role; }
            set { _role = value; }
        }

       #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="id">Identifiant d'un utilisateur</param>
        /// <param name="username">Nom d'un utilisateur</param>
        /// <param name="password">Mot de passe d'un utilisateur</param>
        /// <param name="email">Email d'un utilisateur</param>
        /// <param name="role">Role d'un utilisateur</param>
        public Utilisateur(int id, string username, string password, string email, bool role)
        {
            this.id_utilisateur = id;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public Utilisateur(int id, string username, string password, bool role)
        {
            this.id_utilisateur = id;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Utilisateur(int id)
        {
            this.id_utilisateur = id;
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
