using System;
using SharedProject.Generic.BaseClasses;
using NativeReferenceApp.Adapters;
using NativeReferenceApp.Services;

namespace NativeReferenceApp.ViewModels
{
    public class NRAiewModel : ViewModelBase
    {
        public NRAiewModel()
        {
        }

        public void DummyFunction()
        {

            var httpService = new NRAHttpService();
            var dbService = new NRADBService();

            var adapter = new NRADummyAdapter(httpService, dbService);
            adapter.DummyFunction();


        }
    }
}
