using ClassesMetiers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class PostDAO
    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthodes GetAllReponseBySujet, permet de recupérer toutes les reponses
        /// d'un sujet dont l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet</param>
        /// <returns>Les reponses, concernant un sujet dont l'identifiant est passé en paramètre</returns>
        /// 
        public static List<Post> GetAllPostBySubject(int id_subject)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllPostByIdSubject";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@Idsubject";
            parm.Value = id_subject;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Post") ;
            da.Fill(dt);

            if (dt.Rows.Count >= 1)
            {
                List<Post> _Posts = new List<Post>();
                foreach (DataRow row in dt.Rows)
                {
                    Post rep = new Post(int.Parse(row["ID_POST"].ToString()), row["POST_CONTENT"].ToString(), DateTime.Parse(row["POST_DATE"].ToString()), int.Parse(row["ID_USERS"].ToString()), id_subject);
                    _Posts.Add(rep);
                }
                return _Posts;
            }
            return null;
        }

        /// <summary>
        /// La méthode AddReponse, permet d'ajouter une reponse au sujet passé en paramateur
        /// par un utilisateur connecté
        /// </summary>
        /// <param name="id_subject">L'identifiant du sujet concerné</param>
        /// <param name="id_users">L'identifiant de l'utilisateur, qui répond</param>
        /// <param name="post_content">Le texte de la reponse</param>
        /// <returns></returns>
        public static int AddPost(int id_subject, int id_users, string post_content)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "AddPost";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmid_subject = cmd.CreateParameter();
            parmid_subject.ParameterName = "@ID_SUBJECT";
            parmid_subject.Value = id_subject;
            cmd.Parameters.Add(parmid_subject);

            SqlParameter parmidid_users = cmd.CreateParameter();
            parmidid_users.ParameterName = "@ID_USERS";
            parmidid_users.Value = id_users;
            cmd.Parameters.Add(parmidid_users);

            SqlParameter parmContentPost = cmd.CreateParameter();
            parmContentPost.ParameterName = "@TEXT_REPONSE";
            parmContentPost.Value = post_content;
            cmd.Parameters.Add(parmContentPost);

            con.Open();
            //excute une action T-SQL sur la connexion et retourne le nombres de lignes affectéess
            int nbLigne = cmd.ExecuteNonQuery();
            con.Close();
            return nbLigne;
        }

        /// <summary>
        /// La méthode DeleteReponse, permet la suppression d'une reponse
        /// dont l'id est passé en parametre
        /// </summary>
        /// <param name="idsujet">L'identifiant de la reponse</param>
        /// <returns>Le nombre de lignes supprimées, nbligne = 1 si tout va bien</returns>
        public static int DeleteReponse(int idReponse)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "DeleteReponse";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parmIdRep = cmd.CreateParameter();
            parmIdRep.ParameterName = "@ID_POST";
            parmIdRep.Value = idReponse;
            cmd.Parameters.Add(parmIdRep);

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
