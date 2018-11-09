using System;
using SharedProject.Generic.BaseClasses;
using SharedProject.Generic.Interfaces;
 
namespace FormsReferenceApp.Adapters
{
    public class FRAAdapter : ModuleAdapterBase
    {
        public FRAAdapter(IHttpService httpService, IDbService dbService)
            : base(httpService, dbService)
        {
        }
    }
}
