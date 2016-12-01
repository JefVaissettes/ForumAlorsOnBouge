using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DALWinPhone
{
    [Serializable]

    [DataContract]

    public class DalWSRRubric
    {
        #region propriétés et attributs

        private int _Id;
        /// <summary>
        /// Identifiant de la rubrique
        /// </summary>
        [DataMember]
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        private string _Libelle;
        /// <summary>
        /// Titre de la rubrique
        /// </summary>
        [DataMember]
        public string Libelle
        {
            get { return _Libelle; }
            set { _Libelle = value; }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DalWSRRubric() { }

        /// <summary>
        /// Constructeur d'une rubrique
        /// </summary>
        /// <param name="id_rubric">L'identifiant d'une rubrique</param>
        /// <param name="rubric_title">Titre d'une rubrique</param>
        /// 
        public DalWSRRubric(int id, string title)
        {
            this.Id = id;
            this.Libelle = title;
        }
        #endregion
    }
}
