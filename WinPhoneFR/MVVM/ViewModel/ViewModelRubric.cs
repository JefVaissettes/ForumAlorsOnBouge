using ConsumeWSR;
using MetiersPortable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPhoneFR
{
    public class ViewModelRubric : ViewModelBase
    {
        private ConsumeWSRest _cdDAL;
        private int _idRubric;
        private string _title;

        #region Constructeurs

        internal ViewModelRubric(Rubric rubric, ConsumeWSRest cdDAL)
        {
            _idRubric = rubric.Id;
            _title = rubric.Libelle;
            _cdDAL = cdDAL;
        }
        #endregion Constructeurs

        #region Propriétés bindables

        public int IdRubric
        {
            get { return _idRubric; }
            private set
            {
                _idRubric = value;
                RaisePropertyChanged();
            }
        }

        public string Title
        {
            get { return _title; }
            private set
            {
                _title = value;
                RaisePropertyChanged();
            }
        }
        #endregion¨Propriétés bindables

        #region Méthodes

        public override string ToString()
        {
            return Title;
        }
        #endregion Méthodes
    }
}
