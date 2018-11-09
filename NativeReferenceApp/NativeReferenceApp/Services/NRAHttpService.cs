using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using SharedProject.Generic.Interfaces;
using SharedProject.Generic.BaseClasses;

namespace NativeReferenceApp.Services
{
    public class NRAHttpService : IHttpService
    {

        public ErrorBase HttpServiceError { get; set; }

        public IHttpService Headers(Dictionary<string, string> headersDictionary)
        {

            throw new NotImplementedException();

        }

        public IHttpService Body(Dictionary<string, string> bodyDictionary)
        {

            throw new NotImplementedException();

        }

        public IHttpService Query(Dictionary<string, string> queryDictionary)
        {

            throw new NotImplementedException();

        }

        public IHttpService Build()
        {

            throw new NotImplementedException();

        }

        public async Task<string> GetAsync()
        {

            throw new NotImplementedException();

        }

        public async Task<string> PostAsync()
        {

            throw new NotImplementedException();

        }

        public async Task<string> PutAsync()
        {

            throw new NotImplementedException();

        }

        public void Pause()
        {

            throw new NotImplementedException();

        }

        public void Resume()
        {

            throw new NotImplementedException();

        }

        public void Cancel()
        {

            throw new NotImplementedException();

        }


    }
}
