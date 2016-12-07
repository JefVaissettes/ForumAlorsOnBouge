using ClassesMetiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServRestFR
{
    [ServiceContract]
    public interface IServiceFR
    {
        [OperationContract]
        List<Subject> GetAllReponseBySujet();

        [OperationContract]
        List<Rubric> GetAllCategories();         

        [OperationContract]
        List<Rubric> GetSujetsByCategorieID() ;        
    }
}
