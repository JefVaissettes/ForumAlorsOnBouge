using MetiersPortable;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace ConsumeWSR
{
    public class ConsumeWSRest
    {
        private const string ADR_GET_RUBRIC = "http://user12.2isa.org/ServiceFR.svc/Rubric";
        private List<Rubric> _rubrics = new List<Rubric>();

        #region Rubric

        public List<Rubric> Rubrics
        {
            get
            {
                return _rubrics;
            }
        }

        public async Task<List<Rubric>> getRubric()
        {

            // Création de l'instance HttpClient avec Timeout infini car c'est le CancellationToken qui gère l'arrêt ou le TimeOut de la tâche
            // ATTENTION, en Windows phone on a quand même un timeout au bout de 60s
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                // Permet de supprimer la mise en cache. En WindowsPhone, deux requêtes successives identiques retournent le résultat de la première 
                // qui a été mis en cache
                client.DefaultRequestHeaders.IfModifiedSince = DateTimeOffset.Now;

                // Appel du service Rest (en asynchrone)
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_RUBRIC, CancellationToken.None))
                {
                    if (wcfResponse.IsSuccessStatusCode)
                    {
                        // Désérialisation de la réponse du service
                        return DeserializeHttpContent(wcfResponse.Content);
                    }

                }
                return null;
            }
        }



        private List<Rubric> DeserializeHttpContent(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if (s.Length > 0)
                {
                    return _rubrics = (List<Rubric>)new DataContractSerializer(typeof(List<Rubric>)).ReadObject(s);
                }
                return null;
            }
        }
        #endregion Rubric

        #region Sujet



        #endregion Sujet
    }
}
