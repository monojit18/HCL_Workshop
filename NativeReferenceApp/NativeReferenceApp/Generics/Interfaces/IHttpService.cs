using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using SharedProject.Generic.BaseClasses;

namespace SharedProject.Generic.Interfaces
{
    
    public interface IHttpService
    {
        
		ErrorBase HttpServiceError { get; set; }

        //IHttpService Url(string urlString);
        IHttpService Headers(Dictionary<string, string> headersDictionary);
        IHttpService Body(Dictionary<string, string> bodyDictionary);
        IHttpService Query(Dictionary<string, string> queryDictionary);
        IHttpService Build();
		Task<string> GetAsync();
        Task<string> PostAsync();
		Task<string> PutAsync();
        void Pause();
        void Resume();
        void Cancel();
    }
}
