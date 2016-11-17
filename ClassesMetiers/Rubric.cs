using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesMetiers
{
    /// <summary>
    /// La classe Rubric, se compose d'un identifiant unique pour chaque rubrique
    /// Elle est compposée d'un titre et d'un résumé
    /// </summary>
    
    public class Rubric
    {
        #region "Property et attributs"

        private int _id_rubric;
        /// <summary>
        /// Identifiant de la rubrique
        /// </summary>
        public int id_rubric
        {
            get { return _id_rubric; }
            set { _id_rubric = value; }
        }

        private string _rubric_title;
        /// <summary>
        /// Titre de la rubrique
        /// </summary>
        public string rubric_title
        {
            get { return _rubric_title; }
            set { _rubric_title = value; }
        }

        #endregion

        #region "Constructeurs"
        /// <summary>
        /// Constructeur d'une rubrique
        /// </summary>
        /// <param name="id_rubric">L'identifiant d'une rubrique</param>
        /// <param name="rubric_title">Titre d'une rubrique</param>
        /// 
        public Rubric(int id_rubric, string rubric_title)
        {
            this.id_rubric = id_rubric;
            this.rubric_title = rubric_title;
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
