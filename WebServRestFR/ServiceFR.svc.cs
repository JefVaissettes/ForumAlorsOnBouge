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
        private object idSubject;
        private object idrubric;

        public List<Rubric> GetAllCategories()
        {
            List<Rubric> liste = new List<Rubric>();

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "GetAllCategories";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Rubric");
            da.Fill(dt);

            return liste;
        }

        public List<Subject> GetAllReponseBySujet()
        {            
            List<Subject> liste = new List<Subject>();            

            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = "GetAllReponseBySujet";
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter parm = cmd.CreateParameter();
            parm.ParameterName = "@idSubject";
            parm.Value = idSubject;
            cmd.Parameters.Add(parm);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("Post");
            da.Fill(dt);

            return liste;
        }

        public List<Rubric> GetSujetsByCategorieID()
        {
            List<Rubric> liste = new List<Rubric>();

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

            return liste;
        }
    }
}
