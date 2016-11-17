using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class SubjectDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"
        /// <summary>
        /// La méthode GetAllSujet, retourne tous les sujets du forum
        /// </summary>
        /// <returns>Tous les sujets</returns>
        public static DataTable GetAllSujets()
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllSujets";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable("Subject");
            da.Fill(dt);
            //con.Close();

           return dt;
        }
        /// <summary>
        /// La methode GetSujetsByCategorie, permet de récupéré tous les sujets d'une catégorie
        /// </summary>
        /// <param name="id_rubric">L'identifiant de la catégorie</param>
        /// <returns>La liste des sujets pour une catégorie donnée</returns>

        public static DataTable GetSujetsByCategorieID(int id_rubric)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSujetsByCategorieID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@idRubric";
            parm.Value = id_rubric;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TousLesSujets");
            da.Fill(dt);
            //con.Close();

            return dt;
            
        }

        /// <summary>
        /// La Méthode GetSujetByID, permet de retourné un sujet dont l'identifiant est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Le sujet, dont l'identifiant est passé en paramatre </returns>
        public static DataTable GetSujetByID(int id_subject)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetSubjetByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdSujet";
            parm.Value = id_subject;

            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("SUBJECT");
            da.Fill(dt);
            //con.Close();

            return dt;
            
        }

        /// <summary>
        /// La méthode AddSujet, permet l'ajout d'un nouveau sujet à la table sujet 
        /// dans la base de données
        /// </summary>
        /// <param name="idCategorie">L'identifiant de la catégorie</param>
        /// <param name="idUtilisateur">L'identifiant de l'utilisateur</param>
        /// <param name="description">La description du sujet</param>
        /// <param name="titre">Le titre su sujet</param>
        /// <returns>Le nombre de ligne, nbligne = 1, si tout se passe bien</returns>
        public static int AddSujet(int idUtilisateur, int idRubric, string description, string titre)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdUtilisateur = cmd.CreateParameter();
            parmIdUtilisateur.ParameterName = "@ID_UTILISATEUR";
            parmIdUtilisateur.Value = idUtilisateur;
            cmd.Parameters.Add(parmIdUtilisateur);

            SqlParameter parmIdCategorie = cmd.CreateParameter();
            parmIdCategorie.ParameterName = "@ID_RUBRIC";
            parmIdCategorie.Value = idRubric;
            cmd.Parameters.Add(parmIdCategorie);

            SqlParameter parmDescri = cmd.CreateParameter();
            parmDescri.ParameterName = "@SUBJECT_DESCRIPTION";
            parmDescri.Value = description;
            cmd.Parameters.Add(parmDescri);

            SqlParameter parmTitre = cmd.CreateParameter();
            parmTitre.ParameterName = "@SUBJECT_TITLE";
            parmTitre.Value = titre;
            cmd.Parameters.Add(parmTitre);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode ModifierSujet, permet la modification d'un sujet en lui changeant le titre et/ou la description
        /// on passe les anciennes données en paramètres
        /// </summary>
        /// <param name="subject">le sujet à modifier</param>
        /// <param name="newTitre">le nouveau titre</param>
        /// <param name="newDescription">la nouvelle description</param>
        /// <returns>le nombre de ligne modifié, nbligne = 1 si tout va bien</returns>
        public static int ModifierSujet (int idsubject, string oldtitre,  string newTitre, string olddescription, string newDescription)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "ModifierSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUBJECT";
            parmIdSujet.Value = idsubject;
            cmd.Parameters.Add(parmIdSujet);

            SqlParameter parmNewTitre = cmd.CreateParameter();
            parmNewTitre.ParameterName = "@NEW_TITRE";
            parmNewTitre.Value = newTitre;
            cmd.Parameters.Add(parmNewTitre);

            SqlParameter parmOldTitre = cmd.CreateParameter();
            parmOldTitre.ParameterName = "@OLD_TITRE";
            parmOldTitre.Value = oldtitre;
            cmd.Parameters.Add(parmOldTitre);

            SqlParameter parmNewDescr = cmd.CreateParameter();
            parmNewDescr.ParameterName = "@NEW_DESC";
            parmNewDescr.Value = newDescription;
            cmd.Parameters.Add(parmNewDescr);

            SqlParameter parmOldDescr = cmd.CreateParameter();
            parmOldDescr.ParameterName = "@OLD_DESC";
            parmOldDescr.Value = olddescription;
            cmd.Parameters.Add(parmOldDescr);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        ///// <summary>
        ///// La méthode EditSujet, permet la modification du titre d'un sujet, et/ou la description
        ///// on passant l'ancien sujet en parametre
        ///// </summary>
        ///// <param name="id_sujet">Sujet</param>
        ///// <param name="subject_title">Nouveau Titre</param>
        ///// <param name="subject_description">Nouvelle description</param>
        ///// <returns>Le nombre des lignes affectées, nbligne = 1, si tout se passe bien</returns>
        //public static int EditSujet(int id_subject, string subject_title, string subject_description)
        //{
        //    SqlCommand cmd = con.CreateCommand();
        //    cmd.CommandText = "EditSujet";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    SqlParameter parmIdSujet = cmd.CreateParameter();
        //    parmIdSujet.ParameterName = "@ID_SUJET";
        //    parmIdSujet.Value = id_subject;
        //    cmd.Parameters.Add(parmIdSujet);

        //    SqlParameter paramTitre = cmd.CreateParameter();
        //    paramTitre.ParameterName = "@NEW_TITRE";
        //    paramTitre.Value = subject_title;
        //    cmd.Parameters.Add(paramTitre);

        //    //SqlParameter parmOldTitre = cmd.CreateParameter();
        //    //parmOldTitre.ParameterName = "@OLD_TITRE";
        //    //parmOldTitre.Value = subject.subject_title;
        //    //cmd.Parameters.Add(parmOldTitre);

        //    SqlParameter parmDesc = cmd.CreateParameter();
        //    parmDesc.ParameterName = "@NEW_DESC";
        //    parmDesc.Value = subject_description;
        //    cmd.Parameters.Add(parmDesc);

        //    //SqlParameter parmOldDesc = cmd.CreateParameter();
        //    //parmOldDesc.ParameterName = "@OLD_DESC";
        //    //parmOldDesc.Value = subject.subject_description;
        //    //cmd.Parameters.Add(parmOldDesc);

        //    con.Open();
        //    int nbLigne = cmd.ExecuteNonQuery();
        //    con.Close();
        //    return nbLigne;
        //}


        /// <summary>
        /// La méthode DeleteSujet, permet la suppression d'un sujet
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteSujet(int idsujet)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteSujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdSujet = cmd.CreateParameter();
            parmIdSujet.ParameterName = "@ID_SUBJECT";
            parmIdSujet.Value = idsujet;
            cmd.Parameters.Add(parmIdSujet);

            con.Open();
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;

        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion 
    }
}
