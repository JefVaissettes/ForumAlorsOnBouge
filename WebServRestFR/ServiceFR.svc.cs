using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesMetiers;
using System.Data.SqlClient;
using System.Data;

namespace WebServRestFR
{
    public class ServiceFR : IServiceFR
    {
        private SqlConnection cn;
        private object id_subject;
        private object idrubric;

        public List<Rubric> GetAllCategories()
        {
            List<Rubric> listRubrics = new List<Rubric>();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubric");
            da.Fill(dt);

            return listRubrics;
        }

        public List<Subject> GetAllReponseBySujet()
        {            
            List<Subject> listPosts = new List<Subject>();            

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "GetAllReponseBySujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@idSubject";
            parm.Value = id_subject;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Post");
            da.Fill(dt);

            return listPosts;
        }

        public List<Rubric> GetSujetsByCategorieID()
        {
            List<Rubric> listSubjByRub = new List<Rubric>();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "GetSujetsByCategorieID";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@IdRubric";
            parm.Value = idrubric;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("TousLesSujets");
            da.Fill(dt);

            return listSubjByRub;
        }
    }
}
