using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    /// <summary>
    /// RubricDAO, permet de récupérer les catégories, qui se trouvent dans la base de données
    /// </summary>
    /// 
    public static class RubricDAO

    {
        #region "Property et attributs"

        private static SqlConnection con = ConnexionDBDAO.GetConnexion();

        #endregion

        #region "Constructeurs"
        #endregion

        #region "Methodes"

        /// <summary>
        /// La méthodes GetAllCategories, permet de récupérer toutes les catégories
        /// enregistrées dans la base de données
        /// </summary>
        /// <returns>Les rubriques de la database</returns>

        public static DataTable GetAllRubrics()
        {
            // con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllRubrics";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubric");
            da.Fill(dt);
            //con.Close();

            return dt;
        }

        /// <summary>
        /// La méthode GetRubricById, permet de récuperer une catégorie 
        /// dont le l'identifiant est passé en paramètre
        /// </summary>
        /// <param name="idRubric">L'identifiant de la catégorie</param>
        /// <returns>La Rubric</returns>

        public static DataTable GetRubricByID(int idRubric)
        {
            //con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetRubricByID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdRubric";
            parm.Value = idRubric;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubric");
            da.Fill(dt);
            //con.Close();

            return dt;
        }
        #endregion

        #region "Methodes héritées et substituées"
        #endregion

        #region "Methodes à implementer pour les interfaces"
        #endregion
    }

}
