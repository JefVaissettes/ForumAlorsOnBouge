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
using MetiersPortable;

namespace WebServRestFR
{
    public class ServiceFR : IServiceFR
    {
        public List<Rubric> GetAllCategories()
        {
            return Outil.GetAllRubrics();
        }

        public List<Post> GetAllReponseBySujet(string id_subject)
        {
            int r; //Variable locale de retour (résultat)
            if(int.TryParse(id_subject, out r))
            {
                return Outil.GetAllReponseBySujet(r);
            }
            else
            {
                return null;
            }
        }

        public List<Subject> GetSujetsByCategorieID(string idrubric)
        {
            int r; 
            if(int.TryParse(idrubric, out r))
            {
                return Outil.GetSujetsByCategorieID(r);
            }
            else
            {
                return null;
            }
        }

    }
}
