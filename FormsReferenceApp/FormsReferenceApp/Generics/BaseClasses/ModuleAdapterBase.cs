using System;
using SharedProject.Generic.Interfaces;

namespace SharedProject.Generic.BaseClasses
{
    public class ModuleAdapterBase
    {
        protected IHttpService _httpService;
        protected IDbService _dbService;

        public ModuleAdapterBase(IHttpService httpService, IDbService dbService)
        {

            _httpService = httpService;
            _dbService = dbService;

        }

        void Pause() { }

        void Resume() { }

        void Cancel() { }
    }
}
