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

        private int _Id;
        /// <summary>
        /// Identifiant de l'utilisateur
        /// </summary>
        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Username;
        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        [DataMember]
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Mdp;
        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        [DataMember]
        public string Mdp
        {
            get { return _Mdp; }
            set { _Mdp = value; }
        }

        private string _Email;
        /// <summary>
        /// Email de l'utilisateur
        /// </summary>
        [DataMember]
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private bool _IsRmod;
        /// <summary>
        /// Numéro de role de l'utilisateur
        /// Isrmod permet de voir si l'user est un moderateur ou non 
        /// </summary>
        [DataMember]
        public bool IsRmod
        {
            get { return _IsRmod; }
            set { _IsRmod = value; }
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
        public Utilisateur(int id, string username, string password, string email, bool isRmod)
        {
            this.Id = id;
            this.Username = username;
            this.Mdp = password;
            this.Email = email;
            this.IsRmod = isRmod;
        }

       public Utilisateur( int id, string username, string password, bool isRmod)
        {
            this.Id = id;
            this.Username = username;
            this.Mdp = password;
            this.IsRmod = isRmod;
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
