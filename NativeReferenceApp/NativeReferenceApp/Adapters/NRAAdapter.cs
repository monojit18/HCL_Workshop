using System;
using SharedProject.Generic.BaseClasses;
using SharedProject.Generic.Interfaces;
 
namespace NativeReferenceApp.Adapters
{
    public class NRAAdapter : ModuleAdapterBase
    {
        public NRAAdapter(IHttpService httpService, IDbService dbService)
            : base(httpService, dbService)
        {
        }
    }
}
