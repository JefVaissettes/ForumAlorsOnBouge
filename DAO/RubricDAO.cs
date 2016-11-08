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
   public static class RubricDAO
        /// <summary>
        /// RubricDAO, permet de récupérer les catégories, qui se trouvent dans la base de données
        /// </summary>
         
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
        /// <returns>Les Catégories existant dans la bdd</returns>
        public static List<Rubric> GetAllRubrics()
        {
            // con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "GetAllRubrics";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubric");
            da.Fill(dt);
            //con.Close();

            if (dt.Rows.Count >= 1)
            {
                List<Rubric> _Rubrics = new List<Rubric>();
                foreach (DataRow row in dt.Rows)
                {
                    Rubric cat = new Rubric(int.Parse(row["ID_RUBRIC"].ToString()), row["RUBRIC_TITLE"].ToString());
                    cat.id_rubric = int.Parse(row["ID_RUBRIC"].ToString());
                    _Rubrics.Add(cat);
                }
                return _Rubrics;
            }
            return null;
        }

            /// <summary>
            /// La méthode GetRubricById, permet de récuperer une catégorie 
            /// dont le l'identifiant est passé en paramètre
            /// </summary>
            /// <param name="idRubric">L'identifiant de la catégorie</param>
            /// <returns>La Rubric</returns>
            public static Rubric GetRubricByID(int idRubric)
            {
                //con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "GetRubricById";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parm = cmd.CreateParameter();
                parm.ParameterName = "@IdRubric";
                parm.Value = idRubric;
                cmd.Parameters.Add(parm);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable("Rubric");
                da.Fill(dt);
                //con.Close();

                if (dt.Rows.Count == 1)
                {
                    DataRow row = dt.Rows[0];
                    Rubric cat = new Rubric(int.Parse(row["ID_RUBRIC"].ToString()), row["RUBRIC_TITLE"].ToString());
                    return cat;
                }
                return null;
            }
            #endregion

        #region "Methodes héritées et substituées"
            #endregion

        #region "Methodes à implementer pour les interfaces"
            #endregion
        }
    
}
