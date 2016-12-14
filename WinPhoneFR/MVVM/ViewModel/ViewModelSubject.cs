using ConsumeWSR;
using MetiersPortable;
using System;
using System.Collections.ObjectModel;

namespace WinPhoneFR
{
    public class ViewModelSubject : ViewModelBase

    {
        //private ConsumeWSRest _cdDAL;
        //private int _idCategorie;
        private int _idSubject;
        private string _Titre;
        private DateTime _date;
        private string _auteur;

        private ObservableCollection<ViewModelPost> _colViewModelPost;

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        internal ViewModelSubject() { }

        /// <summary>
        /// Constructeur avec passage des paramètres Id, Titre, Date et Auteur des sujets
        /// </summary>
        /// <param name="cdDAL"></param>
        /// <param name="subject"></param>
        internal ViewModelSubject(Subject subject, ConsumeWSRest cdDAL)
        {
            //_cdDAL = cdDAL;
            _idSubject = subject.Id;
            _Titre = subject.Titre;
            _date = subject.Date;
            _auteur = subject.Auteur;
            _colViewModelPost = new ObservableCollection<ViewModelPost>();
        }

        #endregion Constructeurs

        #region Propriétés bindables

        public int idSubject
        {
            get { return _idSubject; }
            private set
            {
                _idSubject = value;
                RaisePropertyChanged();
            }
        }

        public string Titre
        {
            get { return _Titre; }
            private set
            {
                if (_Titre != null)
                {
                    _Titre = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime Date
        {
            get { return _date; }
            private set
            {
                if (_date != null)
                {
                    _date = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Auteur
        {
            get { return _auteur; }
            private set
            {
                if (_auteur != null)
                {
                    _auteur = value;
                    RaisePropertyChanged();
                }
            }
        }

        public ReadOnlyObservableCollection<ViewModelPost> Posts
        {
            get { return new ReadOnlyObservableCollection<ViewModelPost>(_colViewModelPosts); }
        }

        #endregion Propriétés bindables

        #region Méthodes

        public override string ToString()
        {
            return Titre;
        }
        #endregion Méthodes

    }
}
