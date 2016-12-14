﻿using MetiersPortable;
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

        private const string ADR_GET_SUBJECT = "http://user12.2isa.org/ServiceFR.svc/Subject/idRubric";
        private List<Subject> _subjects = new List<Subject>();

        private const string ADR_GET_POST = "http://user12.2isa.org/ServiceFR.svc/Post/idSubject";
        private List<Post> _posts = new List<Post>();


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


        #region Subject

        public List<Subject> Subjects
        {
            get
            {
                return _subjects;
            }
        }

        public async Task<List<Subject>> getSubject()
        {
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_SUBJECT, CancellationToken.None))
                {
                    if(wcfResponse.IsSuccessStatusCode)
                    {
                        return DeserializeHttpContentSubject(wcfResponse.Content);
                    }
                }
                return null;
            }
        }

        private List<Subject> DeserializeHttpContentSubject(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if(s.Length > 0)
                {
                    return _subjects = (List<Subject>)new DataContractSerializer(typeof(List<Subject>)).ReadObject(s);
                }
                return null;
            }
        }
        #endregion Subject

        #region Post

        public List<Post> Posts
        {
            get
            {
                return _posts;
            }
        }

        public async Task<List<Post>> getPost()
        {
            using (HttpClient client = new HttpClient() { Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite) })
            {
                using (HttpResponseMessage wcfResponse = await client.GetAsync(ADR_GET_POST, CancellationToken.None))
                {
                    if(wcfResponse.IsSuccessStatusCode)
                    {
                        return DeserializeHttpContentPost(wcfResponse.Content);
                    }
                }
                return null;
            }
        }

        private List<Post> DeserializeHttpContentPost(HttpContent content)
        {
            using (Stream s = content.ReadAsStreamAsync().Result)
            {
                if(s.Length > 0)
                {
                    return _posts = (List<Post>)new DataContractSerializer(typeof(List<Post>)).ReadObject(s);
                }
                return null;
            }
        }

        #endregion Post
    }
}
