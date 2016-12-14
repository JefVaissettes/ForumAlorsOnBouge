using ConsumeWSR;
using MetiersPortable;

namespace WinPhoneFR
{
    public class ViewModelRubric : ViewModelBase
    {
        private ConsumeWSRest _cdDAL;
        private int _idCategorie;
        private string _Libelle;

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        internal ViewModelRubric() { }

        /// <summary>
        /// Constructeur avec passage des paramètres Id et Libellé (titre)
        /// </summary>
        /// <param name="rubric"></param>
        /// <param name="cdDAL"></param>
        internal ViewModelRubric(Rubric rubric, ConsumeWSRest cdDAL)
        {
            _idCategorie = rubric.Id;
            _Libelle = rubric.Libelle;
            _cdDAL = cdDAL;
        }
        #endregion Constructeurs


        #region Propriétés bindables

        public int IdCategorie
        {
            get { return _idCategorie; }
            private set            
                {
                    _idCategorie = value;
                    RaisePropertyChanged();
                }
        }

        public string Libelle
        {
            get { return _Libelle; }
            private set
            {
                if(_Libelle != null)
                {
                    _Libelle = value;
                    RaisePropertyChanged();
                }
            }
        }

        #endregion¨Propriétés bindables
        

        #region Méthodes

        public override string ToString()
        {
            return Libelle;
        }
        #endregion Méthodes
    }
}
