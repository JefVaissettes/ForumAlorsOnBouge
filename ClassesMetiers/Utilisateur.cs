using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
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



        //private string _Mdp;
        ///// <summary>
        ///// Gets/sets the underlying base64 encoded string
        ///// </summary>
        //public string Mdp
        //{
        //    get { return _Mdp; }
        //    set
        //    {
        //        if (value != _Mdp)
        //        {
        //            _Mdp = value;
        //            _guid = Decode(value);
        //        }
        //    }
        //}

        //private object Decode(string value)
        //{
        //    throw new NotImplementedException();
        //}

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

        //public object _guid { get; private set; }

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

        //#region "Methodes de hashage du mot de passe avec GUID"

        /// <summary>
        /// Represents a globally unique identifier (GUID) with a
        /// shorter string value. Sguid
        /// </summary>
        //public struct ShortGuid
        //{
        //    #region Static

        //    /// <summary>
        //    /// A read-only instance of the ShortGuid class whose value
        //    /// is guaranteed to be all zeroes.
        //    /// </summary>
        //    public static readonly ShortGuid Empty = new ShortGuid(Guid.Empty);

        //    #endregion

        //    #region Fields

        //    Guid _guid;
        //    string _value;

        //    #endregion

        //    #region Contructors

        //    /// <summary>
        //    /// Creates a ShortGuid from a base64 encoded string
        //    /// </summary>
        //    /// <param name="value">The encoded guid as a
        //    /// base64 string</param>
        //    public ShortGuid(string value)
        //    {
        //        _value = value;
        //        _guid = Decode(value);
        //    }

        //    /// <summary>
        //    /// Creates a ShortGuid from a Guid
        //    /// </summary>
        //    /// <param name="guid">The Guid to encode</param>
        //    public ShortGuid(Guid guid)
        //    {
        //        _value = Encode(guid);
        //        _guid = guid;
        //    }

        //    #endregion

        //    #region Properties

        //    /// <summary>
        //    /// Gets/sets the underlying Guid
        //    /// </summary>
        //    public Guid Guid
        //    {
        //        get { return _guid; }
        //        set
        //        {
        //            if (value != _guid)
        //            {
        //                _guid = value;
        //                _value = Encode(value);
        //            }
        //        }
        //    }

        //    #endregion

        //    #region ToString

        //    /// <summary>
        //    /// Returns the base64 encoded guid as a string
        //    /// </summary>
        //    /// <returns></returns>
        //    public override string ToString()
        //    {
        //        return _value;
        //    }

        //    #endregion

        //    #region Equals

        //    /// <summary>
        //    /// Returns a value indicating whether this instance and a
        //    /// specified Object represent the same type and value.
        //    /// </summary>
        //    /// <param name="obj">The object to compare</param>
        //    /// <returns></returns>
        //    public override bool Equals(object obj)
        //    {
        //        if (obj is ShortGuid)
        //            return _guid.Equals(((ShortGuid)obj)._guid);
        //        if (obj is Guid)
        //            return _guid.Equals((Guid)obj);
        //        if (obj is string)
        //            return _guid.Equals(((ShortGuid)obj)._guid);
        //        return false;
        //    }

        //    #endregion

        //    #region GetHashCode

        //    /// <summary>
        //    /// Returns the HashCode for underlying Guid.
        //    /// </summary>
        //    /// <returns></returns>
        //    public override int GetHashCode()
        //    {
        //        return _guid.GetHashCode();
        //    }

        //    #endregion

        //    #region NewGuid

        //    /// <summary>
        //    /// Initialises a new instance of the ShortGuid class
        //    /// </summary>
        //    /// <returns></returns>
        //    public static ShortGuid NewGuid()
        //    {
        //        return new ShortGuid(Guid.NewGuid());
        //    }

        //    #endregion

        //    #region Encode

        //    /// <summary>
        //    /// Creates a new instance of a Guid using the string value,
        //    /// then returns the base64 encoded version of the Guid.
        //    /// </summary>
        //    /// <param name="value">An actual Guid string (i.e. not a ShortGuid)</param>
        //    /// <returns></returns>
        //    public static string Encode(string value)
        //    {
        //        Guid guid = new Guid(value);
        //        return Encode(guid);
        //    }

        //    /// <summary>
        //    /// Encodes the given Guid as a base64 string that is 22
        //    /// characters long.
        //    /// </summary>
        //    /// <param name="guid">The Guid to encode</param>
        //    /// <returns></returns>
        //    public static string Encode(Guid guid)
        //    {
        //        string encoded = Convert.ToBase64String(guid.ToByteArray());
        //        encoded = encoded
        //          .Replace("/", "_")
        //          .Replace("+", "-");
        //        return encoded.Substring(0, 22);
        //    }

        //    #endregion

        //    #region Decode

        //    /// <summary>
        //    /// Decodes the given base64 string
        //    /// </summary>
        //    /// <param name="value">The base64 encoded string of a Guid</param>
        //    /// <returns>A new Guid</returns>
        //    public static Guid Decode(string value)
        //    {
        //        value = value
        //          .Replace("_", "/")
        //          .Replace("-", "+");
        //        byte[] buffer = Convert.FromBase64String(value + "==");
        //        return new Guid(buffer);
        //    }

        //    #endregion

        //    #region Operators

        //    /// <summary>
        //    /// Determines if both ShortGuids have the same underlying
        //    /// Guid value.
        //    /// </summary>
        //    /// <param name="x"></param>
        //    /// <param name="y"></param>
        //    /// <returns></returns>
        //    public static bool operator ==(ShortGuid x, ShortGuid y)
        //    {
        //        if ((object)x == null) return (object)y == null;
        //        return x._guid == y._guid;
        //    }

        //    /// <summary>
        //    /// Determines if both ShortGuids do not have the
        //    /// same underlying Guid value.
        //    /// </summary>
        //    /// <param name="x"></param>
        //    /// <param name="y"></param>
        //    /// <returns></returns>
        //    public static bool operator !=(ShortGuid x, ShortGuid y)
        //    {
        //        return !(x == y);
        //    }

        //    /// <summary>
        //    /// Implicitly converts the ShortGuid to it's string equivilent
        //    /// </summary>
        //    /// <param name="shortGuid"></param>
        //    /// <returns></returns>
        //    public static implicit operator string(ShortGuid shortGuid)
        //    {
        //        return shortGuid._value;
        //    }

        //    /// <summary>
        //    /// Implicitly converts the ShortGuid to it's Guid equivilent
        //    /// </summary>
        //    /// <param name="shortGuid"></param>
        //    /// <returns></returns>
        //    public static implicit operator Guid(ShortGuid shortGuid)
        //    {
        //        return shortGuid._guid;
        //    }

        //    /// <summary>
        //    /// Implicitly converts the string to a ShortGuid
        //    /// </summary>
        //    /// <param name="shortGuid"></param>
        //    /// <returns></returns>
        //    public static implicit operator ShortGuid(string shortGuid)
        //    {
        //        return new ShortGuid(shortGuid);
        //    }

        //    /// <summary>
        //    /// Implicitly converts the Guid to a ShortGuid
        //    /// </summary>
        //    /// <param name="guid"></param>
        //    /// <returns></returns>
        //    public static implicit operator ShortGuid(Guid guid)
        //    {
        //        return new ShortGuid(guid);
        //    }

        //    #endregion
        //}

        //#endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }


}
