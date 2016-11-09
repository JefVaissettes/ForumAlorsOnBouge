using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// La classe Users permet à un utilisateur de s'identifier avec 
    /// son username (nom) et son mot de passe
    /// </summary>
    
    public class Utilisateur
    {
        #region "Property et attributs"

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

        private string _password;
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>

        public string password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;
        /// <summary>
        /// Email de l'utilisateur
        /// </summary>

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private int _role;
        /// <summary>
        /// Numéro de role de l'utilisateur
        /// 0 = userlogged, 1 = moderator, 2 = administrator
        /// </summary>
        public int role
        {
            get { return _role; }
            set { _role = value; }
        }
        #endregion

        #region "Constructeurs"

        /// <summary>
        /// Constructeur d'un utilisateur
        /// </summary>
        /// <param name="id_users">Identifiant d'un utilisateur</param>
        /// <param name="username">Nom d'un utilisateur</param>
        /// <param name="password">Mot de passe d'un utilisateur</param>
        /// <param name="email">Email d'un utilisateur</param>
        /// <param name="role">Role d'un utilisateur</param>
        public Utilisateur(int id_users, string username, string password, string email, int role)
        {
            this.id_users = id_users;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public Utilisateur(int id_users, string username, string password, int role)
        {
            this.id_users = id_users;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public Utilisateur(int id_users)
        {
            this.id_users = id_users;
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
