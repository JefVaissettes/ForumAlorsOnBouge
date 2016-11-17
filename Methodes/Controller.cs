using ClassesMetiers;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodes
{
    public static class Controller
    {
        #region Méthodes Rubrique

        /// <summary>
        /// La methode static GetAllRubrics, permet de voir toutes les catégorie du forum
        /// </summary>
        /// <returns>Tous les rubriques du forum</returns>
        public static List<Rubric> GetAllRubrics()
        {
            return RubricDAO.GetAllRubrics();
        }


        /// <summary>
        /// La methode GetCategorieByID, permet de recupérer une categorie, 
        /// en lui passant l'identifiant en parametre
        /// </summary>
        /// <param name="id_rubric">L'identifiant de la rubrique</param>
        /// <returns>L'identifiant de la rubrique passé en parametre</returns>
        public static Rubric GetRubricByID(int id_rubric)
        {
            return RubricDAO.GetRubricByID(id_rubric);
        }

        #endregion

        #region Méthodes Sujet

        /// <summary>
        /// La méthode GetAllSujets, permet de recupérer tous les sujets du forum
        /// </summary>
        /// <returns>La liste des sujets</returns>
        public static List<Subject> GetAllSujets()
        {
            return SubjectDAO.GetAllSujets();
        }

        /// <summary>
        /// La méthode GetSujetsByRubric, permet de recupérer tous les sujets
        /// d'une rubrique, dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idrubric">L'identifiant de la rubrique</param>
        /// <returns>La liste des tous les sujets, d'une rubrique donnée</returns>
        public static List<Subject> GetSujetsByCategorieID(int id_rubric)
        {
            return SubjectDAO.GetSujetsByCategorieID(id_rubric);
        }

        /// <summary>
        /// La Méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Le sujet, dont l'identifiant est passé en paramatre </returns>
        public static Subject GetSujetByID(int id_subject)
        {
            return SubjectDAO.GetSujetByID(id_subject);
        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la table sujet 
        /// dans la base de données
        /// </summary>
        /// <param name="id_rubric">L'identifiant de la catégorie</param>
        /// <param name="id_users">L'identifiant de l'utilisateur</param>
        /// <param name="subject_description">La description du sujet</param>
        /// <param name="subject_title">Le titre su sujet</param>
        /// <returns>Le nombre de ligne, nbligne = 1, si tout se passe bien</returns>
        public static int AddSujet(int id_users, int id_rubric, string subject_description, string subject_title)
        {
            return SubjectDAO.AddSujet(id_users, id_rubric, subject_description, subject_title);
        }


        /// <summary>
        /// La méthode EditSujet, permet la modification du titre d'un sujet, et/ou la description
        /// on passant l'ancien sujet en parametre
        /// </summary>
        /// <param name="id_subject">Sujet</param>
        /// <param name="subject_title">Nouveau Titre</param>
        /// <param name="subject_description">Nouvelle description</param>
        /// <returns>Le nombre des lignes affectées, nbligne = 1, si tout se passe bien</returns>
        public static int EditSujet(int id_subject, string subject_title, string subject_description)
        {
            return SubjectDAO.EditSujet(id_subject, subject_title, subject_description);
        }

        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant du sujet</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteSujet(int idsujet)
        {
            return SubjectDAO.DeleteSujet(idsujet);
        }

        #endregion

        #region Méthodes Post

        /// <summary>
        /// La méthodes GetAllReponseBySujet, permet de recupérer toutes les reponses
        /// d'un sujet. dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet. Dont l'identifiant est passé en parametre</returns>
        /// 
        public static List<Post> GetAllReponseBySujet(int id_subject)
        {
            return PostDAO.GetAllPostBySubject(id_subject);
        }


        /// <summary>
        /// La méthode AddReponse, permet d'ajouter une reponse au sujet passé en paramateur
        /// par un utilisateur connecté
        /// </summary>
        /// <param name="idSujet">L'identifiant du sujet concerné</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur, qui répond</param>
        /// <param name="texte">Le texte de la reponse</param>
        /// <returns></returns>
        public static int AddReponse(int idSujet, int idUtilisateur, string texte)
        {
            return PostDAO.AddPost(idSujet, idUtilisateur, texte);
        }

        /// <summary>
        /// La méthode DeleteReponse, permet la suppression d'une reponse
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            return PostDAO.DeleteReponse(idReponse);
        }
        #endregion

        #region Méthode Utilisateurs

        /// <summary>
        /// La méthode login, permet à un utilisateur de s'identifier
        /// </summary>
        /// <param name="username">Le nom de l'utilisateur</param>
        /// <param name="password">LE mot de passe</param>
        /// <returns></returns>
        public static Utilisateur Username(string username, string password)
        {
            return UtilisateurDAO.GetLoginPassword(username, password);
        }

        #endregion
    }
}
