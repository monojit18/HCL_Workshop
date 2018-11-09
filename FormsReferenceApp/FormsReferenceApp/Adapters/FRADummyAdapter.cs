using System;
using SharedProject.Generic.BaseClasses;
using SharedProject.Generic.Interfaces;
using FormsReferenceApp.Services;

namespace FormsReferenceApp.Adapters
{
    public class FRADummyAdapter : FRAAdapter
    {
        public FRADummyAdapter(IHttpService httpService, IDbService dbService)
            : base(httpService, dbService)
        {
        }

        public void DummyFunction()
        {

            var httpService = _httpService as FRADummyService;
            httpService.DummyHttpFunction();

            var dbService = _dbService as FRADBService;
            dbService.DummyDBFunction();


        }



    }
}
